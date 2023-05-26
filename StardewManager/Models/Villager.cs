namespace StardewManager.Models
{
    public class Villager
    {
        public string Name { get; set; }
        public int Id { get; set; } 
        public string Description { get; set; }
        public string Birthday { get; set; }
        public List<Gift> Loves { get; set; }
        public List<Gift> Likes { get; set; }
        public List<Gift> Neutral { get; set; }
        public List<Gift> Dislikes { get; set; }
        public List<Gift> Hates { get; set; }

    }
}
