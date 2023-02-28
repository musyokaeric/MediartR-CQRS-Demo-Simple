using MediatR;
using MediatRDemo.Library.Commands;
using MediatRDemo.Library.Data;
using MediatRDemo.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatRDemo.Library.Handlers
{
    public class DeletePersonHandler : IRequestHandler<DeletePersonCommand, List<Person>>
    {
        private readonly IDataAccess data;

        public DeletePersonHandler(IDataAccess data)
        {
            this.data = data;
        }
        public Task<List<Person>> Handle(DeletePersonCommand request, CancellationToken cancellationToken) => Task.FromResult(data.DeletePerson(request.Id));
    }
}
