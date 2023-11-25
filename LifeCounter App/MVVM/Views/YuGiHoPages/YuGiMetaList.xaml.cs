using LifeCounter_App.MVVM.ViewModels;

namespace LifeCounter_App.MVVM.Views.YuGiHoPages;

public partial class YuGiMetaList : ContentPage
{
    YuGiHoViewModel _yuGiHoViewModel = new YuGiHoViewModel();
	public YuGiMetaList()
	{
		InitializeComponent();
	}
    private void TabItem_Clicked(object sender, EventArgs e)
    {
        if (sender is Button clickedButton)
        {
            if (clickedButton.Text == "Life Counter")
            {
                Application.Current.MainPage = new YuGiHoLifeCounter();
            }
            else if (clickedButton.Text == "Flip Coin")
            {
                Application.Current.MainPage = new CoinFlipPage();
            }
            else
            {
                Application.Current.MainPage = new YuGiMetaList();
            }
        }
    }

    private void MetaItem_Clicked(object sender, EventArgs e)
    {
        if (sender is Button clickedButton)
        {
            _yuGiHoViewModel.GetMetaItemLink(clickedButton);
        }
    }
}