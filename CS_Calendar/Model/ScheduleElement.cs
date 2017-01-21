using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CS_Calendar.Model
{
    public abstract class ScheduleElement
    {
        private string eventName { get; set; } 
        private DateTime startDate { get; set; }
        private DateTime endDate { get; set; }
        private string description { get; set; }

        public ScheduleElement(string eventName, DateTime startDate, DateTime endDate, string description) {
            this.eventName = eventName;
            this.startDate = startDate;
            this.endDate = endDate;
            this.description = description;
        }

    }
} 