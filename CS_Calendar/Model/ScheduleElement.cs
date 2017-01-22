using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CS_Calendar.Model
{
    public abstract class ScheduleElement
    {
        public string eventName { get; set; } 
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        public string description { get; set; }

        public ScheduleElement(string eventName, DateTime startDate, DateTime endDate, string description) {
            this.eventName = eventName;
            this.startDate = startDate;
            this.endDate = endDate;
            this.description = description;
        }
        public ScheduleElement(string eventName, string description)
        {
            this.eventName = eventName;
            this.description = description;
        }

    }
} 