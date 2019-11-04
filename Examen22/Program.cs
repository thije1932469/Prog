using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen_pratique_2
{
    public enum Sorte { Commun = 1, rare = 2, epic = 3, Légendaire = 4 };
    class Program
    {
        static Random generateur = new Random();
        public static int genererNB(int min, int max)
        {
            return (int)generateur.Next(min, max);
        }
        public struct Ship
        {
            public Ship[] tabShip;

            public string Nom;
            public int NbVie;
            public int Rare;
            public int Vitesse;
            public int Prix;

            public Ship(string _nom, int _Nbvie, int _vitesse, int _Rare): this()
            {
                Nom = _nom;
                NbVie = _Nbvie;
                Vitesse = _vitesse;
                Rare = _Rare;
            }

        }

        Ship ship1 = new Ship("test",100, 300, 2);
        Ship ship2 = new Ship("test2", 150, 600, 3);
        Ship ship3 = new Ship("test3", 150, 600, 3);
        Ship ship4 = new Ship("test4", 150, 600, 3);
        Ship ship5 = new Ship("test5", 150, 600, 3);
        Ship ship6 = new Ship("test6", 150, 600, 3);
        Ship ship7 = new Ship("test7", 150, 600, 3);
        Ship ship8 = new Ship("test8", 150, 600, 3);
        Ship ship9 = new Ship("test9", 150, 600, 3);
        Ship ship10 = new Ship("test10", 150, 600, 3);

        static void Menu()
        {
            int Options = 0;
            Console.WriteLine("Bienvenue chez Walmart, ou les nouveaux vaisseaux spaciaux sont mainteneant disponibles!");
            Console.WriteLine("");
            Console.WriteLine("Que voulez-vous faire?");
            Console.WriteLine("");
            Console.WriteLine("1- Afficher les vaisseaux disponibles");
            Console.WriteLine("");
            Console.WriteLine("2- Vérifier si un vaisseaux légendaire est en stock.");
            Console.WriteLine("");
            Console.WriteLine("3- Trouver le vaisseaux qui a le plus de vie");
            Console.WriteLine("");
            Console.WriteLine("4- Afficher la moyenne des prix");
            Console.WriteLine("");
            Console.WriteLine("5- Quitter");
            
        }

       static void VerifierL()
        {
            int rare = 0;
            rare = genererNB(1, 5);
            if (rare == 4)
            {
                Console.WriteLine("Oui, il y a un vaisseau légendaire.");
            }
            else
            {
                Console.WriteLine("Non, il n'y a pas de vaisseau légendaire.");
            }
        }
        static void VerifierV()
        {

        }
        static void Moyenne()
        {

        }

        
    static void Main(string[] args)
        {
            int rare = 0;
            int Options = 0;
            Menu();
            Options = Convert.ToInt32(Console.ReadLine());
            Ship ship1 = new Ship();
            Ship ship2 = new Ship();
            Ship ship3 = new Ship();
            Ship ship4 = new Ship();
            Ship ship5 = new Ship();
            Ship ship6 = new Ship();
            Ship ship7 = new Ship();
            Ship ship8 = new Ship();
            Ship ship9 = new Ship();
            Ship ship10 = new Ship();
            switch (Options)
            {
                case 1: Console.WriteLine("Voici les vaisseaux disponibles : ");
                    Console.Write(ship1.Nom + ship1.Vitesse);
                        Console.Write(ship1);
                        Console.Write(ship2);
                        Console.Write(ship3);
                        Console.Write(ship4);
                        Console.Write(ship5);
                        Console.Write(ship6);
                        Console.Write(ship7);
                        Console.Write(ship8);
                        Console.Write(ship9);
                        Console.Write(ship10);
                    break;
                case 2: VerifierL();
                    break;
                case 3: VerifierV();
                    break;
                    case 4: Moyenne();
                    break;
            }
            // Comme tu peux le voir j'ai manqué de temps. Tout ce que je peux dire c'est que je ferais mieux la prochaine fois //
        }
    }
}
