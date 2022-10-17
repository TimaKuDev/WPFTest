using System;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace WPFTest.Classes
{
    internal class Morty : Character
    {
        private const int MORTY_MOVMENT_DISTANCE = 5;

        public Morty() : base(MORTY_MOVMENT_DISTANCE)
        {
            GenerateMorty();
        }

        private void GenerateMorty()
        {
            const string IMAGE_PATH = @"/Images/Morty.jpg";
            Uri uri = new Uri(IMAGE_PATH, UriKind.Relative);
            BitmapImage bitmapImage = new BitmapImage(uri);
            CharacterImage.Source = bitmapImage;
            CharacterImage.Width = 50;
            CharacterImage.Height = 50;
        }
    }
}
