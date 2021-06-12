using System;
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
    public partial class ProfessorForm : Form {
        public Professor NewProfessor { get; set; }
        public ProfessorForm() {
            InitializeComponent();
        }

        private void ProfessorForm_Load(object sender, EventArgs e) {

        }

       

       
        private void professorCreateButton_Click_1(object sender, EventArgs e) {
            NewProfessor.Name = Convert.ToString(crtlName.EditValue);
            NewProfessor.Surname = Convert.ToString(crtlRank.EditValue);
            NewProfessor.Age = Convert.ToInt32(crtlAge.EditValue);
            NewProfessor.Rank = Convert.ToString(crtlSurname.EditValue);
            DialogResult = DialogResult.OK;
            Close();
        }

        private void professorCancelButton_Click_1(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
