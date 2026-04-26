using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using Figgle;

namespace MicroRPG
{
    class Game
    {

        private Player CurrentPlayer;// моя играч
        private Character CurrentEnemy;// лоия който се бия в момента
        private List<Character> Enemies;// лист, кохто съдържа всички лоши

        public Game()
        {


            Ant fireAnt = new Ant("Fire Ant", 5, ConsoleColor.Blue);
            Ant officerFireAnt = new Ant("Fire Ant", 12, ConsoleColor.Blue);
            QueenOfAnts quennOfAnts = new QueenOfAnts ("Quenn of ants", 15, ConsoleColor.DarkBlue);
            Bee attackerBee = new Bee("Attacker Bee", 7, ConsoleColor.Yellow);
            Beetle beetle = new Beetle("Heavy armored beetle", 20, ConsoleColor.Gray);
            Bat bat= new Bat("Vampire bat", 10, ConsoleColor.DarkGray);
            Snake snake = new Snake("Snaiki", 35, ConsoleColor.DarkGreen);
            Tiger tiger = new Tiger("Tigris ", 45, ConsoleColor.DarkYellow);
            TwinSnake twinSnake = new TwinSnake("The poison duo", 60, ConsoleColor.DarkCyan);
            GenModifiedLizard dragon = new GenModifiedLizard("Drago", 75, ConsoleColor.DarkRed);
            BigSoldier bigSoldier = new BigSoldier("Leitenaut Chaikowski", 100, ConsoleColor.DarkMagenta);
            // суздаване на лошите

            Enemies = new List<Character>() {fireAnt,officerFireAnt,quennOfAnts,attackerBee,beetle,bat,snake,tiger,twinSnake,dragon,bigSoldier };// полиморфизъм за да съхраним лошите

        }

        public void Run()
        {
          
            RunIntro();

            for (int i = 0; i < Enemies.Count; i += 1)
            {
                CurrentEnemy = Enemies[i];
                IntroCurrentEnemy();
                BattleCurrentEnemy();

                if (CurrentPlayer.IsDead)
                {
                    WriteLine("You were defeated!!");
                    WaitForKey();
                    break;
                }
                else
                {
                    WriteLine($"You defeated {CurrentEnemy.Name}!");
                    CurrentPlayer.Health = 100;
                    WaitForKey();
                }

            }

            RunGameOver();
            



        }
        private void RunIntro()

        {
            WriteLine("##### Micro RPG #####\n");
            WriteLine(FiggleFonts.Ogre.Render("MicroRPG"));


            Write("What is your name ");
            string name = ReadLine();
            CurrentPlayer = new Player(name, 100, ConsoleColor.Green);

            ForegroundColor = ConsoleColor.Green;
            WriteLine(@"You wake up in grass tall like you. 
Yours mremories are dizzy but you are trying  hard to remember what happend to you and why the grass is so tall.
You realized the grass is not tall, but you are very tiny. 
When you realized that you remember why you are small and here, then you hear a voice.....

    /  /          \
/   /   \          /   \
\   \   /          \   /  /
/   /  /     o   \  \  \  \
\  /  /  /  /|\  /  /  /  /
 \ \  \ /   / \  \ /   \ /
");
           
            ResetColor();
            WaitForKey();
            Clear();

            WriteLine($@"Hello {name} are you ready to test your skills for the gen modified liitle super warriors.
If you forget why you are here I General Iron will tell you. 
You show desire to take test for this new special secret squad called litlle killers. 
This squad will be gen modified humans to be small and more stronger than they are. 
You are in special facility to test your skills ao we can see are you good enough to be part from this top secret squad.
Good luck and lets the test BEGIN!!!!



Are you ready  soldier you have got {Enemies.Count} x opponets to face...
");
            
             
           

            CurrentPlayer.DisplayInfo();
            WaitForKey();
        }

        private void RunGameOver()
        {
            Clear();
            if (CurrentPlayer.IsDead)
            {
                WriteLine($@"{FiggleFonts.Epic.Render("You lose!")}
You failed in the experiment for microscobic gen modified soldiers. Thanks for the participation.
We will send your reamianigs to your family with regards and money for the apprication.
The next canditate may come in.");
            }
            else
            {
                WriteLine($@"{FiggleFonts.Epic.Render("You win!")}
Congratulations to you soldier!!!!! You pass the test for the microschobic gen modified soldiers.
From now on you will serve this country from the tiny shadows.
You will take on only special missions for this microscobic squad! GOOD LUCK you will needed it !!");
            }

            WriteLine("Thanks for playng my game player lets meet next time too.");

            WaitForKey();
        }
        private void IntroCurrentEnemy()
        {
            Clear();
            ForegroundColor = CurrentEnemy.Color;
            WriteLine("A new enemy apprachoes!");
            ResetColor();
            CurrentEnemy.DisplayInfo();
            WriteLine();
            WaitForKey();
        }


        private void BattleCurrentEnemy()
        {
            while (CurrentPlayer.IsAlive && CurrentEnemy.IsAlive)
            {

                Clear();
                CurrentPlayer.DisplayHealthBar();
                CurrentEnemy.DisplayHealthBar();
                WriteLine();

                CurrentPlayer.Fight(CurrentEnemy);


                WriteLine();
                WaitForKey();

                if (CurrentPlayer.IsDead || CurrentEnemy.IsDead)
                {
                    break;
                }

                Clear();
                CurrentPlayer.DisplayHealthBar();
                CurrentEnemy.DisplayHealthBar();
                WriteLine();

                CurrentEnemy.Fight(CurrentPlayer);

                WaitForKey();
            }


        }



        private void WaitForKey()
        {
            WriteLine("Press any key to continue...\n");
            ReadKey(true);
        }

    }
}
