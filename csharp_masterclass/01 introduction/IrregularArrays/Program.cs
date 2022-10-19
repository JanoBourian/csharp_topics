using System;
using System.Collections;
using System.Collections.Generic;

namespace IrregularArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] irregular = new int[3][];
            irregular[0] = new int[5];
            irregular[1] = new int[3];
            irregular[2] = new int[9];

            irregular[0] = new int[] { 1, 2, 3, 4, 5};
            irregular[1] = new int[] { 0, 3, 5};
            irregular[2] = new int[] { 1, 9, 8, 7, 8, 9, 7, 9, 9 };

            int[][] irregular2 = new int[][]
            {
                new int[] { 1, 2, 3, 4, 5},
                new int[] { 0, 3, 5 },
                new int[] { 1, 9, 8, 7, 8, 9, 7, 9, 9 }
             };

            for(int i= 0; i < irregular2.Length; i++)
            {
                printArray(irregular2[i]);
                Console.WriteLine("!");
            }
            arrayAsAList();
            Console.ReadLine();
        }

        static void printArray(int[] arrayToPrint)
        {
            for(int i = 0; i < arrayToPrint.Length; i++)
            {
                Console.WriteLine("{0}", arrayToPrint[i]);
            }
        }

        static void arrayAsAList()
        {
            ArrayList miArray = new ArrayList();
            ArrayList miSecondArray = new ArrayList(100);

            for(int i = 0; i < 10; i++)
            {
                Console.Write("Escribe una palabra: ");
                String name = Console.ReadLine();
                miArray.Add(name);
            }

            foreach(object obj in miArray)
            {
                Console.WriteLine(obj);
            }

            /* 
             * Add()
             * Remove() <- tho show
             * RemoveAt() <- position
             * Count
             */
        }

        // List
        static void workWithList()
        {
            var numeros = new List<int>();
            var randomValues = new List<object>();
        }
    }
}
