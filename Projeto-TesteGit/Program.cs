using System;
using System.Collections.Generic;
using System.Globalization;

namespace Projeto_TesteGit
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime t = new DateTime(2020, 1, 17, 21, 7, 56);
            HashSet<int> lista = new HashSet<int>();

            lista.Add(1);
            lista.Add(2);

            for(int i=0;i<t.Day;i++)
            {
                lista.Add(i);
            }

            foreach(int x in lista)
            {
                Console.Write(x + " ");
            }

            

            Console.WriteLine("\n\nTeste 1: Learning how to work with GitHub/GitBash... \n" + t.ToLongDateString());
        }
    }
}
