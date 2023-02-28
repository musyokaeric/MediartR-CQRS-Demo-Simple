using MediatRDemo.Library.Models;

namespace MediatRDemo.Library.Data
{
    public interface IDataAccess
    {
        Person AddPerson(string firstname, string lastname);
        List<Person> DeletePerson(int id);
        List<Person> GetPeople();
        Person UpdatePerson(int id, Person entity);
    }
}