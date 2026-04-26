using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace MicroRPG
{
    internal class Bee : Character
    {


        public Bee(string name, int health, ConsoleColor color)
        : base(name, health, color, ArtAssets.Bee)
        {
        }
        public override void Fight(Character otherCharacter)
        {
            ForegroundColor = Color;
            int attackChance = AttackGenerator.Next(1, 151);
            if (attackChance >= 1 || attackChance <= 50)
            {
                WriteLine($"Bee {Name} throw honey at {otherCharacter.Name} and take 2 heatlh ");
                otherCharacter.TakeDamage(2);
            }
            else if (attackChance >= 51 || attackChance <= 71)
            {
                WriteLine($" {Name} stinged  {otherCharacter.Name}  take 5 health  ");
                otherCharacter.TakeDamage(5);
 
            }
            else
            {
                WriteLine(" The bee tried to attack you but you doget it ....");
            }
            ResetColor();

        }
    }
}
