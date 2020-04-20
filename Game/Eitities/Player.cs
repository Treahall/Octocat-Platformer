using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows;
using Game.HelperClasses;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using static System.Windows.Media.Imaging.WriteableBitmapExtensions;
using System.Numerics;

namespace Game.Entities
{

    enum States
    {
        running,
        Jumping,
        falling, 
        ducking
    }
    class Player : Entity
    {
        States playerState;
        public bool dead;
        float Ypos, Xpos, duckDist = 20;
        float Yvelocity = 15;
        public List<string> jumpAnimation, duckAnimation, fallAnimation, runAnimation;

        public Player() : base()
        {
            LoadAnimations();

            dead = false; 
            playerState = States.running;
            //Get the starting X and Y positions
            Ypos = floor += (float)GetSpriteSize().Height; //floor is 470
            Xpos = BackgroundAssets.startPos.X;

            //Initial position of the player
            Position = new System.Numerics.Vector2(Xpos, Ypos);
            //Initial velocity
            Velocity = new System.Numerics.Vector2(0, 0);
        }

//=============================================================================================
        //triggers events based on the players state.
        public override void Update(WriteableBitmap s)
        {
            switch (playerState)
            {
                case States.running:
                    RunEvents();
                    break;
                case States.Jumping:
                    JumpEvents();
                    break;
                case States.falling:
                    FallEvents();
                    break;
                case States.ducking:
                    DuckEvents();
                    break;
                default:
                    break;
            }
            Draw(s);
        }

        public override void Draw(WriteableBitmap surface)
        {
            base.Draw(surface);
        }

//=============================================================================================  
        //Checks for arrow keys pressed then jump or duck if correct key is pressed
        void RunEvents()
        {
            setAnimation();

            if (Keyboard.IsKeyDown(Key.Up))
            {
                playerState = States.Jumping;
            }
            else if (Keyboard.IsKeyDown(Key.Down))
            {
                //Move down
                Ypos += duckDist;
                Position = new Vector2(Xpos, Ypos);
                playerState = States.ducking;
            }
        }
//=============================================================================================
        //Should move the player up in a straight line. 
        void JumpEvents()
        {
            setAnimation();

            //reaches top of jump, so start falling.
            if (Ypos < 420) // jump max
            {
                //user starts falling
                FallEvents();
                playerState = States.falling;
            }
            else 
            {
                Ypos -= Yvelocity;
                Position = new System.Numerics.Vector2(Xpos, Ypos);
            }
        }

//=============================================================================================
        //Should move the player down in a straight line.
        void FallEvents()
        {
            setAnimation();

            //user lands
            if (Ypos > floor) //fall max
            {
                Ypos = floor;
                Position = new System.Numerics.Vector2(Xpos, Ypos);
                playerState = States.running;
            }
            //user is falling
            else
            {
                Ypos += Yvelocity;
                Position = new System.Numerics.Vector2(Xpos, Ypos);
            }

        }

//=============================================================================================
        // TO DO: Change Octocat size to be shorter with the animation to avoid obstacles.
        void DuckEvents()
        {
            setAnimation();

            if (!Keyboard.IsKeyDown(Key.Down))
            {
                //Move back up 
                Ypos -= duckDist;
                Position = new Vector2(Xpos, Ypos);
                playerState = States.running;
            }
        }

//=============================================================================================
        //loads in the string lists for the animation assets
        public override void LoadAnimations()
        {
            CurrentAnimation = HelperClasses.EntityAnimations.OctocatRun;
            runAnimation = HelperClasses.EntityAnimations.OctocatRun;
            jumpAnimation = HelperClasses.EntityAnimations.OctocatJump;
            duckAnimation = HelperClasses.EntityAnimations.OctocatDuck;
            fallAnimation = HelperClasses.EntityAnimations.OctocatFalling;
        }

//=============================================================================================
        //sets the animation based on current state
        public override void setAnimation()
        {
            //stores current animation.
            previousAnimation = CurrentAnimation;

            //updates the animation based on state
            switch (playerState)
            {
                case States.running:
                    CurrentAnimation = runAnimation;
                    break;
                case States.Jumping:
                    CurrentAnimation = jumpAnimation;
                    break;
                case States.falling:
                    CurrentAnimation = fallAnimation;
                    break;
                case States.ducking:
                    CurrentAnimation = duckAnimation;
                    break;
                default:
                    break;
            }

            //If the animation was changed then reset the AnimationIndex
            if (previousAnimation != CurrentAnimation)
            {
                AnimationIndex = 0;
            }
        }
    }
}
