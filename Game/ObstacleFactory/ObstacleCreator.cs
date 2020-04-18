using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game.Entities;

namespace Game.ObstacleFactory
{
    class ObstacleCreator
    {
        Dictionary<Obstacle, ObstacleFactory> obstacleCreator;
        Random rand;

        public ObstacleCreator()
        {
            obstacleCreator = new Dictionary<Obstacle, ObstacleFactory>();
        }
        Obstacle Create(Obstacle s)
        {
            return s;
        }

        Obstacle CreateRandom()
        {
            Obstacle randObstacle = new Obstacle();
            
            return randObstacle;
        }
        
        public void StartSpawning()
        {


        }
    }
}
