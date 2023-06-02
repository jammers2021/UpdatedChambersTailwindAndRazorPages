using Microsoft.AspNetCore.Routing;
using System;
using UpdatedChambersTailwindAndRazorPages.DNDModelsAndServices.Models;
using static UpdatedChambersTailwindAndRazorPages.DNDModelsAndServices.Models.CharacterClassSelection;

namespace UpdatedChambersTailwindAndRazorPages.DNDModelsAndServices.Services
{
    public class ChosenClassSelection : IChosenClassSelection
	{
		public ClassSelection SelectClass(string className)
		{
			var classSelection = new ClassSelection();
			switch (className.ToLower())
			{
				case "artificer":
					classSelection = ClassSelection.Artificer;
					break;
				case "barbarian":
					classSelection = ClassSelection.Barbarian;
					break;
				case "bard":
					classSelection = ClassSelection.Bard;
					break;
				case "cleric":
					classSelection = ClassSelection.Cleric;
					break;
				case "druid":
					classSelection = ClassSelection.Druid;
					break;
				case "fighter":
					classSelection = ClassSelection.Fighter;
					break;
				case "monk":
					classSelection = ClassSelection.Monk;
					break;
				case "paladin":
					classSelection = ClassSelection.Paladin;
					break;
				case "ranger":
					classSelection = ClassSelection.Ranger;
					break;
				case "rogue":
					classSelection = ClassSelection.Rogue;
					break;
				case "sorcerer":
					classSelection = ClassSelection.Sorcerer;
					break;
				case "warlock":
					classSelection = ClassSelection.Warlock;
					break;
				case "wizard":
					classSelection = ClassSelection.Wizard;
					break;
				case "unselected":
				default:
					classSelection = ClassSelection.Unselected;
					break;
			}
			return classSelection;
		}
	}
}
