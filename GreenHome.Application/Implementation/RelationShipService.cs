using AutoMapper;
using AutoMapper.QueryableExtensions;
using GreenHome.Application.Interfaces;
using GreenHome.Application.ViewModels.Relationship;
using GreenHome.Data.Entities;
using GreenHome.Data.IRepositories;
using GreenHome.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GreenHome.Application.Implementation
{
    public class RelationshipService : IRelationshipService
    {
        private IRelationshipRepository _relationshipRepositoryRepository;
        private IUnitOfWork _unitOfWork;

        public RelationshipService(IRelationshipRepository RelationshipRepository, IUnitOfWork unitOfWork)
        {
            _relationshipRepositoryRepository = RelationshipRepository;
            _unitOfWork = unitOfWork;
        }

        public RelationshipViewModel Add(RelationshipViewModel relationshipVm)
        {
            var relationship = Mapper.Map<RelationshipViewModel, Relationship>(relationshipVm);
            _relationshipRepositoryRepository.Add(relationship);
            return relationshipVm;
        }

        public void Delete(int id)
        {
            _relationshipRepositoryRepository.Remove(id);
        }

        public List<RelationshipViewModel> GetAll()
        {
            return _relationshipRepositoryRepository.FindAll().OrderBy(x => x.Id)
                .ProjectTo<RelationshipViewModel>().ToList();
        }

        public List<RelationshipViewModel> GetAll(string keyword)
        {
            if (!string.IsNullOrEmpty(keyword))
                return _relationshipRepositoryRepository.FindAll(x => x.Name.Contains(keyword))
                    .OrderBy(x => x.Id).ProjectTo<RelationshipViewModel>().ToList();
            else
                return _relationshipRepositoryRepository.FindAll().OrderBy(x => x.Id)
            .ProjectTo<RelationshipViewModel>().ToList();
        }

        public List<RelationshipViewModel> GetAllByParentId(int parentId)
        {
            throw new NotImplementedException();
        }

        public RelationshipViewModel GetById(int id)
        {
            return Mapper.Map<Relationship, RelationshipViewModel>(_relationshipRepositoryRepository.FindById(id));
        }

        public List<RelationshipViewModel> GetHomeCategories(int top)
        {
            throw new NotImplementedException();
        }

        public void ReOrder(int sourceId, int targetId)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            _unitOfWork.Commit();
        }

        public void Update(RelationshipViewModel RelationshipVm)
        {
            throw new NotImplementedException();
        }

        public void UpdateParentId(int sourceId, int targetId, Dictionary<int, int> items)
        {
            throw new NotImplementedException();
        }
    }
}
