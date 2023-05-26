using Microsoft.AspNetCore.Mvc;

namespace StardewManager.Models
{
    public class Farm
    {
        public string? Name { get; set; }
        public int Id { get; set; }
        public List<ToDoItem> ToDos { get; set; }
        public List<Villager> Villagers { get; set; }
        
        public Farm() 
        { 
        }

        public Farm(string name, List<ToDoItem> toDos, List<Villager> villagers)
        {
            Name = name;
            ToDos = toDos;
            Villagers = villagers;
            
        }
    }
}