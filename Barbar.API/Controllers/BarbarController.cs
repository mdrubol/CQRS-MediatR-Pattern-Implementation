using Barbar.Application.Commands;
using Barbar.Application.Queries;
using Barbar.Application.Responses;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Barbar.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BarbarController : ControllerBase
    {
        private readonly IMediator _mediator;
        public BarbarController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<List<Barbar.Core.Entities.Barbar>> Get()
        {
            return await _mediator.Send(new GetAllBarbarQuery());
        }
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<BarbarResponse>> CreateBarbar([FromBody] CreateBarbarCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }
    }
}
