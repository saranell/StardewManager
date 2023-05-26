namespace StardewManager.Models
{
    public class ToDoItem
    {
        public string Task { get; set; }
        public int Id { get; set; }
        public bool IsCompleted { get; set; }
        //public List<Bundle> Bundles { get; set; }
    }

    /*public class Bundle
    {
        public string Name { get; set; }
        public string Item { get; set; }
    }*/
}
