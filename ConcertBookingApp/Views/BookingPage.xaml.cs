using ConcertBookingApp.Models;
using ConcertBookingApp.Services;

namespace ConcertBookingApp.Views;

public partial class BookingPage : ContentPage
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
}