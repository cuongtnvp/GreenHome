using AutoMapper;
using GreenHome.Application.ViewModels.Relationship;
using GreenHome.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GreenHome.Application.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<RelationshipViewModel, Relationship>().
                ConstructUsing(c=>new Relationship(c.Name,c.IdCreated,c.IdModified,c.DateCreated,c.DateModified));
        }
    }
}
