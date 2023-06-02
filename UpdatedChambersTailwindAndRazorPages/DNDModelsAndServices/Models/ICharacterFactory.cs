using static UpdatedChambersTailwindAndRazorPages.DNDModelsAndServices.Models.CharacterClassSelection;

namespace UpdatedChambersTailwindAndRazorPages.DNDModelsAndServices.Models
{
	public interface ICharacterFactory
	{
		Character CreateCharacter(ClassSelection classState, int classVariant, string species, List<int> stats);
	}
}