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

//=============================================================================================
        //triggers the update functions of objects and enforces pausing.
        private void Update(object sender, EventArgs e)
        {

            //if paused then wait until unpaused
            if (paused)
            {
                if (Keyboard.IsKeyDown(Key.U))
                {
                    paused = false;
                }
            }

            else
            {
                RemoveDeadAndPickedUp();
                GameEng.Update();
                //Update if not paused during previous GameEng.update()
                if (!paused)
                {
                    foreach (var entity in Entities)
                    {
                        entity.Update(Screen);
                    }

                    foreach (var item in Items)
                    {
                        item.Update(Screen);
                    }
                    if (GameEng.TextData.Count() != 0)
                    {
                        BackgroundAssets.WriteTextToBitmap(Screen, GameEng.TextData);
                        GameEng.TextData.Clear();
                    }
                }
            }
  
        }

        private void RemoveDeadAndPickedUp()
        {
            List<Entity> EToRemove = new List<Entity>();
            List<Item> IToRemove = new List<Item>();

            //get lists of what to remove.
            foreach (var entity in Entities)
            {
                if (entity.dead)
                    EToRemove.Add(entity);
            }
            foreach (var item in Items)
            {
                if (item.PickedUp)
                    IToRemove.Add(item);
            }

            //Remove them
            foreach (var e in EToRemove)
            {
                Entities.Remove(e);
            }
            foreach (var i in IToRemove)
            {
                Items.Remove(i);
            }
        }
    }
}
