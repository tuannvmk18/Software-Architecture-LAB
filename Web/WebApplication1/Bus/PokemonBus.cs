using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication1.Model;
using WebApplication1.Dao;
namespace WebApplication1.Bus
{
    class PokemonBus
    {
      public List<Pokemon> GetAll()
        {
            List<Pokemon> pokemons = new PokemonDao().SelectAll();
            return pokemons;    
        }

       public bool AddNew(Pokemon newPokemon)
        {
            bool result = new PokemonDao().Insert(newPokemon);
            return result;
        }

        public bool Update(Pokemon newPokemon)
        {
            bool result = new PokemonDao().Update(newPokemon);
            return result;
        }

        public bool Delete(string ID)
        {
            bool result = new PokemonDao().Delete(ID);
            return result;
        }

        public List<Pokemon> SelectAllByKeyword(string name)
        {
            return new PokemonDao().SelectAllByKeyword(name);
        }

        public List<Pokemon> GetDetails(string ID)
        {
            return new PokemonDao().GetDetails(ID);
        }

    }
}
