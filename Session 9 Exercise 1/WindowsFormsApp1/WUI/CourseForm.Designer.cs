
namespace WindowsFormsApp1.WUI {
    partial class CourseForm {
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
            this.ctrlSubject = new DevExpress.XtraEditors.TextEdit();
            this.ctrlCode = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.courseCancelButton = new System.Windows.Forms.Button();
            this.courseCreateButton = new System.Windows.Forms.Button();
            this.crtlHours = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlSubject.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crtlHours.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ctrlSubject
            // 
            this.ctrlSubject.Location = new System.Drawing.Point(101, 117);
            this.ctrlSubject.Name = "ctrlSubject";
            this.ctrlSubject.Size = new System.Drawing.Size(100, 20);
            this.ctrlSubject.TabIndex = 3;
            // 
            // ctrlCode
            // 
            this.ctrlCode.Location = new System.Drawing.Point(101, 81);
            this.ctrlCode.Name = "ctrlCode";
            this.ctrlCode.Size = new System.Drawing.Size(100, 20);
            this.ctrlCode.TabIndex = 2;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(45, 120);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(40, 13);
            this.labelControl4.TabIndex = 34;
            this.labelControl4.Text = "Subject:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(56, 84);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(29, 13);
            this.labelControl2.TabIndex = 33;
            this.labelControl2.Text = "Code:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(101, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(127, 13);
            this.labelControl1.TabIndex = 32;
            this.labelControl1.Text = "Credentials of new Course";
            // 
            // courseCancelButton
            // 
            this.courseCancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.courseCancelButton.Location = new System.Drawing.Point(646, 406);
            this.courseCancelButton.Name = "courseCancelButton";
            this.courseCancelButton.Size = new System.Drawing.Size(109, 32);
            this.courseCancelButton.TabIndex = 5;
            this.courseCancelButton.Text = "Cancel";
            this.courseCancelButton.UseVisualStyleBackColor = true;
            this.courseCancelButton.Click += new System.EventHandler(this.courseCancelButton_Click_1);
            // 
            // courseCreateButton
            // 
            this.courseCreateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.courseCreateButton.Location = new System.Drawing.Point(531, 406);
            this.courseCreateButton.Name = "courseCreateButton";
            this.courseCreateButton.Size = new System.Drawing.Size(109, 32);
            this.courseCreateButton.TabIndex = 4;
            this.courseCreateButton.Text = "Create";
            this.courseCreateButton.UseVisualStyleBackColor = true;
            this.courseCreateButton.Click += new System.EventHandler(this.courseCreateButton_Click_1);
            // 
            // crtlHours
            // 
            this.crtlHours.Location = new System.Drawing.Point(101, 45);
            this.crtlHours.Name = "crtlHours";
            this.crtlHours.Size = new System.Drawing.Size(100, 20);
            this.crtlHours.TabIndex = 1;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(56, 48);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(32, 13);
            this.labelControl3.TabIndex = 38;
            this.labelControl3.Text = "Hours:";
            // 
            // CourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.crtlHours);
            this.Controls.Add(this.ctrlSubject);
            this.Controls.Add(this.ctrlCode);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.courseCancelButton);
            this.Controls.Add(this.courseCreateButton);
            this.Name = "CourseForm";
            this.Text = "CourseForm";
            this.Load += new System.EventHandler(this.CourseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ctrlSubject.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crtlHours.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit ctrlSubject;
        private DevExpress.XtraEditors.TextEdit ctrlCode;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.Button courseCancelButton;
        private System.Windows.Forms.Button courseCreateButton;
        private DevExpress.XtraEditors.TextEdit crtlHours;
        private DevExpress.XtraEditors.LabelControl labelControl3;
    }
}