using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Classes {
    public class Course {

        // PROPERTIES
        public string Subject { get; set; }

        public string Code { get; set; }
        public int Hours { get; set; }
        public CoursesCategoryEnum Category { get; set; }

        // CONSTRUCTOR
        public Course() {

        }

        // METHODS
        public void Init() {

            List<Course> courses = new List<Course>();

            Course physics1 = new Course() {
                Subject = "Quantum Physics",
                Category = CoursesCategoryEnum.Physics,
                Hours = 100
            };
            courses.Add(physics1);


            Course physics2 = new Course() {
                Subject = "Electo-Dynamics",
                Category = CoursesCategoryEnum.Physics,
                Hours = 50
            };
            courses.Add(physics2);

            Course static1 = new Course();
            static1.Subject = "Static";
            static1.Category = CoursesCategoryEnum.CivilEngineering;
            static1.Hours = 500;

            courses.Add(static1);


            List<Course> physicsCourses = courses.FindAll(x => x.Category == CoursesCategoryEnum.Physics);


            List<Course> physicsCourses100 = physicsCourses.FindAll(course => course.Hours >= 100);



            List<Course> physicsCourses2 = new List<Course>();
            foreach (Course x in courses) {

                if (x.Category == CoursesCategoryEnum.Physics && x.Hours >= 100) {
                    physicsCourses2.Add(x);
                }
            }

            List<Course> physicsCourses3 = new List<Course>();
            foreach (Course y in courses) {

                if (y.Hours >= 100) {
                    physicsCourses3.Add(y);
                }
            }




        }
    }
}
