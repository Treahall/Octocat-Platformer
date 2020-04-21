using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using Game.Properties;

namespace Game.HelperClasses
{
    class BackgroundAnimator
    {
        WriteableBitmap Screen;
        string currentBackground;
        int cloudPos = -1000, foregroundPos = 0;
        int cloudvelocity = 3, foregroundVelocity = 10;
        public BackgroundAnimator(WriteableBitmap s)
        {
            this.Screen = s;
            currentBackground = BackgroundAssets.Start_Screen;
        }

        public void LoadAll()
        {
            LoadBackground();
            LoadClouds();
            LoadForeground();
        }

        public void LoadClouds()
        {
            if(cloudPos < -1440)
            {
                cloudPos = 1440;
            }
            else
                cloudPos -= cloudvelocity;

            //create the clouds
            BitmapImage backgroundImage = new BitmapImage(new Uri(BackgroundAssets.Clouds, UriKind.Relative));

            //Convert into a WriteableBitmap
            WriteableBitmap BackgroundBitMap = new WriteableBitmap(backgroundImage);

            //Draw the WriteableBitmap onto the Image object.
            Screen.Blit(new Point(cloudPos, 0), BackgroundBitMap, new Rect(new Size(BackgroundBitMap.PixelWidth, BackgroundBitMap.PixelHeight)), Colors.White, WriteableBitmapExtensions.BlendMode.Alpha);
        }

        public void LoadForeground()
        {
            if (foregroundPos < -1440)
            {
                foregroundPos = 1440;
            }
            else
                foregroundPos -= foregroundVelocity;
            //create the Foreground
            BitmapImage backgroundImage = new BitmapImage(new Uri(BackgroundAssets.Foreground, UriKind.Relative));

            //Convert into a WriteableBitmap
            WriteableBitmap BackgroundBitMap = new WriteableBitmap(backgroundImage);

            //Draw the WriteableBitmap onto the Image object.
            Screen.Blit(new Point(foregroundPos, 15), BackgroundBitMap, new Rect(new Size(BackgroundBitMap.PixelWidth, BackgroundBitMap.PixelHeight)), Colors.White, WriteableBitmapExtensions.BlendMode.Alpha);
        }

        public void LoadBackground()
        {
            //TO DO: Create the background using a bitmap image and a relative link to the .png file
            BitmapImage backgroundImage = new BitmapImage(new Uri(currentBackground, UriKind.Relative));

            //Convert backgroundImage into a WriteableBitmap
            WriteableBitmap BackgroundBitMap = new WriteableBitmap(backgroundImage);

            //Draw the WriteableBitmap "BackgroundBitMap" onto the Image object "Screen".
            Screen.Blit(new Point(0, 0), BackgroundBitMap, new Rect(new Size(BackgroundBitMap.PixelWidth, BackgroundBitMap.PixelHeight)), Colors.White, WriteableBitmapExtensions.BlendMode.Alpha);
        }

        public void ChangeBackground(string background)
        {
            currentBackground = background;
        }
    }
}
