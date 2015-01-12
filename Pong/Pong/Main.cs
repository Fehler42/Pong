﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SFML.Window;
using SFML.Graphics;

namespace Pong
{
    class Game
    {

        public static void Main()
        {
            // Erzeuge ein neues Fenster
            RenderWindow win = new RenderWindow(new VideoMode(800, 600), "Mein erstes Fenster");

            GameTime time = new GameTime();
            // Achte darauf, ob Fenster geschlossen wird
            win.Closed += win_Closed;

            initialize();
            loadContent();

            time.start();

            // Das eigentliche Spiel
            while (win.IsOpen())
            {
                // Schauen ob Fenster geschlossen werden soll
                win.DispatchEvents();
                time.update();

                update(time);
                draw(win, time);
            }
            time.stop();
        }

        static void win_Closed(object sender, EventArgs e)
        {
            // Fenster Schließen
            ((RenderWindow)sender).Close();
        }

        static Player player1;
        static Player2 player2;
        static Ball ball;
        static void initialize()
        {
            player1 = new Player();
            player2 = new Player2();
            ball = new Ball();
        }

        static void loadContent()
        {

        }

        static void update(GameTime time)
        {
            player1.move(time);
            player2.move(time);
            ball.move();
            if (collision(player1.getPosition(),player1.getHeight(),player1.getWidth(),ball.getPosition(),ball.getHeight(),ball.getWidth())==true)
                ball.setDirection(new Vector2f(0, 0.2f));
            if (collision(player2.getPosition(), player2.getHeight(), player2.getWidth(), ball.getPosition(), ball.getHeight(), ball.getWidth()) == true)
                ball.setDirection(new Vector2f(0, -0.2f));
    
        }

        static void draw(RenderWindow win, GameTime time)
        {

            win.Clear(new Color(0, 0, 0));
            player1.draw(win);
            player2.draw(win);
            ball.draw(win);
            win.Display();
        }

        static bool collision(Vector2f obj1, float hObj1, float wObj1, Vector2f obj2, float hObj2, float wObj2)
        {
           
            Vector2f Mobj1 = new Vector2f(obj1.X + wObj1 / 2, obj1.Y + hObj1 / 2);
            Vector2f Mobj2 = new Vector2f(obj2.X + wObj2 / 2, obj2.Y + hObj2 / 2);

            float rx1 = wObj1 / 2;
            float rx2 = wObj2 / 2;

            float ry1 = hObj1 / 2;
            float ry2 = hObj2 / 2;

            float dx = Math.Abs(Mobj1.X - Mobj2.X);
            float dy = Math.Abs(Mobj1.Y - Mobj2.Y);

            if (dx < rx1 + rx2 && dy < ry1 + ry2)
                return true;

            else
                return false;
      

        }
    }
}
