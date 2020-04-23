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
using System.Drawing;
using System.Windows.Media;
using Color = System.Windows.Media.Color;

namespace Game
{
    enum GameStates
    {
        MainMenu,
        GameRunning,
        GameOver,
        Store,
        HighScores
    }

    //levels based on minimum distance 
    enum Levels
    {
        one = 5000,
        two = 10000,
        three = 20000, 
        four = 40000
    }


    //Used in the world.xaml.cs with the Screen parameter of the World.xaml.
    class GameEngine
    {
        public List<Tuple<string, int>> HighScores;
        public List<Tuple<string, Point, int>> TextData = new List<Tuple<string, Point, int>>();
        Levels level; int speed;
        GameStates GameState;
        WriteableBitmap Screen;
        ItemCreator ItemSpawner;
        ObstacleCreator ObstacleSpawner;
        public BackgroundAnimator backgroundAnimator;
        int distance;
        public Frame FrameHandler;
        Player User;

        //Constructor
        public GameEngine(WriteableBitmap screen)
        {

            //set values for objects.
            Screen = screen;
            GameState = GameStates.MainMenu;
            distance = 0;
            level = Levels.one;
            speed = 30;
            LoadHighScores();
            //Initialize objects
            User = new Player();
            ItemSpawner = new ItemCreator(User, speed);
            ObstacleSpawner = new ObstacleCreator(User, speed);
            backgroundAnimator = new BackgroundAnimator(screen);
            
        }
//=============================================================================================
        //loads the start screen and initializes the frame handler
        public void start()
        {
            backgroundAnimator.LoadBackground();
            FrameHandler = new Frame(this, Screen);
        }
        
//=============================================================================================
        //Keeps track of event triggers for in game play.
        public void RunningEvents()
        {
            //if pressing p then trigger pause.
            if (Keyboard.IsKeyDown(Key.P))
            {
                FrameHandler.paused = true;
                return;
            }
            //When not paused
            else
            {
                //if the user dies trigger a game over
                if (User.dead == true)
                {
                    FrameHandler.Entities.Clear();
                    FrameHandler.Items.Clear();
                    backgroundAnimator.ChangeBackground(BackgroundAssets.GameOver);
                    backgroundAnimator.LoadBackground();
                    GameState = GameStates.GameOver;
                    return;
                }

                //TO DO: update the distance and other graphics
                
                SpawnThings();
                backgroundAnimator.LoadAll();
                UpdateDistance();
            } 
        }

        void UpdateDistance()
        {
            Point dest = new Point(1105, 28);
            distance += speed;
            OInterval += speed;
            IInterval += speed;

            TextData.Add(new Tuple<string, Point, int>(distance.ToString(), dest ,30));

            if (distance > (int)Levels.one)
            {
                level = Levels.two;
            }
            else if (distance > (int)Levels.two)
            {
                level = Levels.three;
            }
            else if (distance > (int)Levels.three)
            {
                level = Levels.four;
            }

        }

