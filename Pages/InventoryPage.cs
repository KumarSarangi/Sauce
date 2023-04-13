using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;

namespace Selenium_BDD_Automation_Framework.Pages
{

    class InventoryPage
    {
        private readonly IWebDriver driver;

        public InventoryPage(IWebDriver d)
        {
            this.driver = d;
        }

        private readonly By username = By.Id("user-name");

        private readonly By password = By.Id("password");

        private readonly By login = By.Id("login-button");

        private readonly By price = By.ClassName("inventory_item_price");


        public void SauceDemoUrl()
        {
            driver.Url = "https://www.saucedemo.com/";
            Assert.AreEqual("https://www.saucedemo.com/", driver.Url);
        }


        public void Login()
        {
            driver.FindElement(username).SendKeys("standard_user");
            driver.FindElement(password).SendKeys("secret_sauce");
            driver.FindElement(login).Click();


        }

        public void PickHighestPriceItemAndAddToCart()
        {

            IList<IWebElement> pricelist = driver.FindElements(By.ClassName("inventory_item_price"));
            double maxPrice = 0;

            foreach (var items in pricelist)
            {
                double price = Double.Parse(items.Text.Replace("$", ""));
                if (maxPrice < price)
                {
                    maxPrice = price;
                }

            }

            string highestprice = "//div[normalize-space()='$" + maxPrice + "']/following-sibling::button[text()='Add to cart']";
            driver.FindElement(By.XPath(highestprice)).Click();


        }

    }

}



