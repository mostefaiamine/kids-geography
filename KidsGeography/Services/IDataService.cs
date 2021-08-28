using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KidsGeography
{
    /// <summary>
    /// Geography data service
    /// </summary>
    public interface IDataService
    {
        Task<GeoData> GetData();
    }
}
