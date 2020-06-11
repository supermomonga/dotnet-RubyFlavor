using System;
using System.Linq;
using Xunit;
using System.Collections.Generic;
using RubyFlavor;
using Microsoft.CSharp;

namespace RubyFlavor.Tests
{
    public class IComparableExtensionsTest
    {
		[Fact]
        public void UpToTest()
        {
            {
                var actual = 1.UpTo(10, 1).ToList();
                var expected = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
                Assert.Equal(expected, actual);
            }
            {
                var actual = 2.UpTo(10, 3).ToList();
                var expected = new List<int> { 2, 5, 8 };
                Assert.Equal(expected, actual);
            }
            {
                var actual = 10.UpTo(10, 1).ToList();
                var expected = new List<int> { 10 };
                Assert.Equal(expected, actual);
            }
            {
                var actual = 2.UpTo(1, 1).ToList();
                var expected = new List<int> { };
                Assert.Equal(expected, actual);
            }
            {
                var actual = 1.UpTo(10, (x) => x + 1).ToList();
                var expected = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
                Assert.Equal(expected, actual);
            }
            {
                var actual = new DateTime(2000, 1, 1).UpTo(new DateTime(2000, 1, 3), new TimeSpan(12, 0, 0)).ToList();
                var expected = new List<DateTime> {
                    new DateTime(2000, 1, 1).AddHours(12 * 0),
                    new DateTime(2000, 1, 1).AddHours(12 * 1),
                    new DateTime(2000, 1, 1).AddHours(12 * 2),
                    new DateTime(2000, 1, 1).AddHours(12 * 3),
                    new DateTime(2000, 1, 1).AddHours(12 * 4)
                };
                Assert.Equal(expected, actual);
            }
            {
                var actual = new DateTime(2000, 1, 1).UpTo(new DateTime(2000, 3, 1), (x) => x.AddMonths(1)).ToList();
                var expected = new List<DateTime> {
                    new DateTime(2000, 1, 1),
                    new DateTime(2000, 2, 1),
                    new DateTime(2000, 3, 1),
                };
                Assert.Equal(expected, actual);
            }
        }
		[Fact]
        public void DownToTest()
        {
            {
                var actual = 10.DownTo(1, 1).ToList();
                var expected = new List<int> { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1};
                Assert.Equal(expected, actual);
            }
            {
                var actual = 8.DownTo(2, 3).ToList();
                var expected = new List<int> { 8, 5, 2 };
                Assert.Equal(expected, actual);
            }
            {
                var actual = 10.DownTo(10, 1).ToList();
                var expected = new List<int> { 10 };
                Assert.Equal(expected, actual);
            }
            {
                var actual = 1.DownTo(2, 1).ToList();
                var expected = new List<int> { };
                Assert.Equal(expected, actual);
            }
            {
                var actual = 10.DownTo(1, (x) => x - 1).ToList();
                var expected = new List<int> { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
                Assert.Equal(expected, actual);
            }
            {
                var actual = new DateTime(2000, 1, 3).DownTo(new DateTime(2000, 1, 1), new TimeSpan(12, 0, 0)).ToList();
                var expected = new List<DateTime> {
                    new DateTime(2000, 1, 3).AddHours(-12 * 0),
                    new DateTime(2000, 1, 3).AddHours(-12 * 1),
                    new DateTime(2000, 1, 3).AddHours(-12 * 2),
                    new DateTime(2000, 1, 3).AddHours(-12 * 3),
                    new DateTime(2000, 1, 3).AddHours(-12 * 4)
                };
                Assert.Equal(expected, actual);
            }
            {
                var actual = new DateTime(2000, 3, 1).DownTo(new DateTime(2000, 1, 1), (x) => x.AddMonths(-1)).ToList();
                var expected = new List<DateTime> {
                    new DateTime(2000, 3, 1),
                    new DateTime(2000, 2, 1),
                    new DateTime(2000, 1, 1),
                };
                Assert.Equal(expected, actual);
            }
        }
    }
}
