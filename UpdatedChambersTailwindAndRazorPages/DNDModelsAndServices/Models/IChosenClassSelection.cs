namespace UpdatedChambersTailwindAndRazorPages.DNDModelsAndServices.Models
{
    public interface IChosenClassSelection
    {
        CharacterClassSelection.ClassSelection SelectClass(string className);
    }
}