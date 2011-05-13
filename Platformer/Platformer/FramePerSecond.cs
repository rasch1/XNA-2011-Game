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


        public float fps;

        public FramePerSecond(GameTime time)
        {
            this.fps = 1 / (float) time.ElapsedGameTime.TotalSeconds;
        }

    }



}
