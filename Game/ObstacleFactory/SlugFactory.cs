using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game.Entities;

namespace Game.ObstacleFactory
{
    class SlugFactory : ObstacleFactory
    {
        public SlugFactory(Player U) : base(U) { }

        //Creates a new Slug
        public override Obstacle Create()
        {
            return new Slug(User);
        }
    }
}
