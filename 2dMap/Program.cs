using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _2dMap
{
    internal class Program
    {
        static int x = 4;
        static int y = 3;
        static void Main(string[] args)
        {
            while (true)
            {
                DisplayMap(1);
                Player(x, y);
                PlayerUpdate();
            }        
        }
        static char G = '*'; // Ground
        static char M = '^'; // Cliff/Mountain
        static char V = '~'; // Water
        static char[,] map = new char[,] // dimensions defined by following data:
        {   
            { V , V , V , V , V , V , G , G , G , G , G , G , G , G , G , G , G , G , G , G , G , G , G , G , G , G , M , M , M , M },
            { V , V , V , G , G , G , G , G , G , G , G , G , G , G , G , G , G , G , G , G , G , G , G , G , G , G , M , M , M , M },
            { V , G , G , G , G , G , G , M , M , G , G , G , G , G , G , G , G , G , G , G , G , G , G , G , G , G , G , G , M , M },
            { G , G , G , G , G , G , M , M , M , G , G , G , G , G , G , G , G , G , G , G , G , G , G , G , G , G , G , G , M , M },
            { G , G , G , G , G , G , M , M , M , G , G , G , G , G , G , G , G , G , G , G , G , G , G , G , G , G , G , G , G , M },
            { G , G , G , G , G , G , M , M , M , G , G , G , G , G , G , G , M , G , G , M , G , G , G , G , G , G , G , G , G , G },
            { G , G , G , G , G , G , G , M , G , G , G , G , G , G , G , G , M , G , M , M , G , G , G , G , G , G , G , G , G , G },
            { G , G , G , G , G , G , G , M , G , G , G , G , G , G , G , G , G , G , G , M , M , G , G , G , G , G , G , G , G , G },
            { G , G , G , G , G , G , G , G , G , G , G , G , G , G , G , G , G , G , G , M , M , M , G , G , G , G , G , G , G , G },
            { G , G , G , G , G , G , G , G , G , G , G , G , G , G , G , G , G , G , G , M , G , G , G , G , G , G , G , G , G , G },
            { G , G , G , G , G , G , V , V , V , V , G , G , G , G , G , G , G , G , G , G , G , G , G , G , G , G , V , G , G , G },
            { G , G , G , G , G , V , V , G , G , V , V , G , G , G , G , G , G , G , G , G , G , G , G , G , V , V , V , G , G , G },
            { G , G , G , G , V , V , G , G , G , G , V , V , G , G , G , G , G , G , G , G , G , G , G , G , V , V , V , G , G , G },
            { G , G , G , G , V , V , G , G , G , G , V , V , V , V , G , G , G , G , G , G , G , G , G , G , G , V , G , G , G , G },
            { G , G , G , V , V , G , G , G , G , G , G , G , G , V , V , G , G , G , G , G , G , G , G , G , G , G , G , G , G , G }
        };
        static void DisplayMap(int Scale)
        {
            int MapScale;
            int height;
            int width;

            MapScale = Scale;            
            height = map.GetLength(0);
            width = map.GetLength(1);

            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.White;
            for (int e = 0; e <= (width) * MapScale + 3; e++) //Border Width Scale
            {
                Console.Write("O",Console.BackgroundColor, Console.ForegroundColor);
            }
            Console.WriteLine();
            for (int x = 0; x < height; x++)
            {                
                for (int m = 0; m < MapScale; m++)
                {
                    Console.Write("OO", Console.BackgroundColor); // Border Height Scale
                    for (int y = 0; y < width; y++)
                    {                      
                        for (int z = 0; z < MapScale; z++)
                        {
                            if (map[x,y] == G)  
                            {
                                Console.BackgroundColor = ConsoleColor.Green;
                                Console.ForegroundColor = ConsoleColor.Green;
                            }
                            if (map[x, y] == M)
                            {
                                Console.BackgroundColor = ConsoleColor.DarkGray;
                                Console.ForegroundColor = ConsoleColor.Gray;
                            }
                            if (map[x, y] == V)
                            {
                                Console.BackgroundColor = ConsoleColor.DarkBlue;
                                Console.ForegroundColor = ConsoleColor.Blue;
                            }                          
                            Console.Write(map[x, y]); //Map Writer
                        }
                    }
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("OO", Console.BackgroundColor, Console.ForegroundColor); // Border Height Scale
                    Console.WriteLine(); // Height Changer                   
                }           
            }
            for (int e = 0; e <= (width) * MapScale + 3; e++) //Border Width Scale
            {
                Console.Write("O", Console.BackgroundColor, Console.ForegroundColor);
            }
            Console.ResetColor();
        }
        static void DisplayMap()
        {
            int height;
            int width;
            
            height = map.GetLength(0);
            width = map.GetLength(1);

            for (int e = 0; e <= (width) + 3; e++) //Border Width Scale
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("O", Console.BackgroundColor, Console.ForegroundColor);
            }
            Console.WriteLine();
            for (int x = 0; x < height; x++)
            {
                Console.Write("OO", Console.BackgroundColor, Console.ForegroundColor); // Border Height Scale
                for (int y = 0; y < width; y++)
                {
                    if (map[x, y] == G)
                    {
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    if (map[x, y] == M)
                    {
                        Console.BackgroundColor = ConsoleColor.DarkGray;
                        Console.ForegroundColor = ConsoleColor.Gray;
                    }
                    if (map[x, y] == V)
                    {
                        Console.BackgroundColor = ConsoleColor.DarkBlue;
                        Console.ForegroundColor = ConsoleColor.Blue;
                    }
                    Console.Write(map[x, y]); //Map Writer
                }
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("OO", Console.BackgroundColor, Console.ForegroundColor); // Border Height Scale
                Console.WriteLine();
            }
            for (int e = 0; e <= width + 3; e++) //Border Width Scale
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("O", Console.BackgroundColor, Console.ForegroundColor);
            }

            Console.ResetColor();

        }

        
        static void Player(int x, int y)
        {
            Console.CursorVisible = false;
            Console.SetCursorPosition(x, y);
            Console.Write("X");
            //if (Cur
        }
        static void PlayerUpdate()
        {
            ConsoleKeyInfo KeyInfo;
            KeyInfo = Console.ReadKey(true);
            if (KeyInfo.Key == ConsoleKey.W)
            {
                Console.Clear();
                y = y - 1;
            }
            if (KeyInfo.Key == ConsoleKey.A)
            {
                Console.Clear();
                x = x - 1;
            }
            if (KeyInfo.Key == ConsoleKey.S)
            {
                Console.Clear();
                y = y + 1;
            }
            if (KeyInfo.Key == ConsoleKey.D)
            {
                Console.Clear();
                x = x + 1;
            }

        }
    }
}
