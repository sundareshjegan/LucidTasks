

namespace Evaluation1
{
    class Square : IRegion
    {
        public string Name { get; set; }
        public string Id { get; set; }
        public int side { get; set; }
        public int offsetX { get; set; }
        public int offsetY { get; set; }

        public float GetArea(string shape, int id)
        {
            return side*side;
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
        public bool Intersest()
        {
            return true;
        }

        public bool Intersect()
        {
            return true;
        }

        public Square(string regionId,int s, int x, int y)
        {
            Id = regionId;
            side = s;
            offsetX = x;
            offsetY = y;
        }
    }
}
