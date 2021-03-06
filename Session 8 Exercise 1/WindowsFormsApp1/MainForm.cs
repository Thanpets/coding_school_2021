using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Classes;

namespace WindowsFormsApp1 {

    public partial class MainForm : Form {

        List<Student> Students = new List<Student>();
        List<Professor> Professors = new List<Professor>();
        List<Course> Courses = new List<Course>();


        public MainForm() {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e) {

            //MessageBox.Show("Hello World!");
        }

        private void button1_Click(object sender, EventArgs e) {
            //textBox1.Text = "Hello World!";

            //checkBox1.Checked = true;
        }

        

        private void StudentFormLoad(object sender, EventArgs e) {

            Student student = new Student();
            // TODO: 1. ΝΑ ΠΕΡΑΣΩ ΤΟ STUDENT ΟΒJECT ΣΤΗΝ ΦΟΡΜΑ!
            StudentForm studentForm = new StudentForm();
            studentForm.NewStudent = student;
            // TODO: OPEN FORM ...

            studentForm.ShowDialog();
            


            //TODO: WHEN FORM THE CLOSES ADD THE STUDENT TO A STUDENT LIST
            Students.Add(student);
            
            
        }

       

        private void CourseFormload(object sender, EventArgs e) {
            Course course = new Course();

            CourseForm courseForm = new CourseForm();
            courseForm.NewCourse = course;
            courseForm.ShowDialog();

            Courses.Add(course);
        }

        private void ProfessorFormLoad(object sender, EventArgs e) {
            Professor professor = new Professor();
            ProfessorForm professorForm = new ProfessorForm();
            professorForm.NewProfessor = professor;

            professorForm.ShowDialog();

            Professors.Add(professor);

            
        }

        private void ExitApplicationButton_Click(object sender, EventArgs e) {
            Application.Exit();
        }
    }
}
