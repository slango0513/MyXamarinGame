using Xenko.Engine;

namespace MyXamarinGame.Linux
{
    class MyXamarinGameApp
    {
        static void Main(string[] args)
        {
            using (var game = new Game())
            {
                game.Run();
            }
        }
    }
}
