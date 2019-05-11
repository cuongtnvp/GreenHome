using System;
using System.Collections.Generic;
using System.Text;

namespace GreenHome.Data.Interfaces
{
   public interface IAccountTracking
    {
        int IdCreated { set; get; }
        int IdModified { set; get; }

    }
}
