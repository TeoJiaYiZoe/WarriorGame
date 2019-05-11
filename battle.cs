using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace warriorgame
{
    class battle
    {       
        public static void StartFight(warrior warrior1,
            warrior warrior2)
        {
                while (true)
                {
                    if (GetAttackResult(warrior1, warrior2) == "Game Over")
                    {
                        Console.WriteLine("Game Over");
                    }

                    if (GetAttackResult(warrior2, warrior1) == "Game Over")
                    {
                        Console.WriteLine("Game Over");
                        break;
                    }
                }
            
        }

        
        public static string GetAttackResult(warrior warriorA,
            warrior warriorB)
        {
            double warAAttkAmt = warriorA.Attack();
            double warBBlkAmt = warriorB.Block();

            double dmg2WarB = warAAttkAmt - warBBlkAmt;

            if (dmg2WarB > 0)
            {
                warriorB.Health = warriorB.Health - dmg2WarB;
            }
            else dmg2WarB = 0;

            Console.WriteLine("{0} Attacks {1} and Deals {2} Damage", warriorA.Name, warriorB.Name, dmg2WarB);

            Console.WriteLine("{0} Has {1} Health\n", warriorB.Name, warriorB.Health);

            if (warriorB.Health <= 0)
            {
                Console.WriteLine("{0} Has {1} Health. {2} Has {3} Health.", warriorA.Name, warriorA.Health, warriorB.Name, warriorB.Health);
                Console.WriteLine("{0} has Died and {1} is Victorious\n", warriorB.Name, warriorA.Name);

                return "Game Over";
            }
            else if (warriorA.Health <=0)
            {
                Console.WriteLine("{0} Has {1} Health. {2} Has {3} Health.", warriorA.Name, warriorA.Health, warriorB.Name, warriorB.Health);
                Console.WriteLine("{1} has Died and {0} is Victorious\n", warriorB.Name, warriorA.Name);

                return "Game Over";
            }
            else return "Fight Again";
        }





    }
}
