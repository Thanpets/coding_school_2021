
namespace WindowsFormsApp1 {
    partial class MainForm {
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
            this.label1 = new System.Windows.Forms.Label();
            this.AddCoursesButton = new System.Windows.Forms.Button();
            this.AddStudentButton = new System.Windows.Forms.Button();
            this.AddProfessorButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(645, 458);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(143, 32);
            this.button2.TabIndex = 2;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(62, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(595, 39);
            this.label1.TabIndex = 6;
            this.label1.Text = "University Management Application";
            // 
            // AddCoursesButton
            // 
            this.AddCoursesButton.Location = new System.Drawing.Point(69, 70);
            this.AddCoursesButton.Name = "AddCoursesButton";
            this.AddCoursesButton.Size = new System.Drawing.Size(109, 117);
            this.AddCoursesButton.TabIndex = 7;
            this.AddCoursesButton.Text = "Add Course...";
            this.AddCoursesButton.UseVisualStyleBackColor = true;
            this.AddCoursesButton.Click += new System.EventHandler(this.CourseFormload);
            // 
            // AddStudentButton
            // 
            this.AddStudentButton.Location = new System.Drawing.Point(217, 70);
            this.AddStudentButton.Name = "AddStudentButton";
            this.AddStudentButton.Size = new System.Drawing.Size(109, 117);
            this.AddStudentButton.TabIndex = 8;
            this.AddStudentButton.Text = "Add Student...";
            this.AddStudentButton.UseVisualStyleBackColor = true;
            this.AddStudentButton.Click += new System.EventHandler(this.StudentFormLoad);
            // 
            // AddProfessorButton
            // 
            this.AddProfessorButton.Location = new System.Drawing.Point(363, 70);
            this.AddProfessorButton.Name = "AddProfessorButton";
            this.AddProfessorButton.Size = new System.Drawing.Size(109, 117);
            this.AddProfessorButton.TabIndex = 9;
            this.AddProfessorButton.Text = "Add Professor...";
            this.AddProfessorButton.UseVisualStyleBackColor = true;
            this.AddProfessorButton.Click += new System.EventHandler(this.ProfessorFormLoad);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 502);
            this.Controls.Add(this.AddProfessorButton);
            this.Controls.Add(this.AddStudentButton);
            this.Controls.Add(this.AddCoursesButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddCoursesButton;
        private System.Windows.Forms.Button AddStudentButton;
        private System.Windows.Forms.Button AddProfessorButton;
    }
}

