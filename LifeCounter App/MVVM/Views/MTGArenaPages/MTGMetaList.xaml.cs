using LifeCounter_App.MVVM.ViewModels;

namespace LifeCounter_App.MVVM.Views.MTGArenaPages;

public partial class MTGMetaList : ContentPage
{
    MTGViewModel MTGViewModel = new MTGViewModel();
	public MTGMetaList()
	{
		InitializeComponent();
	}
    private void TabItem_Clicked(object sender, EventArgs e)
    {
        if (sender is Button clickedButton)
        {
            if (clickedButton.Text == "Life Counter")
            {
                Application.Current.MainPage = new MTGLifeCounter();
            }
            else if (clickedButton.Text == "Roll Dice")
            {
                Application.Current.MainPage = new RollDicePage();
            }
            else
            {
                Application.Current.MainPage = new MTGMetaList();
            }
        }
    }
    private void MetaItem_Clicked(object sender, EventArgs e)
    {
        if (sender is Button clickedButton)
        {
            MTGViewModel.GetMetaItemLink(clickedButton);
        }
    }
}