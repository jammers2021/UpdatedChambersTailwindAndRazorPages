namespace UpdatedChambersTailwindAndRazorPages.DNDModelsAndServices.Models
{
    public interface IModifiers
    {
        Character CalculateCharacterModifiers(Character character);
        Character CreateChaCaster(Character character);
        Character CreateIntCaster(Character character);
        Character CalculateStandardAttackBonuses(Character character);

        Character CreateWisCaster(Character character);
    }
}