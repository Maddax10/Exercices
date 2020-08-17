using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Complexe
{
    class Program
    {
        static void Main(string[] args)
        {

            int partieRéelle, partieImaginaire;

            int QuantiteComplexe = 2;

            Complexe[] TabComplexes = new Complexe[QuantiteComplexe];

            for (int i = 0; i < QuantiteComplexe; i++)
            {
                Console.WriteLine($"Nombre Complexe {i + 1} :");

                Console.Write("Donner la partie réelle :");

                partieRéelle = int.Parse(Console.ReadLine());

                Console.Write("Donner la partie imaginaire :");

                partieImaginaire = int.Parse(Console.ReadLine());

                TabComplexes[i] = new Complexe(partieRéelle, partieImaginaire);
                TabComplexes[i].Afficher();
            }

            Console.WriteLine();
            Console.WriteLine("Plus :");

            TabComplexes[0].Plus(TabComplexes[1]).Afficher();
            Console.WriteLine();

            Console.WriteLine("Moins:");
            TabComplexes[0].Moins(TabComplexes[1]).Afficher();

            Console.ReadLine();

        }
    }
}
