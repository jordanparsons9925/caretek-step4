using System;

namespace Step4Prototype
{
    static class Region
    {
        static string[] regions = { "East Coast", "Central", "West Coast", "Northern Penninsula" };

        public string GetRegion(string regionCode)
        {
            switch (regionCode)
            {
                case "EC":
                    regionName = regions[0];
                    break;
                case "C":
                    regionName = regions[1];
                    break;
                case "WC":
                    regionName = regions[2];
                    break;
                case "NP":
                    regionName = regions[3];
                    break;
            }

            return regionName;
        }
    }
}
