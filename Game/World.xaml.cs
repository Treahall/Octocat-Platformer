using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Game.HelperClasses;
using Game.Properties;
using System.Media;

namespace Game
{
    /// <summary>
    /// Interaction logic for World.xaml
    /// </summary>
    public partial class World : Window
    {
        WriteableBitmap Screen;
        GameEngine GameEng;
        
        public World()
        {
            InitializeComponent();
        }

//=============================================================================================
        //called once when the world.xaml loads. 
        private void LoadScreen (object sender, RoutedEventArgs e)
        {

            //Store the pixel height and width as resources
            Resources.Add("Height", 877);
            Resources.Add("Width", 1440);

            Screen = BitmapFactory.New(Convert.ToInt32(Resources["Width"]), Convert.ToInt32(Resources["Height"]));
            Canvas.Source = Screen;

            // Initializes the object that runs the game.
            GameEng = new GameEngine(Screen);
            GameEng.start();

            SoundPlayer gameMusic = new SoundPlayer();
            gameMusic.SoundLocation = "../../AudioAssets/background_music.wav";
            gameMusic.Load();
            gameMusic.PlayLooping();
        }
    }
}
