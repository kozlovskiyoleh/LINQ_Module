// See https://aka.ms/new-console-template for more information

namespace Task1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            foreach (var num in ParseNumbers(new[] { "-0", "+0000" }))
                Console.WriteLine(num);
            foreach (var num in ParseNumbers(new List<string> { "1", "", "-03", "0" }))
                Console.WriteLine(num);
        }

        public static int[] ParseNumbers(IEnumerable<string> lines)
        {
            return lines
                .Where(x => x != string.Empty)
                .Select(x=> int.Parse(x))
                .ToArray();
        }
    }
}
