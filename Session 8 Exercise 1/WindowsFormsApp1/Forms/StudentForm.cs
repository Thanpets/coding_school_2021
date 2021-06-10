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

    public partial class StudentForm : Form {

        // PROPERTIES ????
        public Student student { get; set; }


        // CONSTRUCTOR
        public StudentForm() {
            InitializeComponent();
        }


        // METHODS
        private void StudentForm_Load(object sender, EventArgs e) {
            
        }

        private void createStudentButton(object sender, EventArgs e) {

            // todo: MODIFY THE OBJECT STUDENT -- CLOSE THE FORM!
            student.Name = studentNameTextEdit.Text;
            student.Age = Convert.ToInt32(studentAgeSpinEdit.Value);
            student.RegistrationNumber = Convert.ToInt32(studentRegNumberTextEdit.Text);
            this.Close();
            
        }

        private void button2_Click(object sender, EventArgs e) {

            // todo: CANCEL EVERYTHING -- DO NOT MODIFY THE OBJECT!
            this.Close();
        }

        
    }
}
