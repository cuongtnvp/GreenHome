using GreenHome.Data.Interfaces;
using GreenHome.Infrastructure.SharedKernel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace GreenHome.Data.Entities
{
    [Table("StudentRelationShips")]
    public class StudentRelationShip : DomainEntity<int>, IDateTracking, IAccountTracking
    {
        [StringLength(20)]
        [Required]
        public string FullName { get; set; }
        [StringLength(10)]
     
        public string Phone { get; set; }
        [StringLength(50)]
     
        public string Address { get; set; }
        public int RelationShipId { get; set; }

        [ForeignKey("RelationShipId")]
        public virtual RelationShip RelationShip { set; get; }

        public int StudentId { get; set; }
        [ForeignKey("StudentId")]
        public virtual Student Student { get; set; }

        public DateTime? BirthDay { get; set; }
        [StringLength(50)]
        public string Job { get; set; }
        [StringLength(50)]
        public string Company { get; set; }
     
        public int? Income { get; set; }
        [StringLength(100)]
        public string Avatar { get; set; }
        public int IdCreated { get; set; }
        public int IdModified { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }



    }
}
