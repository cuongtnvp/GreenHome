using GreenHome.Application.ViewModels.Relationship;
using System.Collections.Generic;

namespace GreenHome.Application.Interfaces
{
    public interface IRelationshipService
    {
        RelationshipViewModel Add(RelationshipViewModel RelationshipVm);

        void Update(RelationshipViewModel RelationshipVm);

        void Delete(int id);

        List<RelationshipViewModel> GetAll();

        List<RelationshipViewModel> GetAll(string keyword);

        List<RelationshipViewModel> GetAllByParentId(int parentId);

        RelationshipViewModel GetById(int id);

        void UpdateParentId(int sourceId, int targetId, Dictionary<int, int> items);
        void ReOrder(int sourceId, int targetId);

        List<RelationshipViewModel> GetHomeCategories(int top);




        void Save();
    }
}