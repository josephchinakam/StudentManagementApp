namespace StudentManagementApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtProgram;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Button btnDeleteStudent;
        private System.Windows.Forms.Button btnSearchStudent;
        private System.Windows.Forms.ListBox lstStudentList;
        private System.Windows.Forms.Label lblTotalStudents;

        private void InitializeComponent()
        {
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtProgram = new System.Windows.Forms.TextBox();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.btnDeleteStudent = new System.Windows.Forms.Button();
            this.btnSearchStudent = new System.Windows.Forms.Button();
            this.lstStudentList = new System.Windows.Forms.ListBox();
            this.lblTotalStudents = new System.Windows.Forms.Label();

            this.SuspendLayout();

            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(12, 12);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(260, 20);
            this.txtName.TabIndex = 0;
            this.txtName.PlaceholderText = "Enter Name";

            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(12, 38);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(260, 20);
            this.txtID.TabIndex = 1;
            this.txtID.PlaceholderText = "Enter ID";

            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(12, 64);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(260, 20);
            this.txtAge.TabIndex = 2;
            this.txtAge.PlaceholderText = "Enter Age";

            // 
            // txtProgram
            // 
            this.txtProgram.Location = new System.Drawing.Point(12, 90);
            this.txtProgram.Name = "txtProgram";
            this.txtProgram.Size = new System.Drawing.Size(260, 20);
            this.txtProgram.TabIndex = 3;
            this.txtProgram.PlaceholderText = "Enter Program";

            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Location = new System.Drawing.Point(12, 116);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(75, 23);
            this.btnAddStudent.TabIndex = 4;
            this.btnAddStudent.Text = "Add Student";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);

            // 
            // btnDeleteStudent
            // 
            this.btnDeleteStudent.Location = new System.Drawing.Point(93, 116);
            this.btnDeleteStudent.Name = "btnDeleteStudent";
            this.btnDeleteStudent.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteStudent.TabIndex = 5;
            this.btnDeleteStudent.Text = "Delete Student";
            this.btnDeleteStudent.UseVisualStyleBackColor = true;
            this.btnDeleteStudent.Click += new System.EventHandler(this.btnDeleteStudent_Click);

            // 
            // btnSearchStudent
            // 
            this.btnSearchStudent.Location = new System.Drawing.Point(174, 116);
            this.btnSearchStudent.Name = "btnSearchStudent";
            this.btnSearchStudent.Size = new System.Drawing.Size(98, 23);
            this.btnSearchStudent.TabIndex = 6;
            this.btnSearchStudent.Text = "Search Student";
            this.btnSearchStudent.UseVisualStyleBackColor = true;
            this.btnSearchStudent.Click += new System.EventHandler(this.btnSearchStudent_Click);

            // 
            // lstStudentList
            // 
            this.lstStudentList.FormattingEnabled = true;
            this.lstStudentList.Location = new System.Drawing.Point(12, 145);
            this.lstStudentList.Name = "lstStudentList";
            this.lstStudentList.Size = new System.Drawing.Size(260, 95);
            this.lstStudentList.TabIndex = 7;

            // 
            // lblTotalStudents
            // 
            this.lblTotalStudents.AutoSize = true;
            this.lblTotalStudents.Location = new System.Drawing.Point(12, 243);
            this.lblTotalStudents.Name = "lblTotalStudents";
            this.lblTotalStudents.Size = new System.Drawing.Size(84, 13);
            this.lblTotalStudents.TabIndex = 8;
            this.lblTotalStudents.Text = "Total Students: 0";

            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblTotalStudents);
            this.Controls.Add(this.lstStudentList);
            this.Controls.Add(this.btnSearchStudent);
            this.Controls.Add(this.btnDeleteStudent);
            this.Controls.Add(this.btnAddStudent);
            this.Controls.Add(this.txtProgram);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtName);
            this.Name = "Form1";
            this.Text = "Student Management";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
