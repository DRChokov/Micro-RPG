using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace MicroRPG
{
    internal class Player : Character
    {
        public Player(string name, int health, ConsoleColor color)
            : base(name, health, color, ArtAssets.Player)
        {

        }

        private void Punch(Character otherCharacter)
        {
            int randPercent = AttackGenerator.Next(1, 101);
            if (randPercent <= 90)
            {
                WriteLine("you landed great right punch! ");
                otherCharacter.TakeDamage(4);

            }
            else
            {
                WriteLine(" the enemy blocked it... ");
            }
        }
        private void Slice(Character otherCharacter)
        {
            int randPercent = AttackGenerator.Next(1, 101);
            if (randPercent <= 70)
            {
                WriteLine("You succseed with the slice! ");
                otherCharacter.TakeDamage(6);

            }
            else
            {
                WriteLine(" the enemy dodget your knife... ");
            }
        }


        private void Shoot(Character otherCharacter)
        {      
            int randPercent = AttackGenerator.Next(1, 101);
            if (randPercent <= 51)
            {
                WriteLine("blueyes you landed a hit!");
                otherCharacter.TakeDamage(10);

            }
            else
            {
                WriteLine(" The enemy dodged you bullet... ");
            }
        }
        private void ThrowGrenadee(Character otherCharacter)
        {;
            int randPercent = AttackGenerator.Next(1, 101);
            if (randPercent <= 13)
            {
                WriteLine("you succsefully blow the hostile ");
                otherCharacter.TakeDamage(35);

            }
            else
            {
                WriteLine(" the hostile ran away from the explosion...");
            }
        }

        public override void Fight(Character otherCharacter)
        {
            ForegroundColor = Color;
            WriteLine($@"You are facing {otherCharacter.Name}. What would you like to do?

 1) Punch as hard as you can with your fists. (90% to do 2 damage) 
 2) Grab your knife and try to slice the enemy.(70% to do 4  damage)
 3) Grab your gun and lets see how  precise are your gunplay .(50% to do 6 damage)
 4) Use grenade.(13% to do 25 damamge)
");
            ConsoleKeyInfo keyinfo = ReadKey(true);
            if (keyinfo.Key == ConsoleKey.D1)
            {
                Punch(otherCharacter);
            }
            else if (keyinfo.Key == ConsoleKey.D2)
            {
                Slice(otherCharacter);
            }
            else if (keyinfo.Key == ConsoleKey.D3)
            {
                Shoot(otherCharacter);
            }
            else if (keyinfo.Key == ConsoleKey.D4)
            {
                ThrowGrenadee(otherCharacter);
            }
            else
            {
                WriteLine("Thats not  a valid move. Try again!");
                Fight(otherCharacter);
                return;
            }
            ResetColor();
        }

    }
}
