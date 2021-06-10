using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Classes {
    public class Person {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public virtual string GetName() {
            return Name;
        }
        public void SetName(string name) {

        }

    }
    public class Professor : Person {
        public string Rank { get; set; }


        public Course[] Courses { get; set; } /*= new Course[] { new Course {Code = "Test",  ID = Guid.NewGuid(),Subject ="blabla" } };*/

        public void Teach(Course course, DateTime date) {

        }
        public void SetGrade(Guid studentID, Guid courseID, Grade grade) {

        }
        public override string GetName() {
            return "Dr." + Name;
        }
        public void Evaluate(Student student) {

        }

    }
    public class Student : Person {
        public int RegistrationNumber { get; set; }
        public Course[] Courses { get; set; }

        public void Attend(Course course, DateTime date) {

        }
        public void WriteExam(Course course, DateTime date) {

        }
    }
}
