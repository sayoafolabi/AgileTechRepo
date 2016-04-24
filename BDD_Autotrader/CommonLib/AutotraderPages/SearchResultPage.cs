using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDD_Autotrader.AutotraderPages
{
    public class SearchResultPage : BaseClass
    {
        private IList<IWebElement> searchResult;


        public void ThenIAmOnSearchResultPage()
        {
            searchResult = GetElementsByClassName("search-result__title");
            Assert.True(searchResult.Count > 0, "Search result list not displayed");
        }

        public void ThenTheCarSearchedForIsDisplayedOnSearchResultPage(string carMake)
        {
            searchResult = GetElementsByClassName("gui-test-search-result-link");
            
            foreach(var search in searchResult)
            {
                var searchText = search.Text.ToLower();

                Assert.True(searchText.Contains(carMake.ToLower()), String.Format("The car text that was wrong is {0}", searchText));
            }
        }
    }
}
