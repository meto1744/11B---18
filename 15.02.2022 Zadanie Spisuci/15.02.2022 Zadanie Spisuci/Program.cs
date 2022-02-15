using System;
using System.Collections.Generic;
using System.Linq;

namespace _15._02._2022_Zadanie_Spisuci
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine().Split().ToList();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "print")
                {
                    Console.WriteLine(string.Join(" ", names));
                }
                string[] commands = input.Split();

                switch (commands[0])
                {
                    case "add":
                        {
                            string elementToAdd = (commands[1]);
                            names.Add(elementToAdd);
                            if (names.Contains(elementToAdd))
                            { 
                                Console.WriteLine("Element already exists!");
                            }
                            break;
                            
                        }
                    case "contains":
                        {
                            string nameToSearch = (commands[1]);
                            if (names.Contains(nameToSearch))
                            {
                                Console.WriteLine(names.IndexOf(nameToSearch));
                            }
                            break;
                        }
                    case "insert":
                        int numberToInsert = int.Parse(commands[1]);
                        
                        break;
                    
                       
                }
                    
            }
        }
    }
}
