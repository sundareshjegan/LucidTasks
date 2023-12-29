using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluation1
{
    public interface IRegion
    {
        string Name { get; set; }
        string Id { get; set; }
        int offsetX { get; set; }
        int offsetY { get; set; }

        float GetArea(string shape,int id);
        void MoveRegion(int offsetX, int offsetY);
        void Resize(int scaleX, int scaleY);
        bool Intersect();
    }
}
