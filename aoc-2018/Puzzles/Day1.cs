using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.IO;

namespace aoc_2018.Puzzles
{
    public class Day1 : IDay
    {
        public string GetPart1Answer()
        {
            var input = File.ReadAllText("Inputs/Day1.txt");
            return GetPart1Answer(input);
        }

        public string GetPart1Answer(string input)
        {
            return input.Split('\n').Sum(x => Int32.Parse(x)).ToString();
        }

        public string GetPart2Answer(string input)
        {
            var changes = input.Split('\n').Select(x => Int32.Parse(x)).ToArray();

            int curFreq = 0;
            int i = 0;
            HashSet<int> frequencies = new HashSet<int>();

            while(!frequencies.Contains(curFreq))
            {
                frequencies.Add(curFreq);
                curFreq += changes[i];

                i = ++i % changes.Length;
            }

            return curFreq.ToString();
        }

        public string GetPart2Answer()
        {
            var input = File.ReadAllText("Inputs/Day1.txt");
            return GetPart2Answer(input);
        }
    }
}
