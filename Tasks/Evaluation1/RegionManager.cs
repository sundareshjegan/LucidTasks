using System;
using System.Collections.Generic;
using System.Linq;


namespace Evaluation1
{
    public static class RegionManager
    {
        static Dictionary<string, IRegion> regions = new Dictionary<string, IRegion>();

        public static void AddRegion(string regionId, int l, int b, int x, int y)
        {
            regions.Add(regionId, new Rectangle(regionId,l,b,x,y));
        }
        public static void AddRegion(string regionId, int side)
        {
            //regions.Add(regionId, new Square(side));
        }
        public static void AddRegion(string regionId, int length, int breadth, int height)
        {
            //regions.Add(regionId, new Triangle(side));
        }
        public static string RemoveRegion(string regionId)
        {
            foreach(KeyValuePair<string,IRegion> regs in regions)
            {
                if (regions.ContainsKey(regionId))
                {
                    regions.Remove(regionId);
                    return "Region removed Successfully..!";
                }
            }
            return "No Regions Found..!";
        }
        public static Dictionary<string,IRegion> getAllRegions()
        {
            return regions;
        }
        public static void getRegions()
        {

        }
    }
}
