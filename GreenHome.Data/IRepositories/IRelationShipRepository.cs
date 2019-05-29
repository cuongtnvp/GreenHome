using GreenHome.Data.Entities;
using GreenHome.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace GreenHome.Data.IRepositories
{
    public interface IRelationshipRepository: IRepository<Relationship,int>
    {
        List<Relationship> GetByName(string name);
    }
}
