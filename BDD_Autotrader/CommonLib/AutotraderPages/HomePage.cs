using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDD_Autotrader.AutotraderPages
{
    public class HomePage : BaseClass
    {
        private IWebElement autoTraderLogo;
        private IWebElement postcode;
        private IWebElement distance;
        private IWebElement make;
        private IWebElement submitButton;


        public void AndIAmOnAutotraderHomepage()
        {
            autoTraderLogo = GetElementByClassName("site-header__logo");
            Assert.True(autoTraderLogo.Displayed, "Autotrader homepage is not displayed");
        }

        public void WhenIEnterValidPostcode()
        {
            postcode = GetElementById("postcode");
            postcode.Clear();
            postcode.SendKeys("OL9 8LE");
        }

        public void WhenIEnterValidPostcode(string postalCode)
        {
            postcode = GetElementById("postcode");
            postcode.Clear();
            postcode.SendKeys(postalCode);
        }

        public void AndISelectDistanceToPostcode()
        {
            distance = GetElementById("radius");
            SelectByValue(distance, "50");

        }

        public void AndISelectDistanceToPostcode(string distanceTo)
        {
            distance = GetElementById("radius");
            SelectByText(distance, distanceTo);

        }

        public void AndISelectACarMake()
        {
            make = GetElementById("searchVehiclesMake");
            SelectByValue(make, "audi");
        }

        public void AndISelectACarMake(string carMake)
        {
            make = GetElementById("searchVehiclesMake");
            SelectByValue(make, carMake.ToLower());
        }

        public SearchResultPage AndIClickOnSearchCarButton()
        {
            submitButton = GetElementById("search");
            submitButton.Click();

            return new SearchResultPage();
        }

    }
}
