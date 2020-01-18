using System;
using System.Globalization;

namespace Projeto_TesteGit
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime t = new DateTime(2020, 1, 17, 21, 7, 56);

            Console.WriteLine("Teste 1: Learning how to work with GitHub/GitBash... \n" + t.ToLongDateString());
        }
    }
}
