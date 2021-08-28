using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KidsGeography
{
    /// <summary>
    /// Geo data
    /// </summary>
    public class GeoData
    {
        /// <summary>
        /// countries
        /// </summary>
        public List<Country> Countries { get; set; }

        /// <summary>
        /// towns
        /// </summary>
        public List<Town> Towns { get; set; }
    }
}
