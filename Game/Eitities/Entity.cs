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
using Game.HelperClasses;

namespace Game
{
    public abstract class Entity
    {
        public int floor = (int)(BackgroundAssets.Floor.Y);

        public int AnimationIndex = 0, speed;
        public int FrameCount = 0, Fpa = 1; //fpa is frames per animation.
        public double leftbound = 0, rightbound;

        //stores all animations for an entity
        public List<string> CurrentAnimation = null;
        public List<string> previousAnimation = null;
        public List<string> runAnimation = null;

        public Vector2 Position { get; set; } //Location of game entity. = (X, Y).
        public Vector2 Velocity { get; set; } //Velocity of game entity in pixels/sec. = (Change of X, Change of Y)

        public Entity()
        {
            setSpeed();
        }

        public abstract void Update(WriteableBitmap s);
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
            WriteableBitmap BackgroundBitMap = new WriteableBitmap(img);

            //merge image onto screen
            surface.Blit(new Point(Position.X, Position.Y), BackgroundBitMap, new Rect(new Size(BackgroundBitMap.PixelWidth, BackgroundBitMap.PixelHeight)), Colors.White, WriteableBitmapExtensions.BlendMode.Alpha);


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
    }
}
