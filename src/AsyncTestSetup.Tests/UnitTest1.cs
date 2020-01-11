using System;
using Xunit;

namespace AsyncTestSetup.Tests
{
    public class UnitTest1 : IClassFixture<TestFixture>
    {
        private readonly TestFixture _testFixture;

        public UnitTest1(TestFixture testFixture)
        {
            _testFixture = testFixture;
        }

        [Fact]
        public void Test1()
        {
            // Arrange
            var expected = "Async init successful";

            Assert.Equal(expected, _testFixture.HeaderText);
        }
    }
}
