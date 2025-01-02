using ConcertBookingApp.Models;

public interface IConcertService
{
    Task<List<Concert>> GetConcertsAsync();
}