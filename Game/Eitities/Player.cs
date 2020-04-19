using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using static System.Windows.Media.Imaging.WriteableBitmapExtensions;

namespace Game.Entities
{
    class Player : Entity
    {
        bool jumping, falling, ducking;
        int jumpForce = 400, force;
        float userPosY, playerPositionX = 1440 / 8;
        float userVelocityY = 15;
        public List<string> jumpAnimation, duckAnimation, fallAnimation;

        public Player() : base()
        {
            LoadAnimations();
            force = -jumpForce;

            jumping = false; falling = false; ducking = false;

            userPosY = floor += (int)GetSpriteSize().Height; //677 is the initial size
            //Initial position
            Position = new System.Numerics.Vector2((float)(playerPositionX), userPosY);

            //Initial velocity
            Velocity = new System.Numerics.Vector2(0, 0);
        }

        //Starts the running animation and allows you to control player with arrow keys
        public void Start(WriteableBitmap s)
        {
            setAnimation();

            if (falling)
            {
                Fall();
            }
            else if (jumping)
            {
                Jump();
            }
            else if (Keyboard.IsKeyDown(Key.Up))
            {
                Jump();
            }
            else if (Keyboard.IsKeyDown(Key.Down))
            {
                Duck();
                ducking = false;
            }
            else
            {
                CurrentAnimation = runAnimation;
            }
            Draw(s);
        }

        // TO DO: needed??
        public override void setSpeed()
        {
            //speed = 0;
        }

        // TO DO: needed??
        public override void SetVelocity()
        {

        }

        //Checks for arrow keys pressed then jump or duck if correct key is pressed
        public override void Update(WriteableBitmap s)
        {
            if (falling)
            {
                Fall();
            }
            else if (jumping)
            {
                Jump();
            }
            else if (Keyboard.IsKeyDown(Key.Up))
            {
                Jump();
            }
            else if (Keyboard.IsKeyDown(Key.Down))
            {
                Duck();
                ducking = false;
            }
            else
            {
                CurrentAnimation = runAnimation;
            }
            Draw(s);
        }

        public override void Draw(WriteableBitmap surface)
        {
            base.Draw(surface);
        }
        
        //Should move the player up in a straight line. 
        void Jump()
        {
            jumping = true;
            setAnimation();

            
            if (userPosY < 420) // jump max
            {
                //user starts falling
                Fall();
                jumping = false;
                falling = true;
            }
            else 
            {
                userPosY -= userVelocityY;
                Position = new System.Numerics.Vector2(playerPositionX, userPosY);
            }
        }

        //Should move the player down in a straight line.
        void Fall()
        {
            setAnimation();

            if (userPosY > 677) //fall max
            {
                //user lands
                userPosY = 677;
                Position = new System.Numerics.Vector2(playerPositionX, userPosY);
                falling = false;
            }
            else
            {
                userPosY += userVelocityY;
                Position = new System.Numerics.Vector2(playerPositionX, userPosY);
            }

        }


        // TO DO: Change Octocat size to be shorter with the animation to avoid obstacles.
        void Duck()
        {
            ducking = true;
            setAnimation();
        }

        public override void LoadAnimations()
        {
            CurrentAnimation = HelperClasses.EntityAnimations.OctocatRun;
            runAnimation = HelperClasses.EntityAnimations.OctocatRun;
            jumpAnimation = HelperClasses.EntityAnimations.OctocatJump;
            duckAnimation = HelperClasses.EntityAnimations.OctocatDuck;
            fallAnimation = HelperClasses.EntityAnimations.OctocatFalling;
        }

        public override void setAnimation()
        {
            previousAnimation = CurrentAnimation;

            if (ducking)
            {
                CurrentAnimation = duckAnimation;
            }
            else if (jumping && !falling)
            {
                CurrentAnimation = jumpAnimation;
            }
            else if (!jumping && falling)
            {
                CurrentAnimation = fallAnimation;
            }
            else
            {
                CurrentAnimation = runAnimation;
            }

            if (previousAnimation != CurrentAnimation)
            {
                AnimationIndex = 0;
            }
        }
    }
}
