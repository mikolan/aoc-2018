using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace aoc_2018.Puzzles
{
    public class Day2 : IDay
    {
        public string GetPart1Answer()
        {
            var input = File.ReadAllText("Inputs/Day2.txt");
            return GetPart1Answer(input);
        }

        public string GetPart1Answer(string input)
        {
            string[] boxes = input.Split('\n');
            int doubles = 0;
            int triples = 0;

            foreach(var box in boxes)
            {
                var occurances = box.GroupBy(c => c).Select(c => new { Letter = c.Key, Count = c.Count() }).Where(c => c.Count > 1);
                doubles += occurances.Where(c => c.Count == 2).Any() ? 1 : 0;
                triples += occurances.Where(c => c.Count == 3).Any() ? 1 : 0;
            }

            int result = doubles * triples;

            return result.ToString();
        }

        public string GetPart2Answer()
        {
            var input = File.ReadAllText("Inputs/Day2.txt");
            return GetPart2Answer(input);
        }

        public string GetPart2Answer(string input)
        {
            string[] boxes = input.Split('\n').Select(s => s.Trim()).ToArray();

            for(int i = 0; i < boxes.Length - 1; i++)
            {
                for(int j = i + 1; j < boxes.Length; j++)
                {
                    var diff = Intersect(boxes[i], boxes[j]);
                    if (diff.Count() == boxes[i].Length - 1)
                        return string.Concat(diff);
                }
            }

            return "";
        }

        private string Intersect(string first, string second)
        {
            var sb = new StringBuilder();

            for (int i = 0; i < first.Length; i++)
            {
                if (first[i] == second[i])
                {
                    sb.Append(first[i]);
                }
            }

            return sb.ToString();
        }
    }
}
