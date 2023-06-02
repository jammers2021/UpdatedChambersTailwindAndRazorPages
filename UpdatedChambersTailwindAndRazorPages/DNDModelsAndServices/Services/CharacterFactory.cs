using static UpdatedChambersTailwindAndRazorPages.DNDModelsAndServices.Models.CharacterClassSelection;

namespace UpdatedChambersTailwindAndRazorPages.DNDModelsAndServices.Models;




public class CharacterFactory : ICharacterFactory
{
    private IArmorClassCalculations _armorClassCalculations;
	private IModifiers _modifiers;
	private IHitPointCalculation _hitPointCalculation;
	private ISpeciesSelection _speciesSelection;
	public CharacterFactory(IArmorClassCalculations armorClassCalculations, IModifiers modifiers, IHitPointCalculation hitPointCalculation, ISpeciesSelection speciesSelection)
    {
        _armorClassCalculations = armorClassCalculations;
		_modifiers = modifiers;
		_hitPointCalculation = hitPointCalculation;
		_speciesSelection = speciesSelection;
    }
    public Character CreateCharacter(ClassSelection classState, int classVariant, string species, List<int> stats)
	{


		switch (classState)
		{
			case ClassSelection.Artificer:
				var myCharacter = new Character
				{

					DndClass = classState,
					Charisma = stats[1],
					Constitution = stats[3],
					Dexterity = stats[4],
					Intelligence = stats[5],
					Strength = stats[0],
					Wisdom = stats[2],
					ConSaveProficiency = true,
					IntSaveProficiency = true,
					ArcanaProf = true,
					InvestigationProf = true,
				};
				myCharacter = _modifiers.CalculateCharacterModifiers(myCharacter);
				myCharacter = _speciesSelection.NameAndSelectSpecies(myCharacter, species);
				myCharacter = _modifiers.CalculateCharacterModifiers(myCharacter);
				myCharacter = _hitPointCalculation.CalculateHitPoints(myCharacter);
				myCharacter = _modifiers.CreateIntCaster(myCharacter);
				myCharacter =_modifiers.CalculateStandardAttackBonuses(myCharacter);
				myCharacter = _armorClassCalculations.CalculateArmorClassWithScaleMailAndShieldMediumArmor(myCharacter);
				if (myCharacter.Species == "Warforged")
				{
					myCharacter.ArmorClass += 1;
				}
				return myCharacter;


			case ClassSelection.Barbarian:
				myCharacter = new Character
				{
					DndClass = classState,
					Charisma = stats[0],
					Constitution = stats[4],
					Dexterity = stats[3],
					Intelligence = stats[1],
					Strength = stats[5],
					Wisdom = stats[2],
					ConSaveProficiency = true,
					StrSaveProficiency=true,
					AthleticsProf = true,
					IntimidationProf = true,
				};
				myCharacter = _modifiers.CalculateCharacterModifiers(myCharacter);
				myCharacter = _speciesSelection.NameAndSelectSpecies(myCharacter, species);
				myCharacter = _modifiers.CalculateCharacterModifiers(myCharacter);
				myCharacter = _modifiers.CalculateStandardAttackBonuses(myCharacter);
				myCharacter = _armorClassCalculations.CalculateArmorClassBarbarianUnarmored(myCharacter);
				return myCharacter;

			case ClassSelection.Bard:
				myCharacter = new Character
				{
					DndClass = classState,
					Charisma = stats[5],
					Constitution = stats[4],
					Dexterity = stats[3],
					Intelligence = stats[1],
					Strength = stats[0],
					Wisdom = stats[2],
					ChaSavePoficiency = true,
					DexSaveProficiency = true,
					PerceptionProf = true,
					StealthProf = true,
					PerformanceProf = true,
				};
				myCharacter = _modifiers.CalculateCharacterModifiers(myCharacter);
				myCharacter = _speciesSelection.NameAndSelectSpecies(myCharacter, species);
				myCharacter = _modifiers.CalculateCharacterModifiers(myCharacter);
				myCharacter = _modifiers.CalculateStandardAttackBonuses(myCharacter);
				myCharacter = _modifiers.CreateChaCaster(myCharacter);
				myCharacter = _armorClassCalculations.CalculateArmorClassWithLeatherLightArmor(myCharacter);
				if(myCharacter.Species=="Warforged")
				{
					myCharacter.ArmorClass += 1;
				}
				return myCharacter;

			case ClassSelection.Cleric:
				myCharacter = new Character
				{

					DndClass = classState,
					Charisma = stats[0],
					Constitution = stats[3],
					Dexterity = stats[1],
					Intelligence = stats[2],
					Strength = stats[4],
					Wisdom = stats[5],
					ChaSavePoficiency = true,
					WisSaveProficiency = true,
					InsightProf = true,
					ReligionProf = true,
				};
				myCharacter = _modifiers.CalculateCharacterModifiers(myCharacter);
				myCharacter = _speciesSelection.NameAndSelectSpecies(myCharacter, species);
				myCharacter = _modifiers.CalculateCharacterModifiers(myCharacter);
				myCharacter = _modifiers.CalculateStandardAttackBonuses(myCharacter);
				myCharacter = _modifiers.CreateWisCaster(myCharacter);
				myCharacter = _armorClassCalculations.CalculateArmorClassWithChainMailAndShieldHeavyArmor(myCharacter);
				myCharacter.Subclass = "Forge Cleric";
				if (myCharacter.Subclass == "Forge Cleric")
				{
					myCharacter.ArmorClass += 1;
				}
				if (myCharacter.Species == "Warforged")
				{
					myCharacter.ArmorClass += 1;
				}
				return myCharacter;

			case ClassSelection.Druid:
				myCharacter = new Character
				{
					DndClass = classState,
					Charisma = stats[2],
					Constitution = stats[4],
					Dexterity = stats[1],
					Intelligence = stats[3],
					Strength = stats[0],
					Wisdom = stats[5],
					IntSaveProficiency = true,
					WisSaveProficiency = true,
					InsightProf = true,
					PerceptionProf = true,
				};
				myCharacter = _modifiers.CalculateCharacterModifiers(myCharacter);
				myCharacter = _speciesSelection.NameAndSelectSpecies(myCharacter, species);
				myCharacter = _modifiers.CalculateCharacterModifiers(myCharacter);
				myCharacter = _modifiers.CalculateStandardAttackBonuses(myCharacter);
				myCharacter = _modifiers.CreateWisCaster(myCharacter);
				myCharacter = _armorClassCalculations.CalculateArmorClassWithLeatherLightArmor(myCharacter);
				if (myCharacter.Species == "Warforged")
				{
					myCharacter.ArmorClass += 1;
				}
				return myCharacter;

			case ClassSelection.Fighter:
				if (classVariant != 1)
				{
					myCharacter = new Character
					{
						DndClass = classState,
						Charisma = stats[0],
						Constitution = stats[4],
						Dexterity = stats[3],
						Intelligence = stats[1],
						Strength = stats[5],
						Wisdom = stats[2],
						StrSaveProficiency = true,
						ConSaveProficiency = true,
						AthleticsProf = true,
						PerceptionProf= true,
					};
					myCharacter = _modifiers.CalculateCharacterModifiers(myCharacter);
					myCharacter = _speciesSelection.NameAndSelectSpecies(myCharacter, species);
					myCharacter = _modifiers.CalculateCharacterModifiers(myCharacter);
					myCharacter = _modifiers.CalculateStandardAttackBonuses(myCharacter);
					myCharacter = _armorClassCalculations.CalculateArmorClassWithChainMailAndShieldHeavyArmor(myCharacter);
					if (myCharacter.Species == "Warforged")
					{
						myCharacter.ArmorClass += 1;
					}
					return myCharacter;

				}
				else
				{
					myCharacter = new Character
					{
						DndClass = classState,
						Charisma = stats[0],
						Constitution = stats[4],
						Dexterity = stats[5],
						Intelligence = stats[1],
						Strength = stats[3],
						Wisdom = stats[2],
						StrSaveProficiency = true,
						ConSaveProficiency = true,
						AcrobaticsProf = true,
						PerceptionProf = true,
					};
					myCharacter = _modifiers.CalculateCharacterModifiers(myCharacter);
					myCharacter = _speciesSelection.NameAndSelectSpecies(myCharacter, species);
					myCharacter = _modifiers.CalculateCharacterModifiers(myCharacter);
					myCharacter = _modifiers.CalculateStandardAttackBonuses(myCharacter);
					myCharacter = _armorClassCalculations.CalculateArmorClassWithLeatherLightArmor(myCharacter);
					if (myCharacter.Species == "Warforged")
					{
						myCharacter.ArmorClass += 1;
					}
					return myCharacter;
				}
			case ClassSelection.Monk:
				myCharacter = new Character
				{
					DndClass = classState,
					Charisma = stats[0],
					Constitution = stats[3],
					Dexterity = stats[5],
					Intelligence = stats[1],
					Strength = stats[2],
					Wisdom = stats[4],
					StrSaveProficiency = true,
					DexSaveProficiency = true,
					StealthProf = true,
					AcrobaticsProf = true,
				};
				myCharacter= _modifiers.CalculateCharacterModifiers(myCharacter);
				myCharacter = _speciesSelection.NameAndSelectSpecies(myCharacter, species);
				myCharacter = _modifiers.CalculateCharacterModifiers(myCharacter);
				myCharacter = _modifiers.CalculateStandardAttackBonuses(myCharacter);
				myCharacter = _armorClassCalculations.CalculateArmorClassMonkUnarmoredDefense(myCharacter);
				return myCharacter;

			case ClassSelection.Paladin:
				myCharacter = new Character
				{
					DndClass = classState,
					Charisma = stats[4],
					Constitution = stats[3],
					Dexterity = stats[5],
					Intelligence = stats[1],
					Strength = stats[5],
					Wisdom = stats[2],
					WisSaveProficiency = true,
					ChaSavePoficiency = true,
					ReligionProf = true,
					PersuasionProf = true,
				};
				myCharacter = _modifiers.CalculateCharacterModifiers(myCharacter);
				myCharacter = _speciesSelection.NameAndSelectSpecies(myCharacter, species);
				myCharacter = _modifiers.CalculateCharacterModifiers(myCharacter);
				myCharacter = _modifiers.CalculateStandardAttackBonuses(myCharacter);
				myCharacter = _modifiers.CreateChaCaster(myCharacter);
				myCharacter = _armorClassCalculations.CalculateArmorClassWithChainMailAndShieldHeavyArmor(myCharacter);
				if (myCharacter.Species == "Warforged")
				{
					myCharacter.ArmorClass += 1;
				}
				return myCharacter;

			case ClassSelection.Ranger:
				myCharacter = new Character
				{
					DndClass = classState,
					Charisma = stats[1],
					Constitution = stats[3],
					Dexterity = stats[5],
					Intelligence = stats[2],
					Strength = stats[0],
					Wisdom = stats[4],
					StrSaveProficiency = true,
					DexSaveProficiency = true,
					StealthProf = true,
					PerceptionProf = true,
				};
				myCharacter = _modifiers.CalculateCharacterModifiers(myCharacter);
				myCharacter = _speciesSelection.NameAndSelectSpecies(myCharacter, species);
				myCharacter = _modifiers.CalculateCharacterModifiers(myCharacter);
				myCharacter = _modifiers.CreateWisCaster(myCharacter);
				myCharacter = _modifiers.CalculateStandardAttackBonuses(myCharacter); 
				myCharacter = _armorClassCalculations.CalculateArmorClassWithLeatherLightArmor(myCharacter);
				if (myCharacter.Species == "Warforged")
				{
					myCharacter.ArmorClass += 1;
				}
				return myCharacter;

			case ClassSelection.Rogue:
				myCharacter = new Character
				{
					DndClass = classState,
					Charisma = stats[1],
					Constitution = stats[3],
					Dexterity = stats[5],
					Intelligence = stats[2],
					Strength = stats[0],
					Wisdom = stats[4],
					DexSaveProficiency = true,
					IntSaveProficiency = true,
					StealthProf = true,
					PerceptionProf = true,
				};
				myCharacter = _modifiers.CalculateCharacterModifiers(myCharacter);
				myCharacter = _speciesSelection.NameAndSelectSpecies(myCharacter, species);
				myCharacter = _modifiers.CalculateCharacterModifiers(myCharacter);
				myCharacter = _modifiers.CalculateStandardAttackBonuses(myCharacter);
				myCharacter = _armorClassCalculations.CalculateArmorClassWithLeatherLightArmor(myCharacter);
				if (myCharacter.Species == "Warforged")
				{
					myCharacter.ArmorClass += 1;
				}
				return myCharacter;

			case ClassSelection.Sorcerer:
				myCharacter = new Character
				{
					DndClass = classState,
					Charisma = stats[5],
					Constitution = stats[3],
					Dexterity = stats[4],
					Intelligence = stats[1],
					Strength = stats[0],
					Wisdom = stats[2],
					ConSaveProficiency = true,
					ChaSavePoficiency = true,
					ArcanaProf = true,
					DeceptionProf = true,
				};
				myCharacter = _modifiers.CalculateCharacterModifiers(myCharacter);
				myCharacter = _speciesSelection.NameAndSelectSpecies(myCharacter, species);
				myCharacter = _modifiers.CalculateCharacterModifiers(myCharacter);
				myCharacter = _modifiers.CalculateStandardAttackBonuses(myCharacter);
				myCharacter = _modifiers.CreateChaCaster(myCharacter);
				myCharacter = _armorClassCalculations.CalculateArmorClassWithNoArmor(myCharacter);
				return myCharacter;

			case ClassSelection.Warlock:
				myCharacter = new Character
				{
					DndClass = classState,
					Charisma = stats[5],
					Constitution = stats[3],
					Dexterity = stats[4],
					Intelligence = stats[1],
					Strength = stats[0],
					Wisdom = stats[2],
					WisSaveProficiency = true,
					ChaSavePoficiency = true,
					ArcanaProf = true,
					DeceptionProf = true,
				};
				myCharacter = _modifiers.CalculateCharacterModifiers(myCharacter);
				myCharacter = _speciesSelection.NameAndSelectSpecies(myCharacter, species);
				myCharacter = _modifiers.CalculateCharacterModifiers(myCharacter);
				myCharacter = _modifiers.CalculateStandardAttackBonuses(myCharacter);
				myCharacter = _modifiers.CreateChaCaster(myCharacter);
				myCharacter = _armorClassCalculations.CalculateArmorClassWithLeatherLightArmor(myCharacter);
				if (myCharacter.Species == "Warforged")
				{
					myCharacter.ArmorClass += 1;
				}
				return myCharacter;

			case ClassSelection.Wizard:
				myCharacter = new Character
				{
					DndClass = classState,
					Charisma = stats[1],
					Constitution = stats[3],
					Dexterity = stats[4],
					Intelligence = stats[5],
					Strength = stats[0],
					Wisdom = stats[2],
					WisSaveProficiency = true,
					IntSaveProficiency = true,
					ArcanaProf = true,
					InvestigationProf = true,
				};
				myCharacter = _modifiers.CalculateCharacterModifiers(myCharacter);
				myCharacter = _speciesSelection.NameAndSelectSpecies(myCharacter, species);
				myCharacter = _modifiers.CalculateCharacterModifiers(myCharacter);
				myCharacter = _modifiers.CalculateStandardAttackBonuses(myCharacter);
				myCharacter = _modifiers.CreateIntCaster(myCharacter);
				myCharacter = _armorClassCalculations.CalculateArmorClassWithNoArmor(myCharacter);
				return myCharacter;
			default:
				return null;

		}

	}


}
