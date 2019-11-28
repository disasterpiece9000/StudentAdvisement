using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Diagnostics;

namespace StudentAdvisement
{
    public partial class Form1 : Form
    {
        // Course info
        public Dictionary<string, Course> masterCourseList;
        public Dictionary<string, Course> takenCourseList;
        public string selectedSemester;
        public List<Course> validCourses;

        // Info for working memory
        public LinkedList<Course> courseCheckQueue;
        public Course currentCourseCheck;
        public LinkedList<Course> prereqCheckQueue;
        public Course currentPrereqCheck;
        public LinkedList<string[]> checkStepQueue;
        public string currentCheckStep;

        // Toggles for buttons
        public bool finishSelected = false;
        public bool backwardsChain = false;

        public Form1()
        {
            getCourseList();

            InitializeComponent();
        }

        public void getCourseList()
        {
            
            Dictionary<string, Course> courseList = new Dictionary<string, Course>();
            System.IO.StreamReader courseText = null;

            try
            {
                // Read all lines from CourseList.txt
                courseText = new System.IO.StreamReader("CourseList.txt");
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("The program could not find the master course list! Check the file path and place the Course List within the Debug Folder!");
            }


            // Process each course line by line
            string line;
            while ((line = courseText.ReadLine()) != null)
            {

                // Parse data delimited by tabs, dashes, and commas
                string[] courseData = line.Split('\t');
                string[] mainCourseData = courseData[0].Split('-');
                string courseName = mainCourseData[0];
                string[] semesters = mainCourseData[1].Split(',');
                string[] prereqData = courseData[1].Split(',');

                // Put prerequs in a dict
                Dictionary<string, Course> prereqList = new Dictionary<string, Course>();

                // Check if course has any prereqs
                if (prereqData[0] != "")
                {
                    for (int i = 0; i < prereqData.Length; i += 2)
                    {
                        prereqList[prereqData[i]] = new Course("Prereq", prereqData[i], prereqData[i + 1][0]);
                    }
                }

                // Store course and prerequs in master list
                courseList[courseName] = new Course("Course", courseName, prereqList, semesters);
            }
                masterCourseList = courseList; 
        }
        
        //Checks the semester cobo box and compares it to the current course
        public bool checkSemester()
        {
            foreach (string semester in currentCourseCheck.Semesters)
            {
                if (selectedSemester.ToLower() == semester.ToLower()) return true;
            }
            return false;
        }

        public bool checkPrereqGrade()
        {
            char gradeNeeded = currentPrereqCheck.Grade;
            char gradeReceived = takenCourseList[currentPrereqCheck.Name].Grade;

            if (gradeReceived <= gradeNeeded) return true;
            else return false;
        }

        public void setupNextPrereq(bool result)
        {
            // If another prereq exists, pop it off prereq queue
            if (result && prereqCheckQueue.Count > 0)
            {
                currentPrereqCheck = prereqCheckQueue.First.Value;
                prereqCheckQueue.RemoveFirst();
            }

            // Otherwise the course is valid
            else if (result)
            {
                validCourses.Add(currentCourseCheck);
                getNextCourse();
            }
        }

        public void setupPrereqs()
        {
            prereqCheckQueue = new LinkedList<Course>(currentCourseCheck.Prerequs.Values);

            for (int i = prereqCheckQueue.Count - 1; i >= 0; i--)
            {
                Course prereq = prereqCheckQueue.ElementAt(i);
                checkStepQueue.AddFirst(new string[] { "check prereq", "The student meets the prereq requirements for " + prereq.Name, currentCourseCheck.Name });
            }

            if (prereqCheckQueue.Count > 0)
            {
                currentPrereqCheck = prereqCheckQueue.First();
                prereqCheckQueue.RemoveFirst();
            }
            else
            {
                validCourses.Add(currentCourseCheck);
                getNextCourse();
            } 
        }

        public void getNextCourse()
        {
            // Pop next course off the queue
            if (courseCheckQueue.Count > 0)
            {
                currentCourseCheck = courseCheckQueue.First();
                courseCheckQueue.RemoveFirst();
            }

            // If no courses are left, display results
            else
            {
                // Display backwards chaining results under check courses button
                if (backwardsChain)
                {
                    if (validCourses.Count == 0) checkLabel.Text = "False";
                    else if (validCourses[0].Name == currentCourseCheck.Name) checkLabel.Text = "True";
                    backwardsChain = false;
                }

                // Display forward chainging results in list box under get valid courses
                else
                {
                    foreach (Course c in validCourses) validListBox.Items.Add(c.Name);

                    memoryListBox.Items.Clear();
                    memoryListBox.Items.Add("Done!");
                    resultLabel.Text = "";
                    finishSelected = false;
                }
            }
        }

        // Update the working memory with the step queue
        public void updateMemory()
        {
            memoryListBox.Items.Clear();

            for (int i = 0; i < checkStepQueue.Count; i++)
            {
                string[] stepData = checkStepQueue.ElementAt(i);
                memoryListBox.Items.Add(stepData[1]);
            }
        }

        // Remove all steps in queue that belong to the current course
        public bool removeCourseFromQueue(string[] stepData)
        {
            string courseName = stepData[2];

            if (courseName == currentCourseCheck.Name) return true;
            else return false;
        }

        // Store all courses the student has taken
        private void submitBtn_Click(object sender, EventArgs e)
        {
            Dictionary<string, Course> courseList = new Dictionary<string, Course>();

            // Parse data from each row of the data grid
            foreach (DataGridViewRow row in takenDataGrid.Rows)
            {
                DataGridViewCellCollection cells = row.Cells;
                if (cells[0].Value == null) break;

                string courseName = cells[0].Value.ToString();
                char grade = cells[1].Value.ToString()[0];
                courseList[courseName] = new Course("Course", courseName, grade);
            }

            takenCourseList = courseList;
        }

