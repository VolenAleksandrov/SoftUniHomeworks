using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_5
{
    class Program
    {
        static void Main()
        {
            char[][] input = new char[4][];
            for (int i = 0; i < 4; i++)
            {
                input[i] = Console.ReadLine().ToArray();
            }

            string commands = Console.ReadLine();
            int coinsCollected = 0;
            int wallHit = 0;
            int x = 0, y = 0;

            for (int i = 0; i < commands.Length; i++)
            {
                char direction = commands[i];

                if (direction == 'V')
                {
                    x++;
                    if (x > input.Length - 1)
                    {
                        wallHit++;
                        x = input.Length - 1;
                    }
                    else if (y > input[x].Length - 1)
                    {
                        x--;
                        y = input[x].Length - 1;
                        wallHit++;
                    }
                    else if (input[x][y] == '$')
                    {
                        coinsCollected++;
                    }
                }

                else if (direction == '^')
                {
                    x--;
                    if (x < 0)
                    {
                        wallHit++;
                        x = 0;
                    }
                    else if (input[x][y] == '$')
                    {
                        coinsCollected++;
                    }
                }

                else if (direction == '<')
                {
                    y--;
                    if (y < 0)
                    {
                        wallHit++;
                        y = 0;
                    }
                    else if (input[x][y] == '$')
                    {
                        coinsCollected++;
                    }
                }

                else if (direction == '>')
                {
                    y++;
                    if (y > input[x].Length - 1)
                    {
                        wallHit++;
                        y = input[x].Length - 1;
                    }
                    else if (input[x][y] == '$')
                    {
                        coinsCollected++;
                    }
                }
            }
            Console.WriteLine("Coins: {0}, walls: {1}", coinsCollected, wallHit);
        }
    }
}