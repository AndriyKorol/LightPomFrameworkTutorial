﻿using System.Threading;
using NUnit.Framework;

namespace SauceLabs
{

    [Category("DataDrivenParallelTests")]
    [Parallelizable]
    [TestFixture("chrome", "45", "Windows 7", "", "")]
    [TestFixture("chrome", "50", "Windows 7", "", "")]
    [TestFixture("MicrosoftEdge", "14.14393", "Windows 10", "", "")]
    [TestFixture("chrome", "6.0", "Android", "Android Emulator", "portrait")]
    [TestFixture("Safari", "11.2", "iOS", "iPhone X Simulator", "portrait")]
    public class AdvancedSauceTests : BaseTest
    {
        public AdvancedSauceTests(string browser, string version, string os, string deviceName, string deviceOrientation) : 
            base(browser, version, os, deviceName, deviceOrientation)
        {
        }

        [Test]
        public void TestMethodInClass1()
        {
            Driver.Navigate().GoToUrl("https://www.google.com");
            Assert.Pass("passed the test");
        }

    }
    [TestFixture]
    [Category("DataDrivenParallelTests")]
    [Parallelizable]
    [TestFixture("chrome", "45", "macOS 10.13", "", "")]
    [TestFixture("chrome", "50", "macOS 10.13", "", "")]
    public class AdvancedSauceTests2 : BaseTest
    {
        public AdvancedSauceTests2(string browser, string version, string os, string deviceName, string deviceOrientation) : 
            base(browser, version, os, deviceName, deviceOrientation)
        {
        }
        [Test]
        public void TestMethodInClass2()
        {
            SetGenderTypes(Gender.Female, Gender.Female);

            SampleAppPage.GoTo();
            Thread.Sleep(20000);
            SampleAppPage.FillOutEmergencyContactForm(EmergencyContactUser);
            var ultimateQAHomePage = SampleAppPage.FillOutPrimaryContactFormAndSubmit(TheTestUser);
            AssertPageVisible(ultimateQAHomePage);
        }

    }
}
