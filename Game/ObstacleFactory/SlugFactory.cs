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
        Obstacle slug;
        public SlugFactory(Random r) : base(r)
        {
            slug = new Slug();
        }

        Obstacle create()
        {
            return slug;
        }
    }
}
