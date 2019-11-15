using System;
using System.Collections.Generic;

namespace FamilyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, string>> myFamily = new Dictionary<string, Dictionary<string, string>>();

            myFamily.Add("father", new Dictionary<string, string>()
            { { "name", "Alexander" }, { "age", "42" }
            });
            myFamily.Add("mother", new Dictionary<string, string>()
            { { "name", "Krista" }, { "age", "40" }
            });
            myFamily.Add("sister", new Dictionary<string, string>()
            { { "name", "Kreepa" }, { "age", "16" }
            });
            myFamily.Add("brother", new Dictionary<string, string>()
            { { "name", "Kevin" }, { "age", "14" }
            });

            foreach (KeyValuePair<string, Dictionary<string, string>> familyMember in myFamily)
            {

                Console.WriteLine($"{familyMember.Value["name"]} is my {familyMember.Key} and her age is {familyMember.Value["age"]}");
            }
        }
    }
}