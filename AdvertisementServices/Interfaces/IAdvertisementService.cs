using DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvertisementServices
{
    public interface IAdvertisementService
    {
        IEnumerable<AdvertisementDTO> List();
    }
}
