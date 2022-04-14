

using GraphQL_API.Models;
using HotChocolate.Data;
using RickAndMortyGraphQL.Models;
using System;
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
            new CharacterModel (new OriginModel("Earth", "https://rickandmortyapi.com/api/location/1" ), new LocationModel("Earth", "https://rickandmortyapi.com/api/location/20" ))
            {
                    Id = 1,
                    Name = "Morty Smith",
                    Status = "Alive",
                    Species = "Human",
                    Type = "",
                    Gender = "Male",  
                    image = new Uri ("https://rickandmortyapi.com/api/character/avatar/2.jpeg"),
                    Episode = new string[] { "https://rickandmortyapi.com/api/episode/1",
                       "https://rickandmortyapi.com/api/episode/2" },
                    url= new Uri ("https://rickandmortyapi.com/api/location/1"),
                    Created = "2017-11-04T18:50:21.651Z"
            },
            new CharacterModel(new OriginModel("Earth", "https://rickandmortyapi.com/api/location/1" ), new LocationModel("Earth", "https://rickandmortyapi.com/api/location/20" ))
            {
                    Id = 2,
                    Name = "Summer Smith",
                    Species = "Human",
                    Gender = "Female",                    
            },
            new CharacterModel(new OriginModel("Unity's Planet", "https://rickandmortyapi.com/api/location/1" ), new LocationModel("Unity's Planet", "https://rickandmortyapi.com/api/location/20" ))
            {
                Id = 3,
                Name = "Karen Entity",
                Species = "Alien",
                Gender = "Female",               

            },
             new CharacterModel (new OriginModel("Earth", "https://rickandmortyapi.com/api/location/1" ), new LocationModel("Earth", "https://rickandmortyapi.com/api/location/20" ))
            {
                Id = 4,
                Name = "Kathy Ireland",
                Species = "Human",
                Gender = "Female",

            },
              new CharacterModel (new OriginModel("Interdimensional Cable", "https://rickandmortyapi.com/api/location/1" ), new LocationModel("Interdimensional Cable", "https://rickandmortyapi.com/api/location/20" ))
            {
                Id = 5,
                Name = "When Wolf",
                Species = "Mythological Creature",
                Gender = "Male",
            },
        }.AsQueryable();
    }
    
}

