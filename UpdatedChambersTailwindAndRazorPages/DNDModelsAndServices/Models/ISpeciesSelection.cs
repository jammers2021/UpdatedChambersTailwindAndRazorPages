namespace UpdatedChambersTailwindAndRazorPages.DNDModelsAndServices.Models
{
    public interface ISpeciesSelection
    {
        Character BaseStatsForCharacterGeneration(Character character);
        Character NameAndSelectSpecies(Character character, string species);
    }
}