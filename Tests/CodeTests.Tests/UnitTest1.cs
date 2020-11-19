using System;
using Xunit;
using Code;

namespace CodeTests.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void AddTests()
        {   
            Assert.Equal(4, Code.Code.Add(2,2));
        }

        [Theory]
        [InlineData(3)]
        [InlineData(5)]
        [InlineData(9)]
        public void FirstTheory(int number)
        {
            Assert.True(Code.Code.isOdd(number));
        }

    }
}
