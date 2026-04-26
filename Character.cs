using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace MicroRPG
{
    internal class Character
    {
        public string Name { get; protected set; }  
        public int Health { get;  set; }
        public int MaxHealth { get; protected set; }    
        public string TextArt { get; protected set; }
        public ConsoleColor Color { get; protected set; }
        public  Random AttackGenerator { get; protected set; }
        public bool IsDead { get => Health <= 0; }
        public bool IsAlive { get => Health > 0; }
        public Character (string name, int health, ConsoleColor color, string textArt)

        {
            Name = name;
            Health = health;
            MaxHealth = health;
            Color = color;
            TextArt = textArt;
            AttackGenerator = new Random();

        }
        public void DisplayInfo()
        {
            ForegroundColor = Color;
            WriteLine($"--- {Name}---");
            WriteLine($"\n{TextArt}\n");
            WriteLine($"Health:{Health}\n");
            WriteLine("---");
            ResetColor();

        }
        public  virtual void  Fight(Character otherCharacter)
        {
            WriteLine("Enemy is fighting!");
        }
        public void TakeDamage(int damageAmount)
        {
            Health -= damageAmount;
            if(Health < 0)
            {
                Health = 0;
            }
        }

        public void DisplayHealthBar()
        {
            ForegroundColor = Color;
            WriteLine($"{Name}'s Health: ");
            ResetColor();
            WriteLine("[");
            BackgroundColor = ConsoleColor.Green;
            for (int i = 0; i < Health; i++)
            {
                Write(" ");
            }
            BackgroundColor = ConsoleColor.Black;
            for (int i = Health; i < MaxHealth; i++)
            {
                Write(" ");
            }
            ResetColor();
            WriteLine($"]({Health}/{MaxHealth})");
           
        }
    }

}
