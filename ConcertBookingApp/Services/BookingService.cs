using ConcertBookingApp.Models;

namespace ConcertBookingApp.Services;

public class BookingService : IBookingService
{
    private readonly List<Booking> _bookings = new();

    public Task SaveBookingAsync(Booking booking, bool isNew)
    {
        if (isNew)
        {
            _bookings.Add(booking);
        }
        else
        {
            var existing = _bookings.FirstOrDefault(b => b.CustomerEmail == booking.CustomerEmail);
            if (existing != null)
            {
                existing.CustomerName = booking.CustomerName;
                existing.CustomerPhone = booking.CustomerPhone;
                existing.IsComplete = booking.IsComplete;
            }
        }
        return Task.CompletedTask;
    }

    public Task DeleteBookingAsync(Booking booking)
    {
        _bookings.Remove(booking);
        return Task.CompletedTask;
    }
}