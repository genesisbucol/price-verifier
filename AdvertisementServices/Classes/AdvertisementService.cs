using AdvertisementServices;
using DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvertisementServices
{
    public class AdvertisementService : IAdvertisementService
    {
        private  IAdvertisementDL advertisementDl;

        public AdvertisementService(IAdvertisementDL adsDL)
        {
            this.advertisementDl = adsDL;
        }

        public IEnumerable<AdvertisementDTO> List()
        {
            return this.advertisementDl.List();
        }
    }
}
