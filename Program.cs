using System;
using System.Collections.Generic;

namespace FamilyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, string>> myFamily = new Dictionary<string, Dictionary<string, string>>();

            myFamily.Add("father", new Dictionary<string, string>(){
                {"name", "Billy"},
                {"age", "56"}
            });

            myFamily.Add("mother", new Dictionary<string, string>(){
                {"name", "Elizabeth"},
                {"age", "56"}
            });

            myFamily.Add("brother", new Dictionary<string, string>(){
                {"name", "Dyllan"},
                {"age", "24"}
            });

            foreach(KeyValuePair<string, Dictionary<string, string>> familyMember in myFamily)
            {
                Console.WriteLine("");
                Console.WriteLine($"{familyMember.Value["name"]} is my {familyMember.Key} and is {familyMember.Value["age"]} years old.");
                Console.WriteLine("");
            }
        }
    }
}
