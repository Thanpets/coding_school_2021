using Microsoft.EntityFrameworkCore;
using Session18App.EF.Context;
using Session18App.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session18App
{
    public partial class StudentForm : Form
    {
        private Session18AppContext _session18Context;
        public StudentForm()
        {
            InitializeComponent();
            bindingSource1.DataSource = typeof(Student);

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = "Name", HeaderText = "Name" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = "Surname", HeaderText = "Surname" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = "Birthdate", HeaderText = "Birthdate" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = "Adress", HeaderText = "Adress" });
            dataGridView1.DataSource = bindingSource1;

            textBox1.DataBindings.Add("Text", bindingSource1, "Name");
            textBox2.DataBindings.Add("Text", bindingSource1, "Surname");
            textBox3.DataBindings.Add("Text", bindingSource1, "Birthdate");
            textBox4.DataBindings.Add("Text", bindingSource1, "Adress");
            //checkBox1.DataBindings.Add("Checked", bindingSource1, "Complete");
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {
            var optionsBuilder = new DbContextOptionsBuilder<Session18AppContext>();
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DbTodoApp;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

            _session18Context = new Session18AppContext(optionsBuilder.Options);
            Refresh();
        }

        private void StudentForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _session18Context.Dispose();
        }

        private void crtlSaveChanges_Click(object sender, EventArgs e)
        {
            _session18Context.SaveChanges();
        }

        private void crtlDelete_Click(object sender, EventArgs e)
        {
            var student = bindingSource1.Current as Student;
            if (student is null)
                return;

            bindingSource1.RemoveCurrent();
            _session18Context.Students.Remove(student);
        }

        private void crtlRefresh_Click(object sender, EventArgs e)
        {
            Refresh();
        }
        private void Refresh()
        {
            bindingSource1.Clear();
            _session18Context.ChangeTracker.Clear();
            foreach (var todo in _session18Context.Students.ToList())
            {
                bindingSource1.Add(todo);
            }
        }

        private void crtlAdd_Click(object sender, EventArgs e)
        {
            var newStudent = new Student();
            newStudent.Name = textBox1.Text;
            newStudent.Surname = textBox2.Text;
            //newStudent.Birthdate = DateTime.TryParse(textBox3.Text);
            newStudent.Adress = textBox4.Text;

            bindingSource1.Insert(0, newStudent);
            _session18Context.Students.Add(newStudent);
        }
    }
}
