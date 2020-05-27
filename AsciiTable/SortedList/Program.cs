using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedList
{
    class Program
    {
        static void Main(string[] args)
        {
            String a = "Moshe Davidov";
            String b = "Moshe Moshonov";

            Driver firstDriver = new Driver(EnumLisencseType.B, "moshe");
            Driver secondDriver = new Driver(EnumLisencseType.C, "adam");
            Driver thirdDriver = new Driver(EnumLisencseType.D, "moshe");
            Driver fourth = new Driver(EnumLisencseType.D, "baruh");
            Driver fifth = new Driver(EnumLisencseType.D, "andrey");

            Dictionary<string, Driver> myallDrivers = new Dictionary<string, Driver>();
            myallDrivers.Add(firstDriver.Id, firstDriver);
            myallDrivers.Add(secondDriver.Id, secondDriver);
            myallDrivers.Add(thirdDriver.Id, thirdDriver);
            myallDrivers.Add(fourth.Id, fourth);
            myallDrivers.Add(fifth.Id, fifth);

            Console.WriteLine("Please input your id");
            string myID = Console.ReadLine();
            if (myallDrivers.ContainsKey(myID))
            {
                Driver currentDriver = myallDrivers[myID];
                // needed driver operation
            }
            else
            {
                Console.WriteLine("Id not found");
            }

            // itterate (pass) the values list
            foreach (Driver currentDriver in myallDrivers.Values)
            {
                Console.WriteLine(currentDriver.ToString());
            }

            // itterate (pass) the keys list
            foreach (String currentDriverKey in myallDrivers.Keys)
            {
                Console.WriteLine(currentDriverKey);
            }

            // dictionary of the values, ordered by the key
            SortedList<string, Driver> mySortedList = new SortedList<string, Driver>();
            mySortedList.Add(fifth.Id, fifth);
            mySortedList.Add(thirdDriver.Id, thirdDriver);
            mySortedList.Add(firstDriver.Id, firstDriver);

            mySortedList.Add(secondDriver.Id, secondDriver);

            mySortedList.Add(fourth.Id, fourth);


            foreach (Driver currentDriver in mySortedList.Values)
            {
                Console.WriteLine(currentDriver);

            }

            Language languageEnglish = new Language(1, "English");
            Language languageHebrew = new Language(2, "Hebrew");


            Dictionary<string, Language> languages = new Dictionary<string, Language>();
            languages.Add(languageEnglish.Code + "_" + languageEnglish.Name, languageEnglish);
            languages.Add(languageHebrew.Code + "_" + languageHebrew.Name, languageHebrew);



            





        }
    }
}
