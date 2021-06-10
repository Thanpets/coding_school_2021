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
        public Professor professor { get; set; }
        public ProfessorForm() {
            InitializeComponent();
        }

        private void ProfessorForm_Load(object sender, EventArgs e) {

        }

        private void professorCreateButton_Click(object sender, EventArgs e) {
            professor.Name = professorNameTextEdit.Text;
            professor.Age = Convert.ToInt32(professorAgeSpinEdit.Value);
            professor.Rank = professorRankTextEdit.Text;
            this.Close();
        }

        private void professorCancelButton_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
