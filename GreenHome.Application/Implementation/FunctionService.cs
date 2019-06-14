using AutoMapper.QueryableExtensions;
using GreenHome.Application.Interfaces;
using GreenHome.Application.ViewModels.System;
using GreenHome.Data.IRepositories;
using GreenHome.Infrastructure.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenHome.Application.Implementation
{
   public   class FunctionService:IFunctionService
    {
        private IFunctionRepository _functionRepository;
      

        public FunctionService(IFunctionRepository functionRepository)
        {
            _functionRepository = functionRepository ;
           
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public Task<List<FunctionViewModel>> GetAll()
        {
            return _functionRepository.FindAll()
                .ProjectTo<FunctionViewModel>().ToListAsync();
        }

        public List<FunctionViewModel> GetAllByPermission(Guid userId)
        {
            throw new NotImplementedException();
        }
    }
}
