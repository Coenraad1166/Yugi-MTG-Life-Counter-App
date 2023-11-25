namespace LifeCounter_App.MVVM.Views.MTGArenaPages;

public partial class RollDicePage : ContentPage
{
	public RollDicePage()
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

    private void Roll_Clicked(object sender, EventArgs e)
    {
        Random random = new Random();
        if( rollBtn.Text == "Roll")
        {
            int playerOne = random.Next(0, 21);
            rollResult.Text = playerOne.ToString();
            playerOneRoll.Text = playerOne.ToString();
            rollBtn.Text = "Roll Again";
            playerOneRoll.IsVisible = true;
        }
        else if ( rollBtn.Text == "Roll Again")
        {
            int playerTwo = random.Next(0, 21);
            rollResult.Text = playerTwo.ToString();
            playerTwoRoll.Text = playerTwo.ToString();
            rollBtn.Text = "Back To Game";
            playerTwoRoll.IsVisible = true;
        } else
        {
            Application.Current.MainPage = new MTGLifeCounter();
        }

       
    }
}