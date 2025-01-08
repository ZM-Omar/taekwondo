using Microsoft.Maui.Controls;

namespace MauiApp1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnGenerateSalaClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new GenerarSalaPage());
        }
    }
}
