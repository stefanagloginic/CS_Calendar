using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CS_Calendar.Model
{
    public class Exam
    {
        private string name { get; set; }
        private MeetingTime meetingTime { get; set; }

        public Exam(string name, MeetingTime meetingTime)
        {
            this.name = name;
            this.meetingTime = meetingTime;
        }
    }
}