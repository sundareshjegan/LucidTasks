using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluation1
{
    class Triangle : IRegion
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public int NoOfEdges => 3;

        public int Length { get; set; }
        public int Breadth { get; set; }
        public int Height { get; set; }
        public int X;
        public int Y;

        public double GetArea()
        {
            return 0.5 * Length * Breadth * Height;
        }

        public bool Intersect()
        {
            return true;
        }        

        public bool MoveRegion(int offsetX, int offsetY)
        {
            if (X + offsetX < 0 || Y + offsetY < Y)
            {
                return false;
            }
            X += offsetX;
            Y += offsetY;
            return true;
        }

        public void Resize(int scaleX, int scaleY)
        {
            throw new NotImplementedException();
        }
    }
}
