using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using Newtonsoft.Json;
using WinFormsApp.Model;
namespace WinFormsApp.Bus
{
    class PokemonBus
    {
      String URI = "https://restservice20210608231859.azurewebsites.net/api/pokemons";

      public List<Pokemon> GetAll()
        {
            WebClient client = new WebClient();
            String response = client.DownloadString(URI);
            return JsonConvert.DeserializeObject<List<Pokemon>>(response);    
        }

       public bool GetDetails(String ID)
        {
            WebClient client = new WebClient();
            String response = client.DownloadString(URI + "/" + ID);
            return JsonConvert.DeserializeObject<bool>(response);
        }

        public bool Addnew(Pokemon newPokemon)
        {
            String data = JsonConvert.SerializeObject(newPokemon);
            WebClient client = new WebClient();
            client.Headers[HttpRequestHeader.ContentType] = "application/json";
            String response = client.UploadString(URI, "POST", data);
            return bool.Parse(response);
        }

        public List<Pokemon> Search(string keyword)
        {
            WebClient client = new WebClient();
            String response = client.DownloadString(URI + "/search/" + keyword);
            return JsonConvert.DeserializeObject<List<Pokemon>>(response);
        }

        public bool Update(Pokemon pokemon)
        {
            String data = JsonConvert.SerializeObject(pokemon);
            WebClient client = new WebClient();
            client.Headers[HttpRequestHeader.ContentType] = "application/json";
            String response = client.UploadString(URI + "/" + pokemon.ID, "PUT", data);
            return bool.Parse(response);
        }

        public bool Delete(string ID)
        {
            WebClient client = new WebClient();
            String response = client.UploadString(URI + "/" + ID, "DELETE", "");
            return bool.Parse(response);
        }
    }
}
