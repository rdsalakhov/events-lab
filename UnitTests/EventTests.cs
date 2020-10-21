using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab13;
using GoodsClassLibrary;

namespace UnitTests
{
    [TestClass]
    public class EventTest
    {
        [TestMethod]
        public void CollectionCountChangedEventTest()
        {
            var col1 = new MyNewCollection("FirstCol", 10);
            var journal = new Journal();
            col1.CollectionCountChanged += journal.OnCollectionCountChanged;
            col1.Remove(5);
            col1.AddRandom();
            col1.Add((Food)new Food().CreateRandom());
            Assert.IsTrue(journal.ToString().Contains("Удаление"));
            Assert.IsTrue(journal.ToString().Contains("Добавление"));
        }

        [TestMethod]
        public void CollectionReferenceChangedEventTest()
        {
            var col1 = new MyNewCollection("FirstCol", 10);
            var journal = new Journal();
            col1.CollectionReferenceChanged += journal.OnCollectionReferenceChanged;
            col1[5] = (Food)new Food().CreateRandom();
            Assert.IsTrue(journal.ToString().Contains("Изменена ссылка"));
        }

        [TestMethod]
        public void CollectionHandlerEventArgsToStringTest()
        {
            var food = new Food();
            var eventArgs = new CollectionHandlerEventArgs("Changed collection", "Changelog", food);
            var expected = $"Changed collection Changelog {food.GetName()}";
            Assert.AreEqual(expected, eventArgs.ToString());

        }
    }
}
