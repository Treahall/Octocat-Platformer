using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game.ItemCreatorFile;
using System.Windows.Media.Imaging;
using Game.ObstacleFactory;
using Game.Entities;
using Game.HelperClasses;
using System.Windows.Input;

namespace Game
{
   
    class GameEngine
    {
        WriteableBitmap Screen;
        ItemCreator ItemSpawner = new ItemCreator();
        ObstacleCreator ObstacleSpawner = new ObstacleCreator();
        int distance;
        Player User = new Player();
        bool gamestarted = false, gameOver = false;
        // referencing the world in xaml.cs
        // frame used in world.xaml.cs

        public GameEngine(WriteableBitmap s)
        {
            Screen = s;
        }

        public void checkGameOver()
        {
            if(!gameOver)
            {
                startRunning();
            }
        }

        public void startRunning()
        {
            ObstacleSpawner.StartSpawning();
            ItemSpawner.StartSpawning();
            User.Start(Screen);
        }

        public void TogglePause()
        {

        }

        public void DeathEvents()
        {

        }

        public void Update()
        {
            if (Keyboard.IsKeyDown(Key.Enter) || gamestarted)
            {
                gamestarted = true;
                checkGameOver();
            }

        }
    }
}
