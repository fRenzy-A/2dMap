using System;
using System.Collections.Generic;
using System.Linq;
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

        static char[,] map = new char[,] // dimensions defined by following data:
        {
            {'╔','═','═','═','═','═','═','═','═','═','═','═','═','═','═','═','═','═','═','═','═','═','═','═','═','═','═','═','═','╗'},
            {'║','^','`','`','`','`','*','*','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','~','~','~','`','`','║'},
            {'║','^','`','`','`','*','*','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','~','~','~','`','`','`','`','║'},
            {'║','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','║'},
            {'║','`','`','`','~','~','~','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','║'},
            {'║','`','`','`','~','~','~','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','║'},
            {'║','`','`','~','~','~','~','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','^','^','`','`','`','`','`','║'},
            {'║','`','`','`','`','~','~','~','`','`','`','`','`','`','`','`','`','`','`','`','`','^','^','^','^','`','`','`','`','║'},
            {'║','`','`','`','`','~','~','~','~','`','`','`','`','`','`','`','`','`','`','`','`','`','`','^','^','^','^','`','`','║'},
            {'║','`','`','`','`','`','`','~','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','║'},
            {'║','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','║'},
            {'╚','═','═','═','═','═','═','═','═','═','═','═','═','═','═','═','═','═','═','═','═','═','═','═','═','═','═','═','═','╝'},
        };

        static void DisplayMap(int Scale)
        {
            int MapScale;
            MapScale = Scale;
            int L;
            int W;
            var G = "*"; // Ground
            var M = "^"; // Cliff/Mountain
            var V = "~"; // Water
            // ╔═╗╝╚║
            string[,] map = new string[,] // dimensions defined by following data:
        {   { G , M , G , G , G , G , G , G , G , G , M , M , M , G},
            { M , M , G , G , G , G , G , G , G , G , M , M , M , G},
            { G , G , V , V , G , G , G , G , G , G , M , M , M , G},
            { G , G , V , V , G , G , G , G , G , G , V , V , V , V},
            { G , G , V , V , G , G , G , G , G , G , V , V , V , G},
            { G , G , G , G , G , G , G , G , G , G , G , G , G , G},
            { G , G , G , G , G , G , G , G , G , G , G , G , G , G}
        };
            int height;
            int width;

            height = map.GetLength(0);
            width = map.GetLength(1);

            //Console.WriteLine(map.GetLength(1));
            /*for (int i = 0; i < height; i++)
            {

            }*/
            for (int x = 0; x < height; x++)
            {
                for (int m = 0; m < MapScale; m++)
                {
                    for (int y = 0; y < width; y++)
                    {
                        for (int z = 0; z < MapScale; z++)
                        {
                            Console.Write(map[x, y]);
                        }
                    }
                    Console.WriteLine();
                }
               
            }
            
            
            
        }

        static void DisplayMap()
        {
            int height;
            int width;

            height = map.GetLength(0);
            width = map.GetLength(1);
            
            for (int x = 0; x < height; x++)
            {
                for (int y = 0; y < width; y++)
                {
                    Console.Write(map[x, y]);
                }
                Console.WriteLine();
            }
            


        }
    }
}
