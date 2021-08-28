using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KidsGeography
{
    public class DataService : IDataService
    {
        public Task<GeoData> GetData()
        {
            return Task.FromResult(GeoDataSample.Data);
        }
    }
}
