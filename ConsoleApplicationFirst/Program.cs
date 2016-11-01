using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter size: ");
            string input = Console.ReadLine();
            int number = 0;
            Int32.TryParse(input, out number);

            int[][] array = new int[number][];
            int iBuff = 0;
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new int[number];
                Console.WriteLine();
                for (int j = 0; j < array[i].Length; j++)
                {
                    iBuff++;
                    array[i][j] = iBuff;
                    Console.Write(array[i][j] + " ");
                }
                    
            };

            
            Console.Write("\nEnter 2 coordinates: ");
            string coordinates = Console.ReadLine();
            var coordinateSplit = coordinates.Split(' ');

            int coord0;
            int coord1;
            Int32.TryParse(coordinateSplit[0], out coord0);
            Int32.TryParse(coordinateSplit[1], out coord1);
            array[coord0][coord1]++;
            PrintArray(array);


        }

        static void PrintArray(int[][] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {

                Console.WriteLine();
                for (int j = 0; j < arr.Length; j++)
                {
                    Console.Write(arr[i][j] + " ");
                }

            };
        }
    }
}
