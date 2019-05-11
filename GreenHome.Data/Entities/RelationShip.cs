using GreenHome.Data.Interfaces;
using GreenHome.Infrastructure.SharedKernel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace GreenHome.Data.Entities
{
    [Table("RelationShip")]
    public class RelationShip : DomainEntity<int>, IDateTracking, IAccountTracking
    {
        [StringLength(10)]
        [Required]
        public string Name { get; set; }

        public int IdCreated { get; set; }
        public int IdModified { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }

        public virtual ICollection<StudentRelationShip> StudentRelationShips { set; get; }
    }
}
