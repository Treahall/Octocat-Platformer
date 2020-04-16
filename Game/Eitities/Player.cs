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

namespace Game.Eitities
{
    class Player : Entity
    {
        bool jumping, falling, ducking;
        int jumpForce = 400, force;
        float playerPositionX = 1440 / 8;
        public string jumpAnimation;
        public string duckAnimation;

        // TO DO: Start() versus Player()?? 
        public Player() : base()
        {
            LoadAnimations();
            force = -jumpForce;

            jumping = false; falling = false; ducking = false;
            //Initial position
            Position = new System.Numerics.Vector2((float)(playerPositionX), floor -= (int)GetSpriteSize().Height);
        }

        //starts the running animation and allows you to control player with arrow keys
        public void Start()
        {
            setAnimation();
        }

        // TO DO: needed??
        public override void setSpeed()
        {
            speed = 0;
        }

        // TO DO: needed??
        public override void SetVelocity()
        {

        }

        //check for arrow keys pressed then jump or duck if correct key is pressed
        public override void Update(WriteableBitmap s)
        {
            if(Keyboard.IsKeyDown(Key.Down))
            {
                Duck();
            }
            else if(Keyboard.IsKeyDown(Key.Up))
            {
                Jump();
            }
            Draw(s);
        }

        public override void Draw(WriteableBitmap surface)
        {
            base.Draw(surface);
        }

        // TO DO: Figure out algorithm for jumping in place. 
        //Should just move the player up and down in a straight line. Should switch animation when player begins falling.
        void Jump()
        {
            jumping = true;
            setAnimation();
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
            
            if (previousAnimation != CurrentAnimation) AnimationIndex = 0;
        }
    }
}
