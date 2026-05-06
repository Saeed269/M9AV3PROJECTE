using Anime.Services;
using Microsoft.AspNetCore.Mvc;

namespace Anime.Controllers
{
    public class CharacterController : Controller
    {
        private readonly CharacterService _characterService;

        public CharacterController(CharacterService characterService)
        {
            _characterService = characterService;
        }

        public async Task<IActionResult> Detail(int id, string role, int favorites)
        {
            var character = await _characterService.GetCharacterByIdAsync(id);
            character.Role = role;
            character.Favorites = favorites;
            return View(character);
        }
    }
}
