using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtelierBoucle_tableau
{
    class Program
    {
        static void Main(string[] args)
        {
            int NombreSaisi = 0;
            Console.WriteLine("Ce programme vous donnera la factorielle d'un nombre de votre choix");
            Console.WriteLine("Enter un nombre");
            NombreSaisi = Convert.ToInt32(Console.ReadLine());
            int ì = 0;
            int total = 1;
            for (int i = 1; i <= NombreSaisi;i++)
            {
                total = total * i;
            }
            Console.WriteLine("La factorielle est de " + total);
            Console.WriteLine("Etes-vous satisfait monseigneur de vinci du premier?");
        }
    }
}
