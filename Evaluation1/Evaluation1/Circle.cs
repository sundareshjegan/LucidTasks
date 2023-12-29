using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluation1
{
    class Circle : IRegion
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public int NoOfEdges { get; } = 0;

        public int Radius { get; set; }
        public int X;
        public int Y;

        public double GetArea()
        {
            return 2 * Math.PI * Radius;
        }

        public bool Intersect()
        {
            throw new NotImplementedException();
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
            X += scaleX;
            Y += scaleY;
        }
    }
}
