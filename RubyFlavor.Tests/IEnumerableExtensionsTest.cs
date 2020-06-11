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

        [Fact]
        public void CollectTest()
        {
			Func<int, int> selector = x => x * 2;
			var xs = (new List<int> { 1, 2, 3, 4, 5, 6 }).Collect(selector);

            Assert.Equal(6, xs.Count());
			Assert.Equal(xs.ElementAt(0), 2);
			Assert.Equal(xs.ElementAt(1), 4);
        }

        [Fact]
        public void ChunkWithEmptyListTest()
        {
            var xs = new List<int> {};
            Func<int, bool> keySelector = x => x % 2 == 0;
            var chunked = xs.Chunk(keySelector);

            Assert.Equal(0, chunked.Count());
        }

        [Fact]
        [InlineData()]
        public void EachConsecutiveTest()
        {
            {
                var xs = new List<int> {};
                var length = 2;
                var expected = new List<List<int>> {};
                Assert.Equal(expected, xs.EachConsecutive(length));
            }
            {
                var xs = Enumerable.Range(1, 4);
                var length = 2;
                var expected = new List<List<int>> { new List<int> { 1, 2 }, new List<int> { 2, 3 }, new List<int> { 3, 4 } };
                Assert.Equal(expected, xs.EachConsecutive(length));
            }
            {
                var xs = Enumerable.Range(1, 4);
                var length = 3;
                var expected = new List<List<int>> { new List<int> { 1, 2, 3 }, new List<int> { 2, 3, 4 } };
                Assert.Equal(expected, xs.EachConsecutive(length));
            }
            {
                var xs = Enumerable.Range(1, 4);
                var length = 4;
                var expected = new List<List<int>> { new List<int> { 1, 2, 3, 4 } };
                Assert.Equal(expected, xs.EachConsecutive(length));
            }
            {
                var xs = Enumerable.Range(1, 4);
                var length = 5;
                var expected = new List<List<int>> {};
                Assert.Equal(expected, xs.EachConsecutive(length));
            }
        }

        [Fact]
        [InlineData()]
        public void EachSliceTest()
        {
            {
                var xs = new List<int> {};
                var length = 2;
                var expected = new List<List<int>> {};
                Assert.Equal(expected, xs.EachSlice(length));
            }
            {
                var xs = Enumerable.Range(1, 4);
                var length = 2;
                var expected = new List<List<int>> { new List<int> { 1, 2 }, new List<int> { 3, 4 } };
                Assert.Equal(expected, xs.EachSlice(length));
            }
            {
                var xs = Enumerable.Range(1, 4);
                var length = 3;
                var expected = new List<List<int>> { new List<int> { 1, 2, 3 }, new List<int> { 4 } };
                Assert.Equal(expected, xs.EachSlice(length));
            }
            {
                var xs = Enumerable.Range(1, 4);
                var length = 4;
                var expected = new List<List<int>> { new List<int> { 1, 2, 3, 4 } };
                Assert.Equal(expected, xs.EachSlice(length));
            }
            {
                var xs = Enumerable.Range(1, 4);
                var length = 5;
                var expected = new List<List<int>> { new List<int> { 1, 2, 3, 4 } };
                Assert.Equal(expected, xs.EachSlice(length));
            }
        }
    }
}
