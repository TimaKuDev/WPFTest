using System.Windows.Controls;

namespace WPFTest.Classes
{
    internal class Character
    {
        private Image characterImage;
        private int characterMovmentDistance;

        public Character(int characterMovmentDistance)
        {
            CharacterImage = new Image();
            CharacterMovmentDistance = characterMovmentDistance;
        }

        public Image CharacterImage { get => characterImage; protected set => characterImage = value; }

        public int CharacterMovmentDistance { get => characterMovmentDistance; private set => characterMovmentDistance = value; }
    }
}
