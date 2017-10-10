﻿using System;
using NLog;
using OpenQA.Selenium;

namespace CreatingReports.Pages
{
    internal class SearchPage : BaseApplicationPage
    {
        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

        public SearchPage(IWebDriver driver) : base(driver)
        {
        }

        internal bool Contains(Item itemToCheckFor)
        {
            Reporter.LogPassingTestStepToBugLogger($"Validate that item=>{itemToCheckFor} exists.");

            switch (itemToCheckFor)
            {
                case Item.Blouse:
                    var isBlouseDisplayed = Driver.FindElement(By.XPath("//*[@title='Blouse']")).Displayed;
                    Logger.Trace("Element found by XPath=>*[@title=\'Blouse\'] isDisplayed=>" + isBlouseDisplayed);
                    return isBlouseDisplayed;
                default:
                    throw new ArgumentOutOfRangeException("No such item exists in this collection");
            }
        }
    }
}