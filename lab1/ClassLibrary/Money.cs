
namespace ClassLibrary
{
    public class Money
    {
        public int WholePart { get; private set; }
        public int FractionalPart { get; private set; }

        public Money(int wholePart, int fractionalPart)
        {
            WholePart = wholePart;
            FractionalPart = fractionalPart;
        }

        public void SetValues(int wholePart, int fractionalPart)
        {
            if (wholePart < 0  || fractionalPart < 0)
            {
                throw new ArgumentException("Неможливо встановити від'ємні значення для цілої частини і копійок");
            }
            WholePart = wholePart;
            FractionalPart = fractionalPart;
        }

        public override string ToString()
        {
            return $"{WholePart}.{FractionalPart} невстановленої валюти";
        }
    }
}
