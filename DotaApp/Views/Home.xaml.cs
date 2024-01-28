using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotaApp.Views;

public partial class Home : ContentPage
{
    public Home()
    {
        NavigationPage.SetHasNavigationBar(this, false);
        InitializeComponent();
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