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
    public partial class CourseForm : Form {
        public Course Course { get; set; }
        public CourseForm() {
            InitializeComponent();
        }

        private void courseCreateButton_Click(object sender, EventArgs e) {
            Course.Subject = courseSubjectTextEdit.Text;
            Course.Code = courseCodeTextEdit.Text;
            this.Close();
        }

        private void courseCancelButton_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
