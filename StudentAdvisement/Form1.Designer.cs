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
            this.label2 = new System.Windows.Forms.Label();
            this.validBtn = new System.Windows.Forms.Button();
            this.validListView = new System.Windows.Forms.ListView();
            this.checkBtn = new System.Windows.Forms.Button();
            this.checkTxtBox = new System.Windows.Forms.TextBox();
            this.memoryListView = new System.Windows.Forms.ListView();
            this.label3 = new System.Windows.Forms.Label();
            this.nextBtn = new System.Windows.Forms.Button();
            this.finishBtn = new System.Windows.Forms.Button();
            this.howWhyBtn = new System.Windows.Forms.Button();
            this.CourseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GradeReceived = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.takenDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Semester";
            // 
            // semesterCmbBox
            // 
            this.semesterCmbBox.FormattingEnabled = true;
            this.semesterCmbBox.Location = new System.Drawing.Point(17, 67);
            this.semesterCmbBox.Name = "semesterCmbBox";
            this.semesterCmbBox.Size = new System.Drawing.Size(282, 21);
            this.semesterCmbBox.TabIndex = 1;
            // 
            // takenDataGrid
            // 
            this.takenDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.takenDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CourseName,
            this.GradeReceived});
            this.takenDataGrid.Location = new System.Drawing.Point(17, 143);
            this.takenDataGrid.Name = "takenDataGrid";
            this.takenDataGrid.Size = new System.Drawing.Size(293, 365);
            this.takenDataGrid.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label2.Location = new System.Drawing.Point(12, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "Courses Taken";
            // 
            // validBtn
            // 
            this.validBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.validBtn.Location = new System.Drawing.Point(369, 38);
            this.validBtn.Name = "validBtn";
            this.validBtn.Size = new System.Drawing.Size(221, 50);
            this.validBtn.TabIndex = 4;
            this.validBtn.Text = "Get Valid Courses";
            this.validBtn.UseVisualStyleBackColor = true;
            // 
            // validListView
            // 
            this.validListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.validListView.GridLines = true;
            this.validListView.HideSelection = false;
            this.validListView.Location = new System.Drawing.Point(369, 94);
            this.validListView.Name = "validListView";
            this.validListView.Size = new System.Drawing.Size(221, 300);
            this.validListView.TabIndex = 5;
            this.validListView.UseCompatibleStateImageBehavior = false;
            // 
            // checkBtn
            // 
            this.checkBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.checkBtn.Location = new System.Drawing.Point(369, 426);
            this.checkBtn.Name = "checkBtn";
            this.checkBtn.Size = new System.Drawing.Size(221, 50);
            this.checkBtn.TabIndex = 6;
            this.checkBtn.Text = "Check Course";
            this.checkBtn.UseVisualStyleBackColor = true;
            // 
            // checkTxtBox
            // 
            this.checkTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.checkTxtBox.Location = new System.Drawing.Point(369, 482);
            this.checkTxtBox.Name = "checkTxtBox";
            this.checkTxtBox.Size = new System.Drawing.Size(221, 26);
            this.checkTxtBox.TabIndex = 7;
            // 
            // memoryListView
            // 
            this.memoryListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.memoryListView.GridLines = true;
            this.memoryListView.HideSelection = false;
            this.memoryListView.Location = new System.Drawing.Point(655, 67);
            this.memoryListView.Name = "memoryListView";
            this.memoryListView.Size = new System.Drawing.Size(270, 312);
            this.memoryListView.TabIndex = 8;
            this.memoryListView.UseCompatibleStateImageBehavior = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label3.Location = new System.Drawing.Point(650, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 26);
            this.label3.TabIndex = 9;
            this.label3.Text = "Working Memory";
            // 
            // nextBtn
            // 
            this.nextBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.nextBtn.Location = new System.Drawing.Point(655, 402);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(122, 50);
            this.nextBtn.TabIndex = 10;
            this.nextBtn.Text = "Next Step";
            this.nextBtn.UseVisualStyleBackColor = true;
            // 
            // finishBtn
            // 
            this.finishBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.finishBtn.Location = new System.Drawing.Point(803, 402);
            this.finishBtn.Name = "finishBtn";
            this.finishBtn.Size = new System.Drawing.Size(122, 50);
            this.finishBtn.TabIndex = 11;
            this.finishBtn.Text = "Finish";
            this.finishBtn.UseVisualStyleBackColor = true;
            // 
            // howWhyBtn
            // 
            this.howWhyBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.howWhyBtn.Location = new System.Drawing.Point(680, 458);
            this.howWhyBtn.Name = "howWhyBtn";
            this.howWhyBtn.Size = new System.Drawing.Size(221, 50);
            this.howWhyBtn.TabIndex = 12;
            this.howWhyBtn.Text = "How / Why";
            this.howWhyBtn.UseVisualStyleBackColor = true;
            // 
            // CourseName
            // 
            this.CourseName.HeaderText = "Course Name";
            this.CourseName.Name = "CourseName";
            this.CourseName.Width = 150;
            // 
            // GradeReceived
            // 
            this.GradeReceived.HeaderText = "Grade Received";
            this.GradeReceived.Name = "GradeReceived";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 520);
            this.Controls.Add(this.howWhyBtn);
            this.Controls.Add(this.finishBtn);
            this.Controls.Add(this.nextBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.memoryListView);
            this.Controls.Add(this.checkTxtBox);
            this.Controls.Add(this.checkBtn);
            this.Controls.Add(this.validListView);
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
        private System.Windows.Forms.ListView validListView;
        private System.Windows.Forms.Button checkBtn;
        private System.Windows.Forms.TextBox checkTxtBox;
        private System.Windows.Forms.ListView memoryListView;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button nextBtn;
        private System.Windows.Forms.Button finishBtn;
        private System.Windows.Forms.Button howWhyBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseName;
        private System.Windows.Forms.DataGridViewComboBoxColumn GradeReceived;
    }
}

