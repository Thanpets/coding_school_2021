
namespace Session18App
{
    partial class CourseForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.crtlAdd = new System.Windows.Forms.Button();
            this.crtlRefresh = new System.Windows.Forms.Button();
            this.crtlDelete = new System.Windows.Forms.Button();
            this.crtlSaveChanges = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.crtlDataGrid = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.crtlDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // crtlAdd
            // 
            this.crtlAdd.Location = new System.Drawing.Point(60, 66);
            this.crtlAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.crtlAdd.Name = "crtlAdd";
            this.crtlAdd.Size = new System.Drawing.Size(82, 22);
            this.crtlAdd.TabIndex = 11;
            this.crtlAdd.Text = "Add";
            this.crtlAdd.UseVisualStyleBackColor = true;
            // 
            // crtlRefresh
            // 
            this.crtlRefresh.Location = new System.Drawing.Point(317, 66);
            this.crtlRefresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.crtlRefresh.Name = "crtlRefresh";
            this.crtlRefresh.Size = new System.Drawing.Size(82, 22);
            this.crtlRefresh.TabIndex = 10;
            this.crtlRefresh.Text = "Refresh";
            this.crtlRefresh.UseVisualStyleBackColor = true;
            // 
            // crtlDelete
            // 
            this.crtlDelete.Location = new System.Drawing.Point(148, 66);
            this.crtlDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.crtlDelete.Name = "crtlDelete";
            this.crtlDelete.Size = new System.Drawing.Size(82, 22);
            this.crtlDelete.TabIndex = 9;
            this.crtlDelete.Text = "Delete";
            this.crtlDelete.UseVisualStyleBackColor = true;
            // 
            // crtlSaveChanges
            // 
            this.crtlSaveChanges.Location = new System.Drawing.Point(404, 66);
            this.crtlSaveChanges.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.crtlSaveChanges.Name = "crtlSaveChanges";
            this.crtlSaveChanges.Size = new System.Drawing.Size(106, 22);
            this.crtlSaveChanges.TabIndex = 8;
            this.crtlSaveChanges.Text = "SaveChanges";
            this.crtlSaveChanges.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(516, 93);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(224, 291);
            this.panel1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Title";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(130, 28);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(78, 19);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "Complete";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(3, 26);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(110, 23);
            this.textBox1.TabIndex = 0;
            // 
            // crtlDataGrid
            // 
            this.crtlDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.crtlDataGrid.Location = new System.Drawing.Point(60, 93);
            this.crtlDataGrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.crtlDataGrid.Name = "crtlDataGrid";
            this.crtlDataGrid.RowHeadersWidth = 51;
            this.crtlDataGrid.RowTemplate.Height = 29;
            this.crtlDataGrid.Size = new System.Drawing.Size(450, 291);
            this.crtlDataGrid.TabIndex = 6;
            // 
            // CourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crtlAdd);
            this.Controls.Add(this.crtlRefresh);
            this.Controls.Add(this.crtlDelete);
            this.Controls.Add(this.crtlSaveChanges);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.crtlDataGrid);
            this.Name = "CourseForm";
            this.Text = "CourseForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.crtlDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button crtlAdd;
        private System.Windows.Forms.Button crtlRefresh;
        private System.Windows.Forms.Button crtlDelete;
        private System.Windows.Forms.Button crtlSaveChanges;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView crtlDataGrid;
    }
}