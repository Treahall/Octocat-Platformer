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
using Game.ItemCreatorFile;
using Point = System.Drawing.Point;
using Size = System.Drawing.Size;

namespace Game.Entities
{

    enum States
    {
        running,
        Jumping,
        falling, 
        ducking,
        left,
        right
    }
    class Player : Entity
    {
        States playerState;
        public List<int> ItemsOwned = new List<int>() { 0, 0, 0, 0 };
        int duckDist = 20, playerFloor;
        Point JumpVelocity = new Point(0, 40); //Magic numbers for jumping
        public List<string> jumpAnimation, duckAnimation, fallAnimation, runAnimation,
            magDuck, magRun, magJump, magFall, shieldDuck, shieldRun, shieldJump, shieldFall,
            nyanRun;

        public Player() : base()
        {
            LoadAnimations();

            playerState = States.running;

            //Initial position of the player
            Position = EntityAnimations.PlayerStartPos;
            Position.Y -= GetSpriteSize().Height; //Offset Y by the Entity height.
            playerFloor = Position.Y;

            //Initial velocity X and Y.
            Velocity = new Point(0, 0);
        }

//=============================================================================================
        //triggers events based on the players state.
        public override void Update(WriteableBitmap s)
        {
            switch (playerState)
            {
                case States.running:
                    RunningEvents();
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
            UpdateHitBox();
            Draw(s);
        }

        public override void Draw(WriteableBitmap surface)
        {
            base.Draw(surface);
        }

//=============================================================================================  
        //Checks for arrow keys pressed then jump or duck if correct key is pressed
        void RunningEvents()
        {
            setAnimation();

            if (Keyboard.IsKeyDown(Key.Up))
            {
                playerState = States.Jumping;
            }
            else if (Keyboard.IsKeyDown(Key.Down))
            {
                //Add duckDist to Position.Y to move down
                Position.Y += duckDist;
                playerState = States.ducking;
            }
        }
//=============================================================================================
        //Should move the player up in a straight line. 
        void JumpEvents()
        {
            setAnimation();

            //reaches top of jump, so start falling.
            if (Position.Y < 450) // jump max (lower Y = higher pos)
            {
                //user starts falling
                FallEvents();
                playerState = States.falling;
            }
            else 
            {
                //Subtract velocity from the position to move up.
                Position -= (Size)JumpVelocity;
            }
        }

//=============================================================================================
        //Should move the player down in a straight line.
        void FallEvents()
        {
            setAnimation();

            //user lands
            if (Position.Y > playerFloor) //fall max (greater Y = lower pos)
            {
                Position.Y = playerFloor;
                playerState = States.running;
            }
            //user is falling
            else
            {
                //Add jumpvelocity to position to move down
                Position += (Size)JumpVelocity;
            }
        }

//=============================================================================================
        //Change Octocat size to be shorter with the animation to avoid obstacles.
        void DuckEvents()
        {
            setAnimation();

            if (!Keyboard.IsKeyDown(Key.Down))
            {
                //Subtract to move back up 
                Position.Y -= duckDist;
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
            magDuck = HelperClasses.EntityAnimations.MagnetDuck;
            magRun = HelperClasses.EntityAnimations.MagnetRun;
            magJump = HelperClasses.EntityAnimations.MagnetJump;
            magFall = HelperClasses.EntityAnimations.MagnetFall;
            shieldDuck = HelperClasses.EntityAnimations.ShieldDuck;
            shieldRun = HelperClasses.EntityAnimations.ShieldRun;
            shieldJump = HelperClasses.EntityAnimations.ShieldJump;
            shieldFall = HelperClasses.EntityAnimations.ShieldFall;
            nyanRun = HelperClasses.EntityAnimations.NyanRun;
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
