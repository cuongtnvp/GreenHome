using System;
using System.Collections.Generic;
using System.Text;

namespace GreenHome.Data.Interfaces
{
   public interface IDateTracking
    {
        DateTime DateCreated { set; get; }
        DateTime DateModified { get; set; }
    }
}
