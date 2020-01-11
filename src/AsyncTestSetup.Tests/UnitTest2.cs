using System;
using Xunit;

namespace AsyncTestSetup.Tests
{
    public class UnitTest2 : TestFixture
    {
        public UnitTest2()
            : base (TestFixture.Init, "Async init unsuccessful")
        {
        }

        [Fact]
        public void Test1()
        {
            // Arrange
            var expected = "Async init unsuccessful";

            Assert.Equal(expected, HeaderText);
        }
    }
}
