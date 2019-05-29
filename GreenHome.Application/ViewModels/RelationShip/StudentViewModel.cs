using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GreenHome.Application.ViewModels.Relationship
{
    public class StudentViewModel
    {
        public int Id { get; set; }
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

        public ICollection<StudentRelationshipViewModel> StudentRelationships { set; get; }
    }
}
