
namespace WindowsFormsApp1.WUI {
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
            this.crtlAge = new DevExpress.XtraEditors.SpinEdit();
            this.crtlSurname = new DevExpress.XtraEditors.TextEdit();
            this.crtlName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.professorCancelButton = new System.Windows.Forms.Button();
            this.professorCreateButton = new System.Windows.Forms.Button();
            this.crtlRank = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.crtlAge.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crtlSurname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crtlName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crtlRank.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // crtlAge
            // 
            this.crtlAge.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.crtlAge.Location = new System.Drawing.Point(65, 138);
            this.crtlAge.Name = "crtlAge";
            this.crtlAge.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.crtlAge.Size = new System.Drawing.Size(100, 20);
            this.crtlAge.TabIndex = 30;
            // 
            // crtlSurname
            // 
            this.crtlSurname.Location = new System.Drawing.Point(65, 99);
            this.crtlSurname.Name = "crtlSurname";
            this.crtlSurname.Size = new System.Drawing.Size(100, 20);
            this.crtlSurname.TabIndex = 29;
            // 
            // crtlName
            // 
            this.crtlName.Location = new System.Drawing.Point(65, 66);
            this.crtlName.Name = "crtlName";
            this.crtlName.Size = new System.Drawing.Size(100, 20);
            this.crtlName.TabIndex = 28;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(12, 102);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(46, 13);
            this.labelControl4.TabIndex = 27;
            this.labelControl4.Text = "Surname:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(28, 141);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(23, 13);
            this.labelControl3.TabIndex = 26;
            this.labelControl3.Text = "Age:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(27, 69);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(31, 13);
            this.labelControl2.TabIndex = 25;
            this.labelControl2.Text = "Name:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(65, 21);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(139, 13);
            this.labelControl1.TabIndex = 24;
            this.labelControl1.Text = "Credentials of new Professor";
            // 
            // professorCancelButton
            // 
            this.professorCancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.professorCancelButton.Location = new System.Drawing.Point(671, 397);
            this.professorCancelButton.Name = "professorCancelButton";
            this.professorCancelButton.Size = new System.Drawing.Size(109, 32);
            this.professorCancelButton.TabIndex = 23;
            this.professorCancelButton.Text = "Cancel";
            this.professorCancelButton.UseVisualStyleBackColor = true;
            this.professorCancelButton.Click += new System.EventHandler(this.professorCancelButton_Click_1);
            // 
            // professorCreateButton
            // 
            this.professorCreateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.professorCreateButton.Location = new System.Drawing.Point(556, 397);
            this.professorCreateButton.Name = "professorCreateButton";
            this.professorCreateButton.Size = new System.Drawing.Size(109, 32);
            this.professorCreateButton.TabIndex = 22;
            this.professorCreateButton.Text = "Create";
            this.professorCreateButton.UseVisualStyleBackColor = true;
            this.professorCreateButton.Click += new System.EventHandler(this.professorCreateButton_Click_1);
            // 
            // crtlRank
            // 
            this.crtlRank.Location = new System.Drawing.Point(65, 170);
            this.crtlRank.Name = "crtlRank";
            this.crtlRank.Size = new System.Drawing.Size(100, 20);
            this.crtlRank.TabIndex = 31;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(12, 173);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(28, 13);
            this.labelControl5.TabIndex = 32;
            this.labelControl5.Text = "Rank:";
            // 
            // ProfessorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.crtlRank);
            this.Controls.Add(this.crtlAge);
            this.Controls.Add(this.crtlSurname);
            this.Controls.Add(this.crtlName);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.professorCancelButton);
            this.Controls.Add(this.professorCreateButton);
            this.Name = "ProfessorForm";
            this.Text = "ProfessorForm";
            ((System.ComponentModel.ISupportInitialize)(this.crtlAge.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crtlSurname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crtlName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crtlRank.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SpinEdit crtlAge;
        private DevExpress.XtraEditors.TextEdit crtlSurname;
        private DevExpress.XtraEditors.TextEdit crtlName;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.Button professorCancelButton;
        private System.Windows.Forms.Button professorCreateButton;
        private DevExpress.XtraEditors.TextEdit crtlRank;
        private DevExpress.XtraEditors.LabelControl labelControl5;
    }
}