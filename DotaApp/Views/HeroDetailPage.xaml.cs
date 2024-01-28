using DotaApp.Models;

namespace DotaApp.Views;

public partial class HeroDetailPage : ContentPage
{
	private readonly Hero _hero;
	public HeroDetailPage(Hero hero)
	{
        NavigationPage.SetHasNavigationBar(this, false);
        InitializeComponent();
		_hero = hero;
        BindingContext = _hero;
    }

    // navigation menu footer
    private async void ImageButton_PageHeroes(object sender, EventArgs e)
    {
        SelectedPage.indexPage = 0;
        await Navigation.PushAsync(new HeroesPages());
    }

    private async void ImageButton_Page¿ssembly(object sender, EventArgs e)
    {
        SelectedPage.indexPage = 1;
        await Navigation.PushAsync(new HeroesPages());
    }


    private async void ImageButton_PageUpdates(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new UpdatesPage());
    }

}