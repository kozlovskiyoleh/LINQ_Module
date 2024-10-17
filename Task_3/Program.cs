// See https://aka.ms/new-console-template for more information
namespace Task_3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Classroom[] classes =
            {
                new Classroom {Students = {"Pavel", "Ivan", "Petr"},},
                new Classroom {Students = {"Anna", "Ilya", "Vladimir"},},
                new Classroom {Students = {"Bulat", "Alex", "Galina"},}
            };
            var allStudents = GetAllStudents(classes);
            Array.Sort(allStudents);
            Console.WriteLine(string.Join(" ", allStudents));
        }

        public static string[] GetAllStudents(Classroom[] classes) => classes.SelectMany(x=>x.Students).ToArray();
    }

    public class Classroom
    {
        public List<string> Students = new List<string>();
    }
}
