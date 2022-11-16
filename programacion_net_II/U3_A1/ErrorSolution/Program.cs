using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ErrorSolution
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int[,] mEjemplo = new int[3, 4];
            Random aleatorios = new Random();
            try
            {
                StreamWriter sw = new StreamWriter("C:\\ArchivoDummy.txt", true, Encoding.ASCII);
                for (byte fila = 0; fila < 3; fila++)
                {
                    for (byte columna = 0; columna < 4; columna++)
                    {
                        mEjemplo[fila, columna] = aleatorios.Next(1, 101);
                        sw.Write(mEjemplo[fila, columna]+"\n");
                        Console.WriteLine(mEjemplo[fila, columna]);
                    }
                }
                sw.Close();
            }catch(UnauthorizedAccessException uae)
            {
                Console.WriteLine("ERROR: {0}", uae.ToString());
            }
            catch (DirectoryNotFoundException dnfe)
            {
                Console.WriteLine("ERROR: {0}", dnfe.ToString());
            }
            catch(IOException ioe)
            {
                Console.WriteLine("ERROR: {0}", ioe.ToString());
            }
            finally
            {
                Console.WriteLine("All was fine!");
            }
            Console.ReadLine();
        }
    }
}
