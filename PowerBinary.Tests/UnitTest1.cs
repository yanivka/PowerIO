using System;
using Xunit;
using Xunit.Abstractions;

namespace PowerBinary.Tests
{
    public class FirstTest
    {
        private readonly ITestOutputHelper output;

        public FirstTest(ITestOutputHelper output)
        {
            this.output = output;
        }

        [Fact]
        public void Test1()
        {
            this.output.WriteLine("This is running!");
            Assert.True(true);
        }
    }
}
