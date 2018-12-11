using System;
using System.Collections.Generic;
using System.Text;

namespace aoc_2018
{
    interface IDay
    {
        string GetPart1Answer();
        string GetPart2Answer();
        string GetPart1Answer(string input);
        string GetPart2Answer(string input);
    }
}
