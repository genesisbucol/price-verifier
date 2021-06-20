using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class AdvertisementEFDL : IAdvertisementDL
    {
        public IEnumerable<AdvertisementDTO> List()
        {
            var listAdvertisements = new List<AdvertisementDTO>();
            using (var ctx = new dbContainer())
            {
                var ctxAdvertisements = ctx.Advertisements
                               .Where(i => i.IsActive == true)
                               .OrderBy(i=> i.DisplayIndex);

                foreach (var ads in ctx.Advertisements)
                {
                    var e = new AdvertisementDTO();
                    e.Id = ads.Id;
                    e.AdvertisementName = ads.AdvertisementName;
                    e.AdvertisementType = ads.AdvertisementType;
                    e.Interval = ads.Interval;
                    e.DisplayIndex = ads.DisplayIndex;
                    e.FilePath = ads.FilePath;

                    listAdvertisements.Add(e);
                }
            }

            return listAdvertisements;
        }
    }
}
