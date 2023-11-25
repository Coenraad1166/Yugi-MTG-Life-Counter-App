namespace LifeCounter_App.MVVM.Views.YuGiHoPages;

public partial class CoinFlipPage : ContentPage
{

    public CoinFlipPage()
    {
        InitializeComponent();
        tailsLbl.IsVisible = false;
        headsLbl.IsVisible = false;
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

    private async void coinFlipBtn_Clicked(object sender, EventArgs e)
    {
        if (coinFlipBtn.Text == "Flip Coin")
        {

            headsView.IsVisible = false;
            tailsView.IsVisible = false;
            topView.IsVisible = false;
           


            headsView.IsVisible = false;
            topView.IsVisible = true;
            tailsView.IsVisible = false;
            await Task.Delay(150);

            headsView.IsVisible = false;
            topView.IsVisible = false;
            tailsView.IsVisible = true;
            await Task.Delay(150);

            headsView.IsVisible = false;
            topView.IsVisible = true;
            tailsView.IsVisible = false;
            await Task.Delay(150);

            headsView.IsVisible = true;
            topView.IsVisible = false;
            tailsView.IsVisible = false;
            await Task.Delay(150);
            headsView.IsVisible = false;
            topView.IsVisible = true;
            tailsView.IsVisible = false;
            await Task.Delay(150);
            headsView.IsVisible = false;
            topView.IsVisible = true;
            tailsView.IsVisible = false;
            await Task.Delay(150);

            headsView.IsVisible = false;
            topView.IsVisible = false;
            tailsView.IsVisible = true;
            await Task.Delay(150);

            headsView.IsVisible = false;
            topView.IsVisible = true;
            tailsView.IsVisible = false;
            await Task.Delay(150);

            headsView.IsVisible = true;
            topView.IsVisible = false;
            tailsView.IsVisible = false;
            await Task.Delay(150);
            headsView.IsVisible = false;
            topView.IsVisible = true;
            tailsView.IsVisible = false;
            await Task.Delay(150);
            headsView.IsVisible = false;
            topView.IsVisible = true;
            tailsView.IsVisible = false;
            await Task.Delay(150);

            headsView.IsVisible = false;
            topView.IsVisible = false;
            tailsView.IsVisible = true;
            await Task.Delay(150);

            headsView.IsVisible = false;
            topView.IsVisible = true;
            tailsView.IsVisible = false;
            await Task.Delay(150);

            headsView.IsVisible = true;
            topView.IsVisible = false;
            tailsView.IsVisible = false;
            await Task.Delay(150);
            headsView.IsVisible = false;
            topView.IsVisible = true;
            tailsView.IsVisible = false;
            await Task.Delay(150);


            int randomNumber = new Random().Next(1, 101);
            string result = (randomNumber < 50) ? "Tails" : "Heads";


            // Optionally, add a delay here before setting the final state
            // await Task.Delay(500);

            if (result == "Tails")
            {
                headsView.IsVisible = false;
                topView.IsVisible = false;
                tailsView.IsVisible = true;
                tailsLbl.IsVisible = true;
            }
            else
            {
                headsView.IsVisible = true;
                topView.IsVisible = false;
                tailsView.IsVisible = false;
                headsLbl.IsVisible = true;
            }
            coinFlipBtn.Text = "Back To Game";



        }
        else
        {
            Application.Current.MainPage = new YuGiHoLifeCounter();
        }
    }
}
    
