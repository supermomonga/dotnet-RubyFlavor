using System;
using System.Linq;
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
            var xs = new List<int> { 1, 3, 5, 2, 4, 6, 1, 2 };
            Func<int, bool> keySelector = x => x % 2 == 0;
            var chunked = xs.Chunk(keySelector);

            Assert.Equal(4, chunked.Count());
            {
                var x = chunked.ElementAt(0);
                Assert.Equal(x.Key, false);
                Assert.Equal(new List<int> { 1, 3, 5 }, x);
            }
            {
                var x = chunked.ElementAt(1);
                Assert.Equal(x.Key, true);
                Assert.Equal(new List<int> { 2, 4, 6 }, x);
            }
            {
                var x = chunked.ElementAt(2);
                Assert.Equal(x.Key, false);
                Assert.Equal(new List<int> { 1 }, x);
            }
            {
                var x = chunked.ElementAt(3);
                Assert.Equal(x.Key, true);
                Assert.Equal(new List<int> { 2 }, x);
            }
        }
    }
}
