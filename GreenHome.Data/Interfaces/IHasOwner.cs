using System;
using System.Collections.Generic;
using System.Text;

namespace GreenHome.Data.Interfaces
{
  public  interface IHasOwner<T>
    {
        T OwnerId { get; set; }
    }
}
