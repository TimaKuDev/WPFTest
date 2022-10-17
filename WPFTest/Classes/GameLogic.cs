using System.Collections.Generic;
using System.Windows.Controls;

namespace WPFTest.Classes
{
    internal class GameLogic
    {
        private Bart bart;
        private List<Morty> mortyList = new List<Morty>();
        private List<Image> allGameCharactersImages = new List<Image>();

        internal List<Image> AllGameCharactersImages { get => allGameCharactersImages; private set => allGameCharactersImages = value; }
        internal Bart Bart { get => bart; }
        internal List<Morty> MortyList { get => mortyList; set => mortyList = value; }

        public GameLogic()
        {
            GenerateAllCharacteres();
        }

        private void GenerateAllCharacteres()
        {
            bart = new Bart();
            AllGameCharactersImages.Add(bart.CharacterImage);
            for (int i = 0; i < 5; i++)
            {
                Morty morty = new Morty();
                mortyList.Add(morty);
                AllGameCharactersImages.Add(morty.CharacterImage);
            }
        }

        public bool BartInTheWest(double bartXPosition, double mortyXPosition)
        {
            return bartXPosition < mortyXPosition;
        }

        public bool BartInTheEast(double bartXPosition, double mortyXPosition)
        {
            return bartXPosition > mortyXPosition;
        }

        public bool BartInTheNorth(double bartYPosition, double mortyYPosition)
        {
            return bartYPosition < mortyYPosition;
        }

        public bool BartInTheSouth(double bartYPosition, double mortyYPosition)
        {
            return bartYPosition > mortyYPosition;
        }
    }
}
