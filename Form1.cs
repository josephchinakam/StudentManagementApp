using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace StudentManagementApp
{
    public partial class Form1 : Form
    {
        // List to store student data
        private List<Student> students = new List<Student>();

        public Form1()
        {
            InitializeComponent();
        }

        // Class to represent a Student
        public class Student
        {
            public string Name { get; set; }
            public string ID { get; set; }
            public int Age { get; set; }
            public string Program { get; set; }

            public override string ToString()
            {
                return $"{Name} - {ID} - {Age} - {Program}";
            }
        }

        // Add student
        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            try
            {
                // Validation for empty fields
                if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtID.Text) || string.IsNullOrEmpty(txtAge.Text) || string.IsNullOrEmpty(txtProgram.Text))
                {
                    MessageBox.Show("All fields must be filled.");
                    return;
                }

                // Validate Age input (must be a number)
                if (!int.TryParse(txtAge.Text, out int age))
                {
                    MessageBox.Show("Age must be a valid number.");
                    return;
                }

                // Create new student and add to list
                Student student = new Student()
                {
                    Name = txtName.Text,
                    ID = txtID.Text,
                    Age = age,
                    Program = txtProgram.Text
                };

                students.Add(student);

                // Update the ListBox
                lstStudentList.Items.Add(student);

                // Update the total student count
                lblTotalStudents.Text = $"Total Students: {students.Count}";

                // Clear input fields
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // Delete selected student
        private void btnDeleteStudent_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the selected student
                if (lstStudentList.SelectedIndex != -1)
                {
                    // Remove from list and ListBox
                    Student selectedStudent = (Student)lstStudentList.SelectedItem;
                    students.Remove(selectedStudent);
                    lstStudentList.Items.Remove(selectedStudent);

                    // Update the total student count
                    lblTotalStudents.Text = $"Total Students: {students.Count}";
                }
                else
                {
                    MessageBox.Show("Please select a student to delete.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // Search student by ID or Name
        private void btnSearchStudent_Click(object sender, EventArgs e)
        {
            try
            {
                string searchTerm = txtID.Text.Trim().ToLower();
                var result = students.Where(s => s.ID.ToLower().Contains(searchTerm) || s.Name.ToLower().Contains(searchTerm)).ToList();

                if (result.Any())
                {
                    lstStudentList.Items.Clear();
                    foreach (var student in result)
                    {
                        lstStudentList.Items.Add(student);
                    }
                }
                else
                {
                    MessageBox.Show("No student found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // Helper method to clear input fields
        private void ClearFields()
        {
            txtName.Clear();
            txtID.Clear();
            txtAge.Clear();
            txtProgram.Clear();
        }
    }
}
