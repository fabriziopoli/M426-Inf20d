using System;
using Xunit;

namespace FooBarQix.Tests
{
    public class FooBarQixDeterminerTest
    {
        [Fact]
        public void Determine_DividedByInput()
        {
            int a = 15;
            string expected = "FooBar";

            FooBarQixDeterminer fooBarQixDeterminer = new FooBarQixDeterminer();

            string actual = fooBarQixDeterminer.Determine(a);
            Assert.Equal(expected, actual);
        }
    }
}