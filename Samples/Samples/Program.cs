using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Samples
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "Old value";
            string s2 = s1;
            s1 = "New value";
            Console.WriteLine(s2);
            Console.Read();

            string str = "seo tutorials advanced";
            //string[] stopWords = { "i", "is", "a", "able", "about", "across", "after", "all", "almost", "also", "am", "among", "an", "and", "any", "are", "as", "at", "be", "because", "in" };
            string[] stopWords = { };
            List<string> TokensList = new List<string>();
            string[] strArr = str.Split(Convert.ToChar(" "));
            
            foreach (string strr in strArr)
            {
                if(!stopWords.Contains(strr))
                {
                    TokensList.Add(strr);
                }
            }

            for (int i = 0; i < TokensList.Count; i++)
            {
                for (int j = i; j < TokensList.Count; j++)
                {
                    string token = string.Empty;
                    for (int k = i; k <= j; k++)
                    {
                        token = token + " " + TokensList[k];
                    }
                    Console.WriteLine(token);
                }
            }
            
            // create a new dictionary of strings, with string keys.
            Dictionary<string, string> synonyms = new Dictionary<string,string>();
            
            // Now add some elements to dictionary, keys must not be duplicate.
            synonyms.Add("advanced","new");
            synonyms.Add("2","tow");
            synonyms.Add("3","three");
            synonyms.Add("4","four");
            synonyms.Add("5","five");

            foreach(KeyValuePair<string, string> kvp in synonyms)
            {
                Console.WriteLine("Key = {0}, Value = {1}", kvp.Key, kvp.Value);
                Console.Write('\n');
            }

            // replace the spin-able word with spun word by matching it via regular expression
            string inputText = Regex.Replace(str, Regex.Escape("advanced"), synonyms["advanced"]);
            Console.WriteLine(inputText);
            Console.Read();
            Console.Read();

            /*
            Student stu = new Student();
            stu.RollNumber = 5;
            Console.Write("Roll Number: " + stu.RollNumber);
            Console.Write('\n');
            string str = "my name is muhammad a able about sohail";
            string[] stopWords = {"is","a","able","about","across","after","all","almost","also","am","among","an","and","any","are","as","at","be","because"};
            List<string> list = new List<string>();
            string[] strArr = str.Split(Convert.ToChar(" "));
            foreach(string strr in strArr)
            {
                if (Array.IndexOf(stopWords, strr) == -1)
                {
                    list.Add(strr);
                }
            }
            
            foreach(string item in list)
            {
                Console.WriteLine(item);
            }

            string token = new string(" ".ToCharArray());
            Console.WriteLine("Tokens:\n");
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = 0; j < list.Count; j++)
                {
                    token = "";
                    for (int k = 0; k < i + 1; k++)
                    {
                        if (j == list.Count - 1 && i == 1)
                            break;
                        token = token + " " + list[j + k];
                    }
                    Console.WriteLine("Token is: " + token);
                }
            }

                for (int i = 0; i < strArr.Length; i++)
                {
                    Console.Write("Row: " + i);
                    for (int j = 0; j < i; j++)
                    {

                    }
                    Console.Write('\n');
                    Console.ReadLine();
                }
            */
        }
    }


    // Defining a property of an object
    class Student
    {
        private int rollNo;
        
        // interface to set/get property
        // value is an implicit parameter that is passed to set method
        public int RollNumber
        {
            get { return rollNo; }
            set { this.rollNo = value; }
        }
    }
}
