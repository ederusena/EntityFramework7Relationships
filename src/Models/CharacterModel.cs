using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace src.Models
{
    public class CharacterModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public BackpackModel Backpack { get; set; }
        public List<WeaponModel> Weapons { get; set; }
        public List<FactionModel> Factions { get; set; }
    }
}