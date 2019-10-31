using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeJeuDu31
{
    public enum Sorte { Coeur = 1, Pique = 2, Carreau = 3, Trefle = 4 };
    class Program
    {

        static Random generateur = new Random();
        public static int genererNB(int min, int max)
        {
            return (int)generateur.Next(min, max);
        }
        public struct Carte
        {
            public Sorte sorte;
            public int valeur;
            public Carte(Sorte _sorte, int _valeur) : this()
            {
                sorte = _sorte;
                valeur = _valeur;
            }
        }
        public struct Joueur
        {
            public Carte[] tabCarte;
            public int nbVie;
            public Joueur(int _nbVie) : this()
            {
                tabCarte = new Carte[3];
                tabCarte[0] = new Carte((Sorte)genererNB(1, 5), genererNB(1, 14));
                tabCarte[1] = new Carte((Sorte)genererNB(1, 5), genererNB(1, 14));
                tabCarte[2] = new Carte((Sorte)genererNB(1, 5), genererNB(1, 14));
                nbVie = _nbVie;
            }
        }

        static void AfficherCarte(int valeur, Sorte sorte)
        {

            switch (valeur)
            {
                case 1: Console.Write("As"); break;
                case 2: Console.Write(valeur.ToString()); break;
                case 3: Console.Write(valeur.ToString()); break;
                case 4: Console.Write(valeur.ToString()); break;
                case 5: Console.Write(valeur.ToString()); break;
                case 6: Console.Write(valeur.ToString()); break;
                case 7: Console.Write(valeur.ToString()); break;
                case 8: Console.Write(valeur.ToString()); break;
                case 9: Console.Write(valeur.ToString()); break;
                case 10: Console.Write(valeur.ToString()); break;
                case 11: Console.Write("Valet"); break;
                case 12: Console.Write("Dame"); break;
                case 13: Console.Write("Roi"); break;


            }
        }

        static void Options()
        {
            int options = 0;
            Console.WriteLine("Que voulez-vous faire?");
            Console.WriteLine("");
            Console.WriteLine("1- Prendre une nouvelle carte et se débarrasser d’une de ses 3 cartes");
            Console.WriteLine("");
            Console.WriteLine("2- Prendre la carte retournée et se débarrasser d’une de ses 3 cartes");
            Console.WriteLine("");
            Console.WriteLine("3- Aviser les joueurs que c’est le dernier tour. ( il faut avoir plus de 21  pour  réaliser  cette  étape  ).  Alors,  chaque  joueur  à  un dernier tour pour essayer d’augmenter son score");
            options = Convert.ToInt32(Console.ReadLine());
        }
        static void Jetezcarte(ref Joueur joueur, int valeurCarte, Sorte sorteCarte, Joueur joueur1)
        {
            int jetezcarte = 0;
            Console.WriteLine("Quelle carte voulez-vous jetez?");
            Console.WriteLine("0- Celle de gauche");
            Console.WriteLine("1- Celle du centre");
            Console.WriteLine("2- Celle de droite");
            valeurCarte = genererNB(1, 14); sorteCarte = (Sorte)genererNB(1, 5);
            jetezcarte = Convert.ToInt32(Console.ReadLine());
            joueur1.tabCarte[jetezcarte].valeur = valeurCarte; joueur1.tabCarte[jetezcarte].sorte = sorteCarte;

        }
        static void Pile(ref Joueur joueur, int valeurCarte, Sorte sorteCarte, Joueur joueur1)
        {
            int Pile = 0;
            Console.WriteLine("Quelle carte voulez-vous remplacer?");
            Console.WriteLine("0- Celle de gauche");
            Console.WriteLine("1- Celle du centre");
            Console.WriteLine("2- Celle de droite");

            Pile = Convert.ToInt32(Console.ReadLine());
            joueur1.tabCarte[Pile].valeur = valeurCarte; joueur1.tabCarte[Pile].sorte = sorteCarte;

        }
        static void Cogner(int total, ref bool cogner)
        {

            if (total > 21)
            {
                Console.WriteLine("Le joueur a cogné, c'est donc le dernier tour pour tous les joueurs.");
                cogner = true;
            }
            else if (total < 21)
            {
                Console.WriteLine("Vous ne pouvez pas cogner, votre total est en bas de 21.");

            }
        }

        static void TourOrdi(ref bool TourOrdi)
        {
            Console.WriteLine("C'est le tour de l'ordinateur fffffffff");
        }

        static void Main(string[] args)
        {
            bool TourOrdi = false;
            bool Tourjoueur = true;
            int total = 0;
            int totalOrdi = 0;
            int NbtourRestant = 1;
            bool finManche = false;
            bool lastTurn = false;
            bool CognerOrdi = false;
            int options = 0;
            int nbJoueur = 0;
            bool cogner = false;
            Joueur joueur1 = new Joueur(3);
            Joueur ordi = new Joueur(3);
            int valeurCarte = genererNB(1, 14);
            Sorte sorteCarte = (Sorte)genererNB(1, 5);

            Console.WriteLine("Bienvenue au jeu du 31");
            Console.Clear();
            Console.WriteLine("Vous allez jouer contre l'odinateur. Bonne chance!");

            while (finManche == false)
            {
                if (cogner == false)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Voici vos cartes : " + joueur1.tabCarte[0].valeur + " - " + joueur1.tabCarte[0].sorte + " / " + joueur1.tabCarte[1].valeur + " - " + joueur1.tabCarte[1].sorte + " / " + joueur1.tabCarte[2].valeur + " - " + joueur1.tabCarte[2].sorte);
                    Console.WriteLine("");
                    total = joueur1.tabCarte[0].valeur + joueur1.tabCarte[1].valeur + joueur1.tabCarte[2].valeur;
                    Console.WriteLine("Votre total est de : " + total);
                    Console.WriteLine("");
                    Console.WriteLine("Voici la carte de la pile : " + valeurCarte + " - " + sorteCarte);
                    Console.WriteLine("");
                    Console.WriteLine("Que voulez-vous faire?");
                    Console.WriteLine("");
                    Console.WriteLine("1- Prendre une nouvelle carte et se débarrasser d’une de ses 3 cartes");
                    Console.WriteLine("");
                    Console.WriteLine("2- Prendre la carte retournée et se débarrasser d’une de ses 3 cartes");
                    Console.WriteLine("");
                    Console.WriteLine("3- Aviser les joueurs que c’est le dernier tour. ( il faut avoir plus de 21  pour  réaliser  cette  étape  ).  Alors,  chaque  joueur  à  un dernier tour pour essayer d’augmenter son score");
                    options = Convert.ToInt32(Console.ReadLine());

                    switch (options)
                    {
                        case 1:
                            Console.Clear();

                            Jetezcarte(ref joueur1, valeurCarte, sorteCarte, joueur1);
                            Console.WriteLine("Voici vos cartes : " + joueur1.tabCarte[0].valeur + " - " + joueur1.tabCarte[0].sorte + " / " + joueur1.tabCarte[1].valeur + " - " + joueur1.tabCarte[1].sorte + " / " + joueur1.tabCarte[2].valeur + " - " + joueur1.tabCarte[2].sorte);
                            total = joueur1.tabCarte[0].valeur + joueur1.tabCarte[1].valeur + joueur1.tabCarte[2].valeur;
                            Console.WriteLine("");
                            Console.WriteLine("Votre total est de : " + total);
                            Tourjoueur = false;
                            TourOrdi = true;
                            break;
                        case 2:
                            Console.Clear();
                            Pile(ref joueur1, valeurCarte, sorteCarte, joueur1);
                            Console.WriteLine("Voici vos cartes : " + joueur1.tabCarte[0].valeur + " - " + joueur1.tabCarte[0].sorte + " / " + valeurCarte + " - " + sorteCarte + " / " + joueur1.tabCarte[2].valeur + " - " + joueur1.tabCarte[2].sorte);
                            total = joueur1.tabCarte[0].valeur + valeurCarte + joueur1.tabCarte[2].valeur;
                            Console.WriteLine("");
                            Console.WriteLine("Votre total est de : " + total);
                            Tourjoueur = false;
                            TourOrdi = true;
                            break;
                        case 3:
                            Cogner(total, ref cogner);
                            TourOrdi = true;
                            break;
                    }
                }



                //tour ordi

                Console.WriteLine("C est le tour de l ordinateur");
                totalOrdi = ordi.tabCarte[0].valeur + ordi.tabCarte[1].valeur + ordi.tabCarte[2].valeur;
                Console.ReadKey();

                if (CognerOrdi == true || lastTurn == true)
                {
                    if (total > 31)
                    {
                        Console.WriteLine("Vous avez dépasser 31. Vous avez perdu.");
                        finManche = true;
                    }
                    else if (totalOrdi > 31)
                    {
                        Console.WriteLine("Lordinateur a dépassé 31. Vous avez gagner.");
                        finManche = true;
                    }

                    else if (totalOrdi < total)
                    {
                        Console.WriteLine("Bravo! Vous gagnez. ladversaire a un total de : " + totalOrdi);
                        finManche = true;
                    }
                    else if (totalOrdi > total)
                    {
                        Console.WriteLine("Oh non! Vous avez perdu... l'ordinateur a un total de : " + totalOrdi);
                        finManche = true;
                    }
                }
                else if (lastTurn == false)
                {
                    if (totalOrdi > 21)
                    {
                        Cogner(totalOrdi, ref CognerOrdi);
                    }
                    else if (totalOrdi < 21)
                    {
                        Console.WriteLine("l'ordinateur change de carte...");
                        if (ordi.tabCarte[0].valeur < ordi.tabCarte[1].valeur)
                        {
                            ordi.tabCarte[0].valeur = valeurCarte;
                            if (cogner == true)
                                lastTurn = true;
                        }
                    }
                }
            }
            Environment.Exit(0);
        }
    }
}

