using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(OutputSortedString("789765445whjdbjwhwfbs977865".ToCharArray()));
            Console.WriteLine('a'.ToString());
            Console.ReadKey();
        }

        public static string OutputSortedString(Char[] input)
        {

            for(int i = 0; i < input.Length; i++)
            {
                char min = '9';
                int counter = -1;
                for(int j = i; j < input.Length; j++)
                {
                    if (CompareTwoChar(input[j], min))
                    {
                        min = input[j];
                        counter = j;
                    }

                }
                if (counter != -1)
                {
                    char tmp = input[i];
                    input[i] = min;
                    input[counter] = tmp;
                }


            }
            return new string(input);
        }

        public static bool CompareTwoChar(char a,char b)
        {
            if (DecideOrder(a) == DecideOrder(b))
            {
                if (DecideOrder(a) == 2)
                {
                    if(int.Parse(a.ToString())%2 == int.Parse(b.ToString())%2)
                    {
                        return a < b;
                    }
                    else
                    {
                        return (int.Parse(a.ToString()) % 2) < (int.Parse(b.ToString()) % 2);
                    }
                }
                else
                {
                    return a < b;
                }

            }
            else if(DecideOrder(a) < DecideOrder(b))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static int DecideOrder(char a)
        {
            if (a >= 'A' && a <= 'Z')
            {
                return 1;
            }
            else if (a >= 'a' && a <= 'z')
            {
                return 0;
            }
            else if(a>='0' && a<='9')
            {
                return 2;
            }
            else
            {
                return 3;
            }
        }
    }
}
