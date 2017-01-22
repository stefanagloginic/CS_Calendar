using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CS_Calendar.Model
{
    public class Time
    {
        private int hour { get; set; }
        private int minute { get; set; }

        public Time(int hour, int minute)
        {
            this.hour = hour;
            this.minute = minute;
        }
    }
}