using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Depuration
{
    class Program
    {
        static void Main(string[] args)
        {
            var friends = new List<string> { "Mauricio", "Alejandro", "Mariana", "Julieta", "Marisol", "Ana", "Juan" , "Rodrigo", "Damian", "Luis", "Miguel", "Pedro", "Ariadna", "Lua"};
            var selFriends = selectFriends(friends, 4);
            printList(selFriends);
            Console.ReadLine();
        }

        public static List<string> selectFriends(List<string> listFriends, int number)
        {
            var auxList = new List<string>();
            int size = listFriends.Count;
            for(int i = 0; i < size; i++)
            {
                for(int j = 0; j < (size-1); j++)
                {
                    if (listFriends[j].Length > listFriends[j + 1].Length)
                    {
                        string aux = listFriends[j + 1];
                        listFriends[j + 1] = listFriends[j];
                        listFriends[j] = aux;
                    }
                }
            }

            for(int i = 0; i < number; i++)
            {
                auxList.Add(listFriends[i]);
            }
            return auxList;
        }

        public static void printList(List<string> listFriends)
        {
            foreach(var name in listFriends)
            {
                Console.Write("{0}, ", name);
            }
        }

    }
}
