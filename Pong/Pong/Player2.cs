using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            Texture playerTexture = new Texture("Pictures/player.png");
            playerSprite2 = new Sprite(playerTexture);

            playerPosition2 = new Vector2f(51, 500);
            playerSprite2.Position = playerPosition2;

            playerSprite2.Scale = new Vector2f(0.2f, 0.05f);
        }

        public void move(Map map, GameTime time)
        {
            float runningSpeed = 0.3f * time.EllapsedTime.Milliseconds;

            bool Left = map.isWalckable((int)(this.getPosition().X - runningSpeed) / 50, (int)(this.getPosition().Y) / 50) && map.isWalckable((int)(this.getPosition().X - runningSpeed) / 50, (int)(this.getPosition().Y + this.getHeight()) / 50);
            bool Right = map.isWalckable((int)(this.getPosition().X + this.getWidth() + runningSpeed) / 50, (int)(this.getPosition().Y) / 50) && map.isWalckable((int)(this.getPosition().X + this.getWidth() + runningSpeed) / 50, (int)(this.getPosition().Y + this.getHeight()) / 50);
            bool Up = map.isWalckable((int)(this.getPosition().X) / 50, (int)(this.getPosition().Y - runningSpeed) / 50) && map.isWalckable((int)(this.getPosition().X + this.getWidth()) / 50, (int)(this.getPosition().Y - runningSpeed) / 50);
            bool Down = map.isWalckable((int)(this.getPosition().X) / 50, (int)(this.getPosition().Y + this.getHeight() + runningSpeed) / 50) && map.isWalckable((int)(this.getPosition().X + this.getWidth()) / 50, (int)(this.getPosition().Y + this.getHeight() + runningSpeed) / 50);


            if (Keyboard.IsKeyPressed(Keyboard.Key.J) && Left)
                playerPosition2 = new Vector2f(playerPosition2.X - runningSpeed, playerPosition2.Y);
            if (Keyboard.IsKeyPressed(Keyboard.Key.L) && Right)
                playerPosition2 = new Vector2f(playerPosition2.X + runningSpeed, playerPosition2.Y);
            /* if (Keyboard.IsKeyPressed(Keyboard.Key.W) && Up)
                playerPosition = new Vector2f(playerPosition.X, playerPosition.Y - runningSpeed);
            if (Keyboard.IsKeyPressed(Keyboard.Key.S) && Down)
                playerPosition = new Vector2f(playerPosition.X, playerPosition.Y + runningSpeed); */

            playerSprite2.Position = playerPosition2;
        }

        public void draw(RenderWindow win)
        {
            win.Draw(playerSprite2);
        }

    }
}
