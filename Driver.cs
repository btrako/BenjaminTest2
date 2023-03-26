using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;

namespace HulkProject

{
    public class Driver
    {
        public static IWebDriver Instance { get; set; }

        //Default Constructor
        public static void Initialize()
        {
            Instance = new ChromeDriver();

            Instance.Manage().Timeouts().ImplicitWait.Add(TimeSpan.FromSeconds(5));

            Instance.Manage().Window.Maximize();
        }

        public static void Initialize(int n)
        {

            if (n == 1)
            {
                var downloadDirectory = @"C:\Files";
                FirefoxOptions options = new FirefoxOptions();

                options.SetPreference("download.default_directory", downloadDirectory);
                options.SetPreference("download.prompt_for_download", false);
                options.SetPreference("disable-popup-blocking", "true");

                Instance = new FirefoxDriver();
                Instance.Manage().Timeouts().ImplicitWait.Add(TimeSpan.FromSeconds(5));
                Instance.Manage().Window.Maximize();


            }


            else if (n == 2)
            {
                // Ako odaberemo 2, zadani browwer će biti Google Chrome

                var downloadDirectory = @"C:\Files";
                ChromeOptions options = new ChromeOptions();

                options.AddUserProfilePreference("download.default_directory", downloadDirectory);
                options.AddArgument("--disable-notifications");
                options.AddUserProfilePreference("download.prompt_for_download", false);
                options.AddUserProfilePreference("disable-popup-blocking", "true");
                options.AddUserProfilePreference("plugins.plugins_disabled", new[] {
                "Adobe Flash Player",
                "Chrome PDF Viewer"
                                                                                   });

                Instance = new ChromeDriver(@"C:\Drivers\", options);
                Instance.Manage().Window.Maximize();

            }

            else if (n == 3)
            {
                // Ako odaberemo 3, zadani brower će biti Microsoft Edge
                var downloadDirectory = @"C:\Files";
                EdgeOptions options = new EdgeOptions();

                options.AddUserProfilePreference("download.default_directory", downloadDirectory);
                options.AddArgument("--disable-notifications");
                options.AddUserProfilePreference("download.prompt_for_download", false);
                options.AddUserProfilePreference("disable-popup-blocking", "true");
                options.AddUserProfilePreference("plugins.plugins_disabled", new[] {
                      "Adobe Flash Player",
                       "Chrome PDF Viewer"
               });

                Instance = new EdgeDriver(@"C:\Drivers", options);
                Instance.Manage().Window.Maximize();

            }
        }

        public static void Close()
        {
            Instance.Close();
        }

        internal static IWebElement FindElement(By by)
        {
            throw new NotImplementedException();
        }

        internal static object Navigate()
        {
            throw new NotImplementedException();
        }
    }
}