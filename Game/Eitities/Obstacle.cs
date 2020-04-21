using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using static System.Windows.Media.Imaging.WriteableBitmapExtensions;
using Point = System.Drawing.Point;

namespace Game.Entities
{
    
    abstract class Obstacle : Entity
    {
        public Player User;
        int Speed;

        public Obstacle(Player U) : base()
        {
            Speed = 15;
            User = U;
            LoadAnimations();
            Velocity = new Point(-Speed, 0); //Magic value for velocity.
        }

        public Obstacle(Player U, int speed) : base()
        {
            Speed = speed;
            User = U;
            LoadAnimations();
            Velocity = new Point(-Speed, 0); //Magic value for velocity.
        }

//=============================================================================================
        //Functions controlled by the parent.
        public override void Update(WriteableBitmap s)
        {
            //Move the Entity by velocity
            Position.Offset(Velocity);
            UpdateHitBox();
            CheckCollision();
            Draw(s);
        }

        public override void Draw(WriteableBitmap surface)
        {
            base.Draw(surface);
        }

        //Checks if obstacle intersects with its user.
        public void CheckCollision()
        {
            if (HitBox.IntersectsWith(User.HitBox))
            {
                CollisionEvents();
            }
        }

//=============================================================================================
        //Lets subclasses define the abstract functions below.
        public override abstract void LoadAnimations();
        public abstract void CollisionEvents();

        //Function not needed since we dont change animations.
        public override void setAnimation() { }
    }
}
