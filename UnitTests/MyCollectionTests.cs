using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab13;
using GoodsClassLibrary;

namespace UnitTests
{
    [TestClass]
    public class MyCollectionTests
    {
        [TestMethod]
        public void ConstructorTest()
        {
            var col = new MyCollection(10);
            var col2 = new MyCollection();
            Assert.AreEqual(10, col.Count);
            Assert.AreEqual(0, col2.Count);
        }

        [TestMethod]
        public void ClearTest()
        {
            var col = new MyCollection(10);
            col.Clear();
            Assert.AreEqual(0, col.Length);
        }

        [TestMethod]
        public void AddTest()
        {
            var col = new MyCollection(10);
            col.Add((Food)new Food().CreateRandom());
            Assert.AreEqual(11, col.Count);
        }

        [TestMethod]
        public void AddRandomTest()
        {
            var col = new MyCollection(10);
            col.AddRandom();
            Assert.AreEqual(11, col.Count);
        }

        [TestMethod]
        public void RemoveTest()
        {
            var col = new MyCollection(10);
            col.Remove(0);
            Assert.AreEqual(9, col.Count);
        }

        [TestMethod]
        public void RemoveErrorTest()
        {
            var col = new MyCollection(10);
            try
            {
                col.Remove(10);
                Assert.Fail();

            }
            catch
            {
            }
        }

        [TestMethod]
        public void DefaultSortTest()
        {
            var col = new MyCollection(10);
            col.Sort();
            
            Assert.AreEqual(-1, col[0].Name.CompareTo(col[9].Name));
        }

        [TestMethod]
        public void ComparatorSortTest()
        {
            var col = new MyCollection(10);
            col.Sort(new PriceComparer());
            Assert.AreEqual(-1, col[0].Price.CompareTo(col[9].Price));
        }
    }
}
