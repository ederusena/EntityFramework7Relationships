using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace src.Models
{
    public class WeaponModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CharacterId { get; set; }
        public CharacterModel? Character { get; set; }
    }
}