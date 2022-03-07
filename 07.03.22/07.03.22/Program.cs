using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._03._22
{
    class Program
    {
        static void Main(string[] args)
        /*{
            Dictionary<string, int> email = new Dictionary<string, int>();
            while (true)
            {
                var input = Console.ReadLine().Split();

                if (input[0] == "List")
                {
                    foreach (var item in email)
                    {

                        Console.WriteLine($"{ item.Key} –> {item.Value}");
                    }
                    break;
                }

                if (input[0] == "Add")
                {
                    string name = input[1];

                    string str = "@";

                    int count = int.Parse(input[2]);
                    if (!email.ContainsKey(name))
                    {
                        email.Add(name, count);
                    }
                    else
                    {
                        email[name] = count;
                    }
                    if (!name.StartsWith(str))
                    {
                        Console.WriteLine($"„Input is not correct!“.");
                    }

                }
                if (input[0] == "Sent")
                {
                    string name = input[1];
                    string str = "@";
                    int count = int.Parse(input[2]);
                    if (email.ContainsKey(name))
                    {
                        email[name] = count - 1;
                    }
                    else
                    {
                        Console.WriteLine($"{name} already exists!");
                    }
                    if (!email.ContainsKey(name))
                    {
                        Console.WriteLine($"{name} alraedy exists!");
                    }
                }
                if (input[0] == "Receive")
                {
                    string name = input[1];
                    int count = int.Parse(input[2]);

                }

            }
        }*/

        /*{
            Dictionary<string, string> clothesColor = new Dictionary<string, string>();
            Dictionary<string, int> clothesCount = new Dictionary<string, int>();

            string[] input = Console.ReadLine().Split();

            while (true)
            {
                if (input[0].ToLower() == "show")
                {
                    break;
                }

                if (input[0].ToLower() == "addcolor")
                {
                    if (!input[1].ToLower().StartsWith('t'))
                    {
                        Console.WriteLine("Invalid input!");
                    }

                    else
                    {
                        if (!clothesColor.ContainsKey(input[1]))
                        {
                            clothesColor.Add(input[1], input[2]);
                            clothesCount.Add(input[1], 1);
                        }

                        else
                        {
                            clothesColor[input[1]] = input[2];
                            clothesCount[input[1]] += 1;
                        }
                    }
                }

                if (input[0].ToLower() == "addquantity")
                {
                    if (clothesCount.ContainsKey(input[1]) && clothesCount[input[1]] != 0)
                    {
                        clothesCount[input[1]] += int.Parse(input[2]);
                    }
                }

                if (input[0].ToLower() == "remove")
                {
                    if (!clothesCount.ContainsKey(input[1]) || clothesCount[input[1]] < int.Parse(input[2]) || clothesCount[input[1]] == 0)
                    {
                        Console.WriteLine("Not enough quantity");
                    }

                    else
                    {
                        clothesCount[input[1]] -= int.Parse(input[2]);
                    }
                }

                if (input[0].ToLower() == "empty")
                {
                    foreach (var item in clothesColor.ToList())
                    {
                        clothesColor[item.Key] = "blank";
                    }

                    foreach (var item in clothesCount.ToList())
                    {
                        clothesCount[item.Key] = 0;
                    }

                }

                input = Console.ReadLine().Split();
            }

            int grandTotal = 0;
            foreach (var element in clothesColor)
            {
                string key = element.Key;
                string clothColor = element.Value;
                int clothQuantity = clothesCount[key];
                grandTotal += clothQuantity;

                Console.WriteLine($"{key}: {clothColor} - {clothQuantity}");
            }
            Console.WriteLine($"Grand Total : {grandTotal}");
        }*/
        /*{
            Dictionary<string, int> toys = new Dictionary<string, int>();

            while (true)
            {
                var input = Console.ReadLine().Split();
                if (input[0] == "Stop")
                {
                    foreach (var toy in toys)
                    {
                        Console.WriteLine($"{toy.Key} -> {toy.Value}");
                    }
                    break;
                }

                switch (input[0])
                {
                    case "Purchase":
                        {
                            string toy = input[1];
                            int count = int.Parse(input[2]);

                            if (toy.StartsWith("d"))
                            {
                                if (!toys.ContainsKey(toy))
                                {
                                    toys.Add(toy, count);
                                }

                                else
                                {
                                    toys[toy] += count;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Input is not correct!");
                            }

                            break;
                        }

                    case "Sale":
                        {
                            string toy = input[1];

                            if (!toys.ContainsKey(toy))
                            {
                                Console.WriteLine($"{toy} does not exist");
                            }

                            else
                            {
                                if (toys[toy] > 0)
                                {
                                    toys[toy]--;
                                }
                                else
                                {
                                    Console.WriteLine("Sale is not allowed");
                                }
                            }
                            break;
                        }

                    case "All":
                        {
                            foreach (var toy in toys)
                            {
                                toys[toy.Key] = 0;
                            }
                            break;
                        }

                    default:
                        break;
                }
            }
        }*/
    }

}
        
    

