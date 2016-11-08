using Microsoft.VisualStudio.TestTools.UnitTesting;
using Project;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Tests
{
    [TestClass()]
    public class MyFirstSortedBagTests
    {
        private MyFirstSortedBag bag = new MyFirstSortedBag();
        private static List<int> list = new List<int>();

        [TestMethod()]
        public void AddTest()
        {
            list.Add(bag.Add(1));
            list.Add(bag.Add(2));
            list.Add(bag.Add(3));
            Assert.AreEqual(3, list.Count);
        }

        [TestMethod()]
        public void GetTest()
        {
            //removes 1 and checks if 2 is now smallest number
            list.Remove(bag.Peek);
            Assert.AreEqual(2, list.Min());
        }

        [TestMethod()]
        public void PeekTest()
        {
            Assert.AreEqual(2, list.Min());
        }

        [TestMethod()]
        public void CountTest()

        {
            Assert.AreEqual(2,list.Count);
        }
    }
}