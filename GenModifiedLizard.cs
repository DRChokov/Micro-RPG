using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace MicroRPG
{
    internal class GenModifiedLizard : Character
    {
        public GenModifiedLizard(string name, int health, ConsoleColor color)
       : base(name, health, color, ArtAssets.GenModifiedLizard)
        {
            

        }

        public override void Fight(Character otherCharacter)
        {
            ForegroundColor = Color;
            int attackChance = AttackGenerator.Next(1, 151);
            if (attackChance > 1 || attackChance <= 50)
            {
                WriteLine($"{Name} hit you with his heavy tail {otherCharacter.Name} and take 13 heatlh ");
                otherCharacter.TakeDamage(13);
            }
            else if (attackChance >= 51 || attackChance <= 100)
            {
                WriteLine($"{Name} hitted you with his hards paws {otherCharacter.Name} and take 20 health ");
                otherCharacter.TakeDamage(20);
            }

            else if (attackChance == 1)
            {
                WriteLine($"{Name} burned  {otherCharacter} to death with his fire breath");
                otherCharacter.TakeDamage(200);
            }
            else
            {
                WriteLine(" The gen modified lizard tried to attack you but you doget it ....");
            }
            ResetColor();

        }
    }
}
