using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session18App.Model
{
    public class Course : EntityBase
    {
        public string Title { get; set; }
        public string Category { get; set; }
        public DateTime Date { get; set; } = new DateTime(1990, 1, 1);
        public int Duration { get; set; }

    }
}
