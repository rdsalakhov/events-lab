using System.Collections.Generic;

namespace Lab13
{
    public class Journal
    {
        private List<JournalEntry> _entries = new List<JournalEntry>();

        public void OnCollectionCountChanged(object source, CollectionHandlerEventArgs args)
        {
            _entries.Add(new JournalEntry(args.ChangedCollection, args.ChangeLog, args.ChangedItem.GetName()));
        }
        
        public void OnCollectionReferenceChanged(object source, CollectionHandlerEventArgs args)
        {
            _entries.Add(new JournalEntry(args.ChangedCollection, args.ChangeLog, args.ChangedItem.GetName()));
        }

        public override string ToString()
        {
            string str = "";
            foreach (var entry in _entries)
            {
                str += entry;
                str += "\n";
            }
            return str;
        }
    }
}