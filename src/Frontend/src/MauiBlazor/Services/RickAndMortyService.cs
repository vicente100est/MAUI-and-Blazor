using MauiBlazor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace MauiBlazor.Services
{
    public class RickAndMortyService : IRickAndMortyService
    {
        private const string _url = "https://rickandmortyapi.com/api/character";
        public async Task<RickAndMorty> Get()
        {
            var httpClient = new HttpClient();
            var response = await httpClient.GetAsync(_url);
            var content = await response.Content.ReadAsStringAsync();
            var rickAndMorty = JsonSerializer.Deserialize<RickAndMorty>(content);
            return rickAndMorty;
        }
    }
}
