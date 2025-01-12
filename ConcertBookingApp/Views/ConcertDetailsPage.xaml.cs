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

        /*private async void OnBookClicked(object sender, EventArgs e)
        {
            await DisplayAlert("Bokad", "Du har bokat konserten.", "OK");
        }*/

        private async void OnBookClicked(object sender, EventArgs e)
        {
            // Navigera till BookingPage med vald konsert
            var bookingService = new BookingService(); // Förutsatt att du har en implementation
            await Navigation.PushAsync(new BookingPage(bookingService, SelectedConcert));
        }

        private async void OnCancelBookingClicked(object sender, EventArgs e)
        {
            await DisplayAlert("Cancelled", "You have cancelled the concert.", "OK");
        }
    }
}