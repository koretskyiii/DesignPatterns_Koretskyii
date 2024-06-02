using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
    public class Director
    {
        public Character makeEnemy(EnemyBuilder builder)
        {
            builder.CreateCharacter();
            builder.SetName("ENEMY").SetEyeColor("brown").SetHairColor("red").SetClothes("Black suit").SetInventory("Sword");
            return builder.GetCharacter();
        }
        public Character makeHero(HeroBuilder builder)
        {
            builder.CreateCharacter();
            builder.SetName("HERO").SetEyeColor("blue").SetHairColor("brown").SetClothes("White suit").SetInventory("Mace");
            return builder.GetCharacter();
        }
    }
}
