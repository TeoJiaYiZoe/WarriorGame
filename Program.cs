using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace warriorgame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter player1's name: ");
            string p1 = Console.ReadLine();
            Console.WriteLine("Enter player1's name: ");
            string p2 = Console.ReadLine();
            char answer;
            int countADied = 0;
            int countBDied = 0;
            do { 
            warrior player1 = new warrior(p1, 1000, 120, 40);
            warrior player2 = new warrior(p2, 1000, 120, 40);
            battle.StartFight(player1, player2);
                if (player1.Health<0)
                {
                    countADied++;
                }
                else
                {
                    countBDied++;
                }
                Console.WriteLine("{0} Has Died {1} times. {2} Has Died {3} times.", player1.Name, countADied, player2.Name, countBDied);
            Console.WriteLine("Replay? Y or N");
            answer = char.Parse(Console.ReadLine());
            }
            while (answer == 'Y' || answer == 'y');

        }
    }
}
