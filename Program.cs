// Program.cs
using CheckPoint.Database;
using System;

namespace FiapCheckpoint2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Checkpoint FIAP - EF Core Code First");

            using var db = new ConfigurationDb();

            Console.WriteLine("DbContext ok. Use os comandos de migration para gerar o banco.");
        }
    }
}
