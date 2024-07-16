using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace RubyFlavor.Tests
{
    public class ObjectExtensionsTest
    {
        [Fact]
        public void TapTest()
        {
            {
                var actual = 1.Tap((x) => $"value: {x}");
                Assert.Equal(1, actual);
            }
            {
                var actual = 1.Tap((x) => x + 1);
                Assert.Equal(1, actual);
            }
            {
                var actual = 1.Tap((x) => { });
                Assert.Equal(1, actual);
            }
        }

        [Fact]
        public void YieldSelfTest()
        {
            {
                var actual = 1.YieldSelf((x) => $"value: {x}");
                Assert.Equal(1, actual);
            }
            {
                var actual = 1.YieldSelf((x) => x + 1);
                Assert.Equal(1, actual);
            }
            {
                var actual = 1.YieldSelf((x) => { });
                Assert.Equal(1, actual);
            }
        }
    }
}
