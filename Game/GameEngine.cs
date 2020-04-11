using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game.ItemCreatorFile;
using System.Windows.Media.Imaging;
using Game.ObstacleFactory;
using Game.Eitities;

namespace Game
{
   
    class GameEngine
    {
        ItemCreator ItemSpawner = new ItemCreator();
        ObstacleCreator ObstacleSpawner = new ObstacleCreator();
        Player User = new Player();
        // referencing the world in xaml.cs
        // frame used in world.xaml.cs
        public void Start()
        {


        }

        public void TogglePause()
        {

        }

        public void DeathEvents(WriteableBitmap screen)
        {

        }

        public void Update()
        {

        }
    }
}
