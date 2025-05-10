using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RYMApi.Models;

namespace RYMApi.Controllers
{
    public class charactersControllers
    {
        private HttpClient client;

        public charactersControllers()
        {
            client = new HttpClient();
        }

        public async Task<Characters> GetAllCharacters()
        {
            try
            {
                Characters characters = new Characters();
                HttpResponseMessage response = await
                client.GetAsync("https://rickandmortyapi.com/api/character");

                response.EnsureSuccessStatusCode();

                string responseJson = await response.Content.ReadAsStringAsync();

                characters = JsonConvert.DeserializeObject<Characters>(responseJson);

                return characters;
            }
            catch (Exception)
            {
                return null;

            }
        }
    }
}


