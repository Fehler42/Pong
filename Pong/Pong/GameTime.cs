﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SFML.Window;
using SFML.Graphics;
using System.Diagnostics;

namespace Pong
{
    class GameTime
    {

        Stopwatch watch;
        public TimeSpan TotalTime;
        public TimeSpan EllapsedTime;

        public GameTime()
        {
            watch = new Stopwatch();
            TotalTime = TimeSpan.FromSeconds(0);
            EllapsedTime = TimeSpan.FromSeconds(0);
        }

        public void start()
        {
            watch.Start();
        }

        public void stop()
        {
            watch.Reset();
            TotalTime = TimeSpan.FromSeconds(0);
            EllapsedTime = TimeSpan.FromSeconds(0);
        }

        public void update()
        {
            EllapsedTime = watch.Elapsed - TotalTime;
            TotalTime = watch.Elapsed;

        }
    }
}
