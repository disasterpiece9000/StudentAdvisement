namespace StudentAdvisement
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.semesterCmbBox = new System.Windows.Forms.ComboBox();
            this.takenDataGrid = new System.Windows.Forms.DataGridView();
            this.CourseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GradeReceived = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.validBtn = new System.Windows.Forms.Button();
            this.checkBtn = new System.Windows.Forms.Button();
            this.checkTxtBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nextBtn = new System.Windows.Forms.Button();
            this.finishBtn = new System.Windows.Forms.Button();
            this.submitBtn = new System.Windows.Forms.Button();
            this.memoryListBox = new System.Windows.Forms.ListBox();
            this.validListBox = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.checkLabel = new System.Windows.Forms.Label();
            this.resetBtn = new System.Windows.Forms.Button();
            this.openCourseButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.takenDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(12, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Semester";
            // 
            // semesterCmbBox
            // 
            this.semesterCmbBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.semesterCmbBox.FormattingEnabled = true;
            this.semesterCmbBox.Items.AddRange(new object[] {
            "Spring",
            "Fall",
            "Summer"});
            this.semesterCmbBox.Location = new System.Drawing.Point(17, 111);
            this.semesterCmbBox.Name = "semesterCmbBox";
            this.semesterCmbBox.Size = new System.Drawing.Size(295, 32);
            this.semesterCmbBox.TabIndex = 1;
            this.semesterCmbBox.SelectedIndexChanged += new System.EventHandler(this.semesterCmbBox_SelectedIndexChanged);
            // 
            // takenDataGrid
            // 
            this.takenDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.takenDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CourseName,
            this.GradeReceived});
            this.takenDataGrid.Location = new System.Drawing.Point(17, 185);
            this.takenDataGrid.Name = "takenDataGrid";
            this.takenDataGrid.RowHeadersWidth = 62;
            this.takenDataGrid.Size = new System.Drawing.Size(294, 324);
            this.takenDataGrid.TabIndex = 2;
            // 
            // CourseName
            // 
            this.CourseName.HeaderText = "Course Name";
            this.CourseName.MinimumWidth = 8;
            this.CourseName.Name = "CourseName";
            this.CourseName.Width = 125;
            // 
            // GradeReceived
            // 
            this.GradeReceived.HeaderText = "Grade Received";
            this.GradeReceived.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "F"});
            this.GradeReceived.MinimumWidth = 8;
            this.GradeReceived.Name = "GradeReceived";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label2.Location = new System.Drawing.Point(13, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "Courses Taken";
            // 
            // validBtn
            // 
            this.validBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.validBtn.Location = new System.Drawing.Point(331, 20);
            this.validBtn.Name = "validBtn";
            this.validBtn.Size = new System.Drawing.Size(223, 50);
            this.validBtn.TabIndex = 4;
            this.validBtn.Text = "Get Valid Courses";
            this.validBtn.UseVisualStyleBackColor = true;
            this.validBtn.Click += new System.EventHandler(this.validBtn_Click);
            // 
            // checkBtn
            // 
            this.checkBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.checkBtn.Location = new System.Drawing.Point(332, 432);
            this.checkBtn.Name = "checkBtn";
            this.checkBtn.Size = new System.Drawing.Size(221, 50);
            this.checkBtn.TabIndex = 6;
            this.checkBtn.Text = "Check Course";
            this.checkBtn.UseVisualStyleBackColor = true;
            this.checkBtn.Click += new System.EventHandler(this.checkBtn_Click);
            // 
            // checkTxtBox
            // 
            this.checkTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.checkTxtBox.Location = new System.Drawing.Point(332, 488);
            this.checkTxtBox.Name = "checkTxtBox";
            this.checkTxtBox.Size = new System.Drawing.Size(221, 26);
            this.checkTxtBox.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label3.Location = new System.Drawing.Point(663, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 26);
            this.label3.TabIndex = 9;
            this.label3.Text = "Working Memory";
            // 
            // nextBtn
            // 
            this.nextBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.nextBtn.Location = new System.Drawing.Point(617, 58);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(122, 50);
            this.nextBtn.TabIndex = 10;
            this.nextBtn.Text = "Next Step";
            this.nextBtn.UseVisualStyleBackColor = true;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // finishBtn
            // 
            this.finishBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.finishBtn.Location = new System.Drawing.Point(764, 58);
            this.finishBtn.Name = "finishBtn";
            this.finishBtn.Size = new System.Drawing.Size(122, 50);
            this.finishBtn.TabIndex = 11;
            this.finishBtn.Text = "Finish";
            this.finishBtn.UseVisualStyleBackColor = true;
            this.finishBtn.Click += new System.EventHandler(this.finishBtn_Click);
            // 
            // submitBtn
            // 
            this.submitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.submitBtn.Location = new System.Drawing.Point(17, 515);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(293, 50);
            this.submitBtn.TabIndex = 13;
            this.submitBtn.Text = "Submit Courses";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // memoryListBox
            // 
            this.memoryListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.memoryListBox.FormattingEnabled = true;
            this.memoryListBox.Location = new System.Drawing.Point(581, 111);
            this.memoryListBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.memoryListBox.Name = "memoryListBox";
            this.memoryListBox.Size = new System.Drawing.Size(345, 394);
            this.memoryListBox.TabIndex = 14;
            // 
            // validListBox
            // 
            this.validListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.validListBox.FormattingEnabled = true;
            this.validListBox.ItemHeight = 20;
            this.validListBox.Location = new System.Drawing.Point(332, 75);
            this.validListBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.validListBox.Name = "validListBox";
            this.validListBox.Size = new System.Drawing.Size(223, 324);
            this.validListBox.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label4.Location = new System.Drawing.Point(641, 528);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 26);
            this.label4.TabIndex = 16;
            this.label4.Text = "Result: ";
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.resultLabel.Location = new System.Drawing.Point(783, 528);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(0, 26);
            this.resultLabel.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label5.Location = new System.Drawing.Point(359, 515);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 26);
            this.label5.TabIndex = 18;
            this.label5.Text = "Result: ";
            // 
            // checkLabel
            // 
            this.checkLabel.AutoSize = true;
            this.checkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.checkLabel.Location = new System.Drawing.Point(433, 515);
            this.checkLabel.Name = "checkLabel";
            this.checkLabel.Size = new System.Drawing.Size(0, 26);
            this.checkLabel.TabIndex = 19;
            // 
            // resetBtn
            // 
            this.resetBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.resetBtn.Location = new System.Drawing.Point(17, 20);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(295, 42);
            this.resetBtn.TabIndex = 20;
            this.resetBtn.Text = "Reset Student Info";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // openCourseButton
            // 
            this.openCourseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.openCourseButton.Location = new System.Drawing.Point(931, 111);
            this.openCourseButton.Name = "openCourseButton";
            this.openCourseButton.Size = new System.Drawing.Size(159, 46);
            this.openCourseButton.TabIndex = 21;
            this.openCourseButton.Text = "Open Course List";
            this.openCourseButton.UseVisualStyleBackColor = true;
            this.openCourseButton.Click += new System.EventHandler(this.OpenCourseButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 574);
            this.Controls.Add(this.openCourseButton);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.checkLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.validListBox);
            this.Controls.Add(this.memoryListBox);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.finishBtn);
            this.Controls.Add(this.nextBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkTxtBox);
            this.Controls.Add(this.checkBtn);
            this.Controls.Add(this.validBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.takenDataGrid);
            this.Controls.Add(this.semesterCmbBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.takenDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox semesterCmbBox;
        private System.Windows.Forms.DataGridView takenDataGrid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button validBtn;
        private System.Windows.Forms.Button checkBtn;
        private System.Windows.Forms.TextBox checkTxtBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button nextBtn;
        private System.Windows.Forms.Button finishBtn;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.ListBox memoryListBox;
        private System.Windows.Forms.ListBox validListBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label checkLabel;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseName;
        private System.Windows.Forms.DataGridViewComboBoxColumn GradeReceived;
        private System.Windows.Forms.Button openCourseButton;
    }
}

