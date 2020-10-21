using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using GoodsClassLibrary;

namespace Lab13
{
    public class MyCollection : Collection<Food>
    {
        public int Length
        {
            get => Items.Count;
        }

        public MyCollection() : base()
        {
            
        }

        public MyCollection(int quantity)
        {
            
            for (int i = 0; i < quantity; i++)
            {
                Items.Add((Food)new Food().CreateRandom());
            }
        }

        public new void Clear()
        {
            Items.Clear();
        }

        public new void Add(Food newFoodItem)
        {
            Items.Add(newFoodItem);
        }

        public void AddRandom()
        {
            Items.Add((Food)new Food().CreateRandom());
        }

        public bool Remove(int index)
        {
            if (Items.Count <= index || index < 0) return false;
            else
            {
                Items.RemoveAt(index);
                return true;
            }
        }

        public void Sort(IComparer<Goods> comparer)
        {
            var tempList = Items.ToList();
            tempList.Sort(comparer);
            Items.Clear();
            foreach (var item in tempList)
            {
                Items.Add(item);
            }
        }
        
        public void Sort()
        {
            var tempList = Items.ToList();
            tempList.Sort();
            Items.Clear();
            foreach (var item in tempList)
            {
                Items.Add(item);
            }
            
        }


    }
}