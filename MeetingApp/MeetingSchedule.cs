using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeetingApp
{
    public static class MeetingSchedule
    {
        public static List<Meeting> Meetings { get; set; } = new List<Meeting>();
        public static void SetMeeting(string fullname, DateOnly from, DateOnly to)
        {
            if (Meetings.Any(m => from < m.ToDate))
            {
                throw new ArgumentException("Bu vaxti meeting var");
            }
            else
            {
                Meeting meeting = new Meeting();
                meeting.Name = fullname;
                meeting.FromDate = from;
                meeting.ToDate = to;
                Meetings.Add(meeting);
            }
        }
        public static int FindMeetingsCount(DateOnly date)
        {
            return Meetings.FindAll(m => m.FromDate > date).Count();
        }
        public static bool IsExistsMeetingByName(string name)
        {
            return Meetings.Any(m => m.Name == name);
        }
        public static void GetExistMeetings(string name)
        {
            Meetings.FindAll(m => m.Name == name).ForEach(m => Console.WriteLine($"{m.Name} " +
                $"|| {m.FromDate} || {m.ToDate}"));
        }
    }
}
