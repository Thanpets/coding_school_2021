﻿
namespace WindowsFormsApp1 {
    partial class StudentForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ctrlName = new DevExpress.XtraEditors.TextEdit();
            this.ctrlSurname = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.crtlAge = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.crtlRegNumber = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlSurname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crtlAge.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crtlRegNumber.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(597, 407);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 32);
            this.button2.TabIndex = 4;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(482, 407);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 32);
            this.button1.TabIndex = 3;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ctrlName
            // 
            this.ctrlName.EditValue = "";
            this.ctrlName.Location = new System.Drawing.Point(114, 51);
            this.ctrlName.Name = "ctrlName";
            this.ctrlName.Size = new System.Drawing.Size(100, 20);
            this.ctrlName.TabIndex = 5;
            this.ctrlName.EditValueChanged += new System.EventHandler(this.ctrlName_EditValueChanged);
            // 
            // ctrlSurname
            // 
            this.ctrlSurname.Location = new System.Drawing.Point(114, 77);
            this.ctrlSurname.Name = "ctrlSurname";
            this.ctrlSurname.Size = new System.Drawing.Size(295, 20);
            this.ctrlSurname.TabIndex = 6;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(74, 54);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(34, 13);
            this.labelControl1.TabIndex = 7;
            this.labelControl1.Text = "Name :";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(59, 80);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(49, 13);
            this.labelControl2.TabIndex = 8;
            this.labelControl2.Text = "Surname :";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(59, 12);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(183, 25);
            this.labelControl3.TabIndex = 9;
            this.labelControl3.Text = "Add New Student...";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(74, 106);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(23, 13);
            this.labelControl4.TabIndex = 11;
            this.labelControl4.Text = "Age:";
            // 
            // crtlAge
            // 
            this.crtlAge.Location = new System.Drawing.Point(114, 103);
            this.crtlAge.Name = "crtlAge";
            this.crtlAge.Size = new System.Drawing.Size(53, 20);
            this.crtlAge.TabIndex = 10;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(6, 132);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(102, 13);
            this.labelControl5.TabIndex = 13;
            this.labelControl5.Text = "Registration Number:";
            // 
            // crtlRegNumber
            // 
            this.crtlRegNumber.Location = new System.Drawing.Point(114, 129);
            this.crtlRegNumber.Name = "crtlRegNumber";
            this.crtlRegNumber.Size = new System.Drawing.Size(295, 20);
            this.crtlRegNumber.TabIndex = 12;
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 451);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.crtlRegNumber);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.crtlAge);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.ctrlSurname);
            this.Controls.Add(this.ctrlName);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "StudentForm";
            this.Text = "StudentForm";
            this.Load += new System.EventHandler(this.StudentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ctrlName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlSurname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crtlAge.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crtlRegNumber.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private DevExpress.XtraEditors.TextEdit ctrlName;
        private DevExpress.XtraEditors.TextEdit ctrlSurname;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit crtlAge;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit crtlRegNumber;
    }
}