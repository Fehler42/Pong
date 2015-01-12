using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SFML.Window;
using SFML.Graphics;

namespace Pong
{
            
    class Player2
  {
        Vector2f playerPosition2;
        Sprite playerSprite2;
        

        public Vector2f getPosition()
        {
            return playerPosition2;
        }

        public float getHeight()
        {
            return playerSprite2.Texture.Size.Y * playerSprite2.Scale.Y;
        }

        public float getWidth()
        {
            return playerSprite2.Texture.Size.X * playerSprite2.Scale.X;
        }




        public Player2()
        {
            Texture playerTexture = new Texture("Pics/player2.png");
            playerSprite2 = new Sprite(playerTexture);

            playerPosition2 = new Vector2f(51, 500);
            playerSprite2.Position = playerPosition2;

            playerSprite2.Scale = new Vector2f(0.2f, 0.05f);
        }

        public void move(GameTime time)
        {
            float runningSpeed = 0.3f * time.EllapsedTime.Milliseconds;
            

            if (Keyboard.IsKeyPressed(Keyboard.Key.Left))
                playerPosition2 = new Vector2f(playerPosition2.X - runningSpeed, playerPosition2.Y);
            if (Keyboard.IsKeyPressed(Keyboard.Key.Right))
                playerPosition2 = new Vector2f(playerPosition2.X + runningSpeed, playerPosition2.Y);


            playerSprite2.Position = playerPosition2;
        }

        public void draw(RenderWindow win)
        {
            win.Draw(playerSprite2);
        }

    }
}
