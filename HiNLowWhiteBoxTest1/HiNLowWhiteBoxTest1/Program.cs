using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiNLowWhiteBoxTest1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(42, 17);
           



            

            while (true)
            {
                Console.Clear();


                HighAndLow.Instance.Roll();


                string input = Console.ReadLine();

                if (input.Contains("h") || input.Contains(">"))
                {
                    HighAndLow.Instance.Higher = true;
                }
                else if (input.Contains("l") || input.Contains("<"))
                {
                    HighAndLow.Instance.Higher = false;

                }



                HighAndLow.Instance.Reset();

            }
        }
    }
}
