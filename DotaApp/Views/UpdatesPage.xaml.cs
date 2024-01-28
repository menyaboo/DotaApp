using DotaApp.Models;

namespace DotaApp.Views;

public partial class UpdatesPage : ContentPage
{
    private readonly Services _services;
    public UpdatesPage()
	{
        _services = new Services();
        NavigationPage.SetHasNavigationBar(this, false);
        InitializeComponent();
	}

    private async void CollectionView_Updates_Loaded(object sender, EventArgs e)
    {
        List<Update> updates = await _services.GetUpdates();
        CollectionView_Updates.ItemsSource = updates;
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        Button update = (Button)sender;
        Update selectedUpdate = (Update)update.BindingContext;

        await Navigation.PushAsync(new UpdateDetailPage(selectedUpdate));
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