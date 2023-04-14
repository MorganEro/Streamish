using System;
using Xunit;

namespace Streamish.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Two_Numbers_Should_Equal()
        {
            var num1 = 100;
            var num2 = 100;

            Assert.Equal(num1, num2);
        }
    }
}