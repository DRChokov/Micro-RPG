using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace MicroRPG
{
    internal class Beetle : Character
    {
        public Beetle(string name, int health, ConsoleColor color)
        : base(name, health, color, ArtAssets.Beetle)
        {
        }
        public override void Fight(Character otherCharacter)
        {
            ForegroundColor = Color;
            int attackChance = AttackGenerator.Next(1, 100);
            if (attackChance <= 50)
            {
                WriteLine($" {Name} charges with his strong body at  {otherCharacter.Name} and take 4 heatlh ");
                otherCharacter.TakeDamage(4);
            }
            else
            {
                WriteLine(" The beettle tried to attack you but you doget it ....");
            }
            ResetColor();

        }
    }
}
