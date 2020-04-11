using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game.ItemCreatorFile;
using System.Windows.Media;

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
            CompositionTarget.Rendering += Update;
        }

        private void Update(object sender, EventArgs e)
        {
            foreach (var entity in Entities)
            {
                entity.Update();
            }

            foreach (var item in Items)
            {
                item.Update();
            }

            GameEng.Update();
        }
    }
}
