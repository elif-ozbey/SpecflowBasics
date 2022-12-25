using System.Security.Cryptography.X509Certificates;
using TechTalk.SpecFlow;

namespace SpecflowBasics.Hooks
{
    [Binding]
    public sealed class TestInitialize
    {
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks
        [BeforeTestRun]
        public static void BeforeTest()
        {
            Console.WriteLine("This line executed before testrun");
        }
        [BeforeFeature]
        public static void BeforeFeatureTest() => Console.WriteLine("This line executed before feature");

        [BeforeScenario("mytag")]
        public void BeforeScenarioWithTag()
        {
            Console.WriteLine("Before senerio execute this with tag");
        }


        [AfterScenario]
        public void AfterScenario() => Console.WriteLine("This line executed after scenario");
            
    }
}