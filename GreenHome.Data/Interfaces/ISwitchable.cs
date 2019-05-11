using GreenHome.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace GreenHome.Data.Interfaces
{
    public interface ISwitchable
    {
        Status Status { set; get; }
     }
}
