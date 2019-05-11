using System;
using System.Collections.Generic;
using System.Text;

namespace GreenHome.Data.Interfaces
{
    public interface IHasSoftDelete
    {
        bool IsDelete { set; get; }
    }
}
