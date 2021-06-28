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
    public partial class CourseForm : Form
    {
        private Session18AppContext _session18Context;
        public CourseForm()
        {
            InitializeComponent();
            bindingSource1.DataSource = typeof(Course);

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = "Title", HeaderText = "Title" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = "Category", HeaderText = "Category" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = "Date", HeaderText = "Date" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = "Duration", HeaderText = "Duration" });
            dataGridView1.DataSource = bindingSource1;

            textBox1.DataBindings.Add("Text", bindingSource1, "Title");
            textBox2.DataBindings.Add("Text", bindingSource1, "Category");
            textBox3.DataBindings.Add("Text", bindingSource1, "Date");
            textBox4.DataBindings.Add("Text", bindingSource1, "Duration");
        }

        private void CourseForm_Load(object sender, EventArgs e)
        {
            var optionsBuilder = new DbContextOptionsBuilder<Session18AppContext>();
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DbTodoApp;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

            _session18Context = new Session18AppContext(optionsBuilder.Options);
            Refresh();
        }

        private void crtlAdd_Click(object sender, EventArgs e)
        {
            var newCourse = new Course();
            newCourse.Title = textBox1.Text;
            newCourse.Category = textBox2.Text;
            //newCourse.Date = DateTime.TryParse(textBox3.Text);
            newCourse.Duration = Convert.ToInt32(textBox4.Text);

            bindingSource1.Insert(0, newCourse);
            _session18Context.Courses.Add(newCourse);
        }

        private void crtlDelete_Click(object sender, EventArgs e)
        {
            var course = bindingSource1.Current as Course;
            if (course is null)
                return;

            bindingSource1.RemoveCurrent();
            _session18Context.Courses.Remove(course);
        }

        private void crtlRefresh_Click(object sender, EventArgs e)
        {
            Refresh();
        }
        private void Refresh()
        {
            bindingSource1.Clear();
            _session18Context.ChangeTracker.Clear();
            foreach (var course in _session18Context.Courses.ToList())
            {
                bindingSource1.Add(course);
            }
        }

        private void crtlSaveChanges_Click(object sender, EventArgs e)
        {
            _session18Context.SaveChanges();
        }

        private void CourseForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _session18Context.Dispose();
        }
    }
}
