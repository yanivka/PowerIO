using NUnit.Framework;
using System;

namespace PowerIO.Tests
{
   
    class DemoTest
    {

        [Test]
        public void FirstTest()
        {

            Console.WriteLine("yes");
            Assert.Pass("Passed first test successfully.");
        }
    }
}
