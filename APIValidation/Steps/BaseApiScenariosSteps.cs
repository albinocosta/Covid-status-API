using APIValidation.Apis;
using System;
using TechTalk.SpecFlow;

namespace APIValidation.Steps
{
    [Binding]
    public sealed class BaseApiScenariosSteps
    {
        [Given(@"I want to check critical cases in Lisboa last day")]
        [Obsolete]
        public void GivenIWantToCheckCriticalCasesInLisboaLastDay()
        {
            BaseApiTests.WantToCheck();
        }

        [When(@"I send a resquest to API")]
        [Obsolete]
        public void WhenISendAResquestToAPI()
        {
            BaseApiTests.GetCriticalCases();
        }

        [Then(@"I receive (.*) OK status code")]
        [Obsolete]
        public void VerifyStatusCode(int statuscode)
        {
            BaseApiTests.AssertStatusCode(statuscode);
        }

        [Then(@"critical cases is less than (.*)")]
        [Obsolete]
        public void ThenCriticalCasesIsLessThan(int criticalcases)
        {
            BaseApiTests.AssertCriticalLess100(criticalcases);
        }


    }
}
