using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CS_Calendar.Model
{
    public class Date
    {
        string weekDay;
        int day;
        string month;
        int year;
       
   public Date(string weekDay, int day, string month, int year)
        {
            this.weekDay = weekDay;
            this.day = day;
            this.month = month;
            this.year = year;
        }

    public override string ToString()
        {
            return weekDay +" " + month + " " + day + " " + year;
        }
    }
}