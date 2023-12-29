using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluation1
{
    public static class RegionManager
    {
        public static int id = 1;
        public static Dictionary<string, IRegion> regions = new Dictionary<string, IRegion>();
        public static string AddRegion(string regId,IRegion reg)
        {
            regions.Add(regId, reg);
            return "Region Added Successfully";
        }
        public static string RemoveRegion(string regId)
        {
            if (regions.ContainsKey(regId))
            {
                regions.Remove(regId);
                return "Region Removed Successfully";
            }
            return "Region not found..!";
        }
        public static IReadOnlyDictionary<string,IRegion> GetAllRegions()
        {
            IReadOnlyDictionary<string, IRegion> readonlyRegions = regions;
            return readonlyRegions;
        }
        public static IReadOnlyDictionary<string,IRegion> GetRegions(int regNo)
        {
            Dictionary<string, IRegion> regs = new Dictionary<string, IRegion>();
            if(regNo == 1)
            {
                foreach(var reg in regions)
                {
                    if(reg.Value.NoOfEdges == 4)
                    {
                        regs.Add(reg.Key,reg.Value);
                    }
                }
            }
            else if (regNo == 2)
            {
                foreach (var reg in regions)
                {
                    if (reg.Value.NoOfEdges == 0)
                    {
                        regs.Add(reg.Key, reg.Value);
                    }
                }
            }
            else if (regNo == 2)
            {
                foreach (var reg in regions)
                {
                    if (reg.Value.NoOfEdges == 3)
                    {
                        regs.Add(reg.Key, reg.Value);
                    }
                }
            }
            IReadOnlyDictionary<string, IRegion> readonlyRegions = regs;
            return readonlyRegions;
        }
    }
}
