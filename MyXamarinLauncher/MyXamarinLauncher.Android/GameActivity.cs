using Android.App;
using Android.Content.PM;
using Android.OS;
using Xenko.Engine;
using Xenko.Starter;

namespace MyXamarinLauncher.Droid
{
    [Activity(Label = "GameActivity",
        ScreenOrientation = ScreenOrientation.Landscape,
        ConfigurationChanges = ConfigChanges.UiMode | ConfigChanges.Orientation | ConfigChanges.KeyboardHidden | ConfigChanges.ScreenSize)]
    public class GameActivity : AndroidXenkoActivity
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
