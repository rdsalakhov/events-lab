using System;
using System.Collections.ObjectModel;
using GoodsClassLibrary;

namespace Lab13
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var col1 = new MyNewCollection("FirstCol",10);
            var col2 = new MyNewCollection("SecondCol",10);
            
            var journal1 = new Journal();

            col1.CollectionCountChanged += journal1.OnCollectionCountChanged;
            col1.CollectionReferenceChanged += journal1.OnCollectionReferenceChanged;
            
            var journal2 = new Journal();
            col1.CollectionReferenceChanged += journal2.OnCollectionReferenceChanged;
            col2.CollectionReferenceChanged += journal2.OnCollectionReferenceChanged;
            
            col1[5] = (Food)new Food().CreateRandom();
            col1.Remove(5);
            col1.AddRandom();
            Console.WriteLine(journal1);
            col2.Add((Food)new Food().CreateRandom());
            col2[0] = (Food)new Food().CreateRandom();
            Console.WriteLine(journal2);
        }
    }
}