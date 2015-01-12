using SFML.Graphics;
using SFML.Window;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pong
{
    class Ball
    {

        Sprite Tilesprite;
        Vector2f Ballposition;
        Vector2f Direction;

        public Vector2f getPosition()
        {
            return Ballposition;
        }
        public void setDirection(Vector2f newdirection)
        {
            Direction = newdirection;
        }
        public Vector2f getDirection()
        {
            return Direction;
        }
        public float getHeight()
        {
            return Tilesprite.Texture.Size.Y * Tilesprite.Scale.Y;
        }

        public float getWidth()
        {
            return Tilesprite.Texture.Size.X * Tilesprite.Scale.X;
        }

        public Ball()
        {
            Texture Balltexture = new Texture("Pics/Ball.png");
            Tilesprite = new Sprite(Balltexture);

            Ballposition = new Vector2f(400, 300);
            Tilesprite.Position = Ballposition;
            Direction = new Vector2f(0, 0.2f);
            Ballposition += Direction;
            Tilesprite.Position = Ballposition;
        }


        public void draw(RenderWindow win)
        {
            win.Draw(Tilesprite);
        }

        public void move()
        {
            /*position.X += 0.1f;
            if(position.X > 800)
            {
                position.X = position.X % 800;
            }*/


            // if(player2.getPosition()=Ballposition)
            Ballposition += Direction;
            Tilesprite.Position = Ballposition;
        }
    }
}

