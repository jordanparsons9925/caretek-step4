using System;

namespace Step4Prototype
{
    static class Region
    {
        static string[] regions = { "East Coast", "Central", "West Coast", "NOrthern Penninsula" };

        public string GetRegion(int i)
        {
            return regions[i];
        }
    }
}
