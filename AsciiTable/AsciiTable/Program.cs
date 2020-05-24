using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsciiTable
{
    class Program
    {
        static void Main(string[] args)
        {
            char charA = 'a';

            int myX = 4;
            int MYx = 6;

            int x = 88;
            Console.WriteLine(Convert.ToChar(x));

            //Console.WriteLine(System.Convert.ToInt32(charA));
            //Console.WriteLine(System.Convert.ToInt32('A'));

            string word = "Hello Word";
            Console.WriteLine(word);
            Console.WriteLine("--------------------------------");
            Console.WriteLine();
            foreach( char c in word) // to decimal
            {
                Console.Write(System.Convert.ToInt32(c) + "  ");
            }
            Console.WriteLine();
            Console.WriteLine("--------------------------------");
            foreach (char c in word) // to hexadecimal
            {
                Console.Write(System.Convert.ToInt32(c).ToString("X") +  "  ");
            }
            Console.WriteLine();
            Console.WriteLine("--------------------------------");
            Console.WriteLine();

            for (int i=65; i<=90; i++)
            {
                Console.WriteLine(" " + i + " | " + System.Convert.ToChar(i) + " | |" + i.ToString("X"));
            }

            Console.ReadKey();
        }

      
    }
}
