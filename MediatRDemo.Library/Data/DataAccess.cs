using MediatRDemo.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatRDemo.Library.Data
{
    public class DataAccess : IDataAccess
    {
        private List<Person> people = new();

        public DataAccess()
        {
            people.Add(new Person { Id = 1, FirstName = "John", LastName = "Doe" });
            people.Add(new Person { Id = 2, FirstName = "Eric", LastName = "Musyoka" });
        }

        public List<Person> GetPeople() => people;
        public Person AddPerson(string firstname, string lastname)
        {
            Person person = new Person { FirstName = firstname, LastName = lastname };
            person.Id = people.Max(p => p.Id) + 1;
            people.Add(person);
            return person;
        }

        public Person UpdatePerson(int id, Person entity)
        {
            var person = people.FirstOrDefault(p => p.Id == id);
            person.FirstName = entity.FirstName;
            person.LastName = entity.LastName;
            return person;
        }

        public List<Person> DeletePerson(int id)
        {
            var p = people.FirstOrDefault(p => p.Id == id);
            people.Remove(p);
            return people;
        }
    }
}
