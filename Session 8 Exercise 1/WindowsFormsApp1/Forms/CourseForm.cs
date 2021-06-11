﻿using System;
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
        public Course NewCourse { get; set; }
        public CourseForm() {
            InitializeComponent();
        }

        private void CourseCreateButton_Click(object sender, EventArgs e) {
            NewCourse.Subject = courseSubjectTextEdit.Text;
            NewCourse.Code = courseCodeTextEdit.Text;
            this.Close();
        }

        private void CourseCancelButton_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
