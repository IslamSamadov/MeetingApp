using MeetingApp;

Console.WriteLine("---Meeting Scheduler---");
bool exit = false;
while (!exit)
{
    Console.WriteLine("1- Meeting elave et");
    Console.WriteLine("2- Daxil olunmus date sonraki meetingleri goster");
    Console.WriteLine("3- Daxil olunmus adli meetingleri goster");
    Console.WriteLine("4- Daxil olunmus adli meetingin olub olmadigini yoxlayir");
    Console.WriteLine("0- Cixis et");
    int line = int.Parse(Console.ReadLine());
    switch (line)
    {
        case 1:
            Console.WriteLine("\nMeeting adi daxil edin");
            string title = Console.ReadLine();
            Console.WriteLine("\nMeeting baslama vaxti daxil edin : Il-Ay-Gun(Ex: 2025-12-12)");
            DateOnly dateTime = DateOnly.Parse(Console.ReadLine());
            if (dateTime < DateOnly.FromDateTime(DateTime.Now))
            {
                Console.WriteLine("Tarix kecmise aid ola bilmez");
                break;
            }
            Console.WriteLine("\nMeeting bitme vaxti daxil edin");
            DateOnly dateTimeEnd = DateOnly.Parse(Console.ReadLine());
            if (dateTime > dateTimeEnd)
            {
                throw new DateFromPast("Bitme tarixi baslamadan sonra ola bilmez");
            }
            if (MeetingSchedule.fd == false)
            {
                break;
            }
            MeetingSchedule.SetMeeting(title, dateTime, dateTimeEnd);
            break;
        case 2:
            if (MeetingSchedule.Meetings.Count() == 0)
            {
                Console.WriteLine("Hal hazirda meeting yoxdur");
                break;
            }
            Console.WriteLine("Meeting baslama vaxti daxil edin.");
            DateOnly datetime = DateOnly.Parse(Console.ReadLine());
            Console.WriteLine(MeetingSchedule.FindMeetingsCount(datetime));
            break;
        case 3:
            if (MeetingSchedule.Meetings.Count() == 0)
            {
                Console.WriteLine("Hal hazirda meeting yoxdur");
                break;
            }
            Console.WriteLine("Ad daxil edin.");
            string name = Console.ReadLine();
            MeetingSchedule.GetExistMeetings(name);
            break;
        case 4:
            if (MeetingSchedule.Meetings.Count() == 0)
            {
                Console.WriteLine("Hal hazirda meeting yoxdur");
                break;
            }
            Console.WriteLine("Ad daxil edin.");
            name = Console.ReadLine();
            Console.WriteLine(MeetingSchedule.IsExistsMeetingByName(name));
            break;
        case 0:
            exit = true;
            break;
        default:
            Console.WriteLine("\nMenyuda olan reqem daxil edin!\n");
            break;
    }
}