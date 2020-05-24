using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EncodingDecoding
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please input word");

            // encoding process
            //------------------------------------------------------
            String inputWord = Console.ReadLine();
            List<Int32> encodedWord = Encoding(inputWord);
            Queue<Int32> ourQueue = new Queue<Int32>();

            foreach (Int32 encodedNum in encodedWord)
            {
                ourQueue.Enqueue(encodedNum);
            }
            //--------------------------------------------------------
            //Console.WriteLine( ourQueue.ToString());
            //--------------------------------------------------------
            List<int> queueList = new List<int>();
            while (ourQueue.Count!=0)
            {
                queueList.Add(ourQueue.Dequeue());
            }

            String result = Decoding(queueList);
            Console.WriteLine(result);

            Console.ReadKey();
        }

        public static List<Int32> Encoding(string myLongMessage)
        {
            List<Int32> result = new List<int>();

            foreach (char c in myLongMessage)
            {
                int num = Convert.ToInt32(c);
                if (num%2==0)
                {
                    num = num + 2;  // b = 66 =>  sending code 68   => 68-2 = 66; 66%2 ==0 ; => b
                }
                else
                {
                    num = num + 4; // c = 67 -> sending code 71 => 71 %2 != 0 => 71-4 =? 67 => b
                }
                result.Add(num);
            }
            
            return result;
        }

        public static string Decoding(List<int> myDecodedMessage)
        {
            String result = "";

            foreach (int decodedNum in myDecodedMessage)
            {
                int tempnum = decodedNum;
                if (decodedNum % 2 == 0)
                {
                    tempnum = decodedNum - 2;
                }
                else
                {
                    tempnum = decodedNum - 4;
                }
                result = result + System.Convert.ToChar(tempnum);
            }


            return result;
        }
    }
}
