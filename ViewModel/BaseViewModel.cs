
using CommunityToolkit.Mvvm.ComponentModel;

namespace HelloPole.ViewModel;

public partial class BaseViewModel : ObservableObject
{
    [ObservableProperty]
    bool isBusy;
}
