using AutoFixture;
using System;
using TechTalk.SpecFlow;

namespace SpecflowBasics.StepDefinitions
{
    [Binding]
    public class UserStepDefinitions
    {
        [Given(@"I Enter Random User Data")]
        public void GivenIEnterRandomUserData()
        {
            var person = new Fixture()
                .Build<User>()
                .With(x => x.Email, "eozbey@gmail")
                .Create();
            Console.WriteLine($"The User {person.Name} has email {person.Email} has Adress {person.Adress}");
        }

        public record User
        {
            public string Name { get; set; }
            public string Email { get; set; }

            public string Adress { get; set; }

            public int Phone { get; set; }
        }
    }
}
