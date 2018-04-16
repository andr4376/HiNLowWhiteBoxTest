using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiNLowWhiteBoxTest1
{
    public class HighAndLow
    {
        private static HighAndLow instance;
        public static HighAndLow Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new HighAndLow();
                }
                return instance;
            }
        }

        private Random rng = new Random();

        private int sum;
        private int diceAmount = 2;


        public int Sum
        {
            get { return sum; }
        }

        public int[] RollDice()
        {
            int[] dices = new int[diceAmount];
            for (int i = 0; i < diceAmount; i++)
            {
                int x = rng.Next(1, 7);
                dices[i] = x;
                Console.Write(x + " ");
            }
            return dices;
        }
        public int GetSum(int[] dices)
        {
            int x = 0;
            for (int i = 0; i <= dices.Length - 1; i++)
            {

                x = (x + dices[i]);
            }

            Console.WriteLine(x);
            sum = x;
            return x;
        }

        public void Roll()
        {
            GetSum(RollDice());
        }

        public void Guess(char a)
        {
            switch (a)
            {

                case ('<'):

                        break;
                case ('>'):

                    break;
                default:
                    break;
            }
        }
    }
}
