using MediatR;
using MovieManagementLibrary.Models;
using MovieManagementLibrary.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieManagementLibrary.Handlers
{
    public class GetMovieByIdHandler : IRequestHandler<GetMovieByIdQuery, MovieModel>
    {
        private readonly IMediator _mediator;

        public GetMovieByIdHandler(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<MovieModel> Handle(GetMovieByIdQuery request, CancellationToken cancellationToken)
        {
            var movies = await _mediator.Send(new GetMovieListQuery());
            var movie = movies.FirstOrDefault(x => x.Id == request.id);
            return movie;
        }
    }
}
