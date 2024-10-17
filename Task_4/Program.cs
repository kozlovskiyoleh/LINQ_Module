// See https://aka.ms/new-console-template for more information

namespace Task_4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Point point = new(1, 2);
            foreach (Point neighbour in GetNeighboursLINQ(point))
                Console.WriteLine(neighbour);
        }

        public static List<Point> GetNeighboursLINQ(Point point)
        {
            int[] d = { -1, 0, 1 };
            return d.SelectMany(number => 
                   d.Select(nestedNumber => new Point(point.X + number, point.Y + nestedNumber)))
                   .Where(x=>!x.Equals(point))
                   .ToList();
        }

    }

    public class Point
    {
        public int X { get; private set; }
        public int Y { get; private set; }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public override string ToString()
        {
            return $"({X};{Y})";
        }

        public override bool Equals( object? obj)
        {
            ArgumentNullException.ThrowIfNull(obj);
            Point otherPoint = obj as Point;
            return this.X.Equals(otherPoint.X) && this.Y.Equals(otherPoint.Y);
        }
    }
}