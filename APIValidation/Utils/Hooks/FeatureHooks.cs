using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
