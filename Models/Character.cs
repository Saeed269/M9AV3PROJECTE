namespace Anime.Models
{
    public class CharacterImage
    {
        public string Image_url { get; set; }
    }

    public class CharacterImages
    {
        public CharacterImage Jpg { get; set; }
    }

    public class Character
    {
        public int Mal_id { get; set; }
        public string Name { get; set; }
        public CharacterImages Images { get; set; }
    }

    public class CharacterEntry
    {
        public Character Character { get; set; }
        public string Role { get; set; }
        public int Favorites { get; set; }
    }

    public class CharacterResponse
    {
        public List<CharacterEntry> Data { get; set; }
    }

    public class CharacterSingleResponse
    {
        public Character Data { get; set; }
    }
}
