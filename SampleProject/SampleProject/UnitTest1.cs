using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SampleProject
{
    [TestClass]
    public class PrintData
    {
        [TestMethod]
        public void printFirst()
        {
            Console.WriteLine("This is a print command");
        }
    }
}
