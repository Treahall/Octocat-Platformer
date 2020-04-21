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
using System.Drawing;
using Size = System.Drawing.Size;
using Point = System.Drawing.Point;

namespace Game
{
    public abstract class Entity
    {
        public Rectangle HitBox;
        public int AnimationIndex = 0;
        public bool dead;

        //stores important animations for an entity
        public List<string> CurrentAnimation = null;
        public List<string> previousAnimation = null;

        //Used to calculate and store values for movement
        protected Point Position; //Location of game entity. = (X, Y).
        protected Point Velocity; //Velocity of game entity in pixels/frame = (Change of X, Change of Y)

        public Entity()
        {
            dead = false;
        }

        public abstract void Update(WriteableBitmap s);
        public abstract void LoadAnimations();
        public abstract void setAnimation();

//=============================================================================================
        //Uses rectangles to represent the space an entity takes up.
        public void UpdateHitBox()
        {
            HitBox = new Rectangle(Position, GetSpriteSize());
        }

        //gets the width and height of the current animation.
        public Size GetSpriteSize()
        {
            if (CurrentAnimation != null)
            {
                BitmapImage Img = new BitmapImage(new Uri(CurrentAnimation[AnimationIndex], UriKind.Relative));
                return new Size(Img.PixelWidth, Img.PixelHeight);
            }
            else return new Size(0, 0);
        }

//=============================================================================================
        
        public virtual void Draw(WriteableBitmap surface)
        {

            //Create bitmap from an image source.
            BitmapImage img = new BitmapImage(new Uri(CurrentAnimation[AnimationIndex], UriKind.Relative));
            WriteableBitmap EntityBitMap = new WriteableBitmap(img);

            //Merge image onto screen. Blit uses System.Windows for Point and Size.
            surface.Blit(new System.Windows.Point(Position.X, Position.Y), EntityBitMap, 
                new Rect(new System.Windows.Size(EntityBitMap.PixelWidth, EntityBitMap.PixelHeight)), 
                Colors.White, WriteableBitmapExtensions.BlendMode.Alpha);

            //Next animationIndex
            AnimationIndex = (AnimationIndex + 1) % CurrentAnimation.Count;
        }
    }
}
