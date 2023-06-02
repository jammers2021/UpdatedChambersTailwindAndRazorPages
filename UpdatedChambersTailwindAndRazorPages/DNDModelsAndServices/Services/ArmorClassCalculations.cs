using UpdatedChambersTailwindAndRazorPages.DNDModelsAndServices.Models;

namespace UpdatedChambersTailwindAndRazorPages.DNDModelsAndServices.Services
{
    public class ArmorClassCalculations : IArmorClassCalculations
	{
		public Character CalculateArmorClassBarbarianUnarmored(Character character)
		{
			character.ArmorClass = 10 + character.ConstitutionModifier + character.DexterityModifier;
			return character;
		}
		public Character CalculateArmorClassBarbarianUnarmoredWithShield(Character character)
		{
			character.ArmorClass = 10 + character.ConstitutionModifier + character.DexterityModifier +2;
			return character;
		}
		public Character CalculateArmorClassMonkUnarmoredDefense(Character character)
		{
			
			character.ArmorClass = 10 + character.WisdomModifier + character.DexterityModifier + 2;
			return character;
		}
		public Character CalculateArmorClassWithNoArmor(Character character)
		{
			character.ArmorClass = 10 + character.DexterityModifier;
			return character;
		}
		public Character CalculateArmorClassWithMageArmor(Character character)
		{
			character.ArmorClass = 13 + character.DexterityModifier;
			return character;
		}
		public Character CalculateArmorClassWithLeatherLightArmor(Character character)
		{
			character.ArmorClass = 11 + character.DexterityModifier;
			return character;
		}
		public Character CalculateArmorClassWithLeatherLightArmorAndShield(Character character)
		{
			character.ArmorClass = 11 + character.DexterityModifier + 2;
			return character;
		}
		public Character CalculateArmorClassWithStuddedLeatherLightArmor(Character character)
		{
			character.ArmorClass = 12 + character.DexterityModifier;
			return character;
		}
		public Character CalculateArmorClassWithStuddedLeatherLightArmorAndShield(Character character)
		{
			character.ArmorClass = 12 + character.DexterityModifier +2;
			return character;
		}
		public Character CalculateArmorClassWithScaleMailAndShieldMediumArmor(Character character)
		{
			if (character.Dexterity > 14)
			{
				character.ArmorClass = 14 + 2 + 2;
			}
			else
			{
				character.ArmorClass=14+ character.DexterityModifier + 2;
			}
			character.SteathDisadvantage = true;
			return character;
		}
		public Character CalculateArmorClassWithScaleMailNoShieldMediumArmor(Character character)
		{
			if (character.Dexterity > 14)
			{
				character.ArmorClass = 14 + 2;
			}
			else
			{
				character.ArmorClass = 14 + character.DexterityModifier;
			}
			character.SteathDisadvantage = true;
			return character;
		}
		public Character CalculateArmorClassWithBreastPlateAndShieldMediumArmor(Character character)
		{
			if (character.Dexterity > 14)
			{
				character.ArmorClass = 14 + 2 + 2;
			}
			else
			{
				character.ArmorClass = 14 + character.DexterityModifier + 2;
			}
			character.SteathDisadvantage = false;
			return character;
		}
		public Character CalculateArmorClassWithBreastPlateNoShieldMediumArmor(Character character)
		{

			if (character.Dexterity > 14)
			{
				character.ArmorClass = 14 + 2;
			}
			else
			{
				character.ArmorClass = 14 + character.DexterityModifier;
			}
			character.SteathDisadvantage = false;
			return character;
		}
		public Character CalculateArmorClassWithHalfPlateAndShieldMediumArmor(Character character)
		{

			if (character.Dexterity > 14)
			{
				character.ArmorClass = 15 + 2 + 2;
			}
			else
			{
				character.ArmorClass = 15 + character.DexterityModifier + 2;
			}
			character.SteathDisadvantage = true;
			return character;
		}
		public Character CalculateArmorClassWithHalfPlateNoShieldMediumArmor(Character character)
		{
			if (character.Dexterity > 14)
			{
				character.ArmorClass = 15 + 2;
			}
			else
			{
				character.ArmorClass = 15 + character.DexterityModifier;
			}
			character.SteathDisadvantage = true;
			return character;
		}
		public Character CalculateArmorClassWithChainMailAndShieldHeavyArmor(Character character)
		{
			character.ArmorClass = 18;
			character.SteathDisadvantage = true;
			return character;
		}
		public Character CalculateArmorClassWithChainMailNoShieldHeavyArmor(Character character)
		{
			character.ArmorClass = 16;
			character.SteathDisadvantage = true;
			return character;
		}
		public Character CalculateArmorClassWithSplintNoShieldHeavyArmor(Character character)
		{
			character.ArmorClass = 17;
			character.SteathDisadvantage = true;
			return character;
		}
		public Character CalculateArmorClassWithSplintAndShieldHeavyArmor(Character character)
		{
			character.ArmorClass = 19;
			character.SteathDisadvantage = true;
			return character;
		}
		public Character CalculateArmorClassWithPlateNoShieldHeavyArmor(Character character)
		{
			character.ArmorClass = 18;
			character.SteathDisadvantage = true;
			return character;
		}
		public Character CalculateArmorClassWithPlateAndShieldHeavyArmor(Character character)
		{
			character.ArmorClass = 20;
			character.SteathDisadvantage = true;
			return character;
		}
	}
}
