using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeCounter_App.MVVM.ViewModels
{
    public class MTGViewModel
    {
        public void UpdateLifeTotal(Button button)
        {
            string btnText = button.Text;
            int sign = btnText.StartsWith('-') ? -1 : 1;
            if (int.TryParse(btnText.TrimStart('-', '+'), out int value))
            {
                Grid grid = button.Parent as Grid;

                if (grid != null)
                {
                    Label lifeTotal = grid.Children.OfType<Label>().FirstOrDefault();
                    if (lifeTotal != null)
                    {
                        lifeTotal.Text = (int.Parse(lifeTotal.Text) + sign * value).ToString();
                    }
                }
            }
        }
        public async void UpdateLifeTotalManual(Button button, ContentPage contentPage)
        {
            string btnText = button.Text;
            if (btnText == "Plus")
            {
                Grid grid = button.Parent as Grid;
                VerticalStackLayout gridTwo = grid.Parent as VerticalStackLayout;

                if (gridTwo != null)
                {
                    Grid gridWithLabel = gridTwo.Children.OfType<Grid>().LastOrDefault();
                    Label lifeTotal = gridWithLabel.Children.OfType<Label>().FirstOrDefault();
                    if (lifeTotal != null)
                    {
                        var promptText = await contentPage.DisplayPromptAsync("Enter Number", "Please enter number to add to life", "Update");
                        var lifeToNumber = int.Parse(lifeTotal.Text);
                        var promptParse = int.Parse(promptText);
                        lifeToNumber += promptParse;
                        var lifeBacktoText = lifeToNumber.ToString();
                        lifeTotal.Text = lifeBacktoText;
                    }
                }
            }
            else
            {
                Grid grid = button.Parent as Grid;
                VerticalStackLayout gridTwo = grid.Parent as VerticalStackLayout;

                if (gridTwo != null)
                {
                    Grid gridWithLabel = gridTwo.Children.OfType<Grid>().LastOrDefault();
                    Label lifeTotal = gridWithLabel.Children.OfType<Label>().FirstOrDefault();
                    if (lifeTotal != null)
                    {
                        var promptText = await contentPage.DisplayPromptAsync("Enter Number", "Please enter number to add to life", "Update");
                        var lifeToNumber = int.Parse(lifeTotal.Text);
                        var promptParse = int.Parse(promptText);
                        lifeToNumber -= promptParse;
                        var lifeBacktoText = lifeToNumber.ToString();
                        lifeTotal.Text = lifeBacktoText;
                    }
                }
            }
        }
        public void ResetLifeTotal(Button button)
        {
            VerticalStackLayout layout = button.Parent as VerticalStackLayout;
            if (layout != null)
            {
                Grid gridWithLabel = layout.Children.OfType<Grid>().LastOrDefault();
                Label lifeTotal = gridWithLabel.Children.OfType<Label>().FirstOrDefault();
                lifeTotal.Text = "20";
            }
        }
        public void GetMetaItemLink(Button button)
        {
            switch (button.Text)
            {
                case "Red Deck Wins":
                    OpenLink("https://mtgdecks.net/Standard/red-deck-wins");
                    break;
                case "Domain Ramp":
                    OpenLink("https://mtgdecks.net/Standard/domain-ramp");
                    break;
                case "Esper Midrange":
                    OpenLink("https://mtgdecks.net/Standard/esper-midrange");
                    break;
                case "Golgari Midrange":
                    OpenLink("https://mtgdecks.net/Standard/golgari-midrange");
                    break;
                case "Azorius Soldiers":
                    OpenLink("https://mtgdecks.net/Standard/azorius-soldiers");
                    break;
                case "White Weenie":
                    OpenLink("https://mtgdecks.net/Standard/white-weenie");
                    break;
                case "Esper Control":
                    OpenLink("https://mtgdecks.net/Standard/esper-control");
                    break;
            }
        }
        private async void OpenLink(string url)
        {
            await Browser.Default.OpenAsync(new Uri(url), BrowserLaunchMode.SystemPreferred);
        }
    }
}
