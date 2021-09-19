using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    class GUI
    {

        public static void ShowMenu(string[] possibleSteps)
        {
            for (int i = 0; i < possibleSteps.Length; i++)
            {
                Console.WriteLine((i + 1) + " - " + possibleSteps[i]);
            }
            Console.WriteLine(0 + " - exit");
            Console.WriteLine("?" + " - help");
        }

        public static void RequireUsersTurn()
        {
            Console.WriteLine("Enter your move: ");
        }

        public static void ShowUserMove(string move)
        {
            Console.WriteLine("Your move: " + move);
        }

        public static void ShowComputerMove(string move)
        {
            Console.WriteLine("Computer move: " + move);
        }

        public static void ShowComputerMoveHmac(byte[] hmac)
        {
            Console.WriteLine("HMAC: " + Convert.ToBase64String(hmac));

        }

        public static void ShowComputerMoveHMACKey(byte[] key)
        {
            Console.WriteLine("HMAC key: " + Convert.ToBase64String(key) + '\n');
        }

        public static void ShowHelpTable(string[] possibleSteps)
        {
            for (int i = 0; i < possibleSteps.Length; i++)
            {
                Console.Write(possibleSteps[i] + " win:");
                for(int j = 0; j < (possibleSteps.Length - 1) / 2; j++)
                {
                    int k = (i + j + 1) % possibleSteps.Length;
                    Console.Write(" "+possibleSteps[k]);
                }
                Console.WriteLine(';');
            }
        }

        public static void ShowUserWon()
        {
            Console.WriteLine("You win!!!");
        }
        public static void ShowComputerWon()
        {
            Console.WriteLine("Computer win(");
        }


        public static void ShowDraw()
        {
            Console.WriteLine("Draw, you have chosen the same move as computer!");
        }

        public static void Exit()
        {
            Console.WriteLine("GoodBye!");
        }
    }
}
