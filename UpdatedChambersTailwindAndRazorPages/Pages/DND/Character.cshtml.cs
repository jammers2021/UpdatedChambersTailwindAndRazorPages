using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using UpdatedChambersTailwindAndRazorPages.DNDModelsAndServices.Models;

namespace UpdatedChambersTailwindAndRazorPages.Pages.DND
{
    public class CharacterModel : PageModel
    {
        [BindProperty]
        public Character MyCharacter { get; set; }
        public ActionResult<Character> OnGet(Character? character)
        {
            if(character == null) 
                return RedirectToPage("/DND");
            else
            {
                MyCharacter = character;

                return MyCharacter;
            }

		}
    }
}
