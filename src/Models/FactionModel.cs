using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace src.Models
{
    public class FactionModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [JsonIgnore]
        public List<CharacterModel> Characters { get; set; }
    }
}