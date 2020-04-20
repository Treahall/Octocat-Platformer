using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game.ItemCreatorFile;
using System.Windows.Media;
using Game.HelperClasses;
using System.Windows.Media.Imaging;
using System.Windows.Threading;

namespace Game
{
    class Frame
    {
        GameEngine GameEng;
        List<Entity> Entities;
        List<Item> Items;
        WriteableBitmap Screen;
        DispatcherTimer timer;

        public Frame(GameEngine g, WriteableBitmap s)
        {
            //create timer, set interval, and add update as a function
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(.0333); //.0333 sets 30 FPS
            timer.Tick += Update;
            timer.Start();
            
            Screen = s;
            GameEng = g;
            Entities = new List<Entity>();
            Items = new List<Item>();
        }

        private void Update(object sender, EventArgs e)
        {
            foreach (var entity in Entities)
            {
                entity.Update(Screen);
            }

            foreach (var item in Items)
            {
                item.Update();
            }


            GameEng.Update();
        }
    }
}
