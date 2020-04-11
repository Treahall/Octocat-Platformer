using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game.ItemCreatorFile;

namespace Game
{
    class Frame
    {
        GameEngine GameEng;
        List<Entity> Entities;
        List<Item> Items;
        public Frame(GameEngine g)
        {
            GameEng = g;
            Entities = new List<Entity>();
            Items = new List<Item>();
        }

        void Update()
        {
            foreach (var e in Entities)
            {
                //TO DO: call update on all Entities.
                //e.Update();
            }

            foreach (var i in Items)
            {
                //TO DO: call update on all Items.
                //i.Update();
            }

            //TO DO: Trigger the game engines frame events using the update function.
            //GameEng.Update();
        }
    }
}
