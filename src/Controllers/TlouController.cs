using src.Data;
using src.DTOs;
using src.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace src.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TlouController : ControllerBase
    {
        private readonly DataContext _context;

        public TlouController(DataContext context)
        {
            _context = context;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<CharacterModel>> GetCharacterById(int id)
        {
            var character = await _context.Characters
                .Include(c => c.Backpack)
                .Include(c => c.Weapons)
                .Include(c => c.Factions)
                .FirstOrDefaultAsync(c => c.Id == id);

            return Ok(character);
        }

        [HttpPost]
        public async Task<ActionResult<List<CharacterModel>>> CreateCharacter(CharacterCreateDto request)
        {
            var newCharacter = new CharacterModel
            {
                Name = request.Name,
            };

            var backpack = new BackpackModel { Description = request.Backpack.Description, Character = newCharacter };
            var weapons = request.Weapons.Select(w => new WeaponModel { Name = w.Name, Character = newCharacter }).ToList();
            var factions = request.Factions.Select(f => new FactionModel { Name = f.Name, Characters = new List<CharacterModel> { newCharacter } }).ToList();

            newCharacter.Backpack = backpack;
            newCharacter.Weapons = weapons;
            newCharacter.Factions = factions;

            _context.Characters.Add(newCharacter);
            await _context.SaveChangesAsync();

            return Ok(await _context.Characters.Include(c => c.Backpack).Include(c => c.Weapons).ToListAsync());
        }
    }
}
