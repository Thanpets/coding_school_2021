using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1 {
    public class Grade {
        public Guid ID { get; set; }
        public Guid StudentID { get; set; }
        public Guid CourseID { get; set; }
        public int Grades { get; set; }


    }
}
