using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CS_Calendar.Model
{
    public class Time
    {
        public int hour { get; set; }
        public int minute { get; set; }
        public string period { get; set; }

        public Time(int hour, int minute, string period)
        {
            this.hour = hour;
            this.minute = minute;
            this.period = period;
        }
        public Time(string time)
        {
            char[] delimiterChars = { ' ', ':'};
            List<string> pieces = new List<string>(time.Split(delimiterChars));
            hour = int.Parse(pieces[0]);
            minute = int.Parse(pieces[1]);
            period = pieces[2];
        }

        public override string ToString() 
        {
            string hour = this.hour.ToString();
            string min;
            if(this.minute < 10)
            {
                min = "0" + minute.ToString();  
            }
            else
            {
                min = minute.ToString();
            }

            return hour + ":" +  min + " " + period;
            
        }
    }
}