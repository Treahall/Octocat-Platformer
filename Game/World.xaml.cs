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
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Game.HelperClasses;

namespace Game
{
    /// <summary>
    /// Interaction logic for World.xaml
    /// </summary>
    public partial class World : Window
    {
        double Height, Width;
        int floor;
        WriteableBitmap Screen;
        Frame FrameHandler;
        GameEngine GameEng;
        
        public World()
        {
            InitializeComponent();
        }

        private void LoadScreen (object sender, RoutedEventArgs e)
        {
            //Get window height and width
            Height = (double)this.WorldGrid.ActualHeight;
            Width = (double)this.WorldGrid.ActualWidth;

            //Store as a resource
            Application.Current.Resources["WorldHeight"] = Height;
            Application.Current.Resources["WorldWidth"] = Width;

            Screen = BitmapFactory.New((int)Width, (int)Height);
            Canvas.Source = Screen;

            //set the value of floor
            floor = (int)BackgroundAssets.Floor.Y;

            //TO DO: Create the background using a bitmap image and a relative link to the .png file
            //REFERENCE: BitmapImage background = new BitmapImage(new Uri("The .png file path", UriKind.Relative));
            BitmapImage backgroundImage = new BitmapImage(new Uri(BackgroundAssets.TestBackground, UriKind.Relative));

            //Convert backgroundImage into a WriteableBitmap
            WriteableBitmap BackgroundBitMap = new WriteableBitmap(backgroundImage);

            //Draw the WriteableBitmap "BackgroundBitMap" onto the Image object "Screen".
            Screen.Blit(new Point(0,0), BackgroundBitMap, new Rect(new Size(BackgroundBitMap.PixelWidth, BackgroundBitMap.PixelHeight)), Colors.White, WriteableBitmapExtensions.BlendMode.Alpha);

            GameEng = new GameEngine();

            //its update function gets added as a composition target upon initializing.
            FrameHandler = new Frame(GameEng);
        }
    }
}
