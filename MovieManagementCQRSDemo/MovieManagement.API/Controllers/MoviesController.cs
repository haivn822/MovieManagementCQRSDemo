using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieManagementLibrary.Commands;
using MovieManagementLibrary.Models;
using MovieManagementLibrary.Queries;

namespace MovieManagement.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public MoviesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        //GET: api/<MovieController>
        [HttpGet]
        public async Task<List<MovieModel>> Get()
        {
            return await _mediator.Send(new GetMovieListQuery());
        }


        [HttpGet("{id}")]
        public async Task<MovieModel> Get(int id)
        {
            return await _mediator.Send(new GetMovieByIdQuery(id));
        }

        [HttpPost]
        public async Task<MovieModel> Post(MovieModel movie)
        {
            return await _mediator.Send(new AddMovieCommand(movie));
        }

    }
}
