using System;
using OpenQA.Selenium;
using System.Collections.Generic;
using System.Web.UI.WebControls;

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

            var driver = new OpenQA.Selenium.PhantomJS.PhantomJSDriver(); //headless browser to navigate to gold
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

            List<string> registrationDates = new List<string>();

            registrationDates.Add(elem1.Text);
            registrationDates.Add(elem2.Text);
            registrationDates.Add(elem3.Text);

            for (int i = 0; i < 3; i++)
            {
                Response.Write(registrationDates[i] + " ");
            }

            driver.Quit();

        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            Login();
        }
    }
}