using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game.ItemCreatorFile;
using System.Windows.Media.Imaging;
using Game.ObstacleFactory;
using Game.Eitities;
using Game.HelperClasses;
using System.Windows.Input;

namespace Game
{
   
    class GameEngine
    {
        ItemCreator ItemSpawner = new ItemCreator();
        ObstacleCreator ObstacleSpawner = new ObstacleCreator();
        BackgroundAnimator BackgorundAnimation = new BackgroundAnimator();
        int distance;
        Player User = new Player();
        bool gamestarted = false;
        // referencing the world in xaml.cs
        // frame used in world.xaml.cs
        public void checkStart()
        {
            if(!gamestarted)
            {
                startRunning();
            }
        }

        public void startRunning()
        {
            ObstacleSpawner.StartSpawning();
            ItemSpawner.StartSpawning();
            BackgorundAnimation.StartAnimation();
            User.Start();
        }

        public void TogglePause()
        {

        }

        public void DeathEvents(WriteableBitmap screen)
        {

        }

        public void Update()
        {
            if (Keyboard.IsKeyDown(Key.Enter))
            {
                checkStart();
            }
        }
    }
}
