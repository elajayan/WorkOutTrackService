using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkOutDBLayer.Model
{
    public class workoutactive
    {
        public int Id { get; set; }
        public int WorkOutId { get; set; }
        public string WorkOutTitle { get; set; }
        public string StartTime { get; set; }
        public DateTime StartDate { get; set; }
        public string Endtime { get; set; }
        public DateTime EndDate { get; set; }
        public string WorkOutComment { get; set; }

        public bool Status { get; set; }
    }
}
