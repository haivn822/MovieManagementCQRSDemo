using MediatR;
using MovieManagementLibrary.Data;
using MovieManagementLibrary.Models;
using MovieManagementLibrary.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieManagementLibrary.Handlers
{
    public class GetMovieListHandler : IRequestHandler<GetMovieListQuery, List<MovieModel>>
    {
        private readonly IDataRepository _dataRepository;

        public GetMovieListHandler(IDataRepository dataRepository)
        {
            _dataRepository = dataRepository;
        }

        public Task<List<MovieModel>> Handle(GetMovieListQuery request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_dataRepository.GetMovies());
        }
    }
}
