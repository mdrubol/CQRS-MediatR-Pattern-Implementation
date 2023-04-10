using AutoMapper;
using Barbar.Application.Commands;
using Barbar.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barbar.Application.Mapper
{
    public class BarbarMappingProfile : Profile
    {
        public BarbarMappingProfile()
        {
            CreateMap<Barbar.Core.Entities.Barbar, BarbarResponse>().ReverseMap();
            CreateMap<Barbar.Core.Entities.Barbar, CreateBarbarCommand>().ReverseMap();
        }
    }
}
