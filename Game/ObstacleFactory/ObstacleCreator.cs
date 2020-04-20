using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game.Entities;
using System.Windows.Threading;


namespace Game.ObstacleFactory
{
    class ObstacleCreator
    {
        Dictionary<Obstacle, ObstacleFactory> obstacleCreator;
        ObstacleFactory obstacleFactory;
        Random rand;
        DispatcherTimer timer;

        public ObstacleCreator()
        {
            obstacleCreator = new Dictionary<Obstacle, ObstacleFactory>();
            rand = new Random();
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(.0333); //.0333 sets 30 FPS
            timer.Start();
        }
        Obstacle Create(Obstacle s)
        {
            return s;
        }

        Obstacle CreateRandom()
        {
            obstacleFactory = new ObstacleFactory(rand);
            Obstacle randObstacle = obstacleFactory.create();
            if(randObstacle != null)
                obstacleCreator.Add(randObstacle, obstacleFactory);

            return randObstacle;
        }
        
        public void StartSpawning()
        {
            if (timer.Interval.TotalSeconds % 3 > 1 && timer.Interval.TotalSeconds % 3 < 2) // hmmmm
            {
                CreateRandom();
            }
        }
    }
}
