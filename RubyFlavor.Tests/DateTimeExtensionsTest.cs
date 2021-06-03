using System.Linq;
using Xunit;
using System.Collections.Generic;
using System;

namespace RubyFlavor.Tests
{
    public class DateTimeExtensionsTest
    {
        [Fact]
        public void UpToTest()
        {
            var d1 = new DateTime(2000, 1, 1);
            var d2 = new DateTime(2000, 1, 2);
            var d3 = new DateTime(2000, 1, 3);
            var d4 = new DateTime(2000, 1, 4);
            var d5 = new DateTime(2000, 1, 5);
            var d6 = new DateTime(2000, 1, 6);
            var d7 = new DateTime(2000, 1, 7);
            var d8 = new DateTime(2000, 1, 8);
            var d9 = new DateTime(2000, 1, 9);
            var d10 = new DateTime(2000, 1, 10);
            var d11 = new DateTime(2000, 1, 11);
            var step2 = TimeSpan.FromDays(3);
            var step3 = TimeSpan.FromDays(3);
            {
                var actual = d1.UpTo(d10).ToList();
                var expected = new List<DateTime> { d1, d2, d3, d4, d5, d6, d7, d8, d9, d10 };
                Assert.Equal(expected, actual);
            }
            {
                var actual = d1.UpTo(d1).ToList();
                var expected = new List<DateTime> { d1 };
                Assert.Equal(expected, actual);
            }
            {
                var actual = d10.UpTo(d1).ToList();
                var expected = new List<DateTime> { };
                Assert.Equal(expected, actual);
            }
            {
                var actual = d1.UpTo(d10, step: step3).ToList();
                var expected = new List<DateTime> { d1, d4, d7, d10 };
                Assert.Equal(expected, actual);
            }
            {
                var actual = d1.UpTo(d11, step: step3).ToList();
                var expected = new List<DateTime> { d1, d4, d7, d10 };
                Assert.Equal(expected, actual);
            }
            {
                var actual = d10.UpTo(d10, step: step2).ToList();
                var expected = new List<DateTime> { d10 };
                Assert.Equal(expected, actual);
            }
            {
                var actual = d2.UpTo(d1, step: step2).ToList();
                var expected = new List<DateTime> { };
                Assert.Equal(expected, actual);
            }
        }
        [Fact]
        public void DownToTest()
        {
            var d1 = new DateTime(2000, 1, 1);
            var d2 = new DateTime(2000, 1, 2);
            var d3 = new DateTime(2000, 1, 3);
            var d4 = new DateTime(2000, 1, 4);
            var d5 = new DateTime(2000, 1, 5);
            var d6 = new DateTime(2000, 1, 6);
            var d7 = new DateTime(2000, 1, 7);
            var d8 = new DateTime(2000, 1, 8);
            var d9 = new DateTime(2000, 1, 9);
            var d10 = new DateTime(2000, 1, 10);
            var d11 = new DateTime(2000, 1, 11);
            var step2 = TimeSpan.FromDays(3);
            var step3 = TimeSpan.FromDays(3);
            {
                var actual = d10.DownTo(d1).ToList();
                var expected = new List<DateTime> { d10, d9, d8, d7, d6, d5, d4, d3, d2, d1};
                Assert.Equal(expected, actual);
            }
            {
                var actual = d10.DownTo(d10).ToList();
                var expected = new List<DateTime> { d10 };
                Assert.Equal(expected, actual);
            }
            {
                var actual = d1.DownTo(d2).ToList();
                var expected = new List<DateTime> { };
                Assert.Equal(expected, actual);
            }
            {
                var actual = d10.DownTo(d1, step: step3).ToList();
                var expected = new List<DateTime> { d10, d7, d4, d1};
                Assert.Equal(expected, actual);
            }
            {
                var actual = d11.DownTo(d1, step: step3).ToList();
                var expected = new List<DateTime> { d11, d8, d5, d2};
                Assert.Equal(expected, actual);
            }
            {
                var actual = d10.DownTo(d10, step: step2).ToList();
                var expected = new List<DateTime> { d10 };
                Assert.Equal(expected, actual);
            }
            {
                var actual = d1.DownTo(d2, step: step2).ToList();
                var expected = new List<DateTime> { };
                Assert.Equal(expected, actual);
            }
        }
    }
}
