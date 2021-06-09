using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session4Exercise {
    class Institute {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public int YearsInService { get; set; }

        public void GetName() {

        }
        public void SetName(string name) {

        }
    }
    class University : Institute {
        public Student[] Students { get; set; }
        public Course[] Courses { get; set; }
        public Grade[] Grades { get; set; }
        public Schedule[] ScheduledCourse { get; set; }
        public void GetStudents() {

        }
        public void GetCourses() {

        }
        public void GetGrades() {

        }
        public void SetSchedule(Guid courseID,Guid professorID,DateTime date) {

        }
    }

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
        public void SetGrade(Guid studentID,Guid courseID,Grade grade) {

        }
        public override string GetName() {
            return "Dr."+ Name;
        }
        public void Evaluate(Student student) {

        }

    }
    public class Student : Person {
        public int RegistrationNumber { get; set; }
        public Course[] Courses { get; set; } 

        public void Attend(Course course,DateTime date) {

        }
        public void WriteExam(Course course,DateTime date) {

        }


    }
    public class Grade {
        public Guid ID { get; set; }
        public Guid StudentID { get; set; }
        public Guid CourseID { get; set; }
        public int Grades { get; set; }


    }
    public class Course {
        public Guid ID { get; set; }
        public string Code { get; set; }
        public string Subject { get; set; }


    }
    public class Schedule {
        public Guid ID { get; set; }
        public Guid CourseID { get; set; }
        public Guid ProfessorID { get; set; }
        public DateTime Callendar { get; set; }

    }
}
