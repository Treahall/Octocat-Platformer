using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Game.Eitities
{
    class Player : Entity
    {
        bool jumping, falling, ducking;
        int jumpForce = 400, force;
        public List<string> jumpAnimation;
        public List<string> duckAnimation;

        // TO DO: Start() versus Player()?? 
        public Player() : base()
        {
            LoadAnimations();
            force = -jumpForce;

            jumping = false; falling = false;
            //Initial position
            // TO DO: needs a floor in entity
            Position = new System.Numerics.Vector2((float)(StageGraphics.WindowWidth / 2), floor -= (int)GetSpriteSize().Height);
        }

        //starts the running animation and allows you to control player with arrow keys
        public void Start()
        {

        }

        // TO DO: needed??
        public override void setSpeed()
        {
            //speed = 240;
        }

        // TO DO: needed??
        public override void SetVelocity()
        {

        }

        //check for arrow keys pressed then jump or duck if correct key is pressed
        public void Update()
        {
            if(Keyboard.IsKeyDown(Key.Down))
            {
                Duck();
            }
            if(Keyboard.IsKeyDown(Key.Up))
            {
                Jump();
            }
        }
        // TO DO: should this be in Update()??
        /*
        public override void GameTick(float millisecondsPassed)
        {
            base.GameTick(millisecondsPassed);
        }
        */


        // TO DO: Figure out algorithm for jumping in place. 
        //Should just move the player up and down in a straight line. Should switch animation when player begins falling.
        void Jump()
        {
            jumping = true;
            setAnimation();
        }

        // TO DO: Change Octocat size to be shorter with the animation to avoid obstacles.
        //Should scrunch up Octocat, but should not move Octocat.
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
