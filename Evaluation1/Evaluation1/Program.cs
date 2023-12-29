using System;
using System.Collections.Generic;
using ConsoleTable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluation1
{
    class Program
    {
        static int rectId = 0;
        static int circId = 0;
        static int triId = 0;
        static IReadOnlyDictionary<string, IRegion> regs;
        static void Main(string[] args)
        {
            Console.WriteLine("\n--------- Region Manager ---------");
            string shapeList = "\n----- Select Shapes -----\n1. Rectangle\n2. Circle\n3. Triangle\n4. Exit\nEnter your choice : ";
            string choiceList = "\n----- Select option -----\n1. Add Region\n2. Remove Region\n3. Get All Regions\n4. Get Regions\n";
            choiceList += "5. Get Area\n6. Move Region\n7. Resize Region\nEnter your choice : ";

            int shapeChoice = 0;
            int choice = 0;
            do
            {
                InputValidate.ValidateInt(choiceList);
                choice = InputValidate.intValue;
                switch (choice)
                {
                    case 1:
                        InputValidate.ValidateInt(shapeList);
                        shapeChoice = InputValidate.intValue;
                        switch (shapeChoice)
                        {
                            case 1:
                                InputValidate.ValidateInt("Enter the Length : ");
                                int length = InputValidate.intValue;
                                InputValidate.ValidateInt("Enter the Breadth : ");
                                int breadth = InputValidate.intValue;
                                InputValidate.ValidateInt("Enter the X-Coordinate : ");
                                int x = InputValidate.intValue;
                                InputValidate.ValidateInt("Enter the Y-Coordinate : ");
                                int y = InputValidate.intValue;
                                Rectangle r = new Rectangle()
                                {
                                    Name = "Rectangle",
                                    Id = "R" + (++rectId),
                                    Length = length,
                                    Breadth = breadth,
                                    X = x,
                                    Y = y,
                                };
                                Console.WriteLine(RegionManager.AddRegion(r.Id,r));
                                break;
                            case 2:
                                InputValidate.ValidateInt("Enter the Radius : ");
                                int radius = InputValidate.intValue;
                                InputValidate.ValidateInt("Enter the X-Coordinate : ");
                                x = InputValidate.intValue;
                                InputValidate.ValidateInt("Enter the Y-Coordinate : ");
                                y = InputValidate.intValue;
                                Circle c = new Circle()
                                {
                                    Name = "Circle",
                                    Id = "C" + (++circId),
                                    Radius = radius,
                                    X = x,
                                    Y = y,
                                };
                                Console.WriteLine(RegionManager.AddRegion(c.Id, c));
                                break;
                            case 3:
                                InputValidate.ValidateInt("Enter the length : ");
                                length = InputValidate.intValue;
                                InputValidate.ValidateInt("Enter the Breadth : ");
                                breadth = InputValidate.intValue;
                                InputValidate.ValidateInt("Enter the Height : ");
                                int height = InputValidate.intValue;

                                InputValidate.ValidateInt("Enter the X-Coordinate : ");
                                x = InputValidate.intValue;
                                InputValidate.ValidateInt("Enter the Y-Coordinate : ");
                                y = InputValidate.intValue;
                                Triangle t = new Triangle()
                                {
                                    Name = "Triangle",
                                    Id = "T" + (++triId),
                                    Length = length,
                                    Breadth = breadth,
                                    Height = height,
                                    X = x,
                                    Y = y,
                                };
                                Console.WriteLine(RegionManager.AddRegion(t.Id, t));
                                break;
                        }
                        break;
                    case 2:
                        Console.Write("Enter the region Id to remove : ");
                        string id = Console.ReadLine().ToUpper();
                        Console.WriteLine(RegionManager.RemoveRegion(id));
                        break;
                    case 3:
                        regs = RegionManager.GetAllRegions();
                        DisplayRegions(regs,0);
                        break;
                    case 4:
                        InputValidate.ValidateInt(shapeList);
                        int region = InputValidate.intValue;
                        DisplayRegions(RegionManager.GetRegions(region),region);
                        break;
                    case 5:
                        regs = RegionManager.GetAllRegions();
                        DisplayRegions(regs, 0);
                        Console.Write("Enter the ID to get Area : ");
                        id = Console.ReadLine().ToUpper();
                        if (!regs.ContainsKey(id))
                        {
                            Console.WriteLine("Invalid Id..!");
                        }
                        else
                        {
                            Console.WriteLine($"Area of {id} - {regs[id].Name} : {regs[id].GetArea()}");
                        }
                        break;
                    case 6:
                        regs = RegionManager.GetAllRegions();
                        DisplayRegions(regs, 0);
                        Console.Write("Enter the ID to move Region : ");
                        id = Console.ReadLine().ToUpper();
                        if (!regs.ContainsKey(id))
                        {
                            Console.WriteLine("Invalid Id..!");
                        }
                        else
                        {
                            InputValidate.ValidateInt("Enter the new offsetX value : ");
                            int offsetX = InputValidate.intValue;
                            InputValidate.ValidateInt("Enter the new offsetY value : ");
                            int offsetY = InputValidate.intValue;
                            Console.WriteLine(regs[id].MoveRegion(offsetX, offsetY) ? "Region Moved Successfully" : "Invalid offset values..!");
                        }
                        break;
                    case 7:
                        regs = RegionManager.GetAllRegions();
                        DisplayRegions(regs, 0);
                        Console.Write("Enter the ID to resize Region : ");
                        id = Console.ReadLine().ToUpper();
                        if (!regs.ContainsKey(id))
                        {
                            Console.WriteLine("Invalid Id..!");
                        }
                        else
                        {
                            if(regs[id].NoOfEdges == 0)
                            {
                                InputValidate.ValidateInt("Enter the radius : ");
                                int radius = InputValidate.intValue;

                            }
                        }
                        break;
                }
            }while(choice != 8);
            
        }
        static void DisplayRegions(IReadOnlyDictionary<string,IRegion> regs,int choice)
        {
            var outerTable = new Table();
            var rTable = new Table();
            var cTable = new Table();
            var tTable = new Table();

            rTable.SetHeaders("Id", "Name", "Coords", "Length", "Breadth");
            cTable.SetHeaders("Id", "Name", "Coords", "Radius");
            tTable.SetHeaders("Id", "Name", "Coords", "Length", "Breadth","Height");

            foreach(var reg in regs)
            {
                if (reg.Value is Rectangle r)
                {
                    string coords = $"({r.X},{r.Y})";
                    rTable.AddRow(r.Id, r.Name, coords, r.Length+"", r.Breadth+"");
                }
                else if(reg.Value is Circle c)
                {
                    string coords = $"({c.X},{c.Y})";
                    cTable.AddRow(c.Id, c.Name, coords, c.Radius + "");
                }
                else if(reg.Value is Triangle t)
                {
                    string coords = $"({t.X},{t.Y})";
                    tTable.AddRow(t.Id, t.Name, coords, t.Length + "", t.Breadth + "",t.Height+"");
                }
            }
            switch (choice)
            {
                case 1:
                    Console.WriteLine("\t Rectangle Regions");
                    Console.Write(rTable.ToString());
                    break;
                case 2:
                    Console.WriteLine("\t Circle Regions");
                    Console.WriteLine(cTable.ToString());
                    break;
                case 3:
                    Console.WriteLine("\t Triangle Regions");
                    Console.WriteLine(tTable.ToString());
                    break;
                default:
                    Console.WriteLine(rTable.ToString());
                    Console.WriteLine(cTable.ToString());
                    Console.WriteLine(tTable.ToString());
                    break;
            }
        }
    }
}







//var table = new Table();
//table.SetHeaders("ID", "StudentName", "Maths", "Physics", "Chemistry", "Computer", "Total", "Percentage", "Cutoff", "Pass/Fail", "Rank");
//                foreach (Student s in studentsList)
//                {
//                    string passFail = s.IsFail ? "Fail" : "Pass";
//table.AddRow(s.ID + "", s.Name, s.MathsMark + "", s.PhysicsMark + "", s.ChemistryMark + "", s.ComputerMark + "", s.TotalScored + "", s.Percentage + "", s.CutOff + "", passFail, s.Rank + "");
//                }
//                Console.WriteLine(table.ToString());