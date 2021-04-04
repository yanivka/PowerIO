using NUnit.Framework;
using System;

namespace PowerIO.Tests
{
   
    class DemoTest
    {

        [Test]
        public void FirstTest()
        {
            

            Console.WriteLine("Can you see the current string");
            Assert.Pass("Passed first test successfully.");
        }
    }
}
