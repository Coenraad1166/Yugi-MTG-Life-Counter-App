using LifeCounter_App.MVVM.Views.MTGArenaPages;
using LifeCounter_App.MVVM.Views.YuGiHoPages;

namespace LifeCounter_App.MVVM.Views;

public partial class SelectGamePage : ContentPage
{
	public SelectGamePage()
	{
		InitializeComponent();
	}

    private void YugiBtn_Clicked(object sender, EventArgs e)
    {
        Application.Current.MainPage = new YuGiHoLifeCounter();
    }
    private void MTGBtn_Clicked(object sender, EventArgs e)
    {
        Application.Current.MainPage = new MTGLifeCounter();
    }
}