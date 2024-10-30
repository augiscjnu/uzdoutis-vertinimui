using Knygos.Core.Models;
using Knygos.Core.Repositories;
using System;
using System.ComponentModel.Design;
namespace Knygos
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var repository = new KnyguRepository("knygos.txt");

            while (true)
            {
                Console.WriteLine("Pasirinkite veiksmą:\n1. Pagal autorių\n2. Pagal metus\n3. Klasikos žanras\n4. Baigti");
                string pasirinkimas = Console.ReadLine();

                switch (pasirinkimas)
                {
                    case "1":
                        RodytiKnygasPagalAutoriu(repository);
                        break;
                    case "2":
                        RodytiKnygasPagalMetus(repository);
                        break;
                    case "3":
                        RodytiKlasikosKnygas(repository);
                        break;
                    case "4":
                        return;
                    default:
                        Console.WriteLine("Neteisingas pasirinkimas.");
                        break;
                }
            }
        }

        private static void RodytiKlasikosKnygas(KnyguRepository repository)
        {
            throw new NotImplementedException();
        }

        private static void RodytiKnygasPagalMetus(KnyguRepository repository)
        {
            throw new NotImplementedException();
        }

        private static void RodytiKnygasPagalAutoriu(KnyguRepository repository)
        {
            throw new NotImplementedException();
        }
    }
}
