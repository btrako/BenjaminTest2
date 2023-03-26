using Docker.DotNet.Models;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using NuGet.Common;
using System.Net.Mail;
using HulkProject;

namespace HulkProject
{
    public class HulkApps
    {
        public static string Application()
        {


            string message = "";
            string ApplicationMessage = "";
            string Link1 = "https://qa-practical-test.myshopify.com/password";



            try
            {

                Driver.Instance.Navigate().GoToUrl(Link1); // Navigiranje na stranicu

                // Upišite password da biste otvorili stranicu
                var passwordfield = Driver.Instance.FindElement(By.XPath("//body//div[2]//form//div/input"));
                passwordfield.Click();
                passwordfield.SendKeys("brauff");
                var buttonEnter = Driver.Instance.FindElement(By.CssSelector("body .content div:nth-child(2) button"));
                buttonEnter.Click();


            }

            catch (Exception e)
            {
                message += "ERORR !!!" + e.Message;
            }

            message += ApplicationMessage;
            return message;



        }

        public static string Registration()
        {

            string message = "";
            string RegistrationMessage = "";


            string name = "Alex";
            string lastname = "Bond";
            string email = "alexbond555@gmail.com";
            string password = "UpisiBiloŠta555";





            try
            {
                var Account = Driver.Instance.FindElement(By.XPath("//*[@id=\"shopify-section-header\"]/sticky-header/header/div/a[1]"));
                Account.Click();

                var ButtonCreateAccount = Driver.Instance.FindElement(By.CssSelector("#customer_login a:nth-child(7)"));
                ButtonCreateAccount.Click();

                var FirstName = Driver.Instance.FindElement(By.CssSelector("#RegisterForm-FirstName"));
                FirstName.Click();
                FirstName.SendKeys(name);

                var LastName = Driver.Instance.FindElement(By.CssSelector("#RegisterForm-LastName"));
                LastName.Click();
                LastName.SendKeys(lastname);

                var emailaddress = Driver.Instance.FindElement(By.CssSelector("#RegisterForm-email"));
                emailaddress.Click();
                emailaddress.SendKeys(email);

                var passwordfield = Driver.Instance.FindElement(By.CssSelector("#RegisterForm-password"));
                passwordfield.Click();
                passwordfield.SendKeys(password);

                var CreateButton = Driver.Instance.FindElement(By.CssSelector("#create_customer button"));
                CreateButton.Click();



            }

            catch (Exception e)
            {
                message += "ERORR !!!" + e.Message;
            }

            message += RegistrationMessage;
            return message;


        }

        public static string Login()
        {
            string message = "";
            string LoginMessage = "";
            string email = "alexbond555@gmail.com";
            string password = "UpisiBiloŠta555";


            try
            {
                var Account = Driver.Instance.FindElement(By.XPath("//*[@id=\"shopify-section-header\"]/sticky-header/header/div/a[1]"));
                Account.Click();

                var LogOutButton = Driver.Instance.FindElement(By.CssSelector("#MainContent div:nth-child(1) a"));
                LogOutButton.Click();

                Account = Driver.Instance.FindElement(By.XPath("//*[@id=\"shopify-section-header\"]/sticky-header/header/div/a[1]"));
                Account.Click();

                // Login polja

                var emailfield = Driver.Instance.FindElement(By.CssSelector("#CustomerEmail"));
                emailfield.Click();
                emailfield.SendKeys(email);

                var passwordfield = Driver.Instance.FindElement(By.CssSelector("#CustomerPassword"));
                passwordfield.Click();
                passwordfield.SendKeys(password);

                var SigninBUTTON = Driver.Instance.FindElement(By.CssSelector("#customer_login button"));
                SigninBUTTON.Click();


            }


            catch (Exception e)
            {
                message += "ERORR !!!" + e.Message;
            }


            message += LoginMessage;
            return message;
            
            
            
        }

        public static string SearchField()
        {
            string message = "";
            string SearchMessage = "";
            string text = "14k Bloom Earrings";
            try
            {

                var SearchButton = Driver.Instance.FindElement(By.ClassName("modal__toggle-open icon icon-search"));
                SearchButton.Click();
                var SearchInputField = Driver.Instance.FindElement(By.ClassName("search__input field__input"));
                SearchInputField.Click();
                SearchInputField.SendKeys(text);
                SearchInputField.SendKeys(Keys.Enter);

                var SearchResult = Driver.Instance.FindElement(By.CssSelector("#product-grid li:nth-child(1) .card-information h3 a"));
                SearchResult.Click();



            }

            catch (Exception e)
            {
                message += "ERORR !!!" + e.Message;

            }

            message += SearchMessage;
            return message;




        }

    }
}


