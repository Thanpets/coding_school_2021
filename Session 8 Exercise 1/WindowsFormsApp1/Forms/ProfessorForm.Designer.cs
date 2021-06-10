
namespace WindowsFormsApp1 {
    partial class ProfessorForm {
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
            this.professorRankTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.professorNameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.professorCancelButton = new System.Windows.Forms.Button();
            this.professorCreateButton = new System.Windows.Forms.Button();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.professorAgeSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            ((System.ComponentModel.ISupportInitialize)(this.professorRankTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.professorNameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.professorAgeSpinEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // professorRankTextEdit
            // 
            this.professorRankTextEdit.Location = new System.Drawing.Point(55, 135);
            this.professorRankTextEdit.Name = "professorRankTextEdit";
            this.professorRankTextEdit.Size = new System.Drawing.Size(100, 20);
            this.professorRankTextEdit.TabIndex = 20;
            // 
            // professorNameTextEdit
            // 
            this.professorNameTextEdit.Location = new System.Drawing.Point(55, 57);
            this.professorNameTextEdit.Name = "professorNameTextEdit";
            this.professorNameTextEdit.Size = new System.Drawing.Size(100, 20);
            this.professorNameTextEdit.TabIndex = 19;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(10, 138);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(28, 13);
            this.labelControl4.TabIndex = 18;
            this.labelControl4.Text = "Rank:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(10, 60);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(31, 13);
            this.labelControl2.TabIndex = 16;
            this.labelControl2.Text = "Name:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(55, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(139, 13);
            this.labelControl1.TabIndex = 15;
            this.labelControl1.Text = "Credentials of new Professor";
            // 
            // professorCancelButton
            // 
            this.professorCancelButton.Location = new System.Drawing.Point(676, 406);
            this.professorCancelButton.Name = "professorCancelButton";
            this.professorCancelButton.Size = new System.Drawing.Size(109, 32);
            this.professorCancelButton.TabIndex = 14;
            this.professorCancelButton.Text = "Cancel";
            this.professorCancelButton.UseVisualStyleBackColor = true;
            // 
            // professorCreateButton
            // 
            this.professorCreateButton.Location = new System.Drawing.Point(561, 406);
            this.professorCreateButton.Name = "professorCreateButton";
            this.professorCreateButton.Size = new System.Drawing.Size(109, 32);
            this.professorCreateButton.TabIndex = 13;
            this.professorCreateButton.Text = "Create";
            this.professorCreateButton.UseVisualStyleBackColor = true;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(18, 97);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(23, 13);
            this.labelControl3.TabIndex = 17;
            this.labelControl3.Text = "Age:";
            // 
            // professorAgeSpinEdit
            // 
            this.professorAgeSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.professorAgeSpinEdit.Location = new System.Drawing.Point(55, 94);
            this.professorAgeSpinEdit.Name = "professorAgeSpinEdit";
            this.professorAgeSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.professorAgeSpinEdit.Size = new System.Drawing.Size(100, 20);
            this.professorAgeSpinEdit.TabIndex = 21;
            // 
            // ProfessorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 444);
            this.Controls.Add(this.professorAgeSpinEdit);
            this.Controls.Add(this.professorRankTextEdit);
            this.Controls.Add(this.professorNameTextEdit);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.professorCancelButton);
            this.Controls.Add(this.professorCreateButton);
            this.Name = "ProfessorForm";
            this.Text = "ProfessorForm";
            ((System.ComponentModel.ISupportInitialize)(this.professorRankTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.professorNameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.professorAgeSpinEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.TextEdit professorRankTextEdit;
        private DevExpress.XtraEditors.TextEdit professorNameTextEdit;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.Button professorCancelButton;
        private System.Windows.Forms.Button professorCreateButton;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SpinEdit professorAgeSpinEdit;
    }
}