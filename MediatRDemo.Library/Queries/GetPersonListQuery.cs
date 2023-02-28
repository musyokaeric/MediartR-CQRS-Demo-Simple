using MediatR;
using MediatRDemo.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatRDemo.Library.Queries
{
    //public class GetPersonListQuery : IRequest<List<Person>>
    //{
    //}

    public record GetPersonListQuery() : IRequest<List<Person>>;
}
