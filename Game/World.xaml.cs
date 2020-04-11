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
        bool gamestarted;
        public World()
        {
            InitializeComponent();
        }

        private void LoadScreen (object sender, RoutedEventArgs e)
        {
            //TO DO: Get window height and width

            //TO DO: Store as a resource

            Screen = BitmapFactory.New((int)Width, (int)Height);
            Canvas.Source = Screen;
            //TO DO: set the value of floor

            //TO DO: Create the background using a bitmap image and a relative link to the .png file
            //REFERENCE: BitmapImage background = new BitmapImage(new Uri("The .png file path", UriKind.Relative));

            //TO DO: convert into a WriteableBitmap
            //REFERENCE: WriteableBitmap Background = new WriteableBitmap(background);

            //Draw the WriteableBitmap "Background" onto the Image object Screen
            //Screen.Blit(new Point(0,0), Background, new Rect(new Size(Background.PixelWidth, Background.PixelHeight)), Colors.White, WriteableBitmapExtensions.BlendMode.Alpha);

            GameEng = new GameEngine();
            FrameHandler = new Frame(GameEng);

        }
    }
}
