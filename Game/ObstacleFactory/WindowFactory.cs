using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game.Entities;

namespace Game.ObstacleFactory
{
    class WindowFactory : ObstacleFactory
    {
        Obstacle brokenWindow;
        public WindowFactory(Random r) : base(r)
        {
            brokenWindow = new BrokenWindow();
        }

        Obstacle create()
        {
            return brokenWindow;
        }
    }
}
