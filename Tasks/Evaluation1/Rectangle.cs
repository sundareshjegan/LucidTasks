using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluation1
{
    class Rectangle : IRegion
    {
        public string Name { get; set; }
        public string Id { get; set; }
        public int length { get; set; }
        public int breadth { get; set; }
        public int offsetX { get; set; }
        public int offsetY { get; set; }

        static private int id = 0;

        public float GetArea(string shape, int id)
        {
            return length * breadth; ;
        }

        public void MoveRegion(int X, int Y)
        {
            offsetX = X;
            offsetY = Y;
        }

        public void Resize(int scaleX, int scaleY)
        {
            offsetX += scaleX;
            offsetY += scaleY;
        }

        public bool Intersect()
        {
            return true;
        }

        public Rectangle(string regionId,int l, int b, int x, int y)
        {
            Id = regionId;
            length = l;
            breadth = b;
            offsetX = x;
            offsetY = y;
        }
    }
}
