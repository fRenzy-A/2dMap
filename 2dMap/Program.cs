using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace _2dMap
{
    internal class Program
    {
        static void Main(string[] args)
        {

            
            DisplayMap(1);
            
            Console.ReadKey(true);
            
        }

        static char G = '*'; // Ground
        static char M = '^'; // Cliff/Mountain
        static char V = '~'; // Water
        static char[,] map = new char[,] // dimensions defined by following data:
        {   
            { G , M , G , G , G , G , G , G , G , G , M , M , M , G , G},
            { M , M , G , G , G , G , G , G , G , G , M , M , M , G , G},
            { G , G , V , V , G , G , G , G , G , G , M , M , M , G , G},
            { G , G , V , V , G , G , G , G , G , G , V , V , V , V , G},
            { G , G , V , V , G , G , G , G , G , G , V , V , V , G , G},
            { G , G , G , G , G , G , G , G , G , G , G , G , G , G , G},
            { G , G , G , G , G , G , G , G , G , G , G , G , G , G , G}
        };

        /*static string[] legend = { "*", "^", "~" };
        static string[0];*/

        static void DisplayMap(int Scale)
        {
            int MapScale;
            MapScale = Scale;
            
            int height;
            int width;

            height = map.GetLength(0);
            width = map.GetLength(1);


            for (int e = 0; e <= (width) * MapScale + 1; e++) //Border Width Scale
            {
                Console.Write("O");
            }
            Console.WriteLine();
            for (int x = 0; x < height; x++)
            {                
                for (int m = 0; m < MapScale; m++)
                {
                    Console.Write("O"); // Border Height Scale
                    for (int y = 0; y < width; y++)
                    {
                        for (int z = 0; z < MapScale; z++)
                        {
                            foreach (char currentTile in map)
                            {
                                //var colors = Enum.GetValues(typeof(ConsoleColor)).Cast<ConsoleColor>().ToArray();
                                /*if (currentTile == G)
                                {
                                    Console.ResetColor();
                                    Console.BackgroundColor = ConsoleColor.Green;
                                }*/
                                if (currentTile == V)
                                {
                                    Console.ResetColor();
                                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                                }
                                /*if (currentTile == M)
                                {
                                    Console.ResetColor();
                                    Console.BackgroundColor = ConsoleColor.DarkGray;
                                }*/
                         
                            }
                            Console.Write(map[x, y]);


                        }
                        
                    }
                    Console.Write("O"); // Border Height Scale
                    Console.WriteLine();
                    
                }
                
            }
            for (int e = 0; e <= (width) * MapScale + 1; e++) //Border Width Scale
            {
                Console.Write("O");
            }
            
        }

        static void DisplayMap()
        {
            int height;
            int width;
            
            height = map.GetLength(0);
            width = map.GetLength(1);

            for (int e = 0; e <= (width) + 1; e++) //Border Width Scale
            {
                Console.Write("O");
            }
            Console.WriteLine();
            for (int x = 0; x < height; x++)
            {
                Console.Write("O"); // Border Height Scale
                for (int y = 0; y < width; y++)
                {
                    Console.Write(map[x, y]);
                }
                Console.Write("O"); // Border Height Scale
                Console.WriteLine();
            }
            for (int e = 0; e <= width + 1; e++) //Border Width Scale
            {
                Console.Write("O");
            }



        }
    }
}
