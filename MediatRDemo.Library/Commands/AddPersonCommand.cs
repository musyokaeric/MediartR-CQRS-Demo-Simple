using MediatR;
using MediatRDemo.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatRDemo.Library.Commands
{
    public record AddPersonCommand(string firstName, string lastName) : IRequest<Person>;

    //public class AddPersonCommand : IRequest<Person>
    //{
    //    public string FirstName { get; set; }
    //    public string LastName { get; set; }

    //    public AddPersonCommand(string firstName, string lastName)
    //    {
    //        FirstName = firstName;
    //        LastName = lastName;
    //    }
    //}
}
