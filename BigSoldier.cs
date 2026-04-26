using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace MicroRPG
{
    internal class BigSoldier : Character
    {
        public BigSoldier(string name, int health, ConsoleColor color)
       : base(name, health, color, ArtAssets.RealSizeSolider)
        {


        }

        public override void Fight(Character otherCharacter)
        {
            ForegroundColor = Color;
            int attackChance = AttackGenerator.Next(1, 151);
            if (attackChance > 1 || attackChance <= 50)
            {
                WriteLine($"{Name} slapped {otherCharacter.Name} and take 20 heatlh ");
                otherCharacter.TakeDamage(20);
            }
            else if (attackChance >= 51 || attackChance <= 100)
            {
                WriteLine($"{Name} smashed {otherCharacter.Name} and take 30 health ");
                otherCharacter.TakeDamage(30);
            }

            else if (attackChance == 1)
            {
                WriteLine($"{Name} shot  {otherCharacter} ");
                otherCharacter.TakeDamage(200);
            }
            else
            {
                WriteLine(" The soldier tried to attack you but you doget it ....");
            }
            ResetColor();

        }
    }
}
