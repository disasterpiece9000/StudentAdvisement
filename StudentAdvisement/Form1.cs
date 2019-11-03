using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace StudentAdvisement
{
    public partial class Form1 : Form
    {

        public Dictionary<string, Course> masterCourseList;
        public Dictionary<string, Course> takenCourseList;
        public string selectedSemester;

        public List<Course> validCourses;

        public LinkedList<Course> courseCheckQueue;
        public Course currentCourseCheck;
        public LinkedList<Course> prereqCheckQueue;
        public Course currentPrereqCheck;
        public LinkedList<string[]> checkStepQueue;
        public string currentCheckStep;

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

            // Read all lines from CourseList.txt
            System.IO.StreamReader courseText = new System.IO.StreamReader(@"c:\Users\HackerMan\source\repos\StudentAdvisementFinal\StudentAdvisement\CourseList.txt");

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
                for (int i = 0; i < prereqData.Length; i += 2)
                {
                    prereqList[prereqData[i]] = new Course("Prereq", prereqData[i], prereqData[i + 1][0]);
                }

                // Store course and prerequs in master list
                courseList[courseName] = new Course("Course", courseName, prereqList, semesters);
            }

            masterCourseList = courseList;
        }

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
            currentPrereqCheck = prereqCheckQueue.First();
            prereqCheckQueue.RemoveFirst();

            foreach (Course prereq in currentCourseCheck.Prerequs.Values)
            {
                checkStepQueue.AddFirst(new string[] { "check prereq grade", "The grade received for " + prereq.Name + " meets the requirements", currentCourseCheck.Name});
                checkStepQueue.AddFirst(new string[] { "check prereq taken", "Student has taken the prereq " + prereq.Name, currentCourseCheck.Name });
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
                if (backwardsChain)
                {
                    if (validCourses.Count == 0) checkLabel.Text = "False";
                    else if (validCourses[0].Name == currentCourseCheck.Name) checkLabel.Text = "True";
                }
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
            selectedSemester = semesterCmbBox.SelectedItem.ToString();
        }

        private void validBtn_Click(object sender, EventArgs e)
        {
            validCourses = new List<Course>();
            checkStepQueue = new LinkedList<string[]>();

            // Add each course to the step queue
            foreach (Course c in masterCourseList.Values)
            {
                checkStepQueue.AddFirst(new string[] { "check course", "Student can take " + c.Name, c.Name });
            }

            updateMemory();

            // Add all courses from master course list to course queue
            courseCheckQueue = new LinkedList<Course>(masterCourseList.Values.ToList<Course>());
            getNextCourse();

            // Start first step
            nextBtn_Click(null, null);
        }

        private void checkBtn_Click(object sender, EventArgs e)
        {
            validCourses = new List<Course>();
            checkStepQueue = new LinkedList<string[]>();
            backwardsChain = true;

            Course selectedCourse = masterCourseList[checkTxtBox.Text];

            checkStepQueue.AddFirst(new string[] {"check course", "Student can take " + selectedCourse.Name, selectedCourse.Name });
            courseCheckQueue = new LinkedList<Course>();
            courseCheckQueue.AddFirst(selectedCourse);
            getNextCourse();

            // Start first step
            nextBtn_Click(null, null);
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

            updateMemory();

            resultLabel.Text = result.ToString();

            // If the current requirements are not met, remove all steps belonging to course from queue
            if (!result)
            {
                List<string[]> tempQueue = checkStepQueue.ToList<string[]>();
                tempQueue.RemoveAll(removeCourseFromQueue);
                checkStepQueue = new LinkedList<string[]>(tempQueue);

                getNextCourse();
            }

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

        // Overload for prereq course
        public Course(string Type, string Name, char Grade)
        {
            this.Type = Type;
            this.Name = Name;
            this.Grade = Grade;
        }
    }
}
