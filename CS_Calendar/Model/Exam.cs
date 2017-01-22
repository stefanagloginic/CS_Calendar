using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CS_Calendar.Model
{
    public class Exam
    {
        private string course;
        private string name { get; set; }
        private MeetingTime meetingTime { get; set; }

        public Exam(string name, MeetingTime meetingTime, string course)
        {
            this.name = name;
            this.course = course;
            this.meetingTime = meetingTime;
        }

        public static Exam createExams(IWebElement finals)
        {
            //returns an exam object created from an IWebElement
            return null;
           
        }
    }
}