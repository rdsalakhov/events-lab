using System;
using GoodsClassLibrary;

namespace Lab13
{
    public class CollectionHandlerEventArgs : EventArgs
    {
        public string ChangedCollection { get; set; }
        public string ChangeLog { get; set; }
        public Food ChangedItem { get; set; }

        public override string ToString()
        {
            return $"{ChangedCollection} {ChangeLog} {ChangedItem.GetName()}";
        }

        public CollectionHandlerEventArgs(string changedCollection, string changeLog, Food changedItem)
        {
            this.ChangedCollection = changedCollection;
            this.ChangeLog = changeLog;
            this.ChangedItem = changedItem;
        }
    }
}