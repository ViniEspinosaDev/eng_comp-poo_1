using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace Projeto_TesteGit
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"C:\Users\vinie\Documents\Arquivos\Vinicius\Estudo\Cursos Adicionais\Udemy\C# do Iniciante ao Avançado\Arquivos C# - Teste\espinosa.repositorie\file1.txt";
            
            try
            {
                string[] lines = File.ReadAllLines(sourcePath);
                int[,] mat = new int[lines.Length,3];
                int contLine = 0, contColumn = 0, qtdColumn=0;

                foreach (string line in lines)
                {
                    string[] aux = line.Split(" ");
                    qtdColumn = aux.Length;
                    contColumn = 0;
                    foreach(string x in aux)
                    {
                        mat[contLine,contColumn] = int.Parse(x);
                        contColumn++;
                    }
                    contLine++;
                }

                for(int i=0;i<lines.Length;i++)
                {
                    for(int j=0;j<qtdColumn;j++)
                    {
                        Console.Write(mat[i, j].ToString() + " "); 
                    }
                    Console.WriteLine();
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
            catch (Exception r)
            {
                Console.WriteLine("Error: " + r.Message);
            }

        }
    }
}
