using System.Security.Cryptography.X509Certificates;
using UpdatedChambersTailwindAndRazorPages.DNDModelsAndServices.Models;

namespace UpdatedChambersTailwindAndRazorPages.DNDModelsAndServices.Services
{
    public class SpeciesSelection : ISpeciesSelection
	{
		public Character BaseStatsForCharacterGeneration(Character character)
		{
			if (character.DndClass == CharacterClassSelection.ClassSelection.Warlock || character.DndClass == CharacterClassSelection.ClassSelection.Sorcerer || character.DndClass == CharacterClassSelection.ClassSelection.Bard)
			{
				character.Charisma += 2;
				character.Constitution += 1;
			}
			else if (character.DndClass == CharacterClassSelection.ClassSelection.Paladin)
			{
				character.Charisma += 2;
				character.Strength += 1;

			}
			else if (character.DndClass == CharacterClassSelection.ClassSelection.Wizard || character.DndClass == CharacterClassSelection.ClassSelection.Artificer)
			{
				character.Intelligence += 2;
				character.Constitution += 1;

			}
			else if (character.DndClass == CharacterClassSelection.ClassSelection.Druid || character.DndClass == CharacterClassSelection.ClassSelection.Cleric)
			{
				character.Wisdom += 2;
				character.Constitution += 1;

			}
			else if (character.DndClass == CharacterClassSelection.ClassSelection.Ranger)
			{
				character.Wisdom += 2;
				character.Dexterity += 1;
			}
			else if (character.DndClass == CharacterClassSelection.ClassSelection.Rogue || (character.DndClass == CharacterClassSelection.ClassSelection.Fighter && character.Dexterity > character.Strength))
			{
				character.Dexterity += 2;
				character.DexterityModifier += 1;
			}
			else if (character.DndClass == CharacterClassSelection.ClassSelection.Barbarian || (character.DndClass == CharacterClassSelection.ClassSelection.Fighter && character.Dexterity <= character.Strength))
			{
				character.Strength += 2;
				character.Constitution += 1;
			}
			else if (character.DndClass == CharacterClassSelection.ClassSelection.Monk)
			{
				character.Dexterity += 2;
				character.Wisdom += 1;
			}
			else
			{
				return null;
			}
			return character;
		}
		public Character NameAndSelectSpecies(Character character, string species)
		{
			character = BaseStatsForCharacterGeneration(character);
			switch (species.ToLower())
			{
				case "vhuman":
				case "variant human":
					character.Name = "Roland Webb";
					character.Species = "Variant Human";
					if (character.DndClass == CharacterClassSelection.ClassSelection.Warlock || character.DndClass == CharacterClassSelection.ClassSelection.Sorcerer || character.DndClass == CharacterClassSelection.ClassSelection.Bard)
					{
						character.FeyTouchedFeat = true;
						character.PersuasionProf = true;

					}
					else if (character.DndClass == CharacterClassSelection.ClassSelection.Paladin)
					{
						character.FeyTouchedFeat = true;
						character.AthleticsProf = true;

					}
					else if (character.DndClass == CharacterClassSelection.ClassSelection.Wizard || character.DndClass == CharacterClassSelection.ClassSelection.Artificer)
					{
						character.FeyTouchedFeat = true;
						character.HistoryProf = true;

					}
					else if (character.DndClass == CharacterClassSelection.ClassSelection.Druid || character.DndClass == CharacterClassSelection.ClassSelection.Cleric)
					{
						character.FeyTouchedFeat = true;
						if (character.PerceptionProf == false)
						{
							character.PerceptionProf = true;
						}
						else
						{
							character.SurvivalProf = true;
						}

					}
					else if (character.DndClass == CharacterClassSelection.ClassSelection.Ranger)
					{
						character.FeyTouchedFeat = true;
						character.SleightofHandProf = true;
					}
					else if (character.DndClass == CharacterClassSelection.ClassSelection.Rogue || (character.DndClass == CharacterClassSelection.ClassSelection.Fighter && character.Dexterity > character.Strength))
					{
						if (character.StealthProf == false)
						{
							character.StealthProf = true;
						}
						else
						{
							character.InvestigationProf = true;
						}
						character.PiercerFeat = true;
					}
					else if (character.DndClass == CharacterClassSelection.ClassSelection.Barbarian || (character.DndClass == CharacterClassSelection.ClassSelection.Fighter && character.Dexterity <= character.Strength))
					{
						character.StealthProf = true;
						character.SlasherFeat = true;
					}
					else if (character.DndClass == CharacterClassSelection.ClassSelection.Monk)
					{
						character.PerceptionProf = true;
						character.CrusherFeat = true;
					}
					else
					{
						return null;
					}
					return character;
				case "high elf":
				case "highelf":
					character.Species = "High Elf";
					character.Name = "Sylcan Oakstar";
					return character;
				case "hill dwarf":
				case "dwarfhill":
				case "hilldwarf":
					character.Name = "Thorgrun Mighttankard";
					character.Species = "Hill Dwarf";
					return character;
				case "warforged":
					character.Name = "Clunker";
					character.Species = "Warforged";
					return character;
				default:
					return null;
			}
		}

	}
}
