using MediatR;
using MediatRDemo.Library.Commands;
using MediatRDemo.Library.Models;
using MediatRDemo.Library.Queries;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MediatRDemo.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly IMediator mediator;

        public PersonController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        // GET: api/<PersonController>
        [HttpGet]
        public async Task<List<Person>> Get() => await mediator.Send(new GetPersonListQuery());

        // GET api/<PersonController>/5
        [HttpGet("{id}")]
        public async Task<Person> Get(int id) => await mediator.Send(new GetPersonByIdQuery(id));

        // POST api/<PersonController>
        [HttpPost]
        public async Task<Person> Post([FromBody] Person person) => await mediator.Send(new AddPersonCommand(person.FirstName, person.LastName));

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public async Task<Person> Put(int id, [FromBody] Person person) => await mediator.Send(new UpdatePersonCommand(id, person));

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public async Task<List<Person>> Delete(int id) => await mediator.Send(new DeletePersonCommand(id));
    }
}
