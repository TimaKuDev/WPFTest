using System;
using System.Windows.Media.Imaging;

namespace WPFTest.Classes
{
    internal class Bart : Character
    {
        private const int BART_MOVMENT_DISTANCE = 10;

        public Bart() : base(BART_MOVMENT_DISTANCE)
        {
            GenerateBart();
        }

        private void GenerateBart()
        {
            const string IMAGE_PATH = @"/Images/Bart.png";
            Uri uri = new Uri(IMAGE_PATH, UriKind.Relative);
            BitmapImage bitmapImage = new BitmapImage(uri);
            CharacterImage.Source = bitmapImage;
            CharacterImage.Width = 50;
            CharacterImage.Height = 50;
        }
    }
}
