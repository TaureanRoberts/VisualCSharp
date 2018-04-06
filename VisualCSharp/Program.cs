using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualCSharp
{
    public class Vector2
    {

        public Vector2()
        {
        }
        public Vector2(float lhs, float rhs)
        {
            float mX = lhs;
            float mY = rhs;
        }

        public static Vector2 operator + (Vector2 other)
        {
            Vector2 newvect2 = new Vector2();

            return newvect2;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            Console.ReadKey();
        }
    }
}
