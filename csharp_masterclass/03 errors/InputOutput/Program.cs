using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace InputOutput
{
    class Program
    {
        static void Main(string[] args)
        {
            // All file
            string text = System.IO.File.ReadAllText(@"C:\Users\super\Documents\csharp_topics\text.txt");
            Console.WriteLine("El archivo contiene: {0}", text);

            Console.WriteLine("+++++++++++++++++++++++");
            // Line for line
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\super\Documents\csharp_topics\text.txt");
            for(int i = 0; i < lines.Length; i++)
            {
                Console.WriteLine("{0}", lines[i]);
            }

            Console.WriteLine("Please, write some line: ");
            string line = Console.ReadLine();
            File.WriteAllText(@"C:\Users\super\Documents\csharp_topics\text.txt", line);

            Console.WriteLine("Please write the file name: ");
            string nameFile = Console.ReadLine();
            Console.WriteLine("Please write the information: ");
            line = Console.ReadLine();
            File.WriteAllText(@"C:\Users\super\Documents\csharp_topics\" + nameFile + ".txt", line);

            // Stream writer
            using (StreamWriter file = new StreamWriter(@"C:\Users\super\Documents\csharp_topics\conditions.txt", true))
            {
                string[] allLines = { "Primera", "Segunda", "Tercera" };
                foreach (string lin in allLines)
                {
                    if (lin.Contains("T"))
                    {
                        file.WriteLine(lin);
                    }
                }
            }

            Console.ReadLine();
        }
    }
}
