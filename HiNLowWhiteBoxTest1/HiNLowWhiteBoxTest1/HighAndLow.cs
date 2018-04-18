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

        private int lastSum;

       

        #region Counters;
        public float count2 = 0;
        public float count3 = 0;
        public float count4 = 0;
        public float count5 = 0;
        public float count6 = 0;
        public float count7 = 0;
        public float count8 = 0;
        public float count9 = 0;
        public float count10 = 0;
        public float count11 = 0;
        public float count12 = 0;

        public float totalCounts = 0;

        public float correcCount = 0;
        public float inCorrectCount = 0;
        #endregion

        private bool correct;

        public bool Correct
        {
            get { return correct; }
        }

        private bool higher;

        public bool Higher
        {
            get { return higher; }
            set { higher = value; }
        }

        public int Sum
        {
            get { return sum; }
        }
        public int LastSum
        {
            get { return lastSum; }
        }

        public int[] RollDice(int[] values)
        {
            int[] dices = new int[values.Length];

            for (int i = 0; i < values.Length; i++)
            {
                if (values[i]>6)
                {
                    throw new Exception("HACKER SCUM");
                }
            }

            for (int i = 0; i < values.Length; i++)
            {
                int x = values[i];

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

            Console.WriteLine("= " + x);
            sum = x;

            if (sum != lastSum)
            {

                switch (sum)
                {
                    case 2:
                        count2++;
                        break;
                    case 3:
                        count3++;
                        break;
                    case 4:
                        count4++;
                        break;
                    case 5:
                        count5++;
                        break;
                    case 6:
                        count6++;
                        break;
                    case 7:
                        count7++;
                        break;
                    case 8:
                        count8++;
                        break;
                    case 9:
                        count9++;
                        break;
                    case 10:
                        count10++;
                        break;
                    case 11:
                        count11++;
                        break;
                    case 12:
                        count12++;
                        break;

                    default:
                        break;
                }
                totalCounts++;
            }
            else
            {
                x = GetSum(RollDice(new int[] {rng.Next(1,7),rng.Next(1,7)}));
            }
            return x;
        }

        public int Roll()
        {
            lastSum = sum;

            int value = GetSum(RollDice(new int[] { rng.Next(1, 7), rng.Next(1, 7) }));

            if (value > lastSum && higher == true)
            {
                correct = true;
                correcCount++;
            }
            if (value < lastSum && higher == false)
            {
                correct = true;
                correcCount++;
            }
            if (value == lastSum)
            {

            }

            WriteStats();
            return value;
        }


        public void WriteStats()
        {
            Console.SetCursorPosition(20, 0);

            Console.WriteLine("2:   " + (HighAndLow.Instance.count2 / HighAndLow.Instance.totalCounts * 100) + "%");
            Console.SetCursorPosition(20, 1);
            Console.WriteLine("3:   " + (HighAndLow.Instance.count3 / HighAndLow.Instance.totalCounts * 100) + "%");
            Console.SetCursorPosition(20, 2);
            Console.WriteLine("4:   " + (HighAndLow.Instance.count4 / HighAndLow.Instance.totalCounts * 100) + "%");
            Console.SetCursorPosition(20, 3);
            Console.WriteLine("5:   " + (HighAndLow.Instance.count5 / HighAndLow.Instance.totalCounts * 100) + "%");
            Console.SetCursorPosition(20, 4);
            Console.WriteLine("6:   " + (HighAndLow.Instance.count6 / HighAndLow.Instance.totalCounts * 100) + "%");
            Console.SetCursorPosition(20, 5);
            Console.WriteLine("7:   " + (HighAndLow.Instance.count7 / HighAndLow.Instance.totalCounts * 100) + "%");
            Console.SetCursorPosition(20, 6);
            Console.WriteLine("8:   " + (HighAndLow.Instance.count8 / HighAndLow.Instance.totalCounts * 100) + "%");
            Console.SetCursorPosition(20, 7);
            Console.WriteLine("9:   " + (HighAndLow.Instance.count9 / HighAndLow.Instance.totalCounts * 100) + "%");
            Console.SetCursorPosition(20, 8);
            Console.WriteLine("10:  " + (HighAndLow.Instance.count10 / HighAndLow.Instance.totalCounts * 100) + "%");
            Console.SetCursorPosition(20, 9);
            Console.WriteLine("11:  " + (HighAndLow.Instance.count11 / HighAndLow.Instance.totalCounts * 100) + "%");
            Console.SetCursorPosition(20, 10);
            Console.WriteLine("12:  " + (HighAndLow.Instance.count12 / HighAndLow.Instance.totalCounts * 100) + "%");
            Console.SetCursorPosition(0, 11);
            Console.WriteLine("Total:   " + HighAndLow.Instance.totalCounts);
            Console.SetCursorPosition(0, 10);
            Console.Write("last sum: " + lastSum);
            Console.SetCursorPosition(20, 14);
            Console.WriteLine("Correct:    " + (HighAndLow.Instance.correcCount / HighAndLow.Instance.totalCounts * 100) + "%");
            Console.SetCursorPosition(20, 15);
            Console.WriteLine("Incorrect:  " + (HighAndLow.Instance.inCorrectCount / HighAndLow.Instance.totalCounts * 100) + "%");

            Console.SetCursorPosition(0, 3);
            Console.Write(GetResult());
            Console.SetCursorPosition(0, 15);



        }

        private string GetResult()
        {
            string result = "error";
            if (correct == true)
            {
                result = "CORRECT!";
            }
            if (correct == false)
            {
                result = "FALSE!";

            }
            return result;
        }

        public void Reset()
        {
            if (correct == false)
            {
                inCorrectCount++;
            }
            correct = false;

        }
    }
}
