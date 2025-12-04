using ApiPostagens.ViewModels;

namespace ApiPostagens.Views;

public partial class PostagensView : ContentPage
{
	public PostagensView()
	{
		InitializeComponent();
		this.BindingContext = new PostagensViewModel();
	}
}