// See https://aka.ms/new-console-template for more information
using System.Drawing;

namespace Task_2
{
    public class Program
    {
		public static void Main(string[] args)
		{
            string[] array = { "1 -2", "-3 4", "0 2" };
            ParsePoints(array);
            foreach (var point in ParsePoints(new[] { "1 -2", "-3 4", "0 2" }))
                Console.WriteLine(point.X + " " + point.Y);
            foreach (var point in ParsePoints(new List<string> { "+01 -0042" }))
                Console.WriteLine(point.X + " " + point.Y);
        }

        public static List<Point> ParsePoints(IEnumerable<string> lines)
        {
            return lines
                .Select(x => x.Split(' '))
                .Select(x => new Point(int.Parse(x[0]), int.Parse(x[1])))
                .ToList();
        }
    }

    public class Point
    {
        public int X {  get; set; }
        public int Y {  get; set; }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}
