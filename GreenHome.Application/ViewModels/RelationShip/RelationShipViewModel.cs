using System;
using System.Collections.Generic;

namespace GreenHome.Application.ViewModels.Relationship
{
    public class RelationshipViewModel
    {
      

        public int Id { get; set; }
        public string Name { get; set; }

        public int IdCreated { get; set; }
        public int IdModified { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }

        public  ICollection<StudentRelationshipViewModel> StudentRelationshipViewModels { set; get; }
    }
}