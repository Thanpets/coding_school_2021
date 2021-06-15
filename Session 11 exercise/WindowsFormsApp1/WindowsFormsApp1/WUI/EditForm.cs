﻿using System;
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

    public partial class EditForm : Form {

        // PROPERTIES
        public object EditObject { get; set; }
        public EntityTypeEnum Type { get; set; }

        public EditForm() {

            InitializeComponent();
        }

        private void EditForm_Load(object sender, EventArgs e) {

            switch (Type) {
                case EntityTypeEnum.Course:
                    ctrlTitle.Text = "Add New Course...";

                    lblField1.Text = "Code: ";
                    ctrlEditField1.Width = 150;

                    lblField2.Text = "Subject: ";

                    lblField3.Visible = false;
                    ctrlEditField3.Visible = false;

                    lblField4.Visible = false;
                    ctrlEditField4.Visible = false;

                    // get object -> display existing values
                    Course course = EditObject as Course;

                    ctrlEditField1.EditValue = course.Code;
                    ctrlEditField2.EditValue = course.Subject;

                    break;

                case EntityTypeEnum.Student:
                    ctrlTitle.Text = "Add New Student...";

                    lblField1.Text = "Name: ";
                    ctrlEditField1.Width = 150;

                    lblField2.Text = "Surname: ";

                    lblField3.Visible = false;
                    ctrlEditField3.Visible = false;

                    lblField4.Visible = false;
                    ctrlEditField4.Visible = false;

                    // get object -> display existing values
                    Student student = EditObject as Student;

                    ctrlEditField1.EditValue = student.Name;
                    ctrlEditField2.EditValue = student.Surname;

                    break;

                case EntityTypeEnum.Professor:
                    ctrlTitle.Text = "Add New Professor...";
                    break;

                default:
                    break;
            }


        }

        private void btnOK_Click(object sender, EventArgs e) {

            switch (Type) {
                case EntityTypeEnum.Course:
                    
                    if (ctrlEditField1.EditValue.ToString().Length > 0) {
                        Course course = EditObject as Course;
                        course.Code = Convert.ToString(ctrlEditField1.EditValue);
                        course.Subject = Convert.ToString(ctrlEditField2.EditValue);


                        DialogResult = DialogResult.OK;
                    }

                    break;
                case EntityTypeEnum.Student:


                    if (ctrlEditField1.EditValue.ToString().Length > 0) {
                        Student student = EditObject as Student;
                        student.Name = Convert.ToString(ctrlEditField1.EditValue);
                        student.Surname = Convert.ToString(ctrlEditField2.EditValue);


                        DialogResult = DialogResult.OK;
                    }
                    break;
                case EntityTypeEnum.Professor:
                    break;
                default:
                    break;
            }

        }

        private void btnCancel_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
        }
    }
}
