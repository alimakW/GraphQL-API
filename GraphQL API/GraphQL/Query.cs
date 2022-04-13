

using HotChocolate.Data;
using RickAndMortyGraphQL.Models;
using System.Collections.Generic;
using System.Linq;

namespace Rick_and_Morty_Project.GraphQL
{
    // The Query class is the root type that the GraphQL server will expose—it will allow clients to query Character
    //  For reading characters, I use Query operation, and Creating, Updating and Deleting we can use Mutation operation.
    // Code-first (I declare the schema in code).
    public class Query
    {
 
        // I add the attribute from HotChocolate.Data, which to enable search characters by name      
        [UseFiltering]
        public IQueryable<CharacterModel> Characters => new List<CharacterModel>
        {
            new CharacterModel
            {
                    Id = 1,
                    Name = "Morty Smith",
                    Species = "Human",
                    Gender = "Male",                   
            },
            new CharacterModel
            {
                    Id = 2,
                    Name = "Summer Smith",
                    Species = "Human",
                    Gender = "Female",
                    
            },
            new CharacterModel
            {
                Id = 3,
                Name = "Karen Entity",
                Species = "Alien",
                Gender = "Female",
               
            },
             new CharacterModel
            {
                Id = 4,
                Name = "Kathy Ireland",
                Species = "Human",
                Gender = "Female",

            },
              new CharacterModel
            {
                Id = 5,
                Name = "When Wolf",
                Species = "Mythological Creature",
                Gender = "Male",
            },
        }.AsQueryable();
    }
    
}

