
using Android.App;
using Android.Content;
using Android.Media;
using Android.Widget;
using AndroidX.Core.App;
using HelloPole.Model;

namespace HelloPole.Platforms.Android;

public class NotificationService : INotificationService
{
    public void Notify(string message)
    {
        Toast toast = Toast.MakeText(Platform.CurrentActivity, message, ToastLength.Long);
        toast.Show();
    }
}
