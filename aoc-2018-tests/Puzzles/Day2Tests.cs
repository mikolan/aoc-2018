using System;
using Xunit;
using aoc_2018.Puzzles;

namespace aoc_2018_tests
{
    public class Day2Tests
    {
        [Fact]
        public void Part1Test()
        {
            var day = new Day2();
            string input = "abcdef\nbababc\nabbcde\nabcccd\naabcdd\nabcdee\nababab";

            Assert.Equal("12", day.GetPart1Answer(input));
        }

        [Fact]
        public void Part2Test()
        {
            var day = new Day2();
            string input = "abcde\nfghij\nklmno\npqrst\nfguij\naxcye\nwvxyz";

            Assert.Equal("fgij", day.GetPart2Answer(input));
        }
    }
}
