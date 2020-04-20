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
using System.Windows.Input;

namespace Game
{
    class Frame
    {
        GameEngine GameEng;
        public List<Entity> Entities;
        public List<Item> Items;
        WriteableBitmap Screen;
        public DispatcherTimer timer;
        public bool paused;

        public Frame(GameEngine gameEng, WriteableBitmap screen)
        {
            //create timer, set interval, and add update as a function
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(.0333); //.0333 sets 30 FPS
            timer.Tick += Update;
            timer.Start();

            paused = false;
            Screen = screen;
            GameEng = gameEng;
            Entities = new List<Entity>();
            Items = new List<Item>();
        }

        //triggers the update functions of objects.
        private void Update(object sender, EventArgs e)
        {
            if (paused)
            {
                if (Keyboard.IsKeyDown(Key.U))
                {
                    paused = false;
                }
            }
            else
            {
                GameEng.Update();

                if (!paused)
                {
                    foreach (var entity in Entities)
                    {
                        entity.Update(Screen);
                    }

                    foreach (var item in Items)
                    {
                        item.Update();
                    }
                }
            }          
        }
    }
}
