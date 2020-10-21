using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab13;
using GoodsClassLibrary;

namespace UnitTests
{
    [TestClass]
    public class MMyNewCollectionTests
    {
        [TestMethod]
        public void ConstructorTest()
        {
            var col = new MyNewCollection("TestCollection", 10);
            Assert.AreEqual(10, col.Count);
        }

        [TestMethod]
        public void NameTest()
        {
            var col = new MyNewCollection("TestCollection", 10);
            Assert.AreEqual("TestCollection", col.Name);
        }       

        [TestMethod]
        public void AddTest()
        {
            var col = new MyNewCollection("TestCollection", 10);
            col.Add((Food)new Food().CreateRandom());
            Assert.AreEqual(11, col.Count);
        }

        [TestMethod]
        public void AddRandomTest()
        {
            var col = new MyNewCollection("TestCollection", 10);
            col.AddRandom();
            Assert.AreEqual(11, col.Count);
        }

        [TestMethod]
        public void RemoveTest()
        {
            var col = new MyNewCollection("TestCollection", 10);
            col.Remove(0);
            Assert.AreEqual(9, col.Count);
        }

        [TestMethod]
        public void RemoveErrorTest()
        {
            var col = new MyNewCollection("TestCollection", 10);
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
        public void IndexGetTest()
        {
            var col = new MyNewCollection("TestCollection", 10);
            Food testItem = (Food)new Food().CreateRandom();
            col.Add(testItem);
            Assert.AreEqual(testItem, col[10]);
        }

        [TestMethod]
        public void IndexSetTest()
        {
            var col = new MyNewCollection("TestCollection", 10);
            Food testItem = (Food)new Food().CreateRandom();
            col[0] = testItem;
            Assert.AreEqual(testItem, col[0]);
        }
    }
}
