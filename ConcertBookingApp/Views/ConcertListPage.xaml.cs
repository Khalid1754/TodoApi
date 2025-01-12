using ConcertBookingApp.Models;
using ConcertBookingApp.Services;

namespace ConcertBookingApp.Views;

public partial class ConcertListPage : ContentPage
{
    private readonly IConcertService _concertService;
    private List<Concert> _allConcerts;

    public List<Concert> Concerts { get; set; }

    public ConcertListPage(IConcertService concertService)
    {
        InitializeComponent();
        _concertService = concertService;
        LoadConcerts();
    }

    private async void LoadConcerts()
    {
        _allConcerts = await _concertService.GetConcertsAsync();
        Concerts = _allConcerts;

        BindingContext = this;
    }

    private void OnSearchBarTextChanged(object sender, TextChangedEventArgs e)
    {
        var searchText = e.NewTextValue?.ToLower();
        Concerts = string.IsNullOrEmpty(searchText)
            ? _allConcerts
            : _allConcerts.Where(c => c.Genres.Any(g => g.ToLower().Contains(searchText))).ToList();

        OnPropertyChanged(nameof(Concerts));
    }

    private async void OnViewDetailsClicked(object sender, EventArgs e)
    {
        var button = sender as Button;
        var selectedConcert = button?.BindingContext as Concert;
        if (selectedConcert != null)
        {
            await Navigation.PushAsync(new ConcertDetailsPage(selectedConcert));
        }
    }
}