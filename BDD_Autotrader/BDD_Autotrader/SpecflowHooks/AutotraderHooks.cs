using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace BDD_Autotrader.SpecflowHooks
{
    [Binding]
    public class AutotraderHooks : BaseClass
    {
        [BeforeScenario]
        public void BeforeScenario()
        {
            LaunchBrowser("Chrome");
        }

        [AfterScenario]
        public void AfterScenario()
        {
            CloseBrowser();
        }
    }
}
