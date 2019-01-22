using SFML;

namespace flappybird
{
    class Player
    {
        SFML.Graphics.CircleShape shape;
        SFML.System.Vector2f velocity;
        SFML.System.Vector2f gravityForce; // const
        SFML.Graphics.Texture texture;

        public Player()
        {
            //    texture = new SFML.Graphics.Texture() do uzupełnienia
            gravityForce = new SFML.System.Vector2f(0f, 0.00005f);
            texture = new SFML.Graphics.Texture(800, 800);
            shape = new SFML.Graphics.CircleShape(30f);
            shape.Position = new SFML.System.Vector2f(20, 400);
            // shape.Texture = texture;
            shape.FillColor = SFML.Graphics.Color.Cyan;
        }

        public void Draw(SFML.Graphics.RenderWindow target)
        {
            target.Draw(shape);
        }

        public void MoveUp()
        {
            if(velocity.Y < 1000f)
            {
                velocity.Y += 0.0005f;
            }
        }

        public void MoveDown()
        {
            velocity.Y -= gravityForce.Y;
            if (velocity.Y > 0 || shape.Position.Y <= 540) shape.Position = shape.Position - velocity;
        }
        public void BorderUp()
        {
            if (shape.Position.Y <= 30)
            {
                velocity.Y = 0f;
                velocity.Y -= gravityForce.Y;
            }
        }
        public void BorderDown()
        {
            if (shape.Position.Y >= 540)
            {
                if (velocity.Y < 0f) velocity.Y = 0f;
            }
        }
    }
}
