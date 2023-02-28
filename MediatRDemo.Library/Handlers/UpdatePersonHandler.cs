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
    public class UpdatePersonHandler : IRequestHandler<UpdatePersonCommand, Person>
    {
        private readonly IDataAccess data;

        public UpdatePersonHandler(IDataAccess data)
        {
            this.data = data;
        }
        public Task<Person> Handle(UpdatePersonCommand request, CancellationToken cancellationToken)
            => Task.FromResult(data.UpdatePerson(request.Id, request.Person));
    }
}
