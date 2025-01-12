using ConcertBookingApp.Models;
using ConcertBookingApp.Services;

namespace ConcertBookingApp.Views;

public partial class BookingPage : ContentPage
{
    private readonly IBookingService _bookingService;
    private Booking _booking;

    public BookingPage(IBookingService bookingService, Concert selectedConcert)
    {
        InitializeComponent();
        _bookingService = bookingService;

        // Skapa en ny bokning baserat på vald konsert
        _booking = new Booking
        {
            CustomerName = string.Empty, // Fylls i av användaren
            CustomerEmail = string.Empty,
            CustomerPhone = string.Empty
        };

        BindingContext = _booking;
    }

    private async void OnSaveButtonClicked(object sender, EventArgs e)
    {
        await _bookingService.SaveBookingAsync(_booking, true);
        await Shell.Current.GoToAsync(".."); // Navigera tillbaka

        await DisplayAlert("Booking Confirmed", $"You have successfully booked the concert.", "OK");
    }

    private async void OnDeleteButtonClicked(object sender, EventArgs e)
    {
        await _bookingService.DeleteBookingAsync(_booking);
        await Shell.Current.GoToAsync(".."); // Navigera tillbaka
    }

    private async void OnCancelButtonClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(".."); // Navigera tillbaka
    }
}

/*public partial class BookingPage : ContentPage
{
    private readonly IBookingService _bookingService;
    private Booking _booking;
    private bool _isNewBooking;

    public BookingPage(IBookingService service)
    {
        InitializeComponent();
        _bookingService = service;
        BindingContext = this;
    }

    public Booking Booking
    {
        get => _booking;
        set
        {
            _isNewBooking = IsNewItem(value);
            _booking = value;
            OnPropertyChanged();
        }
    }

    private bool IsNewItem(Booking booking) => string.IsNullOrWhiteSpace(booking.CustomerName);

    private async void OnSaveButtonClicked(object sender, EventArgs e)
    {
        await _bookingService.SaveBookingAsync(Booking, _isNewBooking);
        await Shell.Current.GoToAsync("..");
    }

    private async void OnDeleteButtonClicked(object sender, EventArgs e)
    {
        await _bookingService.DeleteBookingAsync(Booking);
        await Shell.Current.GoToAsync("..");
    }

    private async void OnCancelButtonClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("..");
    }
}*/