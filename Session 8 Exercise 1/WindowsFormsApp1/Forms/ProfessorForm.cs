using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Classes;

namespace WindowsFormsApp1 {
    public partial class ProfessorForm : Form {
        public Professor Professor { get; set; }
        public ProfessorForm() {
            InitializeComponent();
        }

        private void ProfessorForm_Load(object sender, EventArgs e) {

        }

        private void ProfessorCreateButton_Click(object sender, EventArgs e) {
            Professor.Name = professorNameTextEdit.Text;
            Professor.Age = Convert.ToInt32(professorAgeSpinEdit.Value);
            Professor.Rank = professorRankTextEdit.Text;
            this.Close();
        }

        private void ProfessorCancelButton_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
