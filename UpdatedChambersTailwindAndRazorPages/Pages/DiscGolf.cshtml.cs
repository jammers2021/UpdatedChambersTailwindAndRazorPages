using UpdatedChambersTailwindAndRazorPages.Models.DTOs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
 

namespace UpdatedChambersTailwindAndRazorPages.Pages.DiscGolf
{
    public class DiscGolfModel : PageModel
    {
		private IHttpClientFactory _httpClientFactory;
		public List<ScoreDTO> scoreDTOs = new();
		public List<PlayerDTO> playerDTOs = new();
		public DiscGolfModel(IHttpClientFactory httpClient)
        {
            _httpClientFactory = httpClient;
        }
        public async Task OnGetAsync()
		{
			var _httpClient=_httpClientFactory.CreateClient("DiscGolfAPI");
			string path = "api/Round/AllAcesViewer";
			string path2 = "api/Player/ViewAllPlayers";
			scoreDTOs = await _httpClient.GetFromJsonAsync<List<ScoreDTO>>(path);
			playerDTOs = await _httpClient.GetFromJsonAsync<List<PlayerDTO>>(path2);
		}


	}
}
