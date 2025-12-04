using ApiPostagens.Models;
using ApiPostagens.Services;
using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ApiPostagens.ViewModels
{
    public partial class PostagensViewModel : ObservableObject
    {
        [ObservableProperty]
        public int userId;
        [ObservableProperty]
        public int id;
        [ObservableProperty]
        public string title;
        [ObservableProperty]
        public string body;
        public ICommand CarregarPostagenscommand => new Command(async () => CarregaPostagens());

        [ObservableProperty]
        public List<Postagem> listar = new List<Postagem>();

        public async void CarregaPostagens()
        {
            
            listar = await new PostagensService().GetPostagens();
            /*id = Listar[0].id;
            title = Listar[0].title;
            body = Listar[0].body;*/
        }
    }
}
