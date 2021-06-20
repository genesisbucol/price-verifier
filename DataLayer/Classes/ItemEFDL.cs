using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class ItemEFDL : IItemDL
    {
        public ItemDTO GetItem(string scanCode)
        {
            var listItems = new List<ItemDTO>();
            var e = new ItemDTO();
            using (var ctx = new dbContainer())
            {

                var ctxItems = ctx.Items
                               .Where(i => i.ScanCode == scanCode && i.IsActive == true).FirstOrDefault();
                // default

                if (ctxItems != null) {
                    
                    e.Id = ctxItems.Id;
                    e.ItemName = ctxItems.ItemName;
                    e.ItemDescription = ctxItems.ItemDescription;
                    e.DefaultUnitPrice = ctxItems.DefaultUnitPrice;
                    e.ScanCode = ctxItems.ScanCode;
                    e.PicturePath = ctxItems.PicturePath;
                    e.IsActive = ctxItems.IsActive;

                    //listItems.Add(e);
                }

                //foreach (var item in ctxItems)
                //{
                //    var e = new ItemDTO();
                //    e.Id = item.Id;
                //    e.ItemName = item.ItemName;
                //    e.ItemDescription = item.ItemDescription;
                //    e.DefaultUnitPrice = item.DefaultUnitPrice;
                //    e.ScanCode = item.ScanCode;
                //    e.PicturePath = item.PicturePath;
                //    e.IsActive = item.IsActive;

                //    listItems.Add(e);
                //}
            }
            return e;
            //return listItems;
        }
    }
}
