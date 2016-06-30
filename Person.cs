using System.Collections.Generic;
using System.Linq;

namespace myapp {
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    public class ThingThatDoesStuff
    {
        private List<Person> _people;

        public ThingThatDoesStuff(List<Person> people) {
            _people = people;
        }

        public List<int> GetPeopleAges()
        {
            return _people.Select(p => p.Age).ToList();
        }
    }
}