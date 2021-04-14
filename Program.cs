using System;

namespace Polindrom
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the your word:");
            var word = Console.ReadLine();
            var word2 = word.ToLower();

            char[] symbol = word.ToCharArray();
            char[] symbol2 = word2.ToCharArray();

            int n = symbol.Length;
            var wordlenght = n;
            string reverseword;
            bool ispalindrom = true;
            n = n / 2;

            for (int i = 0; i <= n; i++)
            {
                var a = wordlenght - i - 1;
                if (symbol2[i] != symbol2[a])
                {
                    ispalindrom = false;
                    Console.WriteLine("mas[{0}]= {1}  and  mas[{2}] = {3} is not equal", i, symbol[i], a, symbol[a]);

                }
                else
                {
                    Console.WriteLine("mas[{0}]= {1}  and  mas[{2}]= {3} is equal", i, symbol[i], a, symbol[a]);
                }
            }
            if (ispalindrom) { Console.WriteLine("Word '{0}' is Polindrom", word); }
            else Console.WriteLine("Word '{0}' is not Polindrom", word);

            for (int i = 0; i <= n; i++)
            {
                var a = wordlenght - i - 1;
                var bubble = symbol[i];
                symbol[i] = symbol[a];
                symbol[a] = bubble;
            }
            reverseword = String.Concat<char>(symbol);
            Console.WriteLine("{0} reverse {1}",word,reverseword);
        }
    }
}

