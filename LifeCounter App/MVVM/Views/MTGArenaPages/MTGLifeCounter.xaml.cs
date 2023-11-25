using LifeCounter_App.MVVM.Models;
using LifeCounter_App.MVVM.ViewModels;

namespace LifeCounter_App.MVVM.Views.MTGArenaPages;

public partial class MTGLifeCounter : ContentPage
{
    YuGiHoModel _yuGiHoModel = new YuGiHoModel();
    MTGViewModel _yuGiHoViewModel = new MTGViewModel();
    public MTGLifeCounter()
	{
		InitializeComponent();
        _yuGiHoModel.PlayerOneLife = "20";
        _yuGiHoModel.PlayerTwoLife = "20";
        _yuGiHoModel.PlayerThreeLife = "20";
        _yuGiHoModel.PlayerFourLife = "20";
        BindingContext = _yuGiHoModel;

    }
    private void UpdateAdditionAndSubstractionBtn_Click(object sender, EventArgs e)
    {
        if (sender is Button clickedButton)
        {
            _yuGiHoViewModel.UpdateLifeTotal(clickedButton);

        }
    }
    private void ManualUpdateBtn_Clicked(object sender, EventArgs e)
    {
        if (sender is Button clickedButton)
        {
            _yuGiHoViewModel.UpdateLifeTotalManual(clickedButton, contentPage);
        }
    }
    private void ResetBtn_Clicked(object sender, EventArgs e)
    {
        if (sender is Button clickedButton)
        {
            _yuGiHoViewModel.ResetLifeTotal(clickedButton);
        }
    }
    private void ChangePlayerAmountBrn_Clicked(object sender, EventArgs e)
    {
        if (sender is Button clickedButton)
        {
            if (clickedButton.Text == "2")
            {
                btnTwoPlayers.TextColor = Color.FromArgb("#D62323");
                btnFourPlayers.TextColor = Color.FromArgb("#d4d4d4");
                btnTwoPlayers.BorderColor = Color.FromArgb("#D62323");
                btnFourPlayers.BorderColor = Color.FromArgb("#d4d4d4");
                twoPlayerGrid.IsVisible = true;
                twoPlayerGrid.IsEnabled = true;
                fourPlayerGrid.IsVisible = false;
                fourPlayerGrid.IsEnabled = false;
            }
            else
            {
                btnTwoPlayers.TextColor = Color.FromArgb("#d4d4d4");
                btnFourPlayers.TextColor = Color.FromArgb("#D26323");
                btnTwoPlayers.BorderColor = Color.FromArgb("#d4d4d4");
                btnFourPlayers.BorderColor = Color.FromArgb("#D26323");

                twoPlayerGrid.IsVisible = false;
                fourPlayerGrid.IsVisible = true;
                twoPlayerGrid.IsEnabled = false;
                fourPlayerGrid.IsEnabled = true;
            }
        }
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

    private void ChangeGameBtn_Clicked(object sender, EventArgs e)
    {
        Application.Current.MainPage = new SelectGamePage();
    }
}