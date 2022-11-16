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
        
        
        static string[,] map = new string[,] // dimensions defined by following data:
        {   { G , M , G , G , G , G , G , G , G , G , M , M , M , G , G},
            { M , M , G , G , G , G , G , G , G , G , M , M , M , G , G},
            { G , G , V , V , G , G , G , G , G , G , M , M , M , G , G},
            { G , G , V , V , G , G , G , G , G , G , V , V , V , V , G},
            { G , G , V , V , G , G , G , G , G , G , V , V , V , G , G},
            { G , G , G , G , G , G , G , G , G , G , G , G , G , G , G},
            { G , G , G , G , G , G , G , G , G , G , G , G , G , G , G}
        };
        /*static string G = "*"; // Ground
        static string M = "^"; // Cliff/Mountain
        static string V = "~"; // Water*/

        static string[] legend = { "*", "^", "~" };
        static string[0] 
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
