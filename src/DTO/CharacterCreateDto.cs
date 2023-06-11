namespace src.DTOs
{
    public record struct CharacterCreateDto(
        string Name, 
        BackpackCreateDto Backpack,
        List<WeaponCreateDto> Weapons,
        List<FactionCreateDto> Factions);
}
