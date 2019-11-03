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
            ((System.ComponentModel.ISupportInitialize)(this.takenDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(18, 129);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 37);
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
            this.semesterCmbBox.Location = new System.Drawing.Point(25, 171);
            this.semesterCmbBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.semesterCmbBox.Name = "semesterCmbBox";
            this.semesterCmbBox.Size = new System.Drawing.Size(441, 40);
            this.semesterCmbBox.TabIndex = 1;
            this.semesterCmbBox.SelectedIndexChanged += new System.EventHandler(this.semesterCmbBox_SelectedIndexChanged);
            // 
            // takenDataGrid
            // 
            this.takenDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.takenDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CourseName,
            this.GradeReceived});
            this.takenDataGrid.Location = new System.Drawing.Point(26, 284);
            this.takenDataGrid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.takenDataGrid.Name = "takenDataGrid";
            this.takenDataGrid.RowHeadersWidth = 62;
            this.takenDataGrid.Size = new System.Drawing.Size(441, 498);
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
            this.GradeReceived.Width = 150;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label2.Location = new System.Drawing.Point(19, 242);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 37);
            this.label2.TabIndex = 3;
            this.label2.Text = "Courses Taken";
            // 
            // validBtn
            // 
            this.validBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.validBtn.Location = new System.Drawing.Point(496, 31);
            this.validBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.validBtn.Name = "validBtn";
            this.validBtn.Size = new System.Drawing.Size(334, 77);
            this.validBtn.TabIndex = 4;
            this.validBtn.Text = "Get Valid Courses";
            this.validBtn.UseVisualStyleBackColor = true;
            this.validBtn.Click += new System.EventHandler(this.validBtn_Click);
            // 
            // checkBtn
            // 
            this.checkBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.checkBtn.Location = new System.Drawing.Point(498, 664);
            this.checkBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBtn.Name = "checkBtn";
            this.checkBtn.Size = new System.Drawing.Size(332, 77);
            this.checkBtn.TabIndex = 6;
            this.checkBtn.Text = "Check Course";
            this.checkBtn.UseVisualStyleBackColor = true;
            this.checkBtn.Click += new System.EventHandler(this.checkBtn_Click);
            // 
            // checkTxtBox
            // 
            this.checkTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.checkTxtBox.Location = new System.Drawing.Point(498, 751);
            this.checkTxtBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkTxtBox.Name = "checkTxtBox";
            this.checkTxtBox.Size = new System.Drawing.Size(330, 35);
            this.checkTxtBox.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label3.Location = new System.Drawing.Point(995, 31);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(259, 37);
            this.label3.TabIndex = 9;
            this.label3.Text = "Working Memory";
            // 
            // nextBtn
            // 
            this.nextBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.nextBtn.Location = new System.Drawing.Point(925, 89);
            this.nextBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(183, 77);
            this.nextBtn.TabIndex = 10;
            this.nextBtn.Text = "Next Step";
            this.nextBtn.UseVisualStyleBackColor = true;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // finishBtn
            // 
            this.finishBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.finishBtn.Location = new System.Drawing.Point(1146, 89);
            this.finishBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.finishBtn.Name = "finishBtn";
            this.finishBtn.Size = new System.Drawing.Size(183, 77);
            this.finishBtn.TabIndex = 11;
            this.finishBtn.Text = "Finish";
            this.finishBtn.UseVisualStyleBackColor = true;
            this.finishBtn.Click += new System.EventHandler(this.finishBtn_Click);
            // 
            // submitBtn
            // 
            this.submitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.submitBtn.Location = new System.Drawing.Point(26, 792);
            this.submitBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(440, 77);
            this.submitBtn.TabIndex = 13;
            this.submitBtn.Text = "Submit Courses";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // memoryListBox
            // 
            this.memoryListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.memoryListBox.FormattingEnabled = true;
            this.memoryListBox.ItemHeight = 20;
            this.memoryListBox.Location = new System.Drawing.Point(872, 171);
            this.memoryListBox.Name = "memoryListBox";
            this.memoryListBox.Size = new System.Drawing.Size(515, 604);
            this.memoryListBox.TabIndex = 14;
            // 
            // validListBox
            // 
            this.validListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.validListBox.FormattingEnabled = true;
            this.validListBox.ItemHeight = 29;
            this.validListBox.Location = new System.Drawing.Point(498, 115);
            this.validListBox.Name = "validListBox";
            this.validListBox.Size = new System.Drawing.Size(332, 497);
            this.validListBox.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label4.Location = new System.Drawing.Point(961, 812);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 37);
            this.label4.TabIndex = 16;
            this.label4.Text = "Result: ";
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.resultLabel.Location = new System.Drawing.Point(1174, 812);
            this.resultLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(0, 37);
            this.resultLabel.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label5.Location = new System.Drawing.Point(539, 792);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 37);
            this.label5.TabIndex = 18;
            this.label5.Text = "Result: ";
            // 
            // checkLabel
            // 
            this.checkLabel.AutoSize = true;
            this.checkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.checkLabel.Location = new System.Drawing.Point(649, 792);
            this.checkLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.checkLabel.Name = "checkLabel";
            this.checkLabel.Size = new System.Drawing.Size(0, 37);
            this.checkLabel.TabIndex = 19;
            // 
            // resetBtn
            // 
            this.resetBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.resetBtn.Location = new System.Drawing.Point(25, 31);
            this.resetBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(442, 64);
            this.resetBtn.TabIndex = 20;
            this.resetBtn.Text = "Reset Student Info";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1438, 883);
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
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
    }
}

