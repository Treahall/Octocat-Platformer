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

    enum Speeds
    {
        one = 20,
        two = 30,
        three = 45,
        four = 60
    }

    //Used in the world.xaml.cs with the Screen parameter of the World.xaml.
    class GameEngine
    {
        Levels level; Speeds speed;
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
            speed = Speeds.two;
            //Initialize objects
            User = new Player();
            ItemSpawner = new ItemCreator();
            ObstacleSpawner = new ObstacleCreator(User, (int)speed);
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
                }

                //TO DO: update the distance and other graphics
                UpdateDistance();
                SpawnObstacles();
                backgroundAnimator.LoadAll();
            } 
        }

        void UpdateDistance()
        {
            distance += (int)speed;
            Interval += (int)speed;
        }

        void SpawnItems()
        {

        }

        int spawnInterval = 500;
        int Interval = 0;
        void SpawnObstacles()
        {
            if (Interval >= spawnInterval)
            {
                Interval = 0;
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
            else if (Keyboard.IsKeyDown(Key.LeftShift) || Keyboard.IsKeyDown(Key.RightShift))
            {
                backgroundAnimator.ChangeBackground(BackgroundAssets.High_Scores);
                backgroundAnimator.LoadBackground();
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
