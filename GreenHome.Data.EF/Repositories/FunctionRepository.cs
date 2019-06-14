using GreenHome.Data.Entities;
using GreenHome.Data.IRepositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace GreenHome.Data.EF.Repositories
{
    public class FunctionRepository : EFRepository<Function, string>, IFunctionRepository
    {
        public FunctionRepository(AppDbContext context) : base(context)
        {
        }
    }
}
