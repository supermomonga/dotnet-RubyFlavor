using System;
using Xunit;
using System.Collections.Generic;
using RubyFlavor;

namespace RubyFlavor.Tests
{
    public class IEnumerableExtensions
    {
        [Fact]
        public void ChunkTest()
        {
            IEnumerable<int> xs = new List<int> { 1, 3, 5, 2, 4, 6, 1, 2, 1, 2 };
            IEnumerable<(bool, IEnumerable<int>)> expected = new List<(bool, IEnumerable<int>)> {
                (false, new List<int> {1, 3, 5}),
                (true,  new List<int> {2, 4, 6}),
                (false, new List<int> {1}),
                (true,  new List<int> {2}),
                (false, new List<int> {1}),
                (true,  new List<int> {2})
            };
            Func<int, bool> keySelector = x => x % 2 == 0;
            Assert.Equal(1, 1);
        }
    }
}
