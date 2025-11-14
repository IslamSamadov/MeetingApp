using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeetingApp
{
    public class Meeting
    {
        public DateOnly FromDate { get; set; }
        public DateOnly ToDate { get; set; }
        public string Name { get; set; }

    }
}
