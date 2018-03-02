using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AppTests
{
    [TestClass]
    public class MainTests
    {
        [TestMethod]
        public void Hello_not_equal_world()
        {
            string s1 = "hello";
            string s2 = "world";

            Console.WriteLine("This is some StdOut output!");

            Assert.AreNotEqual(s1, s2);
        }
    }
}
