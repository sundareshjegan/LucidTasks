using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluation1
{
    public interface IRegion
    {
        string Id { get; }
        string Name { get; }
        int NoOfEdges { get; }

        double GetArea();
        bool Intersect();
        bool MoveRegion(int offsetX, int offsetY);
        void Resize(int scaleX, int scaleY);
    }
}
