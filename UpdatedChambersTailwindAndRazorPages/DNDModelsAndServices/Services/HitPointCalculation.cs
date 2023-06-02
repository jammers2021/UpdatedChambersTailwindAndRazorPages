using UpdatedChambersTailwindAndRazorPages.DNDModelsAndServices.Models;

namespace UpdatedChambersTailwindAndRazorPages.DNDModelsAndServices.Services
{
    public class HitPointCalculation : IHitPointCalculation
	{
		public Character CalculateHitPoints(Character character)
		{
			if (character.DndClass == CharacterClassSelection.ClassSelection.Wizard || character.DndClass == CharacterClassSelection.ClassSelection.Sorcerer)
			{
				if (character.ConstitutionModifier > -4)
				{
					character.HitPoints = 6 + character.ConstitutionModifier + 4 * (character.Level - 1) + character.ConstitutionModifier * (character.Level - 1);
				}
			}
			else if (character.DndClass == CharacterClassSelection.ClassSelection.Artificer || character.DndClass == CharacterClassSelection.ClassSelection.Bard
				|| character.DndClass == CharacterClassSelection.ClassSelection.Cleric || character.DndClass == CharacterClassSelection.ClassSelection.Druid
				|| character.DndClass == CharacterClassSelection.ClassSelection.Monk || character.DndClass == CharacterClassSelection.ClassSelection.Rogue
				|| character.DndClass == CharacterClassSelection.ClassSelection.Warlock)
			{
				if (character.ConstitutionModifier > -5)
				{
					character.HitPoints = 8 + character.ConstitutionModifier + 5 * (character.Level - 1) + character.ConstitutionModifier * (character.Level - 1);
				}
			}

			else if (character.DndClass == CharacterClassSelection.ClassSelection.Fighter || character.DndClass == CharacterClassSelection.ClassSelection.Paladin
				|| character.DndClass == CharacterClassSelection.ClassSelection.Ranger)
			{
				character.HitPoints = 10 + character.ConstitutionModifier + 6 * (character.Level - 1) + character.ConstitutionModifier * (character.Level - 1);
			}
			else if (character.DndClass == CharacterClassSelection.ClassSelection.Barbarian)
			{
				character.HitPoints = 12 + character.ConstitutionModifier + 7 * (character.Level - 1) + character.ConstitutionModifier * (character.Level - 1);
			}
			if (character.Species == "Hill Dwarf")
			{
				character.HitPoints = character.HitPoints + 1 * character.Level;
			}
			return character;

		}
	}
}
