using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
    public class EnemyBuilder : CharacterBuilder
    {
        public override CharacterBuilder SetName(string name)
        {
            character.Name = name;
            return this;
        }

        public override CharacterBuilder SetHairColor(string hairColor)
        {
            character.HairColor = hairColor;
            return this;
        }

        public override CharacterBuilder SetEyeColor(string eyeColor)
        {
            character.EyeColor = eyeColor;
            return this;
        }

        public override CharacterBuilder SetClothes(string clothes)
        {
            character.Clothes = clothes;
            return this;
        }

        public override CharacterBuilder SetInventory(string inventory)
        {
            character.Inventory = inventory;
            return this;
        }
    }
}
