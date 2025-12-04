using ApiPostagens.Models;
using Newtonsoft.Json;

namespace ApiPostagens
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        async private void BuscarBtn_Clicked(object sender, EventArgs e)
        {
            Postagem postagem = new Postagem();
            string URI = "https://jsonplaceholder.typicode.com/photos";
            HttpClient httpClient = new HttpClient();
            HttpResponseMessage responseMessage = await httpClient.GetAsync(URI);

            List<Postagem> postagems = new List<Postagem>();

            if (responseMessage.IsSuccessStatusCode)
            {
                
                string conteudo = await responseMessage.Content.ReadAsStringAsync();
                
                postagems = JsonConvert.DeserializeObject<List<Postagem>>(conteudo);

                NomeLbl.Text = postagems[0].title;
            }
        }
    }

}
