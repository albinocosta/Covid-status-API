using System;
using System.Linq;
using APIValidation.Apis;
using TechTalk.SpecFlow;

namespace APIValidation.Utils.Hooks
{
    [Binding]
    internal static class ScenarioHooks
    {
        [BeforeScenario()]
        [Obsolete]
        internal static void BeforeHooks()
        {
            if (ScenarioContext.Current.ScenarioInfo.Tags.Contains("Api"))
            {
                BaseApiTests.SetBaseUri();
            }
        }
    }
}
