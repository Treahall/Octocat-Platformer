using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using static System.Windows.Media.Imaging.WriteableBitmapExtensions;


namespace Game.Entities
{
    class Beetle : Obstacle
    {
        float obstaclePosY = 420, obstaclePosX = 1440;
        float obstacleVelocityX = 5, obstacleVelocityY = 0;
        public Beetle() : base()
        {
            //Initial position
            Position = new System.Numerics.Vector2(obstaclePosX, obstaclePosY);

            //Initial velocity
            Velocity = new System.Numerics.Vector2(obstacleVelocityX, obstacleVelocityY);
        }

        public override void Update(WriteableBitmap s)
        {
            obstaclePosX -= obstacleVelocityX;
            Position = new System.Numerics.Vector2(obstaclePosX, obstaclePosY);
            Draw(s);
        }

        public override void LoadAnimations()
        {
            CurrentAnimation = HelperClasses.EntityAnimations.Beetle;
        }

    }
}
