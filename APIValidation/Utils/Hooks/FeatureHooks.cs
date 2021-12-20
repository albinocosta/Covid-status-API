using System;
using System.Linq;
using APIValidation.Apis;
using TechTalk.SpecFlow;

namespace APIValidation.Utils.Hooks
{
    [Binding]
    internal static class FeatureHooks
    {
        [BeforeFeature()]
        [Obsolete]
        internal static void BeforeHooks()
        {
            if (FeatureContext.Current.FeatureInfo.Tags.Contains("Api"))
            {
                BaseApiTests.SetBaseUri();
            }
        }
    }
}
