using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MyXamarinLauncher
{
    public interface IGameStarter
    {
        void StartGame();
    }

    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(true)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void StartGameButton_Clicked(object sender, EventArgs e)
        {
            (sender as Button).Text = "载入中...";
            DependencyService.Get<IGameStarter>().StartGame();
        }
    }
}
