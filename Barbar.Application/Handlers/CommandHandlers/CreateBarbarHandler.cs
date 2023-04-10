using Barbar.Application.Commands;
using Barbar.Application.Mapper;
using Barbar.Application.Responses;
using Barbar.Core.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Barbar.Application.Handlers.CommandHandlers
{

    public class CreateBarbarHandler : IRequestHandler<CreateBarbarCommand, BarbarResponse>
    {
        private readonly IBarbarRepository _BarbarRepo;

        public CreateBarbarHandler(IBarbarRepository BarbarRepository)
        {
            _BarbarRepo = BarbarRepository;
        }
        public async Task<BarbarResponse> Handle(CreateBarbarCommand request, CancellationToken cancellationToken)
        {
            var BarbarEntitiy = BarbarMapper.Mapper.Map<Barbar.Core.Entities.Barbar>(request);
            if(BarbarEntitiy is null)
            {
                throw new ApplicationException("Issue with mapper");
            }
            var newBarbar = await _BarbarRepo.AddAsync(BarbarEntitiy);
            var BarbarResponse = BarbarMapper.Mapper.Map<BarbarResponse>(newBarbar);
            return BarbarResponse;
        }
    }
}
