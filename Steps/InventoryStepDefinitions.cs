using OpenQA.Selenium;
using Selenium_BDD_Automation_Framework.Pages;
using TechTalk.SpecFlow;

namespace Selenium_BDD_Automation_Framework.Steps
{

    [Binding]
    public class InventoryStepDefinitions
    {
        private readonly IWebDriver driver;
        private readonly InventoryPage inventory;

        public InventoryStepDefinitions(IWebDriver d)
        {
            this.driver = d;
            inventory = new InventoryPage(d);

        }

        [Given(@"I am on saucedemo website")]
        public void WhenIEnterPropelFinanceWebsiteUrl()
        {
            inventory.SauceDemoUrl();
        }

        [When(@"I login with valid username and password")]
        public void GivenILoginWithValidUsernameAndPassword()
        {
            inventory.Login();
        }

        [Then(@"I pick the highest price item and add it to the basket")]
        public void ThenIPickTheHighestPriceItemAndAddItToTheBasket()
        {
            inventory.PickHighestPriceItemAndAddToCart();
        }

    }
}
