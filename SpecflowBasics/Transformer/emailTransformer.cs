using AutoFixture;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace SpecflowBasics.Transformer
{
    [Binding]
    public class emailTransformer
    {
        [StepArgumentTransformation(@"(.*) email")]
        public string GenerateDynamicEmailAdress(string emailAdress)
        {
            return emailAdress.Split("@")[0]+GetRandomDomain();
        }

        private string GetRandomDomain() => new Fixture().Create<MailAddress>().Host;
    }
}
