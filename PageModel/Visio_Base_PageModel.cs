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
using OpenQA.Selenium.Interactions;
using System;
using System.Threading;

namespace PageModel
{

    public class Visio_Base_PageModel
    {

        /// <summary>
        /// Appium test object
        /// </summary>
        protected AppiumTestObject TestObject;

        protected LazyMobileElement FileTab
        {
            get { return new LazyMobileElement(this.TestObject, By.Name("File Tab"), "File Tab Menu Item"); }
        }

        protected LazyMobileElement NewDocumentItem
        {
            get { return new LazyMobileElement(this.TestObject, By.Name("File Tab"), "File Tab Menu Item"); }
        }
        protected LazyMobileElement VisioStandardItem
        {
            get { return new LazyMobileElement(this.TestObject, By.Name("Visio Standard"), "File Tab Menu Item"); }
        }

        protected LazyMobileElement Create
        {
            get { return new LazyMobileElement(this.TestObject, By.Name("Create"), "File Tab Menu Item"); }
        }



        public Visio_Base_PageModel(AppiumTestObject testObject)
        {
            this.TestObject = testObject;
        }

        public void CreateNewDocument(){
            NewDocumentItem.Click();
            VisioStandardItem.Click();
            Create.Click();
            Create.Click();
        }
        public void ClickFileTab(){
            FileTab.Click();
        }
    }
}