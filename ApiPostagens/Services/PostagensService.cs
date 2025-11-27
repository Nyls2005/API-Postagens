using ApiPostagens.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiPostagens.Services
{
    public class PostagensService
    {
        public async Task<List<Postagem>>GetPostagens()
        {
            List<Postagem> postagems = new List<Postagem>();
            string URI = "https://jsonplaceholder.typicode.com/posts";
            HttpClient httpClient = new HttpClient();
            HttpResponseMessage responseMessage = await httpClient.GetAsync(URI);

            if (responseMessage.IsSuccessStatusCode)
            {
                string conteudo = await responseMessage.Content.ReadAsStringAsync();
                postagems = JsonConvert.DeserializeObject<List<Postagem>>(conteudo);
            }

            return (postagems);
        }
    }
}
