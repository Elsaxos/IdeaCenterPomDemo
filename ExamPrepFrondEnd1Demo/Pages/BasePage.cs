﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace IdeaCenterPOM.Pages
{
    public class BasePage
    {
        protected IWebDriver driver;
        protected WebDriverWait wait;
        protected static readonly string BaseUrl =
            "http://softuni-qa-loadbalancer-2137572849.eu-north-1.elb.amazonaws.com:83";

        public BasePage(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }

        public IWebElement HomeLink => driver.FindElement(By.XPath("//img[@class='rounded-circle']"));
        public IWebElement MyProfileLink => driver.FindElement(By.XPath
            ("//a[@class='nav-link'][contains(.,'My Profile')]"));
        public IWebElement MyIdeasLink => driver.FindElement(By.XPath
            ("//a[@class='nav-link'][contains(.,'My Ideas')]"));
        public IWebElement CreateIdeaLink => driver.FindElement(By.XPath
            ("//a[@class='nav-link'][contains(.,'Create Idea')]"));
        public IWebElement LogoutButton => driver.FindElement(By.XPath
            ("//a[@class='btn btn-primary me-3']"));
        public IWebElement LoginButton => driver.FindElement(By.XPath
    ("//a[@class='btn btn-outline-info px-3 me-2']"));
    }
}
