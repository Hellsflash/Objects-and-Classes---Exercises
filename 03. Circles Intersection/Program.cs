using System;
using System.Linq;

namespace _03.Circles_Intersection
{
    public class Program
    {
        public class Circle
        {
            public Point Center { get; set; }
            public int Radius { get; set; }
        }
        public class Point
        {
            public int X { get; set; }
            public int Y { get; set; }
        }
        public static void Main(string[] args)
        {
            Circle firstCircle = ReadCircle(Console.ReadLine());
            Circle secondCircle = ReadCircle(Console.ReadLine());

            int deltaX = firstCircle.Center.X - secondCircle.Center.X;
            int deltaY = firstCircle.Center.Y - secondCircle.Center.Y;

            double disstBetwinCenters = Math.Sqrt(deltaX * deltaX + deltaY * deltaY);

            if (disstBetwinCenters > firstCircle.Radius + secondCircle.Radius)
            {
                Console.WriteLine("No");
            }
            else
            {
                Console.WriteLine("Yes");
            }
        }
        public static Circle ReadCircle(string input)
        {
            var tokens = input.Split()
                .Select(int.Parse)
                .ToArray();
            return new Circle { Center = new Point { X = tokens[0], Y = tokens[1] }, Radius = tokens[2] };
        }
    }
}