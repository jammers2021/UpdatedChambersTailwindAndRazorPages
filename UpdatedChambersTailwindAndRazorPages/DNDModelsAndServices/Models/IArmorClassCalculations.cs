namespace UpdatedChambersTailwindAndRazorPages.DNDModelsAndServices.Models
{
    public interface IArmorClassCalculations
    {
        Character CalculateArmorClassBarbarianUnarmored(Character character);
        Character CalculateArmorClassWithStuddedLeatherLightArmorAndShield(Character character);
        Character CalculateArmorClassWithLeatherLightArmorAndShield(Character character);
		Character CalculateArmorClassBarbarianUnarmoredWithShield(Character character);
        Character CalculateArmorClassMonkUnarmoredDefense(Character character);
		Character CalculateArmorClassWithBreastPlateAndShieldMediumArmor(Character character);
        Character CalculateArmorClassWithBreastPlateNoShieldMediumArmor(Character character);
        Character CalculateArmorClassWithChainMailAndShieldHeavyArmor(Character character);
        Character CalculateArmorClassWithChainMailNoShieldHeavyArmor(Character character);
        Character CalculateArmorClassWithHalfPlateAndShieldMediumArmor(Character character);
        Character CalculateArmorClassWithHalfPlateNoShieldMediumArmor(Character character);
        Character CalculateArmorClassWithLeatherLightArmor(Character character);
        Character CalculateArmorClassWithMageArmor(Character character);
        Character CalculateArmorClassWithNoArmor(Character character);
        Character CalculateArmorClassWithPlateAndShieldHeavyArmor(Character character);
        Character CalculateArmorClassWithPlateNoShieldHeavyArmor(Character character);
        Character CalculateArmorClassWithScaleMailAndShieldMediumArmor(Character character);
        Character CalculateArmorClassWithScaleMailNoShieldMediumArmor(Character character);
        Character CalculateArmorClassWithSplintAndShieldHeavyArmor(Character character);
        Character CalculateArmorClassWithSplintNoShieldHeavyArmor(Character character);
        Character CalculateArmorClassWithStuddedLeatherLightArmor(Character character);
    }
}