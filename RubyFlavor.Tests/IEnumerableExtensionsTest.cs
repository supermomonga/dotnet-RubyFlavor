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
            static bool keySelector(int x) => x % 2 == 0;
            var chunked = xs.Chunk(keySelector);

            Assert.Equal(4, chunked.Count());
            {
                var x = chunked.ElementAt(0);
                Assert.False(x.Key);
                Assert.Equal([1, 3, 5], x);
            }
            {
                var x = chunked.ElementAt(1);
                Assert.True(x.Key);
                Assert.Equal([2, 4, 6], x);
            }
            {
                var x = chunked.ElementAt(2);
                Assert.False(x.Key);
                Assert.Equal(new List<int> { 1 }, x);
            }
            {
                var x = chunked.ElementAt(3);
                Assert.True(x.Key);
                Assert.Equal([2], x);
            }
        }

        [Fact]
        public void CollectTest()
        {
            static int selector(int x) => x * 2;
            var xs = new List<int> { 1, 2, 3, 4, 5, 6 }.Collect(selector);

            Assert.Equal(6, xs.Count());
            Assert.Equal(2, xs.ElementAt(0));
            Assert.Equal(4, xs.ElementAt(1));
        }

        [Fact]
        public void ChunkWithEmptyListTest()
        {
            var xs = new List<int> { };
            static bool keySelector(int x) => x % 2 == 0;
            var chunked = xs.Chunk(keySelector);

            Assert.Empty(chunked);
        }

        [Fact]
        public void EachConsecutiveTest()
        {
            {
                var xs = new List<int> { };
                var length = 2;
                var expected = new List<List<int>> { };
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
                var expected = new List<List<int>> { };
                Assert.Equal(expected, xs.EachConsecutive(length));
            }
        }

        [Fact]
        public void EachSliceTest()
        {
            {
                var xs = new List<int> { };
                var length = 2;
                var expected = new List<List<int>> { };
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

        [Fact]
        public void OneTest()
        {
            Assert.False(new List<int> { }.One());
            Assert.True(new List<int> { 1 }.One());
            Assert.False(new List<int> { 1, 2 }.One());
            Assert.True(new List<int> { 1, 2, 3, 4, 5 }.One(x => x % 3 == 0));
            Assert.False(new List<int> { 1, 2, 3, 4, 5, 6 }.One(x => x % 3 == 0));
        }

        [Fact]
        public void NoneTest()
        {
            Assert.True(new List<int> { }.None());
            Assert.False(new List<int> { 1 }.None());
            Assert.False(new List<int> { 1, 2 }.None());
            Assert.False(new List<int> { 1, 2, 3 }.None(x => x % 3 == 0));
            Assert.True(new List<int> { 1, 2, 4, 5 }.None(x => x % 3 == 0));
        }
    }
}
