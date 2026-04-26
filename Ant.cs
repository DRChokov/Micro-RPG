using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace MicroRPG
{
    internal class Ant : Character
    {


        public Ant(string name, int health, ConsoleColor color)
            : base(name, health, color, ArtAssets.Ant)
        {
        }

        public override void Fight(Character otherCharacter)
        {
            ForegroundColor = Color;
            int attackChance = AttackGenerator.Next(1, 151);
            if (attackChance >= 1 || attackChance <= 50)
            {
                WriteLine($"{Name} bites at {otherCharacter.Name} and take 3 heatlh ");
                otherCharacter.TakeDamage(3);
            }
            else if(attackChance >=51 || attackChance <= 100)
            {
                WriteLine($"{Name} bumped in  {otherCharacter.Name} and take 2 health ");
                otherCharacter.TakeDamage(2);
            }
            else
            {
                WriteLine(" The ant tried to attack you but you doget it ....");
            }
            ResetColor();

        }
    }
}
