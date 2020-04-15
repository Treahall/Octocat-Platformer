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

namespace Game
{
    /// <summary>
    /// Interaction logic for World.xaml
    /// </summary>
    public partial class World : Window
    {
        int floor = (int)BackgroundAssets.Floor.Y;
        WriteableBitmap Screen;
        Frame FrameHandler;
        GameEngine GameEng;
        BackgroundAnimator WorldBackground;
        
        public World()
        {
            InitializeComponent();
            Timeline.DesiredFrameRateProperty.OverrideMetadata(
                typeof(Timeline),
                new FrameworkPropertyMetadata { DefaultValue = 20 }
                );
        }

        private void LoadScreen (object sender, RoutedEventArgs e)
        {

            //Store the pixel height and width as resources
            Resources.Add("Height", this.WorldGrid.ActualHeight);
            Resources.Add("Width", this.WorldGrid.ActualWidth);

            Screen = BitmapFactory.New(Convert.ToInt32(Resources["Width"]), Convert.ToInt32(Resources["Height"]));
            Canvas.Source = Screen;

            //initializes the class that controls the background and its animations.
            WorldBackground = new BackgroundAnimator(Screen);

            //Initializes the object that runs the game.
            GameEng = new GameEngine();

            //its update function gets added as a composition target upon initializing.
            FrameHandler = new Frame(GameEng, Screen);
            FrameHandler.backgroundAnimator = WorldBackground;
        }
    }
}
