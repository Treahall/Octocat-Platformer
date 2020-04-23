﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game.Entities;

namespace Game.ItemCreatorFile
{
    class Shield : Item
    {
        public Shield(Player U, int speed) : base(U, speed)
        {

        }
        public override void CollisionEvents()
        {

        }

        public override void LoadAnimations()
        {
            CurrentAnimation = HelperClasses.ItemAnimations.Shield;
        }
    }
}