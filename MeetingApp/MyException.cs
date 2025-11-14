using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeetingApp
{
    public class DateFromPast : Exception
    {
        public DateFromPast(string message) : base(message) { }
    }
}
