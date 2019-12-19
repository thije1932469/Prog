using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examPratique2Revision
{
    class Program
    {

        public struct Métaux
        {
            public string nom;
            public int résistance;
            public int pointFusion;
            public int poid;
            public int conduc;
            public int cote;

            public Métaux(string _nom, int _résistance, int _pointFusion, int _poid, int _conduc, int _cote) : this()
            {
                nom = _nom;
                résistance = _résistance;
                pointFusion = _pointFusion;
                poid = _poid;
                conduc = _conduc;
                cote = _cote;
               

            }
        }


        static void AffichageMenu()
        {
           
            
                Console.WriteLine("\nVeuillez choisir l’une des options suivantes\n" +
                "\n 1 - Faire afficher la liste des métaux\n" +
                "\n 2 - Trouver le métal avec la pire résistance\n" +
                "\n 3 - Savoir si un métal avec un point de fusion supérieur de plus de 8 existe\n" +
                "\n 4 - Connaître  le  métal  avec  le  meilleur  score  (moyenne  de tous les cotes, doit être le plus près de 5\n" +
                "\n 5 - Créer un nouvel alliagen\n" +
                "\n 6 - Quitter le programme\n");
            
        }


        static void AfficherMétaux(Métaux[] tabMétaux)
            
        {
            for (int i = 0; i < tabMétaux.Length; i++)
            {
                Console.WriteLine("\n\nNom : " + tabMétaux[i].nom + "\n \n résistance : " + tabMétaux[i].résistance + "\n\n pointFusion : " + tabMétaux[i].pointFusion + "\n\n poid : " + tabMétaux[i].poid + "\n\n conduc : " + tabMétaux[i].conduc);
            }
        }

        static void AfficherPireResis(ref Métaux[] tabMétaux)
        {
            int pireResis = 100000;
            int pos = 0;
            for (int i = 0; i < tabMétaux.Length; i++)
            {
                if (tabMétaux[i].résistance < pireResis)
                {
                    pireResis = tabMétaux[i].résistance;
                    pos = i;
                }
            }
            Console.WriteLine("Le nétal ayant la pire est le # "
                + (pos + 1) + " ayant une cote de " + pireResis);
        }

        static bool VerifierPointFusionExiste(Métaux[] tabMétaux)
        {
            bool MétalExiste = false;
            int cpt = 0;
            while (MétalExiste == false && cpt < tabMétaux.Length)
            {
                if (tabMétaux[cpt].pointFusion > 8)
                {
                    MétalExiste = true;

                }
                else
                    cpt++;

            }
            if (MétalExiste == true)
            {
                Console.WriteLine("Il existe un métal avec un point de fusion plus grand que 8");
            }
            else
            {
                Console.WriteLine("Il n'existe pas un métal avec un point de fusion plus grand que 8");
            }
            return MétalExiste;
        }

        static void AfficherMeilleurMoy(ref Métaux[] tabMétaux)
        {

            int Moy = 0; 
            int position = 0;
            for (int i = 0; i < tabMétaux.Length; i++)
            {
                Moy = (tabMétaux[i].résistance + tabMétaux[i].pointFusion + tabMétaux[i].poid + tabMétaux[i].conduc)/4;
                if ((tabMétaux[i].résistance + tabMétaux[i].pointFusion + tabMétaux[i].poid + tabMétaux[i].conduc > 5))
                {
                    Moy = tabMétaux[i].cote;
                    position = i;
                }
            }
            Console.WriteLine("Le métal ayant la meilleur cote est le # "
               + (position + 1) + " ayant une cote de " + Moy);
        }
        static void CreerAlliage(ref Métaux[] tabMétaux)
        {

            int metal1 = 0;
            int metal2 = 0;
            int pourcentage1 = 0;
            int pourcentage2 = 0;
            Console.WriteLine("\nVeuillez choisir 2 métaux.");
            Console.WriteLine("\nChoisir le premier metal :");
            Console.WriteLine("\n1- Fer");
            Console.WriteLine("\n2- Cuivre");
            Console.WriteLine("\n3- Plomb");
            Console.WriteLine("\n4- Zinc");

            metal1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nQuel est le pourcentage? :");
            pourcentage1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Choisir le deuxieme metal :\n");
            Console.WriteLine("\n1- Fer");
            Console.WriteLine("\n2- Cuivre");
            Console.WriteLine("\n3- Plomb");
            Console.WriteLine("\n4- Zinc");
            metal2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nQuel est le pourcentage? :");
            pourcentage2 = Convert.ToInt32(Console.ReadLine());

            //if (tabMétaux[metal1] = 1 )
            //  { 

            // }
            
            if (metal1 == 1 && metal2 == 2)
            {
               tabMétaux[4].résistance = tabMétaux[0].résistance * (pourcentage1 / 100) + tabMétaux[1].résistance * (pourcentage2 / 100);

                if (pourcentage1 > pourcentage2)
                {
                    Console.WriteLine("Fer" + tabMétaux[1].nom);
                    Console.WriteLine("\n Résistance du nouvel alliage : " + tabMétaux[4].résistance);
                }
                else
                {
                    Console.WriteLine("Cuivre" + tabMétaux[0].nom);
                    Console.WriteLine("\n Résistance du nouvel alliage : " + tabMétaux[4].résistance);
                }
            }
            if (metal1 == 1 && metal2 == 3)
            {
                tabMétaux[4].résistance = tabMétaux[0].résistance * (pourcentage1 / 100) + tabMétaux[2].résistance * (pourcentage2 / 100);

                if (pourcentage1 > pourcentage2)
                {
                    Console.WriteLine("Fer" + tabMétaux[0].nom);
                    Console.WriteLine("\n Résistance du nouvel alliage : " + tabMétaux[4].résistance);
                }
                else
                {
                    Console.WriteLine("Plomb" + tabMétaux[2].nom);
                    Console.WriteLine("\n Résistance du nouvel alliage : " + tabMétaux[4].résistance);
                }
            }
            if (metal1 == 1 && metal2 == 4)
            {
                tabMétaux[4].résistance = tabMétaux[0].résistance * (pourcentage1 / 100) + tabMétaux[3].résistance * (pourcentage2 / 100);

                if (pourcentage1 > pourcentage2)
                {
                    Console.WriteLine("Fer" + tabMétaux[0].nom);
                    Console.WriteLine("\n Résistance du nouvel alliage : " + tabMétaux[4].résistance);
                }
                else
                {
                    Console.WriteLine("Zinc" + tabMétaux[3].nom);
                    Console.WriteLine("\n Résistance du nouvel alliage : " + tabMétaux[4].résistance);
                }
            }
            

           
        }

        static void Main(string[] args)
        {
            int choix = 0;
            Métaux[] tabMétaux = new Métaux[5];
            tabMétaux[0] = new Métaux("Fer", 7, 9, 4, 3, 0);
            tabMétaux[1] = new Métaux("Cuivre", 4, 8, 8, 2, 0);
            tabMétaux[2] = new Métaux("Plomb", 1, 3, 7, 2, 0);
            tabMétaux[3] = new Métaux("Zinc", 2, 5, 3, 6, 0);
            tabMétaux[4] = new Métaux("", 0, 0, 0, 0, 0);


            AffichageMenu();

            choix = Convert.ToInt32(Console.ReadLine());


            switch (choix)
            {
                case 1: AfficherMétaux(tabMétaux); break;
                case 2: AfficherPireResis(ref tabMétaux); break;
                case 3: VerifierPointFusionExiste(tabMétaux); break;
                case 4: AfficherMeilleurMoy(ref tabMétaux); break;
                case 5: CreerAlliage(ref tabMétaux); break;
                case 6: Environment.Exit(-1); break;
            }
        }
    }
}
