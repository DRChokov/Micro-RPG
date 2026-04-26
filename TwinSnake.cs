using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace MicroRPG
{
    internal class TwinSnake : Character
    {


        public TwinSnake(string name, int health, ConsoleColor color)
            : base(name, health, color, ArtAssets.TwinSnake)
        {
        }

        public override void Fight(Character otherCharacter)
        {
            ForegroundColor = Color;
            int attackChance = AttackGenerator.Next(1, 151);
            if (attackChance > 1 || attackChance <= 50)
            {
                WriteLine($"{Name} spits poison at {otherCharacter.Name} and take 9 heatlh ");
                otherCharacter.TakeDamage(9);
            }
            else if (attackChance >= 51 || attackChance <= 100)
            {
                WriteLine($"{Name} hitted with their double stonger tail  {otherCharacter.Name} and take 15 health ");
                otherCharacter.TakeDamage(15);
            }

            else if (attackChance == 1  )
            {
                WriteLine($"{Name} eated {otherCharacter} and he died");
                otherCharacter.TakeDamage(200);
            }
            else
            {
                WriteLine(" The twin snake tried to attack you but you doget it ....");
            }
            ResetColor();

        }
    }
}
