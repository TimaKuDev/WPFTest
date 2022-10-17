using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace WPFTest.Classes
{
    internal class DrawTheGame
    {
        private Canvas canvas;

        public Canvas Canvas { get => canvas; private set => canvas = value; }

        public DrawTheGame(Canvas myCanvas)
        {
            Canvas = myCanvas;
        }

        public void drawObjects(List<Image> allObjects)
        {
            for (int i = 0; i < allObjects.Count; i++)
            {
                Image currentCharacterImage = allObjects[i];
                Random random = new Random();
                int maxWindowXValue = int.Parse(Application.Current.MainWindow.Width.ToString()) - int.Parse(currentCharacterImage.Width.ToString());
                int maxWindowYValue = int.Parse(Application.Current.MainWindow.Height.ToString()) - int.Parse(currentCharacterImage.Height.ToString());
                int randomValueX  = random.Next(0, maxWindowXValue);
                int randomValueY  = random.Next(0, maxWindowYValue);  
                Canvas.SetLeft(currentCharacterImage, randomValueX);
                Canvas.SetTop(currentCharacterImage, randomValueY);
                currentCharacterImage.Stretch = System.Windows.Media.Stretch.Fill;
                Canvas.Children.Add(currentCharacterImage);
            }
        }

        public void DrawLeftMovment(Image image, int movmentDistance)
        {
            if (Canvas.GetLeft(image) > 0)
            {
                Canvas.SetLeft(image, Canvas.GetLeft(image) - movmentDistance);
            }
        }

        public void DrawRightMovment(Image image, int movmentDistance)
        {
            if (Canvas.GetLeft(image) + image.Width + 10 < Canvas.ActualWidth)
            {
                Canvas.SetLeft(image, Canvas.GetLeft(image) + movmentDistance);
            }
        }

        public void DrawUpMovment(Image image, int movmentDistance)
        {
            if (Canvas.GetTop(image) > 0)
            {
                Canvas.SetTop(image, Canvas.GetTop(image) - movmentDistance);
            }
        }

        public void DrawDownMovment(Image image, int movmentDistance)
        {
            if (Canvas.GetTop(image) + image.Height + 10 < Canvas.ActualHeight)
            {
                Canvas.SetTop(image, Canvas.GetTop(image) + movmentDistance);
            }
        }
    }
}