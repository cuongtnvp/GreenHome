using GreenHome.Data.Interfaces;
using GreenHome.Infrastructure.SharedKernel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace GreenHome.Data.Entities
{
    [Table("Students")]
    public class Student:DomainEntity<int>,IDateTracking,IAccountTracking
    {
        [StringLength(20)]
        [Required]
        public string FullName { get; set; }
        [StringLength(10)]       
        public string NickName { get; set; }
        public DateTime? BirthDay { get; set; }
        [StringLength(50)]
        public string Address { get; set; }
        [StringLength(100)]
        public string Avatar { get; set; }
        public DateTime? DateStart { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public int IdCreated { get; set; }
        public int IdModified { get; set; }

       public virtual ICollection<StudentRelationShip> StudentRelationShips { set; get; }
    }
}
