

using HelloPole.Model;


namespace HelloPole.ViewModel;

[QueryProperty("Token", "Token")]
public partial class HomeViewModel:BaseViewModel
{
    [ObservableProperty]
    string token;

    private INotificationService _notifier;

    public HomeViewModel(INotificationService notiticationService)
    {
        _notifier = notiticationService;
    }

    [RelayCommand]
    private async void Logout()
    {
        Token = null;
        await Shell.Current.GoToAsync($"//{nameof(LoginPage)}");
    }

    [RelayCommand]
    private void Notify()
    {
        _notifier.Notify("hello from MAUI");
    }
}
