namespace StardewManager.Models
{
    public class Gift
    {
        public int Id { get; set; }
        public string ItemName { get; set; }
        public Category Category { get; set; }
        public string Description { get; set; }

    }
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Category> Categories { get; set;}
    }
}
