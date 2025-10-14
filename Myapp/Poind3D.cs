namespace Myapp
{
    public class Point3D : Point
    {
        private int z;
        public Point3D(int x, int y, int z) : base(x, y)
        {
            this.z = z;
        }
    }
}