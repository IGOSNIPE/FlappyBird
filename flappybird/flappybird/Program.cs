using SFML;

namespace flappybird
{
    class Program
    {
        static void Main(string[] args)
        {
            SFML.Window.VideoMode mode = new SFML.Window.VideoMode(800, 600);
            SFML.Graphics.RenderWindow window = new SFML.Graphics.RenderWindow(mode, "Flappy Bird");
            GameState myState = new GameState();
            
            while (true)
            {
                myState.Update();
                myState.Draw(window);
            }
        }
    }
}
