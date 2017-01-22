using System;
using OpenQA.Selenium;
using System.Collections.Generic;
using OpenQA.Selenium.PhantomJS;
using System.Collections.ObjectModel;
using CS_Calendar.Model;
namespace CS_Calendar
{
    public partial class GoldScraper : System.Web.UI.Page
    {
        public static string BaseUrl = "https://my.sa.ucsb.edu/gold/login.aspx";
        public static string regInfoUrl = "https://my.sa.ucsb.edu/gold/RegistrationInfo.aspx";
        public const int TimeOut = 30;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void Login()
        {
            string user = inputUsername.Value.ToString();
            string pass = inputPassword.Value.ToString();

            var driver = new PhantomJSDriver(); //headless browser to navigate to gold
            driver.Navigate().GoToUrl(BaseUrl);

            var loginBox = driver.FindElementById("pageContent_userNameText"); //grab reference to username textfield on gold login
            loginBox.SendKeys(user);

            var pwBox = driver.FindElementById("pageContent_passwordText");//grab reference to password textfield on gold login
            pwBox.SendKeys(pass);

            var signinBtn = driver.FindElementById("pageContent_loginButton"); //grab reference to  login btn on gold login
            signinBtn.Click();

            if (driver.Url == BaseUrl)
            {
                //make an error message appear login was unsuccesful 
                //http://stackoverflow.com/questions/5731224/calling-javascript-function-from-codebehind
                return;
            }
            else
            {
                //login was succesfull display a message "Login was Successfull"
                //Now getting schedule
            }

            //getting registration info
            var registrationImg = driver.FindElementById("ctl09_image"); //grab reference to registration for navigation 
            registrationImg.Click();

            IWebElement elem1 = driver.FindElementById("pageContent_PassOneLabel");
            IWebElement elem2 = driver.FindElementById("pageContent_PassTwoLabel");
            IWebElement elem3 = driver.FindElementById("pageContent_PassThreeLabel");

            List<string> registrationDates = new List<string>();

            registrationDates.Add(elem1.Text);
            registrationDates.Add(elem2.Text);
            registrationDates.Add(elem3.Text);

            //getting schedule page
            var scheduleImg = driver.FindElementById("ctl05_image");
            scheduleImg.Click();
            //grab course table
            IWebElement scheduleTable = driver.FindElementById("pageContent_CourseList");
            //grab all table elements with scheduleTable with width ="560" and align="center"
            ReadOnlyCollection<IWebElement> list = scheduleTable.FindElements(By.CssSelector("table[width='560'][align='center']"));
            /*foreach (var element in list)
            {
                foreach(var time in Course.courseParser(element).meetingTimes)
                    Response.Write(time + " ");
                Response.Write("</br>");

            }*/
            //convert each webelement into a course object

            //grab final exam information from Gold
            IWebElement finalsTable = driver.FindElementById("pageContent_FinalsGrid");
            ReadOnlyCollection<IWebElement> finalElements = finalsTable.FindElements(By.CssSelector("table[width='560'][align='left']"));
            foreach(var element in finalElements)
            {
                Exam exams = Exam.createExam(element);
                Response.Write(exams + "</br>");
            }
            driver.Quit();

        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            Login();
        }

    }
}