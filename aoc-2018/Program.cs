using aoc_2018.Puzzles;
using System;

namespace aoc_2018
{
    class Program
    {
        static void Main(string[] args)
        {
            var day1 = (IDay)(new Day1());

            Console.WriteLine(day1.GetPart1Answer());
            Console.WriteLine(day1.GetPart2Answer());

            var day2 = (IDay)(new Day2());
            Console.WriteLine(day2.GetPart1Answer());
            Console.WriteLine(day2.GetPart2Answer());
            Console.ReadLine();
        }
    }
}
