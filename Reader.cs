using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Reader
    {
        public static void ReadInput()
        {
            int[] values = new int[3];
            for (int i = 0; i < 3; i++)
            {
                Console.Write("Enter the triangle side length number " + (i + 1) + ": ");
                if (!int.TryParse(Console.ReadLine(), out values[i]))
                {
                    Console.WriteLine("You wrote a character that is not a number. Please press enter to try again!");
                    Console.ReadLine();
                    ReadInput();
                    return;
                }
                else if (values[i] <= 0)
                {
                    Console.WriteLine("Triangle can not have a side of length 0 or less. Please press enter to try again!");
                    Console.ReadLine();
                    ReadInput();
                    return;
                }

            }

            CheckInput(values, false);
        }
        public static int CheckInput(int[] values, bool testing)
        {
            if ((values[0] + values[1]) <= values[2]
                || (values[1] + values[2]) <= values[0]
                || (values[0] + values[2]) <= values[1])
            {
                Console.WriteLine("A triangle can not be made with your given sides");
                return -1;
            }

            else if (values[0] == values[1] && values[1] == values[2])
            {
                Console.WriteLine("That is an equilateral triangle");
                if (testing)
                {
                    return 0;
                }
                
            }

            else if (((values[0] == values[1] && values[0] != values[2])
                || (values[1] == values[2] && values[1] != values[0])
                || (values[0] == values[2] && values[0] != values[1])))
            {
                Console.WriteLine("That is an isosceles triangle");
                if (testing)
                {
                    return 1;
                }
            }

            else
            {
                Console.WriteLine("That is an scalene triangle");
                if (testing)
                {
                    return 2;
                }
            }
            Console.WriteLine("Enter Y to try again or any key to close");
            string input = Console.ReadLine();
            if (String.Equals(input, "y", StringComparison.CurrentCultureIgnoreCase))
            {
                ReadInput();
                return 0;
            }

            return -1;

        }
    }
}
