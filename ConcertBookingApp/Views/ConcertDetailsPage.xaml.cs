using ConcertBookingApp.Models;
using ConcertBookingApp.Services;

namespace ConcertBookingApp.Views
{
    public partial class ConcertDetailsPage : ContentPage
    {
        public Concert SelectedConcert { get; set; }

        // Konstruktor som tar emot en hel Concert-objekt
        public ConcertDetailsPage(Concert selectedConcert)
        {
            InitializeComponent();
            SelectedConcert = selectedConcert;
            BindingContext = SelectedConcert;
        }

        private async void OnBookClicked(object sender, EventArgs e)
        {
            await DisplayAlert("Bokad", "Du har bokat konserten.", "OK");
        }

        private async void OnCancelBookingClicked(object sender, EventArgs e)
        {
            await DisplayAlert("Avbokad", "Du har avbokat konserten.", "OK");
        }
    }
}