using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trouve_le_nombre
{
    class Program
    {
        static void Main(string[] args)
        {
            int difficulté = 0;
            int Nb = 0;
            int saisi = 0;
            Console.WriteLine("Bienvenue au jeu de trouve le nombre.");
            Console.WriteLine("Quelle difficulté voulez vous choisir?");
            Console.WriteLine("1- facile");
            Console.WriteLine("2- moyen");
            Console.WriteLine("3- difficile");
            difficulté = Convert.ToInt32(Console.ReadLine());

            if (difficulté == 1)
            {
                Random generateurNb = new Random();
                Nb = generateurNb.Next(1, 101);


                for(int i=0; i>=0;i++)
                {
                    Console.WriteLine("Choisir un nombre de 1 a 100");
                    saisi = Convert.ToInt32(Console.ReadLine());
                    if (Nb == saisi)
                    {
                        Console.WriteLine("Tu gagnes! Bravo!");
                    }
                    if (Nb > saisi)                   
                        Console.WriteLine("Ouais non, ton nombre est trop petit.");
                        if (Nb < saisi)
                            Console.WriteLine("Ben non, ton nombre est trop grand.");
                    
                }
            }
            else if (difficulté == 2)
            {
                Random generateurNb = new Random();
                Nb = generateurNb.Next(1, 1001);
                for (int i = 0; i >= 0; i++)
                {
                    Console.WriteLine("Choisir un nombre de 1 a 1000");
                    saisi = Convert.ToInt32(Console.ReadLine());
                    if (Nb == saisi)
                    {
                        Console.WriteLine("Tu as gagné!");
                    }
                    if (Nb > saisi)
                        Console.WriteLine("Le nombre est trop petit");
                    if (Nb < saisi)
                        Console.WriteLine("Le nombre est trop grand");
                }
            }

            else if (difficulté == 3)
            {
                Random generateurNb = new Random();
                Nb = generateurNb.Next(1, 10001);
                for (int i = 0; i >= 0; i++)
                {
                    Console.WriteLine("Choisir un nombre de 1 a 1000");
                    saisi = Convert.ToInt32(Console.ReadLine());
                    if (Nb == saisi)
                    {
                        Console.WriteLine("Tu as gagné!");
                    }
                    if (Nb > saisi)
                        Console.WriteLine("Le nombre est trop petit");
                    if (Nb < saisi)
                        Console.WriteLine("Le nombre est trop grand");
                }
            }

        }
    }
}
