using AutoMapper;
using GreenHome.Application.ViewModels.Relationship;
using GreenHome.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GreenHome.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<Relationship, RelationshipViewModel>();
        }
    }
}
