using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemServices
{
    public interface IItemServices
    {
        ItemDTO GetItem(string scanCode);
    }
}
