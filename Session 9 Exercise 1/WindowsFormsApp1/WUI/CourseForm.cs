using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Impl;

namespace WindowsFormsApp1.WUI {
    public partial class CourseForm : Form {
        public Course NewCourse { get; set; }
        public CourseForm() {
            InitializeComponent();
        }

        

       

        private void CourseForm_Load(object sender, EventArgs e) {

        }

        private void courseCreateButton_Click_1(object sender, EventArgs e) {
            NewCourse.Subject = Convert.ToString(ctrlSubject.EditValue);
            NewCourse.Code = Convert.ToString(ctrlCode.EditValue);
            NewCourse.Hours = Convert.ToInt32(crtlHours.EditValue);
            DialogResult = DialogResult.OK;
            Close();
        }

        private void courseCancelButton_Click_1(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
