namespace Lab13
{
    public class JournalEntry
    {
        public string CollectionName { get; set; }
        public string ChangeLog { get; set; }
        public string ChangedItemData { get; set; }

        public override string ToString()
        {
            return $"{CollectionName}, {ChangeLog}, {ChangedItemData}";
        }

        public JournalEntry(string collectionName, string changeLog, string changedItemData)
        {
            this.ChangeLog = changeLog;
            this.CollectionName = collectionName;
            this.ChangedItemData = changedItemData;
        }
    }
}