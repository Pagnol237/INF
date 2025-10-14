using System.Security.Cryptography.X509Certificates;

namespace Myapp
{
    public class Point
    {
        protected int x, y;
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
}