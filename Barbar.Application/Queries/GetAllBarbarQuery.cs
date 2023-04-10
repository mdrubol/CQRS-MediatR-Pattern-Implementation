using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barbar.Application.Queries
{
    public class GetAllBarbarQuery : IRequest<List<Barbar.Core.Entities.Barbar>>
    {

    }
}
