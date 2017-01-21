using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CS_Calendar.Model
{
    public class Course : ScheduleElement
    {
        string instructor { get; }
        Course section { get; }
        Exam final { get; set; }
        SortedSet<MeetingTime> meetingTimes { get; set; }
        List<Exam> midterms { get; set; }


        public Course(string instructor, Course section, Exam final, List<Exam> midterms)
        {
            this.instructor = instructor;
            this.section = section;
            this.final = final;
            this.midterms = midterms;
        }

    }
}