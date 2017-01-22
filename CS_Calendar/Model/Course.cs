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


        public Course(string instructor, SortedSet<MeetingTime> meetingTimes, Course section, string location, Exam final, List<Exam> midterms, string courseName, 
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
            string title = info.FindElement(By.CssSelector("[id*=CourseHeadingLabel]")).Text; //grabbing the class name
            IWebElement instructorTbl = info.FindElement(By.CssSelector("[id*=InstructorList]")); //grabbing instructor and TA 
            ReadOnlyCollection <IWebElement> instructors = instructorTbl.FindElements(By.CssSelector("td[class*=clcellprimary]"));
            IWebElement meetingTimesTbl = info.FindElement(By.CssSelector("[id*=MeetingTimesList]"));
            ReadOnlyCollection<IWebElement> meetingTbls = meetingTimesTbl.FindElements(By.CssSelector("table[width='260'][align='left']"));
            ReadOnlyCollection<IWebElement> meetingCells = meetingTbls[0].FindElements(By.CssSelector("td[class*=clcellprimary]"));
            string lectureDays = meetingCells[0].Text;
            string lectureTimes = meetingCells[1].Text;
            string location = meetingCells[2].Text;

            SortedSet<MeetingTime> meetingTimes = createMeetingTimes(lectureDays, lectureTimes);

            return new Course(instructors[1].Text, meetingTimes, null, location, null, null, title, "");
        }

        public static SortedSet<MeetingTime> createMeetingTimes(string lectureDays, string lectureTimes)
        {
            
            SortedSet <MeetingTime> meetingTimes = new SortedSet<MeetingTime>();
            List<string> days = new List<string>(lectureDays.Split(' '));
            List<string> splitTimes = new List<string>(lectureTimes.Split('-'));
            Time startTime = new Time(splitTimes[0]);
            Time endTime = new Time(splitTimes[1]);

            foreach (var day in days)
            {
                MeetingTime m = new MeetingTime(day, startTime, endTime);
                meetingTimes.Add(m);
            }

            return meetingTimes;
        }

    }
}