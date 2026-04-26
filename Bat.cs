using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace MicroRPG
{
    internal class Bat : Character
    {
        public Bat(string name, int health, ConsoleColor color)
        : base(name, health, color, ArtAssets.Bat)
        {
        }
        public override void Fight(Character otherCharacter)
        {
            ForegroundColor = Color;
            int attackChance = AttackGenerator.Next(1, 100);
            if (attackChance <= 50)
            {
                WriteLine($"{Name} bites with his sharp teeths at {otherCharacter.Name} and take 5 heatlh ");
                otherCharacter.TakeDamage(5);
            }
            else
            {
                WriteLine(" The bat tried to attack you but you doget it ....");
            }
            ResetColor();

        }
    }
}
