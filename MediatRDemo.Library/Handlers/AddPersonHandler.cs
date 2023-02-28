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
    public class AddPersonHandler : IRequestHandler<AddPersonCommand, Person>
    {
        private readonly IDataAccess dataAccess;

        public AddPersonHandler(IDataAccess dataAccess)
        {
            this.dataAccess = dataAccess;
        }
        public Task<Person> Handle(AddPersonCommand request, CancellationToken cancellationToken)
            => Task.FromResult(dataAccess.AddPerson(request.firstName, request.lastName));
    }
}
