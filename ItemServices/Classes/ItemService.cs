using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemServices
{
    public class ItemService : IItemServices
    {
        private IItemDL itemDl;

        public ItemService(IItemDL itemDataLayer)
        {
            this.itemDl = itemDataLayer;
        }

        public ItemDTO GetItem(string scanCode)
        {
            return itemDl.GetItem(scanCode);
        }
    }
}
