using UpdatedChambersTailwindAndRazorPages.DNDModelsAndServices.Models;

namespace UpdatedChambersTailwindAndRazorPages.DNDModelsAndServices.Services
{
    public class Modifiers : IModifiers
	{
		public Character CalculateCharacterModifiers(Character character)
		{
			if (character.Charisma >= 10)
			{
				character.CharismaModifier = (character.Charisma - 10) / 2;
			}
			else
			{
				character.CharismaModifier = (character.Charisma - 10 - 1) / 2;
			}
			character.CharismaSavingThrow = character.ChaSavePoficiency ? character.CharismaModifier + character.ProficiencyBonus
																		: character.CharismaModifier;
			if (character.Constitution >= 10)
			{
				character.ConstitutionModifier = (character.Constitution - 10) / 2;
			}
			else
			{
				character.ConstitutionModifier = (character.Constitution - 10 - 1) / 2;
			}
			character.ConstitutionSavingThrow = character.ConSaveProficiency ? character.ConstitutionModifier + character.ProficiencyBonus
																		: character.ConstitutionModifier;
			if (character.Dexterity >= 10)
			{
				character.DexterityModifier = (character.Dexterity - 10) / 2;
			}
			else
			{
				character.DexterityModifier = (character.Dexterity - 10 - 1) / 2;
			}
			character.DexteritySavingThrow = character.DexSaveProficiency ? character.DexterityModifier + character.ProficiencyBonus
																		: character.DexterityModifier;
			if (character.Intelligence >= 10)
			{
				character.IntelligenceModifier = (character.Intelligence - 10) / 2;
			}
			else
			{
				character.IntelligenceModifier = (character.Intelligence - 10 - 1) / 2;
			}
			character.IntelligenceSavingThrow = character.IntSaveProficiency ? character.IntelligenceModifier + character.ProficiencyBonus
																		: character.IntelligenceModifier;
			if (character.Strength >= 10)
			{
				character.StrengthModifier = (character.Strength - 10) / 2;
			}
			else
			{
				character.StrengthModifier = (character.Strength - 10 - 1) / 2;
			}
			character.StrengthSavingThrow = character.StrSaveProficiency ? character.StrengthModifier + character.ProficiencyBonus
																		: character.StrengthModifier;
			if (character.Wisdom >= 10)
			{
				character.WisdomModifier = (character.Wisdom - 10) / 2;
			}
			else
			{
				character.WisdomModifier = (character.Wisdom - 10 - 1) / 2;
			}
			character.WisdomSavingThrow = character.WisSaveProficiency ? character.WisdomModifier + character.ProficiencyBonus
																		: character.WisdomModifier;
			return character;


		}
		public Character CreateChaCaster(Character character)
		{
			character.ChaSpellAttackBonus = character.CharismaModifier + character.ProficiencyBonus;
			character.ChaSpellSaveDC = character.CharismaModifier + character.ProficiencyBonus + 8;
			return character;
		}
		public Character CreateIntCaster(Character character)
		{
			character.IntSpellAttackBonus = character.IntelligenceModifier + character.ProficiencyBonus;
			character.IntSpellSaveDC = character.IntelligenceModifier + character.ProficiencyBonus + 8;
			return character;
		}
		public Character CreateWisCaster(Character character)
		{
			character.WisSpellAttackBonus = character.WisdomModifier + character.ProficiencyBonus;
			character.WisSpellSaveDC = character.WisdomModifier + character.ProficiencyBonus + 8;
			return character;

		}
		public Character CalculateStandardAttackBonuses(Character character)
		{
			character.DexterityAttackBonus = character.DexterityModifier + character.ProficiencyBonus;
			character.StrengthAttackBonus = character.StrengthModifier + character.ProficiencyBonus;
			character.StrengthWeaponDamageBonus = character.StrengthModifier;
			character.DexterityWeaponDamageBonus = character.DexterityModifier;
			return character;
		}
		
	}
}
