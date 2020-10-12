using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2_TickAlarmClock
{
    class MyTime
    {
        private int hour;
        private int minute;
        private int second;

        public  MyTime(int h,int m,int s)
        {
            if ((h < 0 || h > 24) || (m < 0 || m > 60) || (s < 0 || s > 60))
            {
                throw new ArgumentOutOfRangeException("invalid time!");
            }
            hour = h;
            minute = m;
            second = s;
        }

        public int Hour
        {
            get
            {
                return hour;
            }
            set
            {
                if (value < 0 || value > 24)
                {
                    throw new ArgumentOutOfRangeException("invalid hour!");
                }
                hour = value;
            }
        }

        public int Minute
        {
            get
            {
                return minute;
            }
            set
            {
                if (value < 0 || value > 60)
                {
                    throw new ArgumentOutOfRangeException("invalid minute!");
                }
                minute = value;
            }
        }

        public int Second
        {
            get
            {
                return second;
            }
            set
            {
                if (value < 0 || value > 60)
                {
                    throw new ArgumentOutOfRangeException("invalid second!");
                }
                second = value;
            }
        }

        public override bool Equals(object obj)
        {
            var input = obj as MyTime;
            if(input!=null)
            {
                return this.Hour == input.Hour && this.Minute == input.Minute && this.Second == input.Second;

            }
            else
            {
                return false;
            }
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();            
        }
    }
}
