using System;
using System.Collections.Generic;
using System.Linq;
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
            //---------------------------------------------------------

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
                result.Add(Convert.ToInt32(c) +3);
            }
            
            return result;
        }

        public static string Decoding(List<int> myDecodedMessage)
        {
            String result = "";

            foreach (int decodedNum in myDecodedMessage)
            {
                result = result + System.Convert.ToChar(decodedNum-3);
            }


            return result;
        }
    }
}
