using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;

namespace CS_Calendar.Model
{
    public class Exam
    {
        public string courseTitle { get; set; }
        public string name { get; set; }
        public Date date { get; set; }
        public Time startTime { get; set; }
        public Time endTime { get; set; }

        public Exam(string name, string courseTitle, Date date, Time startTime, Time endTime)
        {
            this.name = name;
            this.courseTitle = courseTitle;
            this.date = date;
            this.startTime = startTime;
            this.endTime = endTime;
        }

        public Exam(string courseTitle, Date date, Time startTime, Time endTime)
        {
            this.courseTitle = courseTitle;
            this.date = date;
            this.startTime = startTime;
            this.endTime = endTime;
        }

        public static Exam createExam(IWebElement finals)
        {
            
            ReadOnlyCollection<IWebElement> tdList = finals.FindElements(By.CssSelector("td[class*=clcellprimary]"));
            string courseTitle = tdList[0].Text;
            string list = tdList[1].Text;
            List<string> dayMonthYear = new List<string>(list.Split(','));
            string weekDay = dayMonthYear[0];
            string monthAndDay = dayMonthYear[1].Substring(1);
            List<string> splitDate = new List<string>(monthAndDay.Split(' '));
            string month = splitDate[0];
            int day = int.Parse(splitDate[1]);
            string yearAndTime = dayMonthYear[2];
            int year = int.Parse(yearAndTime.Substring(1, 4));

            Date date = new Date(weekDay, day, month, year);

            string timeSpan = yearAndTime.Substring(6);

            List<string> splitTimes = new List<string>(timeSpan.Split('-'));
            Time startTime = new Time(splitTimes[0]);
            Time endTime = new Time(splitTimes[1].Substring(1));

            

            //returns an exam object created from an IWebElement
            return new Exam("Final Exam", courseTitle, date, startTime, endTime);
           
        }

        public override string ToString()
        {
            return name + " " + courseTitle + " " + date + " " + startTime + " " + endTime;
        }

    }
}