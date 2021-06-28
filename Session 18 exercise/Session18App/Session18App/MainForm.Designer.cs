
namespace Session18App
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.crtlStudentForm = new System.Windows.Forms.Button();
            this.crtlCourseForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // crtlStudentForm
            // 
            this.crtlStudentForm.Location = new System.Drawing.Point(13, 23);
            this.crtlStudentForm.Name = "crtlStudentForm";
            this.crtlStudentForm.Size = new System.Drawing.Size(168, 98);
            this.crtlStudentForm.TabIndex = 0;
            this.crtlStudentForm.Text = "Manage Students";
            this.crtlStudentForm.UseVisualStyleBackColor = true;
            this.crtlStudentForm.Click += new System.EventHandler(this.crtlStudentForm_Click);
            // 
            // crtlCourseForm
            // 
            this.crtlCourseForm.Location = new System.Drawing.Point(224, 23);
            this.crtlCourseForm.Name = "crtlCourseForm";
            this.crtlCourseForm.Size = new System.Drawing.Size(176, 98);
            this.crtlCourseForm.TabIndex = 1;
            this.crtlCourseForm.Text = "Manage Courses";
            this.crtlCourseForm.UseVisualStyleBackColor = true;
            this.crtlCourseForm.Click += new System.EventHandler(this.crtlCourseForm_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 460);
            this.Controls.Add(this.crtlCourseForm);
            this.Controls.Add(this.crtlStudentForm);
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button crtlStudentForm;
        private System.Windows.Forms.Button crtlCourseForm;
    }
}

