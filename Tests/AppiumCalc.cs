//--------------------------------------------------
// <copyright file="AppiumWinAppUnitTests.cs" company="Magenic">
//  Copyright 2019 Magenic, All rights Reserved
// </copyright>
// <summary>Test class for windows application driver related functions</summary>
//--------------------------------------------------
using Magenic.Maqs.BaseAppiumTest;
using Magenic.Maqs.Utilities.Helper;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Enums;
using OpenQA.Selenium.Appium.Windows;
using System;
using PageModel;
using System.Diagnostics;
using System.Linq;

namespace AppiumUnitTests
{
    /// <summary>
    /// Windows application driver related Appium tests
    /// </summary>
    [TestClass]
    public class VisioTest : BaseAppiumTest
    {
        private AppiumDriver<IWebElement> driver;

        [TestInitialize]
        public void setup()
        {
            AppiumOptions options = new AppiumOptions();
            options.AddAdditionalCapability("platformName", "Windows");
            options.AddAdditionalCapability("platformVersion", "10");
            options.AddAdditionalCapability("app", "C:\\Program Files (x86)\\Microsoft Office\\root\\Office16\\VISIO.EXE");
            options.AddAdditionalCapability("deviceName", "WindowsPC");
            options.AddAdditionalCapability("appWorkingDir", "C:\\Program Files (x86)\\Microsoft Office\\root\\Office16");
            driver = new WindowsDriver<IWebElement>(new Uri("http://127.0.0.1:4723"), options);

        }

        [TestCleanup]
        public void tearDown()
        {
            driver.Close();
            var visioProcesses = Process.GetProcesses().
            Where(pr => pr.ProcessName.Contains("visio")); // without '.exe'

            foreach (var process in visioProcesses)
            {
                process.Kill();
            }
        }

        /// <summary>
        /// Tests the creation of the Appium Windows application driver
        /// </summary>
        [TestMethod]
        [TestCategory(TestCategories.Appium)]
        public void AppiumWinAppDriverTest()
        {
            Visio_Base_PageModel visio = new Visio_Base_PageModel(this.TestObject);
            visio.CreateNewDocument();
            visio.ClickFileTab();
        }
    }
}
