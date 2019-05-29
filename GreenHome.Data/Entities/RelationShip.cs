using GreenHome.Data.Interfaces;
using GreenHome.Infrastructure.SharedKernel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace GreenHome.Data.Entities
{
    [Table("Relationship")]
    public class Relationship : DomainEntity<int>, IDateTracking, IAccountTracking
    {
        public Relationship()
        {
            StudentRelationships = new List<StudentRelationship>();
        }

        public Relationship(string name, int idCreated, int idModified, DateTime dateCreated, DateTime dateModified)
        {
            Name = name ;
            IdCreated = idCreated;
            IdModified = idModified;
            DateCreated = dateCreated;
            DateModified = dateModified;
         
        }

        [StringLength(10)]
        [Required]
        public string Name { get; set; }

        public int IdCreated { get; set; }
        public int IdModified { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }

        public virtual ICollection<StudentRelationship> StudentRelationships { set; get; }
    }
}
