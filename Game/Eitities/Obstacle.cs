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
    class Obstacle : Entity
    {
        float obstaclePosY, obstaclePosX;
        float obstacleVelocityX;
        public Obstacle() : base()
        {
            LoadAnimations();

        }

        public override void Update(WriteableBitmap s)
        {
            obstaclePosX -= obstacleVelocityX;
            Draw(s);
        }

        public override void Draw(WriteableBitmap surface)
        {
            base.Draw(surface);
        }

        public override void LoadAnimations()
        {

        }

        public override void setAnimation()
        {

        }
        public void Create()
        {

        }
    }
}
