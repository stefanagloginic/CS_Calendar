using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;

namespace CS_Calendar.Model
{
    public class Course : ScheduleElement
    {
        public string instructor { get; }
        public Course section { get; }
        public string location { get; set; }
        public Exam final { get; set; }
        public SortedSet<MeetingTime> meetingTimes { get; set; }
        public List<Exam> midterms { get; set; }


        public Course(string instructor, SortedSet<MeetingTime> meetingTime, Course section, string location, Exam final, List<Exam> midterms, string courseName, 
            string description) : base(courseName, description)
        {
            this.meetingTimes = meetingTimes;
            this.instructor = instructor;
            this.section = section;
            this.final = final;
            this.midterms = midterms;
            this.location = location;
        }

        public static Course courseParser(IWebElement info)
        {
            string title = info.FindElement(By.CssSelector("[id*=CourseHeadingLabel]")).Text;
            IWebElement instructorTbl = info.FindElement(By.CssSelector("[id*=InstructorList]"));
            ReadOnlyCollection <IWebElement> instructors = instructorTbl.FindElements(By.CssSelector("td[class*=clcellprimary]"));
           
            return new Course(instructors[1].Text, null, null, "", null, null, title, "");
        }

    }
}