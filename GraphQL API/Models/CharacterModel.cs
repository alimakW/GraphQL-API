using GraphQL_API.Models;
using HotChocolate.Data;

namespace RickAndMortyGraphQL.Models
{
    public class CharacterModel
    {
        internal string Image;
        internal string Url;

        public int Id { get; set; }
        
        public string Name { get; set; }

        public string Status { get; set; }

        public string Species { get; set; }

        public string Type { get; set; }

        public string Gender { get; set; }

        private OriginModel origin { get; set; }

        private LocationModel location { get; set; }

        public System.Uri image { get; set; }

        public string[] Episode { get; set; }

        public System.Uri url { get; set; }
       
        public string Created { get; internal set; }

        public CharacterModel (OriginModel origin, LocationModel location)
        {
            this.origin = origin;
            this.location = location;

        }
    }
}