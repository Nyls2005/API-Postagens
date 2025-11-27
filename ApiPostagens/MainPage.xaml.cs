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
            Fotos minhaFoto = new Fotos();
            string URI = "https://jsonplaceholder.typicode.com/photos";
            HttpClient httpClient = new HttpClient();
            HttpResponseMessage responseMessage = await httpClient.GetAsync(URI);

            List<Fotos> fotos = new List<Fotos>();

            if (responseMessage.IsSuccessStatusCode)
            {
                
                string conteudo = await responseMessage.Content.ReadAsStringAsync();
                
                fotos = JsonConvert.DeserializeObject<List<Fotos>>(conteudo);

                NomeLbl.Text = fotos[0].Title;
            }
        }
    }

}
