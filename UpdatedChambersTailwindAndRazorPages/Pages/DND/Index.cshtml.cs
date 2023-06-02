using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Model;
using System.Diagnostics.Metrics;
using System.Drawing;
using UpdatedChambersTailwindAndRazorPages.DNDModelsAndServices.Models;

namespace UpdatedChambersTailwindAndRazorPages.Pages.DND
{
    public class DndModel : PageModel
    {
        private IStatsGenerationMethod _statsGenerationMethod;
        private ICharacterFactory _characterFactory;
        private IChosenClassSelection _chosenClassSelection;
        public DndModel(IStatsGenerationMethod statsGenerationMethod, ICharacterFactory characterFactory, IChosenClassSelection chosenClassSelection)
        {
            _statsGenerationMethod = statsGenerationMethod;
            _characterFactory = characterFactory;
            _chosenClassSelection = chosenClassSelection;
        }
        [BindProperty]
        public int[]? Stats { get; set; }
        public Character Character { get; set; }
        public string SelectedClass { get; set; }
        public string SelectedStatsMethod { get; set; }

        public void OnGet()
        {



        }
        public IActionResult OnPost(string dndClass, string speciesSelection, string statSelectionMethod, int[]? stats = null)
        {
            if (stats == null)
            {
                stats = Array.Empty<int>();
            }
            var statsList = stats.ToList();
            var fullStats = _statsGenerationMethod.SelectStats(statSelectionMethod, statsList);
            int variant = 0;
            if (dndClass == "FighterDex")
            {
                dndClass = "Fighter";
                variant = 1;
            }
            var selectedClass = _chosenClassSelection.SelectClass(dndClass);
            Character = _characterFactory.CreateCharacter(selectedClass, variant, speciesSelection, fullStats);
            return RedirectToPage("/Dnd/Dnd", new { Character });
        }
    }
}
