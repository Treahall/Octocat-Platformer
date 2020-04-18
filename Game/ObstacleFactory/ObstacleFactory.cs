using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game.Entities;

namespace Game.ObstacleFactory
{
    class ObstacleFactory
    {
        
        public ObstacleFactory()
        {

        }

        Obstacle create()
        {
            Obstacle obstacle = new Obstacle();
            return obstacle;
        }


    }
}
