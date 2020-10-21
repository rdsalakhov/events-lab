using System.Linq;
using GoodsClassLibrary;

namespace Lab13
{
    public class MyNewCollection : MyCollection
    {
        public delegate void CollectionHandler(object source, CollectionHandlerEventArgs args);
        public string Name { get; set; }
              
        public event CollectionHandler CollectionCountChanged;
        
        public event CollectionHandler CollectionReferenceChanged;
        
        public MyNewCollection(string name, int quantity)
        {
            this.Name = name;
            for (int i = 0; i < quantity; i++)
            {
                Items.Add((Food)new Food().CreateRandom());
            }
        }
        
        public new void Add(Food newFoodItem)
        {
            Items.Add(newFoodItem);
            if (CollectionCountChanged != null) 
                CollectionCountChanged(this, new CollectionHandlerEventArgs(Name, "Добавление", newFoodItem));
        }

        public new void AddRandom()
        {
            var randomFoodItem = (Food) new Food().CreateRandom();
            Items.Add(randomFoodItem); 
            if (CollectionCountChanged != null) 
                CollectionCountChanged(this, new CollectionHandlerEventArgs(Name, "Добавление", randomFoodItem));
        }
        
        public new bool Remove(int index)
        {
            if (Items.Count <= index || index < 0) return false;
            else
            {
                if (CollectionCountChanged != null) 
                    CollectionCountChanged(this, new CollectionHandlerEventArgs(Name, "Удаление", Items[index]));
                Items.RemoveAt(index);
                return true;
            }
        }

        public new Food this[int index]
        {
            get => Items[index];
            set
            {
                Items[index] = value;
                if (CollectionReferenceChanged != null) 
                    CollectionReferenceChanged(this, new CollectionHandlerEventArgs(Name, "Изменена ссылка", Items[index]));
            }
        }
    }
}