using Application.Features.Models.Dtos;
using AutoMapper;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Models.Profiles
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Model, ModelListDto>()
                .ForMember(c=>c.BrandName, opt=> opt.MapFrom(c=>c.Brand.Name))
                .ReverseMap();
        }
    }
}
