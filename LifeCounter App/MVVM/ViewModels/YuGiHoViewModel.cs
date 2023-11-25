using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeCounter_App.MVVM.ViewModels
{
    public class YuGiHoViewModel
    {
        public void UpdateLifeTotal(Button button)
        {
            string btnText = button.Text;
            int sign = btnText.StartsWith('-') ? -1 : 1;
            if (int.TryParse(btnText.TrimStart('-','+'), out int value))
            {
                Grid grid = button.Parent as Grid;

                if (grid != null)
                {
                    Label lifeTotal = grid.Children.OfType<Label>().FirstOrDefault();
                    if  (lifeTotal != null) { 
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
                    if (lifeTotal != null) {
                        var promptText = await contentPage.DisplayPromptAsync("Enter Number", "Please enter number to add to life", "Update");
                        var lifeToNumber = int.Parse(lifeTotal.Text);
                        var promptParse = int.Parse(promptText);
                        lifeToNumber += promptParse;
                        var lifeBacktoText = lifeToNumber.ToString();
                        lifeTotal.Text = lifeBacktoText;
                    }
                }
            } else
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
                lifeTotal.Text = "8000";
            }
        }
        public void GetMetaItemLink(Button button)
        {
            switch (button.Text)
            {
                case "Purrely":
                    OpenLink("https://www.masterduelmeta.com/tier-list/deck-types/Purrely");
                    break;
                case "Dragon Link":
                    OpenLink("https://www.masterduelmeta.com/tier-list/deck-types/Dragon%20Link");
                    break;
                case "Labrynth":
                    OpenLink("https://www.masterduelmeta.com/tier-list/deck-types/Labrynth");
                    break;
                case "MathMech":
                    OpenLink("https://www.masterduelmeta.com/tier-list/deck-types/Mathmech");
                    break;
                case "Kashtira":
                    OpenLink("https://www.masterduelmeta.com/tier-list/deck-types/Kashtira");
                    break;
                case "Vanquish Soul":
                    OpenLink("https://www.masterduelmeta.com/tier-list/deck-types/Vanquish%20Soul");
                    break;
            }
        }
        private async void OpenLink(string url)
        {
            await Browser.Default.OpenAsync(new Uri(url), BrowserLaunchMode.SystemPreferred);
        }
    }
}
