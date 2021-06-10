using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Classes {



    //public class Student {

    //    public Guid ID { get; private set; }


    //}

    public class University {

        // PROPERTIES
        public List<Schedule> ScheduledCourses { get; set; }

        public Schedule ScheduledCourse { get; set; }

        // CONSTRUCTOR
        public University() {

        }

        //  METHODS


        public void SetCourse() {


            //Courses physics1 = new Courses();
            //physics1.Category = CoursesCategoryEnum.Physics;




        }

        public void SetGrade(CoursesCategoryEnum coursesCategory) {

            decimal modifier = 0;

            switch (coursesCategory) {
                case CoursesCategoryEnum.Physics:
                    modifier = 0.8m;
                    break;
                case CoursesCategoryEnum.Mathematics:
                    modifier = 0.9m;
                    break;
                case CoursesCategoryEnum.Sociology:
                    modifier = 0.5m;
                    break;
                case CoursesCategoryEnum.Chemistry:
                    modifier = 0.66m;
                    break;
                case CoursesCategoryEnum.Financial:
                    modifier = 0.8m;
                    break;
                default:
                    break;
            }


            if (coursesCategory == CoursesCategoryEnum.Physics) {


            }




        }


        // crud

        public void DeleteScheduledCourse(Guid scheduleID) {

            //Schedule schedule = ScheduledCourses.Find(x => x.ID == scheduleID);
            //ScheduledCourses.Remove(schedule);

            ScheduledCourses.RemoveAll(x => x.ID == scheduleID);
        }

        public void AddScheduledCourse(Guid courseID, Guid professorID, DateTime callendar) {

            // Verb (Action) -> Object

            Schedule schedule = new Schedule() {
                Callendar = callendar,
                CourseID = courseID,
                ProfessorID = professorID

            };

            ScheduledCourse = schedule;

            ScheduledCourses.Add(schedule);
        }

        public void UpdateScheduledCourse(Guid scheduleID, DateTime callendar) {

            // locate
            Schedule schedule = ScheduledCourses.Find(x => x.ID == scheduleID);

            UpdateScheduledCourse(scheduleID, Guid.Empty, Guid.Empty, callendar);
        }

        public void UpdateScheduledCourse(Guid scheduleID, Guid courseID, Guid professorID, DateTime callendar) {

            // locate
            Schedule schedule = ScheduledCourses.Find(x => x.ID == scheduleID);

            // update
            if (courseID != Guid.Empty) {
                schedule.CourseID = courseID;
                // todo ....
            }


            if (professorID != Guid.Empty) {
                schedule.ProfessorID = professorID;

                // todo ....
            }

            schedule.Callendar = callendar;

        }


        public List<Schedule> GetScheduledCourses() {


            return ScheduledCourses;
        }

    }


    public class Crud {





        public void Create() {

        }

        public void Read() {

        }

        public void Update() {

        }

        public void Delete() {

        }
    }






}












