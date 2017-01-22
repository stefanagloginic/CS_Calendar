using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CS_Calendar.Model
{
    public class MeetingTime
    {
        private string day { get; set; }
        private Time time { get; set; }

        public MeetingTime(string day, Time time)
        {
            this.day = day;
            this.time = time;
        }

        
    }
}