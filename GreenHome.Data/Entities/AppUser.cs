using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using GreenHome.Data.Enums;
using GreenHome.Data.Interfaces;
using Microsoft.AspNetCore.Identity;

namespace GreenHome.Data.Entities
{
    [Table("AppUsers")]
    public class AppUser:IdentityUser<Guid>,IDateTracking,ISwitchable 
    {
        public string FullName { get; set; }
        public string Avatar { get; set; }
        public DateTime? Birthday { get; set; }
        public Status Status { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
    }
}
