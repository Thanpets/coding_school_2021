
namespace WindowsFormsApp1 {
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
            this.courseSubjectTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.courseCodeTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.professorCancelButton = new System.Windows.Forms.Button();
            this.professorCreateButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.courseSubjectTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseCodeTextEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // courseSubjectTextEdit
            // 
            this.courseSubjectTextEdit.Location = new System.Drawing.Point(134, 99);
            this.courseSubjectTextEdit.Name = "courseSubjectTextEdit";
            this.courseSubjectTextEdit.Size = new System.Drawing.Size(100, 20);
            this.courseSubjectTextEdit.TabIndex = 29;
            // 
            // courseCodeTextEdit
            // 
            this.courseCodeTextEdit.Location = new System.Drawing.Point(134, 57);
            this.courseCodeTextEdit.Name = "courseCodeTextEdit";
            this.courseCodeTextEdit.Size = new System.Drawing.Size(100, 20);
            this.courseCodeTextEdit.TabIndex = 28;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(78, 102);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(40, 13);
            this.labelControl4.TabIndex = 27;
            this.labelControl4.Text = "Subject:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(89, 60);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(29, 13);
            this.labelControl2.TabIndex = 25;
            this.labelControl2.Text = "Code:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(134, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(127, 13);
            this.labelControl1.TabIndex = 24;
            this.labelControl1.Text = "Credentials of new Course";
            // 
            // professorCancelButton
            // 
            this.professorCancelButton.Location = new System.Drawing.Point(603, 407);
            this.professorCancelButton.Name = "professorCancelButton";
            this.professorCancelButton.Size = new System.Drawing.Size(109, 32);
            this.professorCancelButton.TabIndex = 23;
            this.professorCancelButton.Text = "Cancel";
            this.professorCancelButton.UseVisualStyleBackColor = true;
            // 
            // professorCreateButton
            // 
            this.professorCreateButton.Location = new System.Drawing.Point(488, 407);
            this.professorCreateButton.Name = "professorCreateButton";
            this.professorCreateButton.Size = new System.Drawing.Size(109, 32);
            this.professorCreateButton.TabIndex = 22;
            this.professorCreateButton.Text = "Create";
            this.professorCreateButton.UseVisualStyleBackColor = true;
            // 
            // CourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.courseSubjectTextEdit);
            this.Controls.Add(this.courseCodeTextEdit);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.professorCancelButton);
            this.Controls.Add(this.professorCreateButton);
            this.Name = "CourseForm";
            this.Text = "CourseForm";
            ((System.ComponentModel.ISupportInitialize)(this.courseSubjectTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseCodeTextEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.TextEdit courseSubjectTextEdit;
        private DevExpress.XtraEditors.TextEdit courseCodeTextEdit;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.Button professorCancelButton;
        private System.Windows.Forms.Button professorCreateButton;
    }
}