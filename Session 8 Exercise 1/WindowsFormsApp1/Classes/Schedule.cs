using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Classes {
    public class Schedule {

        // PROPERTIES
        public Guid ID { get; private set; }

        public Guid CourseID { get; set; }
        public Guid ProfessorID { get; set; }

        public DateTime Callendar { get; set; }

        // CONSTRUCTOR
        public Schedule() {
            ID = Guid.NewGuid();
        }

        private void Init() {

            ID = Guid.NewGuid();
        }
    }
}
