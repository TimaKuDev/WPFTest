using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Threading;
using WPFTest.Classes;

namespace WPFTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool goLeft, goRight, goUp, goDown;
        GameLogic gameLogic;
        DrawTheGame drawTheGame;
        DispatcherTimer gameTimer = new DispatcherTimer();

        public MainWindow()
        {
            InitializeComponent();
            MyCanvas.Focus();
            gameLogic = new GameLogic();
            drawTheGame = new DrawTheGame(MyCanvas);
            drawTheGame.drawObjects(gameLogic.AllGameCharactersImages);
            gameTimer.Tick += PlayerMovmentEvent;
            gameTimer.Tick += EnemyMovmentEvent;
            gameTimer.Interval = TimeSpan.FromMilliseconds(20);
            gameTimer.Start();
        }

        private void EnemyMovmentEvent(object? sender, EventArgs e)
        {
            for (int i = 0; i < gameLogic.MortyList.Count; i++)
            {
                if (gameLogic.BartInTheWest(Canvas.GetLeft(gameLogic.Bart.CharacterImage), Canvas.GetLeft(gameLogic.MortyList[i].CharacterImage)))
                {
                    drawTheGame.DrawLeftMovment(gameLogic.MortyList[i].CharacterImage, gameLogic.MortyList[i].CharacterMovmentDistance);
                }

                if (gameLogic.BartInTheEast(Canvas.GetLeft(gameLogic.Bart.CharacterImage), Canvas.GetLeft(gameLogic.MortyList[i].CharacterImage)))
                {
                    drawTheGame.DrawRightMovment(gameLogic.MortyList[i].CharacterImage, gameLogic.MortyList[i].CharacterMovmentDistance);
                }

                if (gameLogic.BartInTheNorth(Canvas.GetTop(gameLogic.Bart.CharacterImage), Canvas.GetTop(gameLogic.MortyList[i].CharacterImage)))
                {
                    drawTheGame.DrawUpMovment(gameLogic.MortyList[i].CharacterImage, gameLogic.MortyList[i].CharacterMovmentDistance);
                }

                if (gameLogic.BartInTheSouth(Canvas.GetTop(gameLogic.Bart.CharacterImage), Canvas.GetTop(gameLogic.MortyList[i].CharacterImage)))
                {
                    drawTheGame.DrawDownMovment(gameLogic.MortyList[i].CharacterImage, gameLogic.MortyList[i].CharacterMovmentDistance);
                }
            }
        }


        private void PlayerMovmentEvent(object? sender, EventArgs e)
        {
            if (goLeft)
            {
                drawTheGame.DrawLeftMovment(gameLogic.Bart.CharacterImage, gameLogic.Bart.CharacterMovmentDistance);
            }

            if (goRight)
            {
                drawTheGame.DrawRightMovment(gameLogic.Bart.CharacterImage, gameLogic.Bart.CharacterMovmentDistance);
            }

            if (goUp)
            {
                drawTheGame.DrawUpMovment(gameLogic.Bart.CharacterImage, gameLogic.Bart.CharacterMovmentDistance);
            }

            if (goDown)
            {
                drawTheGame.DrawDownMovment(gameLogic.Bart.CharacterImage, gameLogic.Bart.CharacterMovmentDistance);
            }
        }

        private void KeyIsDownEvent(object sender, KeyEventArgs e)
        {
            switch (e.Key)
            {
                case Key.Left:
                    goLeft = true;
                    break;
                case Key.Right:
                    goRight = true;
                    break;
                case Key.Up:
                    goUp = true;
                    break;
                case Key.Down:
                    goDown = true;
                    break;
            }
        }

        private void KeyIsUpEvent(object sender, KeyEventArgs e)
        {
            switch (e.Key)
            {
                case Key.Left:
                    goLeft = false;
                    break;
                case Key.Right:
                    goRight = false;
                    break;
                case Key.Up:
                    goUp = false;
                    break;
                case Key.Down:
                    goDown = false;
                    break;
            }
        }
    }
}
