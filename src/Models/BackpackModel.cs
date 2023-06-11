using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace src.Models
{
    public class BackpackModel
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int CharacterId { get; set; }
        public CharacterModel? Character { get; set; }
    }
}