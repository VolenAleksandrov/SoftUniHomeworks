using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.PhoneBook
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string,string> phoneBook = new Dictionary<string,string>();
            while (input != "search")
            {
                string[] nameAndPhone = input.Split('-');

                phoneBook[nameAndPhone[0]] = nameAndPhone[1];
                input = Console.ReadLine();
            }
            bool isPrint = false;
            while (true)
            {
                input = Console.ReadLine();
                foreach (var pair in phoneBook)
                {
                    if (pair.Key == input)
                    {
                        Console.WriteLine("{0} -> {1}", pair.Key, pair.Value);
                        isPrint = true;
                    }
                }
                if (isPrint == false)
                {
                    Console.WriteLine("Contact {0} does not exist.", input);
                }
                isPrint = false;
            }

            
        }
    }
}
