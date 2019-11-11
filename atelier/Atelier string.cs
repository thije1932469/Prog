using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code_string
{
    class Program
    {
        

        static void AfficherMenu(ref int choix)
        {
            Console.WriteLine("1-Permet d’afficher la longueur de la chaîne de caractères");
            Console.WriteLine("2-Permet de déterminer si la phrase contient «octopus»");
            Console.WriteLine("3-Permet de connaître la position du premier ‘e’ ( indice, IndexOf");
            Console.WriteLine("4-Permet d’afficher une sous phrase");
            Console.WriteLine("5-Transforme la chaîne en majuscule puis l’affiche");
            Console.WriteLine("6-Transforme la chaîne en minuscule puis l’affiche");
            Console.WriteLine("7-Termine le programme");
            choix = Convert.ToInt32(Console.ReadLine());
        }
        static void AfficherLong(string Phrase)
        {               
            Console.WriteLine(Phrase.Length);
        }
        static void Octopus(string Phrase)
        {
            if (Phrase.Contains("octopus") == true)
            {
                Console.WriteLine("Oui, il y a bel et bien un octopus... et une japonaise?! Oh shit...");
            }
            else
            {
                Console.WriteLine("Non, il n'y a pas de octopus.");
            }
        }

        static void TentacleHentai(string Phrase)
        {
            Console.WriteLine("case "+Phrase.IndexOf("e"));
        }

        static void SousPhrase(string Phrase)
        {
            int PremierEspace = Phrase.IndexOf(" ");
            Console.WriteLine(Phrase.Substring(0, PremierEspace));
        }

        static void Majuscule(string Phrase)
        {
            Console.WriteLine(Phrase.ToUpper());
        }

        static void Minuscule(string Phrase)
        {
            Console.WriteLine(Phrase.ToLower());
        }

        static void Exit()
        {
            Environment.Exit(-1);
        }

        static void Main(string[] args)
        {
            string Phrase = "";
            int choix = 1;
            Console.WriteLine("Veuillez saisir une phrase.");
            Phrase = Console.ReadLine();
            AfficherMenu(ref choix);
              
            switch (choix)
            {
               case 1: AfficherLong(Phrase); Console.ReadKey(); break;
               case 2: Octopus(Phrase); break;
               case 3: TentacleHentai(Phrase); break;
               case 4: SousPhrase(Phrase); break;
               case 5: Majuscule(Phrase); break;
               case 6: Minuscule(Phrase); break;
               case 7: Exit(); break;

            }
        }
    }
}
