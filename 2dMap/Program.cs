﻿using System;
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
            
            DisplayMap();
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

        static void DisplayMap()
        {
            int height;
            int width;

            height = map.GetLength(0);
            width = map.GetLength(1);

            //Console.WriteLine(map.GetLength(1));

            for (int x = 0; x <= height - 1; x++)
            {
                for (int y = 0; y <= width - 1; y++)
                {
                    Console.Write(map[x,1]); Console.Write(map[1,y]);
                }
                Console.WriteLine();
            }
            
        }

        static void DisplayMap(int scale)
        {
            int row;
            int column;

            row = map.GetLength(0);
            column = map.GetLength(1);


        }
    }
}
