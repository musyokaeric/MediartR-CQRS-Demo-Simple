using MediatR;
using MediatRDemo.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatRDemo.Library.Queries
{
    public record GetPersonByIdQuery(int Id) : IRequest<Person>;
    //public class GetPersonByIdQuery : IRequest<Person>
    //{
    //    public int Id { get; set; }

    //    public GetPersonByIdQuery(int id)
    //    {
    //        Id = id;
    //    }
    //}
}
