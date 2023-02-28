using MediatR;
using MediatRDemo.Library.Data;
using MediatRDemo.Library.Models;
using MediatRDemo.Library.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatRDemo.Library.Handlers
{
    public class GetPersonListHandler : IRequestHandler<GetPersonListQuery, List<Person>>
    {
        private readonly IDataAccess data;

        public GetPersonListHandler(IDataAccess data) 
        {
            this.data = data;
        }
        public Task<List<Person>> Handle(GetPersonListQuery request, CancellationToken cancellationToken)
            => Task.FromResult(data.GetPeople());
    }
}
