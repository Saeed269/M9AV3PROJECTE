using Anime.Services;
using Microsoft.AspNetCore.Mvc;

namespace Anime.Controllers
{
    public class HomeController : Controller
    {
        private readonly CharacterService _characterService;

        public HomeController(CharacterService characterService)
        {
            _characterService = characterService;
        }

        public async Task<IActionResult> Index()
        {
            var characters = await _characterService.GetCharactersAsync();
            return View(characters);
        }

        public IActionResult About()
        {
            return View();
        }
    }
}
