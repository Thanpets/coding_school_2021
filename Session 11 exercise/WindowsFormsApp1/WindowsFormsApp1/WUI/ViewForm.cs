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
    
    public partial class ViewForm : Form {

        public EntityTypeEnum Type { get; set; }
        public University MasterData { get; set; }
        public List<string> ViewData = new List<string>(); 

        public ViewForm() {
            InitializeComponent();
        }

        private void ViewForm_Load(object sender, EventArgs e) {

            
            foreach (string item in ViewData) {
                ctrlViewList.Items.Add(item);
            }


        }

        private void btnEdit_Click(object sender, EventArgs e) {

            EditSelectedRecord();
           // RefreshList();     //Auto refresh
        }

        private void ctrlViewList_MouseDoubleClick(object sender, MouseEventArgs e) {
            EditSelectedRecord();
            //RefreshList();    //Auto refresh
        }


        private void EditSelectedRecord() {
            
            Guid id = GetListID();
            if(id==Guid.Empty) {
                return;
            }
            Object editObject = null;

            // assign edit properties by type
            switch (Type) {
                case EntityTypeEnum.Course:
                    editObject = MasterData.Courses.Find(x => x.ID == id);
                    break;

                case EntityTypeEnum.Student:
                    editObject = MasterData.Students.Find(x => x.ID == id);
                    break;

                case EntityTypeEnum.Professor:
                    break;

                default:
                    break;
            }

            // open edit form
            EditForm form = new EditForm();
            form.Type = Type;
            form.EditObject = editObject;
            form.ShowDialog();

        }

        private Guid GetListID() {

            object listSelection = ctrlViewList.SelectedItem;
            if (listSelection == null) {
                return Guid.Empty;
            }
            List<string> listParse = listSelection.ToString().Split(' ').ToList();

            Guid id = Guid.Parse(listParse[0].Substring(3));
            return id;
        }

        private void btnDelete_Click(object sender, EventArgs e) {


            Guid id = GetListID();
            // assign edit properties by type
            switch (Type) {
                case EntityTypeEnum.Course:
                    
                    MasterData.Courses.RemoveAll(x => x.ID == id);
                    break;

                case EntityTypeEnum.Student:
                   
                    MasterData.Students.RemoveAll(x => x.ID == id);
                    break;

                case EntityTypeEnum.Professor:
                    break;

                default:
                    break;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e) {

        }

        private void btnRefresh_Click(object sender, EventArgs e) {
            RefreshList();
        }
        private void RefreshList() {

            Guid id = GetListID();
            ctrlViewList.Items.Clear();
            switch (Type) {
                case EntityTypeEnum.Course: {
                        foreach (Course item in MasterData.Courses) {
                            ctrlViewList.Items.Add($"ID={item.ID} \t Code={item.Code} \t Subject={item.Subject}");
                        }
                        break;
                    }
                case EntityTypeEnum.Student: {
                        foreach (Student item in MasterData.Students) {
                            ctrlViewList.Items.Add($"ID={item.ID} \t Name={item.Name} \t Surname={item.Surname} \t RegistrationNumber={item.RegistrationNumber} ");
                        }
                        break;
                    }
                case EntityTypeEnum.Professor: {
                        foreach (Professor item in MasterData.Professors) {
                            ctrlViewList.Items.Add($"{item.ID}\t{item.Name}\t{item.Surname}\t {item.Age}\t {item.Rank}");
                        }
                        break;
                    }
                default:
                    break;
            }
        }
    }
}
