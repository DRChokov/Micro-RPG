using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace MicroRPG
{
    internal class Snake : Character
    {
        public Snake(string name, int health, ConsoleColor color)
        : base(name, health, color, ArtAssets.Snake)
        {
        }
        public override void Fight(Character otherCharacter)
        {
            ForegroundColor = Color;
            int attackChance = AttackGenerator.Next(1, 101);
            if (attackChance >= 1 || attackChance <= 50)
            {
                WriteLine($" {Name} spit with poison at {otherCharacter.Name} and take 6 heatlh ");
                otherCharacter.TakeDamage(6);
            }
            else if(attackChance >= 60 || attackChance <= 70)
            {
                WriteLine($"{Name} tried to suffocate {otherCharacter.Name} and take 10 health");
                otherCharacter.TakeDamage(10);
            }
            else
            {
                WriteLine(" The snake tried to attack you but you doget it ....");
            }
            ResetColor();

        }
    }
}

