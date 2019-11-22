using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo3_exercise_1
{
    class Program
    {
        static void AfficherMenu()
        {
            Console.WriteLine("1 -Afficher le nombre de mots contenu dans la phrase");
            Console.WriteLine("2 -Afficher combien de fois chaque lettre apparaît ");
            Console.WriteLine("3 -Afficher la lettre qui apparaît le plus souvent");
            Console.WriteLine("4 -Encoder la phrase en utilisant une clé de +2 et afficher le résultat");
        }
        static void NbMots(string Phrase)
        {
            string[] tabMot = Phrase.Split(' ');
            Console.WriteLine("Il y a "+tabMot.Length+" mots");
        }
        static void NbFois(string Phrase, ref int[] tabLettre)
        {
            for (int i = 0; i < tabLettre.Length; i++)
            {
                char lettre = Convert.ToChar(i + 97);
                Console.WriteLine("La lettre " + lettre + " apparait " + tabLettre[i] + " fois");
            }


        }

        static void PlusSouvent(string Phrase, ref int[] tabLettre)
        {
            
            int PlusGrandNb = 0;
            int temp = 0;
            for (int i = 0; i < tabLettre.Length; i++)
            {

                if (PlusGrandNb < tabLettre[i])
                {
                    PlusGrandNb = tabLettre[i];
                    temp = i;
                }
            }
            char lettre = Convert.ToChar(temp + 97);
            Console.WriteLine("La lettre qui apparait le plus de fois est : " + lettre);



        }

       static void Encodage(string Phrase)
        {
            string tabLettre = "";
            for (int i = 0; i < Phrase.Length; i++)
            {
                int noLettre = (int)Phrase[i];
                tabLettre += char.ConvertFromUtf32((noLettre + 2));
            }
            Console.WriteLine("Voici la phrase encode :" + tabLettre);
        }

        static void Main(string[] args)
        {
            string Phrase = "";
            Console.WriteLine("Veuillez taper une phrase");
            Phrase = Convert.ToString(Console.ReadLine());
            int choix = 0;          
            int[] tabLettre = new int[26];
            for (int i = 0; i < Phrase.Length; i++)
            {
                int indice = (int)Phrase[i] - 97;
                if (indice >= 0 && indice < 26)
                    tabLettre[indice]++;
            }

            

            AfficherMenu();
            choix = Convert.ToInt32(Console.ReadLine());
            switch (choix)
            {
                case 1: NbMots(Phrase);
                    break;
                case 2: NbFois(Phrase ,ref tabLettre);
                    break;
                case 3: PlusSouvent(Phrase, ref tabLettre);
                    break;
                case 4: Encodage(Phrase,ref tabLettre);
                    break;
            }
        }
    }
}
