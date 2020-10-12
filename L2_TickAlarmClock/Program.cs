using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace L2_TickAlarmClock
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                MyClock clock = new MyClock();
                DateTime time = new DateTime();
                time = DateTime.Now;
                clock.AlarmTime = new MyTime(time.Hour, time.Minute + 1, time.Second);
                clock.TickEvent += TickEventSolve;
                clock.AlarmEvent += AlarmEventSolve;
                new Thread(clock.Run).Start();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static void TickEventSolve(MyClock sender)
        {
            MyTime time = sender.CurrentTime;
            Console.WriteLine($"The clock ticks!{ time.Hour}:{ time.Minute}:{ time.Second}.");
        }

        public static void AlarmEventSolve(MyClock sender)
        {
            MyTime time = sender.CurrentTime;
            Console.WriteLine($"The clock alarms!{ time.Hour}:{ time.Minute}:{ time.Second}.");
        }
    }
}
