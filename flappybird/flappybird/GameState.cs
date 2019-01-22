using SFML;

namespace flappybird
{
    class GameState : IState
    {
        Player player;
        Obstacle obstacle;

        public GameState()
        {
            player = new Player();
            obstacle = new Obstacle();
        }

        public bool Update()
        {
            player.BorderUp();
            player.BorderDown();
            player.MoveDown();
            obstacle.MoveLeft();

            if (SFML.Window.Keyboard.IsKeyPressed(SFML.Window.Keyboard.Key.Space))
            {
                player.MoveUp();
            }

            return true;
        }

        public void Draw(SFML.Graphics.RenderWindow target)
        {
            target.DispatchEvents();
            SFML.Graphics.RectangleShape background = new SFML.Graphics.RectangleShape(new SFML.System.Vector2f(800f, 600f));
            background.Texture = SFML.Graphics.Sprite.;
            target.Draw(background);
            player.Draw(target);
            obstacle.Draw(target);
            target.Display();
        }
    }
}
