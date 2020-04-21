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
        public WindowFactory(Player U, int speed) : base(U, speed) { }

        //Create a new BrokenWindow
        public override Obstacle Create()
        {
            return new BrokenWindow(User, Speed);
        }
    }
}
