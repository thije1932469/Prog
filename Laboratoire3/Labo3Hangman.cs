using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hangman
{
    class Program
    {

       
        static void Main(string[] args)
        {
             Console.WriteLine("Bienvenue au jeu du bonhomme pendu.");
            Console.WriteLine("Pour les espaces, veuillez ecrire _");
            // Console.WriteLine("Saisir un mot: ");
            //string motcacher = Console.ReadLine();

            //motcacher = motcacher.ToUpper();

            Console.Clear();

             string[] tabMot= { "anticonstitutionnellement", "doomdoom", "vincentpourquoituneveuxpasquejeprendsvincounet", "sendhelp", "jedetestematis", "jazz", "HeilHitler", "SiegHeil", "chat", "arbre", "gfaim", " idontcareiloveit",};
         
            Random GenerateurNb = new Random();
            int motcacher = GenerateurNb.Next(tabMot.Length);
            string motCacher = tabMot[motcacher];

           // string motCacher = Console.ReadLine();
            motCacher = motCacher.ToUpper();
            int cpt = -1;
            int vies = 3;
            int Total = 0;
                 int longueurmot = motCacher.Length;
               char[] TabMotCacher = motCacher.ToCharArray();           
            char[] LettreTrouver = new char[26];          
            bool QuiPerdGagne = false;
            char[] yeet = new char[longueurmot];

            foreach (char letter in yeet)
            {
                cpt++;
                yeet[cpt] = '-';
            }

            while (vies > 0)
            {
                cpt = -1;
                bool LettresTrouver = false;
                string ZoneduMot = String.Concat(yeet);               
                    int Gfaim = 0;

                    if (ZoneduMot == motCacher)
                    {
                    QuiPerdGagne = true;
                    break;
                    }

                if (vies > 1)
                {
                    Console.WriteLine("Il te reste {0} vies", vies);
                }
                    else
                    {
                    Console.WriteLine("Il te reste juste {0} vies", vies);
                    }


                Console.WriteLine("Mot a trouver : " + ZoneduMot);
                Console.Write("\n\n\n");
                Console.Write("Deviner une lettre: ");
                string choixjoueur = Console.ReadLine();

               
                bool unelettreparfois = choixjoueur.All(Char.IsLetter);

                 while (unelettreparfois == false || choixjoueur.Length != 1)
                {
                    Console.WriteLine("Une lettre a la fois maudit tricheur");
                    Console.Write("Devine UNE lettre : ");
                    choixjoueur = Console.ReadLine();
                    unelettreparfois = choixjoueur.All(Char.IsLetter);
                }

                choixjoueur = choixjoueur.ToUpper();
                char lettredujoueur = Convert.ToChar(choixjoueur);

                if (LettreTrouver.Contains(lettredujoueur) == false)
                {

                    LettreTrouver[Total] = lettredujoueur;
                    Total++;

                    foreach (char letter in TabMotCacher)
                    {
                        cpt++;
                        if (letter == lettredujoueur)
                        {
                            yeet[cpt] = lettredujoueur;
                            LettresTrouver = true;
                            Gfaim++;
                        }

                    }

                    if (LettresTrouver)
                    {
                        Console.WriteLine("Il y a {0} lettre {1}", Gfaim, lettredujoueur);
                    }
                    else
                    {
                        Console.WriteLine("Il n'y a aucune lettre {0}",lettredujoueur);
                        vies--;
                    }
                    
                }
                else
                {
                    Console.WriteLine("Tu as deja utiliser la lettre {0}", lettredujoueur);
                }


            }


            if (QuiPerdGagne == true)
            {
                Console.WriteLine("\n\n Le mot etait : {0}", motCacher);
                Console.WriteLine("\n\n Bravo, tu as gagner");
            }
            else
            {
                Console.WriteLine("\n\n Le mot etait : {0}", motCacher);
                Console.WriteLine("\n\n Bon bah ta perdu.");
            }

        }
    }
    }

