using System;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using Microsoft.Xna.Framework.Input.Touch;

/**
 * 
 * Created by Nicholas Ooi
 * 
 * */
namespace Platformer
{
    class FramePerSecond
    {


        private float fps;

        public float Fps
        {
            get { return fps; }
        }

        public void setFps(GameTime time)
        {
            this.fps = 1 / (float)time.ElapsedGameTime.TotalSeconds; ;
        }

        public FramePerSecond()
        {
        }


    }



}
