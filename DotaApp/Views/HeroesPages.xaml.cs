using DotaApp.Models;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace DotaApp.Views;

public partial class HeroesPages : ContentPage
{
    private readonly Services _services;

    public HeroesPages()
	{
        _services = new Services();
        NavigationPage.SetHasNavigationBar(this, false);
        InitializeComponent();
        NAME_PAGE.Text = SelectedPage.namePage[SelectedPage.indexPage];
    }

    private async void CollectionView_Hero_Loaded(object sender, EventArgs e)
    {
        List<Hero> heroes = await _services.GetHeroes();
        CollectionView_Hero.ItemsSource = heroes;
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        Button button = (Button)sender;
        Hero selectedHero = (Hero)button.BindingContext;
        selectedHero.Skills = await _services.GetSkillsByHero(selectedHero.id);
        await _services.UpdateHeroWithGroupItemsAndItems(selectedHero);

        if (SelectedPage.indexPage == 0)
            await Navigation.PushAsync(new HeroDetailPage(selectedHero));
        if (SelectedPage.indexPage == 1)
            await Navigation.PushAsync(new AssemblyDetailPage(selectedHero));
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

