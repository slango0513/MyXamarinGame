using Android.Content;
using MyXamarinLauncher.Droid;
using Xamarin.Forms;

[assembly: Dependency(typeof(AndroidGameStarter))]
namespace MyXamarinLauncher.Droid
{
    public class AndroidGameStarter : IGameStarter
    {
        public void StartGame()
        {
            var intent = new Intent(Android.App.Application.Context, typeof(GameActivity));
            Android.App.Application.Context.StartActivity(intent);
        }
    }
}
