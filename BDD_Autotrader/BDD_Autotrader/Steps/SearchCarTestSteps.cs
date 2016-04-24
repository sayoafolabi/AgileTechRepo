using BDD_Autotrader.AutotraderPages;
using System;
using TechTalk.SpecFlow;

namespace BDD_Autotrader.Steps
{
    [Binding]
    public class SearchCarTestSteps : BaseClass
    {

        private HomePage homepage;
        private SearchResultPage searchResultPage;

        [Given(@"I navigate to Autotrader website")]
        public void GivenINavigateToAutotraderWebsite()
        {
            homepage = GivenINavigateAutotraderHomepage();
            homepage.AndIAmOnAutotraderHomepage();
        }
        
        [When(@"search for a car type")]
        public void WhenSearchForACarType()
        {
            homepage.WhenIEnterValidPostcode();
            homepage.AndISelectDistanceToPostcode();
            homepage.AndISelectACarMake();
            searchResultPage = homepage.AndIClickOnSearchCarButton();
        }
        
        [Then(@"the result is displayed")]
        public void ThenTheResultIsDisplayed()
        {
            searchResultPage.ThenIAmOnSearchResultPage();
        }

        [When(@"I search for a car ""(.*)"" from a ""(.*)"" of range ""(.*)""")]
        public void WhenISearchForACarFromAOfRange(string make, string postcode, string distance)
        {
            homepage.WhenIEnterValidPostcode(postcode);
            homepage.AndISelectDistanceToPostcode(distance);
            homepage.AndISelectACarMake(make);
            searchResultPage = homepage.AndIClickOnSearchCarButton();
        }

        [Then(@"the result displayed contains ""(.*)""")]
        public void ThenTheResultDisplayedContains(string make)
        {
            searchResultPage.ThenTheCarSearchedForIsDisplayedOnSearchResultPage(make);
        }

    }
}
