
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
            this.studentCancelButton = new System.Windows.Forms.Button();
            this.studentCreateButton = new System.Windows.Forms.Button();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.studentNameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.studentRegNumberTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.studentAgeSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            ((System.ComponentModel.ISupportInitialize)(this.studentNameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentRegNumberTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentAgeSpinEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // studentCancelButton
            // 
            this.studentCancelButton.Location = new System.Drawing.Point(591, 407);
            this.studentCancelButton.Name = "studentCancelButton";
            this.studentCancelButton.Size = new System.Drawing.Size(109, 32);
            this.studentCancelButton.TabIndex = 4;
            this.studentCancelButton.Text = "Cancel";
            this.studentCancelButton.UseVisualStyleBackColor = true;
            this.studentCancelButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // studentCreateButton
            // 
            this.studentCreateButton.Location = new System.Drawing.Point(476, 407);
            this.studentCreateButton.Name = "studentCreateButton";
            this.studentCreateButton.Size = new System.Drawing.Size(109, 32);
            this.studentCreateButton.TabIndex = 3;
            this.studentCreateButton.Text = "Create";
            this.studentCreateButton.UseVisualStyleBackColor = true;
            this.studentCreateButton.Click += new System.EventHandler(this.CreateStudentButton);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(122, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(131, 13);
            this.labelControl1.TabIndex = 5;
            this.labelControl1.Text = "Credentials of new Student";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(77, 60);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(31, 13);
            this.labelControl2.TabIndex = 6;
            this.labelControl2.Text = "Name:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(85, 97);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(23, 13);
            this.labelControl3.TabIndex = 7;
            this.labelControl3.Text = "Age:";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(6, 138);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(102, 13);
            this.labelControl4.TabIndex = 8;
            this.labelControl4.Text = "Registration Number:";
            // 
            // studentNameTextEdit
            // 
            this.studentNameTextEdit.Location = new System.Drawing.Point(122, 57);
            this.studentNameTextEdit.Name = "studentNameTextEdit";
            this.studentNameTextEdit.Size = new System.Drawing.Size(100, 20);
            this.studentNameTextEdit.TabIndex = 9;
            // 
            // studentRegNumberTextEdit
            // 
            this.studentRegNumberTextEdit.Location = new System.Drawing.Point(122, 135);
            this.studentRegNumberTextEdit.Name = "studentRegNumberTextEdit";
            this.studentRegNumberTextEdit.Size = new System.Drawing.Size(100, 20);
            this.studentRegNumberTextEdit.TabIndex = 11;
            // 
            // studentAgeSpinEdit
            // 
            this.studentAgeSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.studentAgeSpinEdit.Location = new System.Drawing.Point(122, 94);
            this.studentAgeSpinEdit.Name = "studentAgeSpinEdit";
            this.studentAgeSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.studentAgeSpinEdit.Size = new System.Drawing.Size(100, 20);
            this.studentAgeSpinEdit.TabIndex = 12;
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 451);
            this.Controls.Add(this.studentAgeSpinEdit);
            this.Controls.Add(this.studentRegNumberTextEdit);
            this.Controls.Add(this.studentNameTextEdit);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.studentCancelButton);
            this.Controls.Add(this.studentCreateButton);
            this.Name = "StudentForm";
            this.Text = "StudentForm";
            this.Load += new System.EventHandler(this.StudentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentNameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentRegNumberTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentAgeSpinEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button studentCancelButton;
        private System.Windows.Forms.Button studentCreateButton;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit studentNameTextEdit;
        private DevExpress.XtraEditors.TextEdit studentRegNumberTextEdit;
        private DevExpress.XtraEditors.SpinEdit studentAgeSpinEdit;
    }
}