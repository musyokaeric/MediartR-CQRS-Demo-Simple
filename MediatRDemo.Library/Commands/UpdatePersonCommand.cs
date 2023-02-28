using MediatR;
using MediatRDemo.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatRDemo.Library.Commands
{
    //public record UpdatePersonCommand(Person person) : IRequest<Person>;
    public class UpdatePersonCommand : IRequest<Person>
    {
        public int Id { get; set; }
        public Person Person { get; set; }

        public UpdatePersonCommand(int id, Person person)
        {
            Id = id;
            Person = person;
        }
    }
}
