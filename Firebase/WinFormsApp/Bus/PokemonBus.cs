using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using Newtonsoft.Json;
using WinFormsApp.Model;
using System.Windows.Forms;
using FireSharp;
using FireSharp.Response;
using FireSharp.Interfaces;
using FireSharp.Config;

namespace WinFormsApp.Bus
{
    class PokemonBus
    {
        String URI = "https://restservice20210608231859.azurewebsites.net/api/pokemons";
        static IFirebaseConfig config = new FirebaseConfig {BasePath = "https://sa-lab-196b3-default-rtdb.firebaseio.com/", AuthSecret= "jzSuT1S8JiACwlkTV5QwJpfPSRvGnLEs7BfFcAAs" };
        static FirebaseClient client = new FirebaseClient(config);

        public async void ListenFirebase(DataGridView girdPokemon)
        {
            EventStreamResponse response = await client.OnAsync("Pokemon",
                added: (sender, args, context) => { UpdateDataGirdView(girdPokemon); },
                changed: (sender, args, context) => { UpdateDataGirdView(girdPokemon); },
                removed: (sender, args, context) => { UpdateDataGirdView(girdPokemon); }
                );
        }

        private void UpdateDataGirdView(DataGridView girdPokemon)
        {
            List<Pokemon> pokemons = GetAll();
            girdPokemon.BeginInvoke(new MethodInvoker(delegate { girdPokemon.DataSource = pokemons; }));
        }

        public List<Pokemon> GetAll()
        {
            FirebaseResponse response = client.Get("Pokemons");
            List<Pokemon> dictPokemons = response.ResultAs<List<Pokemon>>();
            if(dictPokemons != null)
                return dictPokemons.Where(p => p != null).ToList();
            return new List<Pokemon>();
        }

        public Pokemon GetDetails(String ID)
        {
            FirebaseResponse response = client.Get("Pokemons/" + ID);
            Pokemon pokemon = response.ResultAs<Pokemon>();
            return pokemon;
        }

        public bool Addnew(Pokemon newPokemon)
        {
           try
            {
                String key = getKeyByID(newPokemon.ID);
                if (String.IsNullOrEmpty(key))
                    client.Set("Pokemons/" + newPokemon.ID, newPokemon);
                else
                    return false;
            } catch
            {
                return false;
            }
            return true;
        }

        public String getKeyByID(string ID)
        {
            Pokemon pokemon = this.GetAll().FirstOrDefault(x => x.ID == ID);
            if(pokemon != null)
                return pokemon.ID;
            return null;
        }

        public List<Pokemon> Search(string keyword)
        {
            FirebaseResponse response = client.Get("Pokemons");
            List<Pokemon> dictPokemons = response.ResultAs<List<Pokemon>>();
            return dictPokemons.Where(p => p!= null && p.Name.Contains(keyword)).ToList();
        }

        public bool Update(Pokemon pokemon)
        {
            try
            {
                string key = getKeyByID(pokemon.ID);
                if (String.IsNullOrEmpty(key)) return false;
                client.Set("Pokemons/" + key, pokemon);
            }
            catch
            {
                return false;
            }
            return true;
        }

        public bool Delete(string ID)
        {
            try
            {
                string key = getKeyByID(ID);
                if (String.IsNullOrEmpty(key)) return false;
                client.Delete("Pokemons/" + key);
            }
            catch
            {
                return false;
            }
            return true;
        }
    }
}
