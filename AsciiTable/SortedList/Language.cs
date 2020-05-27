using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedList
{
    public class Language
    {
        private string name;
        private int code;
        private char[] lettersInLanguage;

        public Language(int code, string name)
        {
            this.Code = code;
            this.Name = name;


            char firstLetter = 'A';

            lettersInLanguage = new char[22];

            for (int i=0; i<lettersInLanguage.Length; i++)
            {
                lettersInLanguage[i] = Convert.ToChar( Convert.ToInt32(firstLetter) + code);

            }


        }

        public string Name { get => name; set => name = value; }
        public int Code { get => code; set => code = value; }


        public void PrintLanguage()
        {
            Console.WriteLine();
            foreach (char letter in this.lettersInLanguage)
            {
                Console.Write(letter + ",");
            }
            Console.WriteLine();
        }
    }
}
