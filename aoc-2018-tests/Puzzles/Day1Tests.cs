using System;
using Xunit;
using aoc_2018.Puzzles;

namespace aoc_2018_tests
{
    public class Day1Tests
    {
        [Fact]
        public void Part1Test()
        {
            var day = new Day1();
            Assert.Equal("3", day.GetPart1Answer("+1\n+1\n+1"));
            Assert.Equal("0", day.GetPart1Answer("+1\n+1\n-2"));
            Assert.Equal("-6", day.GetPart1Answer("-1\n-2\n-3"));
        }

        [Fact]
        public void Part2Test()
        {
            var day = new Day1();
            Assert.Equal("0", day.GetPart2Answer("+1\n-1"));
            Assert.Equal("10", day.GetPart2Answer("+3\n+3\n+4\n-2\n-4"));
            Assert.Equal("5", day.GetPart2Answer("-6\n+3\n+8\n+5\n-6"));
            Assert.Equal("14", day.GetPart2Answer("+7\n+7\n-2\n-7\n-4"));
        }
    }
}
