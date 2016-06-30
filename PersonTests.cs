using Xunit;
using System.Collections.Generic;

namespace myapp.Tests
{
    public class PersonTests
    {
        [Fact]
        public void CreatesNewPerson()
        {
            Person person = new Person
            {
                Age = 22,
                Name = "Joshua"
            };
            Assert.Equal("Joshua", person.Name);
        }

        [Fact]
        public void ReturnsListOfAges()
        {
            List<Person> people = new List<Person>
            {
                new Person { Age = 22, Name = "Joshua" },
                new Person { Age = 34, Name = "Doug" }
            };
            var thing = new ThingThatDoesStuff(people);
            var ages = thing.GetPeopleAges();
            Assert.Equal(2, ages.Count);
            Assert.Equal(22, ages[0]);
            Assert.Equal(34, ages[1]);
        }
    }
}