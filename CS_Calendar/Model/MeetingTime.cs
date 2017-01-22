using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CS_Calendar.Model
{
    public class MeetingTime : IComparable
    {
        public string day { get; set; }
        public Time startTime { get; set; }
        public Time endTime { get; set; }

        public MeetingTime(string day, Time startTime, Time endTime)
        {
            this.day = day;
            this.startTime = startTime;
            this.endTime = endTime;
        }

        public override string ToString()
        {
            return day + " " + startTime + "-" + endTime;
        }

        public int CompareTo(object obj) {
            if (obj == null) return 1;
            MeetingTime other = obj as MeetingTime;
            if (other != null)
                return enumerator(this.day).CompareTo(enumerator(other.day));
            else
                throw new ArgumentException("Object is not a MeetingTime");
        }

        public int enumerator(string day)
        {
            if (day == "Su") return 0;
            else if (day == "M") return 1;
            else if (day == "T") return 2;
            else if (day == "W") return 3;
            else if (day == "R") return 4;
            else if (day == "F") return 5;
            else if (day == "Sa") return 6;
            else return -1;
        }

    }
}