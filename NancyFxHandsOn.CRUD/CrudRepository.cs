using System.Collections.Generic;
using System.Linq;

namespace NancyFxHandsOn.CRUD
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    public interface ICrudRepository
    {
        IEnumerable<Person> GetAll();
        Person Get(int id);
        Person Create(string firstName, string lastName);
        void Update(Person person);
        void Delete(Person person);
    }

    public class CrudRepository : ICrudRepository
    {
        private static readonly List<Person> FakeRepository = new List<Person>
        {
            new Person {Id = 0, FirstName = "Peter", LastName = "Griffin"},
            new Person {Id = 1, FirstName = "Lois", LastName = "Griffin"},
            new Person {Id = 2, FirstName = "Brian", LastName = "Griffin"},
            new Person {Id = 3, FirstName = "Stewie", LastName = "Griffin"},
            new Person {Id = 4, FirstName = "Meg", LastName = "Griffin"},
            new Person {Id = 5, FirstName = "Chris", LastName = "Griffin"},
            new Person {Id = 6, FirstName = "Brian", LastName = "Griffin"},
            new Person {Id = 7, FirstName = "Glenn", LastName = "Quagmire"},
            new Person {Id = 8, FirstName = "Joe", LastName = "Swanson"},
            new Person {Id = 9, FirstName = "Clevebrown", LastName = "Brown"},
        };

        public IEnumerable<Person> GetAll()
        {
            return FakeRepository;
        }

        public Person Get(int id)
        {
            return FakeRepository.Single(p => p.Id == id);
        }

        public Person Create(string firstName, string lastName)
        {
            var id = FakeRepository.Max(p => p.Id);
            id++;
            var person = new Person
            {
                Id = id,
                FirstName = firstName,
                LastName = lastName
            };
            FakeRepository.Add(person);
            return person;
        }

        public void Update(Person person)
        {
            var repoPerson = FakeRepository.Single(p => p.Id == person.Id);
            repoPerson.FirstName = person.FirstName;
            repoPerson.LastName = person.LastName;
        }

        public void Delete(Person person)
        {
            var repoPerson = FakeRepository.Single(p => p.Id == person.Id);
            FakeRepository.Remove(repoPerson);
        }
    }
}