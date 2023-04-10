using Barbar.Application.Queries;
using Barbar.Core.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Barbar.Application.Handlers.QueryHandlers
{
    public class GetAllBarbarHandler : IRequestHandler<GetAllBarbarQuery, List<Barbar.Core.Entities.Barbar>>
    {
        private readonly IBarbarRepository _BarbarRepo;

        public GetAllBarbarHandler(IBarbarRepository BarbarRepository)
        {
            _BarbarRepo = BarbarRepository;
        }
        public async Task<List<Core.Entities.Barbar>> Handle(GetAllBarbarQuery request, CancellationToken cancellationToken)
        {
            return (List<Core.Entities.Barbar>)await _BarbarRepo.GetAllAsync();
        }
    }
}
