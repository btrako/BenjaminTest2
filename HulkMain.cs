using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HulkProject


{
    [TestClass]
    public class HulkMain
    {

        [TestInitialize]
        public void Init()
        {
            TestArguments parameters = new TestArguments();

            int a = int.Parse(parameters.browser);

            Driver.Initialize(a);
        }


        [TestMethod]
        public void TestMethod1()

        {
            string subject = "";
            string body = "";

            TestArguments parameters = new TestArguments();
            string URL = parameters.url;

            OpenUrl.GoTo(URL);


            string ApplicationMessage = HulkApps.Application();
            string RegistrationMessage = HulkApps.Registration();
            string LoginMessage = HulkApps.Login();
            string SearchMessage = HulkApps.SearchField();




            if (!ApplicationMessage.Contains("ERROR") && (!RegistrationMessage.Contains("ERROR") && (!LoginMessage.Contains("ERORR") && (!SearchMessage.Contains("ERROR")))))
            {
                subject = "Passed!!! " + subject;
                body = "Test je prošao" + "\n" + ApplicationMessage + RegistrationMessage + LoginMessage + SearchMessage;
            }
            else
            {
                subject = "Failed!!! " + subject;
                body = ApplicationMessage + RegistrationMessage + LoginMessage + SearchMessage;
            }

        


            Assert.IsTrue(subject.Contains("Passed"));
            Assert.IsFalse(subject.Contains("Failed"));

        }

        [TestCleanup]
        public void Cleanup()
        {
            Driver.Close();
        }
    }
}