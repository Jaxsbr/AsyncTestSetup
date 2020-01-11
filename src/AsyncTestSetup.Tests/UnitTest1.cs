using System;
using Xunit;

namespace AsyncTestSetup.Tests
{
    public class UnitTest1 : TestFixture
    {        
        public UnitTest1()
            : base (TestFixture.Init, "Async init successful")
        {            
        }

        [Fact]
        public void Test1()
        {
            // Arrange
            var expected = "Async init successful";

            Assert.Equal(expected, HeaderText);
        }
    }
}
