using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualCSharp
{
    class Vector2
    {
        public float m_X;
        public float m_Y;

        public Vector2()
        {
        }
        public Vector2(float lhs, float rhs)
        {
            m_X = lhs;
            m_Y = rhs;
        }

        public static Vector2 operator+ (Vector2 lhs, Vector2 rhs)
        {
            Vector2 sum = new Vector2();
            Vector2 other = new Vector2();
            sum.m_X = lhs.m_X + other.m_X;
            sum.m_Y = rhs.m_Y + other.m_Y;
            return sum;
        }
        public static Vector2 operator- (Vector2 lhs, Vector2 rhs)
        {
            Vector2 sub = new Vector2();
            Vector2 other = new Vector2();
            sub.m_X = lhs.m_X - other.m_X;
            sub.m_Y = rhs.m_Y - other.m_Y;
            return sub;
        }
        public static Vector2 operator* (Vector2 other, float size)
        {
            Vector2 scaler = new Vector2();
            scaler.m_X = other.m_X * size;
            scaler.m_Y = other.m_Y * size;
            return scaler;
        }
        public float dot_opperator(Vector2 other)
        {
            float dot;
            dot = (()+())
            return dot;
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
