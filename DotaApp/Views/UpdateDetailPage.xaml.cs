using DotaApp.Models;
using System.Diagnostics;

namespace DotaApp.Views;

public partial class UpdateDetailPage : ContentPage
{
    private readonly Update _update;
    public UpdateDetailPage(Update update)
	{
        NavigationPage.SetHasNavigationBar(this, false);
        InitializeComponent();
        _update = update;
        Debug.WriteLine(_update.description);
        BindingContext = _update;
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