using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluation1
{
    class Program
    {
        static int squareId = 0;
        static int rectangleId = 0;
        static int triangleId = 0;
        static void Main(string[] args)
        {
            Console.WriteLine("Region Manager\n------ -------");
            string regionChoices = "1. Add Region\n2. Remove Region\n3. GetAll Regions\n4. Get Region\n5. Exit";
            int regionChoice = 0;
            string shapeName = "";
            do
            {
                Console.Write("\n\nEnter the shape name (Rectangle/Circle/Square/exit) : ");
                shapeName = Console.ReadLine().ToLower();
                switch (shapeName)
                {
                    case "rectangle":
                        Console.Write("Enter the length : ");
                        int length = int.Parse(Console.ReadLine());
                        Console.Write("Enter the breadth : ");
                        int breadth = int.Parse(Console.ReadLine());
                        do
                        {
                            Console.WriteLine(regionChoices);
                            regionChoice = int.Parse(Console.ReadLine());
                            switch (regionChoice)
                            {
                                case 1:
                                    Console.Write("Enter the offset-X : ");
                                    int x = int.Parse(Console.ReadLine());
                                    Console.Write("Enter the offset-Y : ");
                                    int y = int.Parse(Console.ReadLine());

                                    string regionId = shapeName + (++rectangleId);
                                    RegionManager.AddRegion(regionId, length, breadth, x, y);
                                    Console.WriteLine("Region Added Successfully..!");
                                    break;
                                case 2:
                                    Console.WriteLine("Enter the regionId : ");
                                    regionId = Console.ReadLine();
                                    Console.WriteLine(RegionManager.RemoveRegion(regionId));
                                    break;
                                case 3:
                                    Dictionary<string, IRegion> regions = RegionManager.getAllRegions();
                                    if (regions.Count == 0)
                                    {
                                        Console.WriteLine("No regions Found");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Region Id\tOff-X\tOff-Y\n------ --\t-----\t-----");
                                        foreach (KeyValuePair<string, IRegion> regs in regions)
                                        {
                                            if ((regs.Key).Contains(shapeName))
                                            {
                                                Console.WriteLine(regs.Key + "\t" + regs.Value.offsetX + "\t" + regs.Value.offsetY);
                                            }
                                        }
                                    }
                                    break;
                            }
                        } while (regionChoice != 5);
                        
                        break;
                    case "square":
                        break;
                    case "triangle":
                        break;
                }
            } while (shapeName != "exit");
            Console.ReadLine();
        }
    }
    
}
