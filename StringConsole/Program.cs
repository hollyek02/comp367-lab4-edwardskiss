using System;
using StringLibrary;

namespace StringConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] samples = new[]
            {
                "Hello",
                "world",
                "",
                "123",
                "Uppercase",
                "lowercase"
            };

            foreach (var sample in samples)
            {
                bool startsWithUpper = sample.StartsWithUpper();
                Console.WriteLine(
                    $"\"{sample}\" starts with uppercase? {startsWithUpper}");
            }
        }
    }
}