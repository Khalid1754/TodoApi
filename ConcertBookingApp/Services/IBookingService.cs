using ConcertBookingApp.Models;

namespace ConcertBookingApp.Services;

public interface IBookingService
{
    Task SaveBookingAsync(Booking booking, bool isNew);
    Task DeleteBookingAsync(Booking booking);
}