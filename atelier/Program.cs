using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atelier_Boucle_Tableaux_exercise_2
{
    class Program
    {
        static void AfficherMenu()
        {
            Console.WriteLine("Que voulez-vous faire?");
            Console.WriteLine("1- Trouvez le plus grand nombre");
            Console.WriteLine("2- Trouvez le plus petit nombre");
            Console.WriteLine("3- Verifier si le nombre saisi existe dans le tableau");
            Console.WriteLine("4- Faire la moyenne");
            Console.WriteLine("5- Quitter le programme");
        }
        static void GrandNb(ref int[] tab)
        {           
            int plusGrandNb = 0;
            
            for (int i = 0; i < tab.Length; i++)
            {
                
                if (plusGrandNb < tab[i])
                {
                    plusGrandNb = tab[i];
                }
            }
            Console.WriteLine("Le plus grand nombre est : " + plusGrandNb);
        }
        static void PetitNombre(ref int[] tab)
        {
            int PetitNombre = 10000;

            for (int i = 0; i < tab.Length; i++)
            {
                if (PetitNombre > tab[i])
                {
                   PetitNombre = tab[i];
                }
            }
            Console.WriteLine("Le plus petit nombre est : " + PetitNombre);
        }
        static void Verification(ref int[] tab)
        {
            int nombreSaisie = 0;
            int i = 0;
            bool nombreSaisieExiste = false;
            Console.WriteLine("Veuillez saisir un nombre");
            nombreSaisie = Convert.ToInt32(Console.ReadLine());
            while (nombreSaisieExiste = false && i < tab.Length)
            {
                if (tab[i] == nombreSaisie)
                {
                    nombreSaisieExiste = true;
                   
                }
                else
                {
                    nombreSaisieExiste = false;
                  
                }
               
            }
            if (nombreSaisieExiste = true)
            {
                Console.WriteLine("Le nombre existe.");
            }
            else
            {
                Console.WriteLine("Le nombre n'existe pas.");
            }
        }
        static void Moyenne(ref int[] tab)
        {
            int moyenne = 0;
            int total = 0;
            for(int i = 0; i < tab.Length;i++)
            {
                total += tab[i];
            }
            
            moyenne =  total / 300;
            Console.WriteLine("La moyenne est de " + moyenne);
                         
        }
       


        static void Main(string[] args)
        {
            int nombre = 0;
            int[] TabValeur = new int[300];
            int plusGrandNombre = 0;
            int plusPetitNombre = TabValeur[0];
            bool valeurSaisie = false;
            double moyenne = 0;
            int choix = 0;

            Random generateur = new Random();

            Console.WriteLine("Ce programme va créer un tableau de 300 valeurs avec des nombres aléatoires");
            for (int i = 0; i < TabValeur.Length; i++)
            {
                TabValeur[i] = generateur.Next(1,10001);
                

            }

            AfficherMenu();
            choix = Convert.ToInt32(Console.ReadLine());
            
           
            switch(choix)
            {
                case 1:
                    GrandNb(ref TabValeur);                  
                    break;
                case 2:
                    PetitNombre(ref TabValeur);
                    break;
                case 3:
                    Verification(ref TabValeur);
                    break;
                case 4:
                    Moyenne(ref TabValeur);
                    break;
                case 5:
                    Environment.Exit(0);
                    break;
            }

        }
    }
}
