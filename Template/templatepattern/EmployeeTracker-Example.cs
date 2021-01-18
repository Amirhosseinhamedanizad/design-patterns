using System;

namespace templatepattern
{
    public abstract class EmployeeTracker
    {
        public abstract void TrackEmployeeLogin();
        public abstract void TrackEmployeeWork();

        public void Template()
        {
            Console.WriteLine("Auditing Started .....");
            TrackEmployeeLogin();
            TrackEmployeeWork();
            Console.WriteLine("Auditing Finished .....");
        }
    }

    public class Tracker1 : EmployeeTracker
    {
        public override void TrackEmployeeLogin()
        {
            Console.WriteLine("tracker 1 starts tracking a logged in employee");
        }

        public override void TrackEmployeeWork()
        {
            Console.WriteLine("tracker 1 starts tracking a work for employee");
        }
    }

    public class Tracker2 : EmployeeTracker
    {
        public override void TrackEmployeeLogin()
        {
            Console.WriteLine("tracker 2 starts tracking a logged in employee");
        }

        public override void TrackEmployeeWork()
        {
            Console.WriteLine("tracker 2 starts tracking a work for employee");
        }
    }
}
