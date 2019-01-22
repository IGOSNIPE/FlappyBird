using SFML;

namespace flappybird
{
    class Obstacle
    {
        SFML.Graphics.RectangleShape obstacle;
        static SFML.System.Vector2f obstacleVelocity = new SFML.System.Vector2f(-0.01f, 0f);
        SFML.Graphics.Texture obstacleTexture;

        public Obstacle()
        {
            obstacle = new SFML.Graphics.RectangleShape(new SFML.System.Vector2f(100, 300));
            obstacleTexture = new SFML.Graphics.Texture(100, 300);
            obstacle.Position = new SFML.System.Vector2f(500, 0);
            //  obstacle.Texture = obstacleTexture;
            obstacle.FillColor = SFML.Graphics.Color.Red;
        }

        public void MoveLeft()
        {
            obstacle.Position += obstacleVelocity;
            if (obstacle.Position.X <= -100)
            {
                obstacle.Position += new SFML.System.Vector2f(1000f,0f);
            }
        }

        public void Draw(SFML.Graphics.RenderWindow target)
        {
            target.Draw(obstacle);
        }
    }
}
