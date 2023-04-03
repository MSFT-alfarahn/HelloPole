

namespace HelloPole.ViewModel;


public partial class LoginViewModel : BaseViewModel 
{
    [ObservableProperty]
    string username;

    [ObservableProperty]
    string password;

    public bool IsLoginEnabled { get; set; }
    public LoginViewModel()
    {
    }

    [RelayCommand]
    private async void Login()
    {
        IsLoginEnabled = false;
        IsBusy = true;
        await Task.Delay(2000); // Make auth call, we dont know how long time it takes!
        IsBusy = false;

        if (Password == "admin")
        {
            await Application.Current.MainPage.DisplayAlert("Login", "Login Success", "OK");
            string token = Guid.NewGuid().ToString();   
            await Shell.Current.GoToAsync($"//{nameof(HomePage)}?Token={token}");    
        }
        else
        {
            await Application.Current.MainPage.DisplayAlert("Login", "Login Failed", "OK");
        }
        IsLoginEnabled = true;
    }
}

