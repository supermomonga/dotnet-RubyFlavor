using System.Linq;
using Xunit;
using System.Collections.Generic;

namespace RubyFlavor.Tests
{
    public class IntegerExtensionsTest
    {
        [Fact]
        public void UpToTest()
        {
            {
                var actual = 1.UpTo(10).ToList();
                var expected = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
                Assert.Equal(expected, actual);
            }
            {
                var actual = 10.UpTo(10).ToList();
                var expected = new List<int> { 10 };
                Assert.Equal(expected, actual);
            }
            {
                var actual = 2.UpTo(1).ToList();
                var expected = new List<int> { };
                Assert.Equal(expected, actual);
            }
        }
        [Fact]
        public void DownToTest()
        {
            {
                var actual = 10.DownTo(1).ToList();
                var expected = new List<int> { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1};
                Assert.Equal(expected, actual);
            }
            {
                var actual = 10.DownTo(10).ToList();
                var expected = new List<int> { 10 };
                Assert.Equal(expected, actual);
            }
            {
                var actual = 1.DownTo(2).ToList();
                var expected = new List<int> { };
                Assert.Equal(expected, actual);
            }
        }
        [Fact]
        public void TimesTest()
        {
            {
                var actual = 10.Times().ToList();
                var expected = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
                Assert.Equal(expected, actual);
            }
            {
                var actual = 0.Times().ToList();
                var expected = new List<int> { };
                Assert.Equal(expected, actual);
            }
            {
                var actual = (-1).Times().ToList();
                var expected = new List<int> { };
                Assert.Equal(expected, actual);
            }
        }
    }
}
