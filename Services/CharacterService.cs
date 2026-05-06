using Anime.Models;
using Newtonsoft.Json;

namespace Anime.Services
{
    public class CharacterService
    {
        private readonly HttpClient _httpClient;

        public CharacterService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<CharacterEntry>> GetCharactersAsync()
        {
            var response = await _httpClient.GetStringAsync(
                "https://api.jikan.moe/v4/anime/2116/characters"
            );
            var result = JsonConvert.DeserializeObject<CharacterResponse>(response);
            return result.Data;
        }

        public async Task<CharacterEntry> GetCharacterByIdAsync(int id)
        {
            var response = await _httpClient.GetStringAsync(
                $"https://api.jikan.moe/v4/characters/{id}"
            );
            var result = JsonConvert.DeserializeObject<CharacterSingleResponse>(response);
            return new CharacterEntry { Character = result.Data };
        }
    }
}
