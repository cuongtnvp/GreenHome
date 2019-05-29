using GreenHome.Data.Entities;
using GreenHome.Data.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GreenHome.Data.EF.Repositories
{
    public class RelationshipRepository : EFRepository<Relationship, int>, IRelationshipRepository
    {
        AppDbContext _context;
        public RelationshipRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public List<Relationship> GetByName(string name)
        {
            return _context.Relationships.Where(x => x.Name == name).ToList();
        }
    }
}
