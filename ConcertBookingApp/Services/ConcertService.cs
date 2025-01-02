using ConcertBookingApp.Models;

public class ConcertService : IConcertService
{

    public async Task<List<Concert>> GetConcertsAsync()
    {
        
        return await Task.FromResult(new List<Concert>
        {
            new Concert
            {
                Id = 1,
                Title = "Rock the Night",
                Description = "An electrifying rock concert.",
                Duration = 120,
                Price = 499.99m,
                Genres = { "Rock", "Pop" }
            },
            new Concert
            {
                Id = 2,
                Title = "Jazz Evening",
                Description = "A relaxing evening of smooth jazz.",
                Duration = 90,
                Price = 299.99m,
                Genres = { "Jazz", "Blues" }
            },
            new Concert
            {
                Id = 3,
                Title = "Symphony of Stars",
                Description = "A grand symphonic performance under the stars.",
                Duration = 150,
                Price = 699.99m,
                Genres = { "Classical", "Instrumental" }
            },
            new Concert
            {
                Id = 4,
                Title = "Hip-Hop Beats Live",
                Description = "Experience the best of live hip-hop music.",
                Duration = 110,
                Price = 399.99m,
                Genres = { "Hip-Hop", "Rap" }
            },
            new Concert
            {
                Id = 5,
                Title = "Country Roads Festival",
                Description = "A festival celebrating the best of country music.",
                Duration = 180,
                Price = 349.99m,
                Genres = { "Country", "Folk" }
            },
            new Concert
            {
                Id = 6,
                Title = "EDM Rave Night",
                Description = "An energetic night of electronic dance music.",
                Duration = 240,
                Price = 549.99m,
                Genres =    { "EDM", "Dance" }
            },
            new Concert
            {
                Id = 7,
                Title = "Soulful Sundays",
                Description = "End your weekend with soulful melodies.",
                Duration = 100,
                Price = 299.99m,
                Genres =  { "Soul", "R&B" }
            },
            new Concert
            {
                Id = 8,
                Title = "Reggae Jam",
                Description = "Feel the rhythm of reggae music live.",
                Duration = 120,
                Price = 319.99m,
                Genres = { "Reggae", "Dub" }
            }
        });
    }
}