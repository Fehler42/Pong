using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SFML.Window;
using SFML.Graphics;

namespace Pong
{
    class Player
    {
        Vector2f playerPosition;
        Sprite playerSprite;

        public Vector2f getPosition()
        {
            return playerPosition;
        }

        public float getHeight()
        {
            return playerSprite.Texture.Size.Y * playerSprite.Scale.Y;
        }

        public float getWidth()
        {
            return playerSprite.Texture.Size.X * playerSprite.Scale.X;
        }




        public Player()
        {
            Texture playerTexture = new Texture("Pics/player.png");
            playerSprite = new Sprite(playerTexture);

            playerPosition = new Vector2f(51, 51);
            playerSprite.Position = playerPosition;

            playerSprite.Scale = new Vector2f(0.2f, 0.05f);
        }

        public void move(GameTime time)
        {
            float runningSpeed = 0.3f * time.EllapsedTime.Milliseconds;

            if (Keyboard.IsKeyPressed(Keyboard.Key.A))
                playerPosition = new Vector2f(playerPosition.X -0.2f, playerPosition.Y);
            if (Keyboard.IsKeyPressed(Keyboard.Key.D))
                playerPosition = new Vector2f(playerPosition.X +0.2f, playerPosition.Y);


            playerSprite.Position = playerPosition;
        }

        public void draw(RenderWindow win)
        {
            win.Draw(playerSprite);
        }

    }
}