        int ItemInterval;
        int IInterval = 0;
        int ObstacleInterval;
        int OInterval = 0;
        void SpawnThings()
        {
            switch (level)
            {
                case Levels.one:
                    ObstacleInterval = 800;
                    ItemInterval = 1000;
                    break;
                case Levels.two:
                    ObstacleInterval = 700;
                    ItemInterval = 1500;
                    break;
                case Levels.three:
                    ObstacleInterval = 600;
                    ItemInterval = 2000;
                    break;
                case Levels.four:
                    ObstacleInterval = 500;
                    ItemInterval = 2500;
                    break;
                default:
                    break;
            }

            //controls item spawn
            if (IInterval >= ItemInterval)
            {
                IInterval = 0;
                FrameHandler.Items.Add(ItemSpawner.SpawnRandom(level));
            }
            //controls obstacle spawn
            if (OInterval >= ObstacleInterval)
            {
                OInterval = 0;
                FrameHandler.Entities.Add(ObstacleSpawner.getRandom());
            }
        }

//=============================================================================================
        //Keeps track of event triggers for the game over menu.
        public void GameOverEvents()
        {
            //return to the start screen
            if (Keyboard.IsKeyDown(Key.Space))
            {
                User.dead = false;
                backgroundAnimator.ChangeBackground(BackgroundAssets.Start_Screen);
                backgroundAnimator.LoadBackground();
                GameState = GameStates.MainMenu;
            }
            //enter a highscore.
            Point NamePoint = new Point(795, 350);
            Point ScorePoint = new Point(1000, 350);

            foreach (var item in HighScores)
            {
                TextData.Add(new Tuple<string, Point, int>(item.Item1, NamePoint, 30));
                TextData.Add(new Tuple<string, Point, int>(item.Item2.ToString(), ScorePoint, 25));
                NamePoint.Offset(0, 33);
                ScorePoint.Offset(0, 33);
            }
            Point dest = new Point(375, 365);
            TextData.Add(new Tuple<string, Point, int>(distance.ToString(), dest, 30));

        }
//=============================================================================================
        //Keeps track of event triggers for the main menu.
        public void MenuEvents()
        {
            //Add the user to FrameHandler and start running the game.
            if (Keyboard.IsKeyDown(Key.Enter))
            {
                backgroundAnimator.ChangeBackground(BackgroundAssets.Running_Background);
                FrameHandler.Entities.Add(User);
                GameState = GameStates.GameRunning;
            }
            //go to the highscores menu
            else if (Keyboard.IsKeyDown(Key.LeftShift) || Keyboard.IsKeyDown(Key.Right))
            {
                backgroundAnimator.ChangeBackground(BackgroundAssets.High_Scores);
                backgroundAnimator.LoadBackground();
                WriteHighScores(530, 775, 270);
                GameState = GameStates.HighScores;
            }
            //go to the store
            else if (Keyboard.IsKeyDown(Key.Tab))
            {
                backgroundAnimator.ChangeBackground(BackgroundAssets.Store);
                backgroundAnimator.LoadBackground();
                GameState = GameStates.Store;
            }
        }
//=============================================================================================
        //Keeps track of event triggers for the store.
        public void StoreEvents()
        {
            if (Keyboard.IsKeyDown(Key.Space))
            {
                backgroundAnimator.ChangeBackground(BackgroundAssets.Start_Screen);
                backgroundAnimator.LoadBackground();
                GameState = GameStates.MainMenu;
            }
        }
//=============================================================================================
        //Keeps track of event triggers for the high scores menu.
        public void HighScoreEvents()
        {

            if (Keyboard.IsKeyDown(Key.Space))
            {
                backgroundAnimator.ChangeBackground(BackgroundAssets.Start_Screen);
                backgroundAnimator.LoadBackground();
                GameState = GameStates.MainMenu;
            }
        }

        //writes the highscores on the current screen.
        void WriteHighScores(int NameX, int ScoreX, int Y)
        {
            Point NamePoint = new Point(NameX, Y);
            Point ScorePoint = new Point(ScoreX, Y);


            foreach (var item in HighScores)
            {
                TextData.Add(new Tuple<string, Point, int>(item.Item1, NamePoint, 30));
                TextData.Add(new Tuple<string, Point, int>(item.Item2.ToString(), ScorePoint, 30));
                NamePoint.Offset(0, 40);
                ScorePoint.Offset(0, 40);
            }
        }

        void LoadHighScores()
        {
            HighScores = new List<Tuple<string, int>>();
            for (int i = 0; i < 10; i++)
            {
                HighScores.Add(new Tuple<string, int>("-------", 0));
            }
        }
//=============================================================================================
        //Triggers events based on the state of the game.
        public void Update()
        {
            switch (GameState)
            {
                case GameStates.MainMenu:
                    MenuEvents();
                    break;
                case GameStates.GameRunning:
                    RunningEvents();
                    break;
                case GameStates.GameOver:
                    GameOverEvents();
                    break;
                case GameStates.Store:
                    StoreEvents();
                    break;
                case GameStates.HighScores:
                    HighScoreEvents();
                    break;
                default:
                    break;
            }
        }
    }
}
