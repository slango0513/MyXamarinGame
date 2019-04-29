using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;

using Xenko.Engine;
using Xenko.Starter;
using Android.Content.PM;

namespace MyXamarinGame.Droid
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true,
          ScreenOrientation = ScreenOrientation.Landscape,
              ConfigurationChanges = ConfigChanges.UiMode | ConfigChanges.Orientation | ConfigChanges.KeyboardHidden | ConfigChanges.ScreenSize)]
    public class MainActivity : AndroidXenkoActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            Game = new Game();
            Game.Run(GameContext);
        }
    

        protected override void OnDestroy()
        {
            Game.Dispose();

            base.OnDestroy();
        }
    }
}