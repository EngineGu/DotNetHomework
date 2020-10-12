using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace L2_TickAlarmClock
{
    class MyClock
    {
        public MyTime CurrentTime
        {
            get;
            set;
        }

        public MyTime AlarmTime
        {
            get;
            set;
        }

        public delegate void TickEventHandler(MyClock sender);
        public delegate void AlarmEventHandler(MyClock sender);
        public event TickEventHandler TickEvent;
        public event AlarmEventHandler AlarmEvent;

        public MyClock()
        {
            CurrentTime = new MyTime(0, 0, 0);
        }

        public void Run()
        {
            while(true)
            {
                DateTime t = DateTime.Now;
                CurrentTime = new MyTime(t.Hour, t.Minute, t.Second);
                TickEvent(this);
                if(AlarmTime.Equals(CurrentTime))
                {
                    AlarmEvent(this);
                }
                Thread.Sleep(1000);
            }
        }
    }
}
