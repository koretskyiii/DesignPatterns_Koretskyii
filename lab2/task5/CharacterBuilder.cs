using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
    public abstract class CharacterBuilder
    {
        protected Character character;

        public Character GetCharacter()
        {
            return character;
        }

        public void CreateCharacter()
        {
            character = new Character();
        }

        public abstract CharacterBuilder SetName(string name);
        public abstract CharacterBuilder SetHairColor(string hairColor);
        public abstract CharacterBuilder SetEyeColor(string eyeColor);
        public abstract CharacterBuilder SetClothes(string clothes);
        public abstract CharacterBuilder SetInventory(string inventory);
    }
}
