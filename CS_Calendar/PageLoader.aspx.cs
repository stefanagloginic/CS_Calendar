using OpenQA.Selenium;
using OpenQA.Selenium.PhantomJS;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Net.Mime;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_Calendar
{
    public partial class PageLoader : System.Web.UI.Page
    {
        private string user;
        private string pass;
        private static string BaseUrl = "https://my.sa.ucsb.edu/gold/login.aspx";
        private List<string> registrationDates;
        private ReadOnlyCollection<IWebElement> courses; //will evntually become a list of courses



        protected void Page_Load(object sender, EventArgs e)
        {
            //if (Session["user"] != null)
            {
                //user = Session["user"].ToString();
                //pass = Session["pass"].ToString();
                //GetUserInfo();
            }
            

        }

        private void GetUserInfo()
        {
            Response.Write("start");
            var driver = new PhantomJSDriver(); //headless browser to navigate to gold
            driver.Navigate().GoToUrl(BaseUrl);

            var loginBox = driver.FindElementById("pageContent_userNameText"); //grab reference to username textfield on gold login
            loginBox.SendKeys(user);

            var pwBox = driver.FindElementById("pageContent_passwordText");//grab reference to password textfield on gold login
            pwBox.SendKeys(pass);

            var signinBtn = driver.FindElementById("pageContent_loginButton"); //grab reference to  login btn on gold login
            signinBtn.Click();

            var registrationImg = driver.FindElementById("ctl09_image"); //grab reference to registration for navigation 
            registrationImg.Click();

            IWebElement elem1 = driver.FindElementById("pageContent_PassOneLabel");
            IWebElement elem2 = driver.FindElementById("pageContent_PassTwoLabel");
            IWebElement elem3 = driver.FindElementById("pageContent_PassThreeLabel");

            registrationDates = new List<string>();

            registrationDates.Add(elem1.Text);
            registrationDates.Add(elem2.Text);
            registrationDates.Add(elem3.Text);
            //getting schedule page
            var scheduleImg = driver.FindElementById("ctl05_image");
            scheduleImg.Click();
            //grab course table
            IWebElement scheduleTable = driver.FindElementById("pageContent_CourseList");
            //grab all table elements with scheduleTable with width ="560" and align="center"
            courses = scheduleTable.FindElements(By.CssSelector("table[width='560'][align='center']"));
            //convert each webelement into a course object

            driver.Quit();
            Response.Write("done");

        }
    }
}