        private void semesterCmbBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (semesterCmbBox.SelectedIndex != -1)
            {
                selectedSemester = semesterCmbBox.SelectedItem.ToString();
            }
        }

        private void validBtn_Click(object sender, EventArgs e)
        {
            if (selectedSemester == null) return;

            // Submit taken courses if not already done
            submitBtn_Click(null, null);

            validCourses = new List<Course>();
            checkStepQueue = new LinkedList<string[]>();

            // Add each course to the step queue
            foreach (Course c in masterCourseList.Values)
            {
                checkStepQueue.AddLast(new string[] { "check course", "Student can take " + c.Name, c.Name });
            }

            updateMemory();

            // Add all courses from master course list to course queue
            courseCheckQueue = new LinkedList<Course>(masterCourseList.Values.ToList<Course>());
            getNextCourse();
        }

        private void checkBtn_Click(object sender, EventArgs e)
        {
            // Submit taken courses if not already done
            submitBtn_Click(null, null);

            // Handle empty text box
            if (checkTxtBox.Text == "" || selectedSemester == null) return;

            // Handle invalid course entered
            if (!masterCourseList.ContainsKey(checkTxtBox.Text))
            {
                System.Windows.Forms.MessageBox.Show("The course you have entered does not exist");
                return;
            }

            validCourses = new List<Course>();
            checkStepQueue = new LinkedList<string[]>();
            backwardsChain = true;

            Course selectedCourse = masterCourseList[checkTxtBox.Text];
            checkStepQueue.AddFirst(new string[] {"check course", "Student can take " + selectedCourse.Name, selectedCourse.Name });
            courseCheckQueue = new LinkedList<Course>();
            courseCheckQueue.AddFirst(selectedCourse);
            getNextCourse();
            updateMemory();
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            // Do nothing if step queue is empty
            if (checkStepQueue.Count == 0) return;

            bool result;

            // Pop current step off the step queue
            string[] stepData = checkStepQueue.First();
            currentCheckStep = stepData[0];
            checkStepQueue.RemoveFirst();
            
            // Process current step
            switch (currentCheckStep)
            {
                case "check course":
                    // Add steps to check course
                    checkStepQueue.AddFirst(new string[] { "check prereqs", "Student meets the prereq requirements for " + currentCourseCheck.Name, currentCourseCheck.Name });
                    checkStepQueue.AddFirst(new string[] { "check semester", currentCourseCheck.Name + " is offered this semester", currentCourseCheck.Name });
                    checkStepQueue.AddFirst(new string[] { "check not taken", "Student has not already taken " + currentCourseCheck.Name , currentCourseCheck.Name });
                    result = true;
                    break;

                case "check not taken":
                    result = !takenCourseList.ContainsKey(currentCourseCheck.Name);
                    break;
                 

                case "check prereqs":
                    result = true;
                    setupPrereqs();
                    break;

                case "check prereq":
                    result = true;
                    checkStepQueue.AddFirst(new string[] { "check prereq grade", "Student meets the grade requirements for the prereq " + currentPrereqCheck.Name, currentCourseCheck.Name });
                    checkStepQueue.AddFirst(new string[] { "check prereq taken", "Student has taken the prereq " + currentPrereqCheck.Name, currentCourseCheck.Name });
                    break;

                case "check semester":
                    result = checkSemester();
                    break;

                case "check prereq taken":
                    result = takenCourseList.ContainsKey(currentPrereqCheck.Name);
                    break;

                case "check prereq grade":
                    result = checkPrereqGrade();
                    setupNextPrereq(result);
                    break;

                default:
                    result = true;
                    break;
            }

            if (currentCheckStep != "check course") resultLabel.Text = result.ToString();

            // If the current requirements are not met, remove all steps belonging to course from queue
            if (!result)
            {
                List<string[]> tempQueue = checkStepQueue.ToList<string[]>();
                tempQueue.RemoveAll(removeCourseFromQueue);
                checkStepQueue = new LinkedList<string[]>(tempQueue);

                getNextCourse();
            }

            updateMemory();

            if (finishSelected)
            {
                nextBtn_Click(null, null);
            }
        }

        private void finishBtn_Click(object sender, EventArgs e)
        {
            finishSelected = true;
            nextBtn_Click(null, null);
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            takenCourseList = new Dictionary<string, Course>();
            takenDataGrid.Rows.Clear();

            //semesterCmbBox.SelectedIndex = -1;

            validListBox.Items.Clear();
            checkTxtBox.Text = "";

            memoryListBox.Items.Clear();

            //This may set our cmb box to blank text
            semesterCmbBox.ResetText();

            getCourseList();
        }

        private void OpenCourseButton_Click(object sender, EventArgs e)
        {
            Process.Start("CourseList.txt");
        }
    }

    public class Course
    {
        public string Name, Type;
        public string[] Semesters;
        public char Grade;
        public Dictionary<string, Course> Prerequs;

        // Overload for general course
        public Course(string Type, string Name, Dictionary<string, Course> Prerequs, string[] Semesters)
        {
            this.Type = Type;
            this.Name = Name;
            this.Prerequs = Prerequs;
            this.Semesters = Semesters;
        }

        // Overload for prereq and taken course
        public Course(string Type, string Name, char Grade)
        {
            this.Type = Type;
            this.Name = Name;
            this.Grade = Grade;
        }
    }
}
