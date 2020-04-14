using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using static System.Windows.Media.Imaging.WriteableBitmapExtensions;

// TO DO: Is StageGraphics needed?
//using Game.Data;

namespace Game
{
    public abstract class Entity
    {
        // TO DO: depends on StageGraphics
        //public int floor = (int)(StageGraphics.FloorPos.Y);

        public int AnimationIndex = 0, speed;
        public int FrameCount = 0, Fpa = 10; //fpa is frames per animation.
        public double leftbound = 0, rightbound;

        //stores all animations for an entity
        public List<string> CurrentAnimation = null;
        public List<string> previousAnimation = null;
        public List<string> runAnimation = null;


        // TO DO: figure out why Vector2 won't work?
        public Vector2 Position { get; set; } //Location of game entity. = (X, Y).
        public Vector2 Velocity { get; set; } //Velocity of game entity in pixels/sec. = (Change of X, Change of Y)

        public Entity()
        {
            setSpeed();
        }

        public abstract void setSpeed();
        public abstract void SetVelocity(); //sets the velocity for the next movement.
        public abstract void LoadAnimations();
        public abstract void setAnimation();

        public Size GetSpriteSize()
        {
            if (CurrentAnimation != null)
            {
                return new Size((double)new BitmapImage(new Uri(CurrentAnimation[AnimationIndex], UriKind.Relative)).PixelWidth,
                    (double)new BitmapImage(new Uri(CurrentAnimation[AnimationIndex], UriKind.Relative)).PixelHeight);
            }
            else return new Size(0, 0);
        }

        public virtual void Draw(WriteableBitmap surface)
        {
            BitmapImage img = new BitmapImage(new Uri(CurrentAnimation[AnimationIndex], UriKind.Relative));
            WriteableBitmap bm = new WriteableBitmap(img);

            //resets animation index to 0 if animation index + 1 is out of bounds
            if (AnimationIndex >= CurrentAnimation.Count - 1)
                AnimationIndex = 0;
            //Increments animation index by 1 when FrameCount is less then fpa
            else if ((FrameCount += 1) > Fpa)
            {
                AnimationIndex += 1;
                FrameCount = 0;
            }
        }

        public void Update(float millisecondsPassed)
        {
            //some code may not be necessary or may be used differently
            /*
            //set right bound for specific image
            rightbound = StageGraphics.WindowWidth - GetSpriteSize().Width;
            SetVelocity();
            //Calculate what floor should be.
            floor = (int)(StageGraphics.FloorPos.Y - GetSpriteSize().Height);
            Position += Velocity * (millisecondsPassed / 1000f);
            */
        }
    }
}
