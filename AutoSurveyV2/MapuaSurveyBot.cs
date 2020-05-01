using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace MapuaSurveyBot
{
    public class bot
    {
        private string email;
        private string password;
        private bool isLoggedIn;
        ChromeDriverService chromeDriverService = ChromeDriverService.CreateDefaultService();
        ChromeOptions option = new ChromeOptions();
        IWebDriver chrome;
        WebDriverWait explicitWait;
        
        public bot(string email, string password, bool isHeadless=false)
        {
            this.email = email;
            this.password = password;
            chromeDriverService.HideCommandPromptWindow = true;

            if (isHeadless)
            {
                option.AddArgument("--headless");
            }

            chrome = new ChromeDriver(chromeDriverService, option);
            explicitWait = new WebDriverWait(chrome, TimeSpan.FromSeconds(10));
            isLoggedIn = false;
        }

        public string Get_Username()
        {
            return email.Remove(email.IndexOf('@'));
        }

        public void Login()
        {
            chrome.Url = "https://login.microsoftonline.com/mymailmapuaedu.onmicrosoft.com/wsfed?wa=wsignin1.0&wtrealm=https%3a%2f%2fmymailmapuaedu.onmicrosoft.com%2fmyMapua365&wctx=rm%3d0%26id%3dpassive%26ru%3d%252f&wct=2020-04-30T16%3a29%3a43Z&sso_reload=true";

            // Start of login
            IWebElement userfield = explicitWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("/html/body/div/form[1]/div/div/div[1]/div[2]/div[2]/div/div/div/div[2]/div[2]/div/input[1]")));
            IWebElement nextButton = explicitWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("/html/body/div/form[1]/div/div/div[1]/div[2]/div[2]/div/div/div/div[4]/div/div/div/div[2]/input")));
            userfield.SendKeys(email);
            nextButton.Click();

            IWebElement passField = explicitWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("/html/body/div/form[1]/div/div/div[1]/div[2]/div[2]/div/div[2]/div/div[2]/div/div[2]/input")));
            IWebElement loginButton = explicitWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("/html/body/div/form[1]/div/div/div[1]/div[2]/div[2]/div/div[2]/div/div[3]/div[2]/div/div/div/div/input")));
            passField.SendKeys(password);
            loginButton.Click();

            //Asks password save
            IWebElement clickable = explicitWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("/html/body/div/form/div[1]/div/div[1]/div[2]/div/div[2]/div/div[3]/div[2]/div/div/div[1]/input")));
            clickable.Click();

            //Is logged in multiple devices??
            if (chrome.Url == "https://my.mapua.edu.ph/Error/MultipleBrowser.aspx" && chrome.Url != "https://my.mapua.edu.ph/Student/Default.aspx")
            {
                clickable = explicitWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("/html/body/form/div[3]/div/p/a")));
                clickable.Click();
            }

            //Close initial pop-up
            clickable = explicitWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("/html/body/form/div[3]/div[3]/a")));
            clickable.Click();

            isLoggedIn = true;
        }


        public bool AnswerFacultyAssessment()
        {
            //Open faculty survey
            try
            {
                IWebElement clickable = explicitWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("/html/body/form/div[3]/div[2]/ul/li[1]/a")));
                clickable.Click();
            }
            catch (Exception e)
            {
                return false;
            }

            //Count how many courses
            IWebElement dropdown = explicitWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("/html/body/form/div[3]/div[2]/p[3]/select")));
            IReadOnlyCollection<IWebElement> courses = dropdown.FindElements(By.CssSelector("option"));

            //Answer Survey
            for (int i = 0; i < courses.Count; i++)
            {
                for (int x = 1; x <= 8; x++)
                {
                    explicitWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("/html/body/form/div[3]/div[2]/ul/li[1]/ul/li[" + x + "]/select"))).SendKeys("10");
                }

                for (int x = 1; x <= 6; x++)
                {
                    explicitWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("/html/body/form/div[3]/div[2]/ul/li[2]/ul/li[" + x + "]/select"))).SendKeys("10");
                }

                for (int x = 1; x <= 9; x++)
                {
                    explicitWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("/html/body/form/div[3]/div[2]/ul/li[3]/ul/li[" + x + "]/select"))).SendKeys("10");
                }

                for (int x = 1; x <= 7; x++)
                {
                    explicitWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("/html/body/form/div[3]/div[2]/ul/li[4]/ul/li[" + x + "]/select"))).SendKeys("10");
                }

                for (int x = 1; x <= 3; x++)
                {
                    explicitWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("/html/body/form/div[3]/div[2]/ul/li[5]/ul/li[" + x + "]/select"))).SendKeys("10");
                }

                //clickable = explicitWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("/html/body/form/div[3]/div[2]/div[1]/input[1]")));
                //clickable.Click();
            }
            return true;
        }

        public void Close()
        {
            chrome.Close();
        }
        
    }
}
