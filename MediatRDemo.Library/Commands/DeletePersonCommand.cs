using MediatR;
using MediatRDemo.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatRDemo.Library.Commands
{
    public record DeletePersonCommand(int Id) : IRequest<List<Person>>;

    //public class DeletePersonCommand : IRequest<List<Person>>;
    //{
    //    public int Id { get; set; }
    //    public DeletePersonCommand(int id)
    //    {
    //        Id = id;
    //    }
    //}
}
