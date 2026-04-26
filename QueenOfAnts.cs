using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace MicroRPG
{
    internal class QueenOfAnts : Character
    {


        public QueenOfAnts(string name, int health, ConsoleColor color)
            : base(name, health, color, ArtAssets.QueenOfAnts)
        {
        }
        public override void Fight(Character otherCharacter)
        {
            ForegroundColor = Color;
            int attackChance = AttackGenerator.Next(1, 151);
            if (attackChance >= 1 || attackChance <= 50)
            {
                WriteLine($" {Name} bites at {otherCharacter.Name} and take 7 heatlh ");
                otherCharacter.TakeDamage(7);
            }
            else if (attackChance >= 51 || attackChance <= 100)
            {
                WriteLine($" {Name} bumped in  {otherCharacter.Name} and take 5 health ");
                otherCharacter.TakeDamage(5);
            }
            else
            {
                WriteLine(" The Queen of ants tried to attack you but you doget it ....");
            }
            ResetColor();
        }
    }
}

