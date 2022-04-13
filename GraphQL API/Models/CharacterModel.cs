using HotChocolate.Data;

namespace RickAndMortyGraphQL.Models
{
    public class CharacterModel
    {
        public int Id { get; set; }
        
        public string Name { get; set; }

        public string Status { get; set; }

        public string Species { get; set; }

        public string Type { get; set; }

        public string Gender { get; set; }
       
    }
}