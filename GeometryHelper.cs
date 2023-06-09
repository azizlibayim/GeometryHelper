using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryHelper
{
    public static class GeometryHelper
    {
        public static void RectangleArea()
        {
            Console.WriteLine("Length:");
            double length = double.Parse(Console.ReadLine());

            Console.WriteLine("Width:");
            double width = double.Parse(Console.ReadLine());

            double area = length * width;
            Console.WriteLine($"Area: {area}");
        }

        public static void TriangleArea()
        {
            Console.WriteLine("Base:");
            double baseLength = double.Parse(Console.ReadLine());

            Console.WriteLine("Height:");
            double height = double.Parse(Console.ReadLine());

            double area = 0.5 * baseLength * height;
            Console.WriteLine($"Area: {area}");
        }

        public static void RoundArea()
        {
            Console.WriteLine("Radius:");
            double radius = double.Parse(Console.ReadLine());

            double area = Math.PI * Math.Pow(radius, 2);
            Console.WriteLine($"Area: {area}");
        }
    }
}
