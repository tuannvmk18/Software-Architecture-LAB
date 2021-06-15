using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SA_Lab.Dao;
namespace SA_Lab.Controllers
{
    public class PokemonController : ApiController
    {
        [HttpGet]
        [Route("api/pokemons")]
        public List<Pokemon> GetAll()
        {
            return new PokemonDao().SelectAll();
        }

        [HttpGet]
        [Route("api/pokemons/{ID}")]
        public List<Pokemon> GetByID(string ID)
        {
            return new PokemonDao().GetDetails(ID);
        }

        [HttpGet]
        [Route("api/pokemons/search/{keyword}")]
        public List<Pokemon> Search(string keyword)
        {
            return new PokemonDao().SelectAllByKeyword(keyword);
        }

        [HttpPost]
        [Route("api/pokemons")]
        public bool addNew(Pokemon pokemon)
        {
            return new PokemonDao().Insert(pokemon);
        }

        [HttpPut]
        [Route("api/pokemons/{ID}")]
        public bool Update(string ID,Pokemon pokemon)
        {
            if (ID != pokemon.ID) return false;
            return new PokemonDao().Update(pokemon);
        }

        [HttpDelete]
        [Route("api/pokemons/{ID}")]
        public bool Delete(string ID)
        {
            return new PokemonDao().Delete(ID);
        }
    }
}
