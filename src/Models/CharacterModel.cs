using src.Models;

namespace src.Models
{
    public class CharacterModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
    	// public int BackpackId { get; set; }
        public BackpackModel Backpack { get; set; }
    }
}