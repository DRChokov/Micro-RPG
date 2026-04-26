using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace MicroRPG
{
    internal class Tiger : Character
    {


        public Tiger(string name, int health, ConsoleColor color)
            : base(name, health, color, ArtAssets.Tiger)
        {
        }

        public override void Fight(Character otherCharacter)
        {
            ForegroundColor = Color;
            int attackChance = AttackGenerator.Next(1, 151);
            if (attackChance >= 1 || attackChance <= 50)
            {
                WriteLine($"{Name} bites at {otherCharacter.Name} and take 10 heatlh ");
                otherCharacter.TakeDamage(10);
            }
            else if (attackChance >= 51 || attackChance <= 100)
            {
                WriteLine($"{Name} stabbed  with his sharp claws  {otherCharacter.Name} and take 15 health ");
                otherCharacter.TakeDamage(15);
            }
            else
            {
                WriteLine(" The tiger tried to attack you but you doget it ....");
            }
            ResetColor();

        }
    }
}

