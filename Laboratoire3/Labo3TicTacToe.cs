using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Program

    {

        

        static char[] Tab = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        static int Joueur = 1;
        static int Choix;

       
        static int yeet = 0;
        // Pour pas que le programme crash
        static void SasieChoix(ref int Choix)
        {
            try
            {
                Choix = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                SasieChoix(ref Choix);
            }
        }

        static void Grille()
        // Jsp pourquoi mais la grille est croche des fois
        {
            //int y = 20;
            //Console.SetCursorPosition(20,y);
            Console.WriteLine("     |     |      ");
          //  y++; Console.SetCursorPosition(20, y);
            Console.WriteLine("  {0}  |  {1}  |  {2}", Tab[1], Tab[2], Tab[3]);

            Console.WriteLine("_____|_____|_____ ");

            Console.WriteLine("     |     |      ");

            Console.WriteLine("  {0}  |  {1}  |  {2}", Tab[4], Tab[5], Tab[6]);

            Console.WriteLine("_____|_____|_____ ");

            Console.WriteLine("     |     |      ");

            Console.WriteLine("  {0}  |  {1}  |  {2}", Tab[7], Tab[8], Tab[9]);

            Console.WriteLine("     |     |      ");

        }

       

        static void Main(string[] args)

        {
            int ModeDeJeu = 0;
            // do c comme while mais c sur qui va le faire au moins une fois
            bool TourOrdi = false;
            Console.WriteLine("Mode joueur vs joueur ou joueur vs ordi?");
            Console.WriteLine("1- Joueur vs Joueur");
            Console.WriteLine("2- Joueur vs Skynet"); //faire boucle while tant quil y a espace libre prend random
            ModeDeJeu = Convert.ToInt32(Console.ReadLine());

            if (ModeDeJeu == 2)
            {
                TourOrdi = true;
            }
           

            while (TourOrdi == true)
            {
                Random GenerateurNb = new Random();
                int rand = GenerateurNb.Next(Tab.Length);

                // Console.WriteLine("Skynet is blocking your access to this game mode. T-8000s are inbound to your position. Serieusement je nai pas ete capable de faire l'ordinateur");

               // if ( == "{O}")
                

                
            }

            do
            {
               

               Console.Clear();
                Console.WriteLine("Joueur 1 : X et Joueur 2 : O");
                Console.WriteLine("\n");
                if (Joueur % 2 == 0)  

                {
                    Console.WriteLine("Tour du joueur 2");
                }
                else

                {
                    Console.WriteLine("Tour du joueur 1");
                }

                Console.WriteLine("\n");


                Grille();
                SasieChoix(ref Choix);             

                if (Tab[Choix] != 'X' && Tab[Choix] != 'O')

                {

                    if (Joueur % 2 == 0)

                    {
                        Tab[Choix] = 'O';
                        Joueur++;
                    }
                    else
                    {
                        Tab[Choix] = 'X';
                        Joueur++;
                    }
                }
                else  
                {
                    Console.WriteLine("La ligne {0} est deja marquer avec {1}", Choix, Tab[Choix]);
                    Console.WriteLine("\n");                                     
                }

                yeet = TuGagnesTu();  

            } while (yeet != 1 && yeet != -1);
            Console.Clear();
            Grille(); 

            if (yeet == 1) 

            {
                Console.WriteLine("Joueur {0} a gagner", (Joueur % 2) + 1);


            }
            else 
            {

                Console.WriteLine("Match nul");
            }
            Console.ReadLine();
        }

         

       
   

        static int TuGagnesTu()

        {           

            if (Tab[1] == Tab[2] && Tab[2] == Tab[3])
            {

                return 1;
            }   

            else if (Tab[4] == Tab[5] && Tab[5] == Tab[6])
            {
                return 1;
            }           
            else if (Tab[6] == Tab[7] && Tab[7] == Tab[8])
            {
                return 1;
            }
            else if (Tab[1] == Tab[4] && Tab[4] == Tab[7])

            {
                return 1;
            }
            else if (Tab[2] == Tab[5] && Tab[5] == Tab[8])
            {
                return 1;
            }
            else if (Tab[3] == Tab[6] && Tab[6] == Tab[9])
            {
                return 1;
            }
            else if (Tab[1] == Tab[5] && Tab[5] == Tab[9])
            {
                return 1;
            }
            else if (Tab[3] == Tab[5] && Tab[5] == Tab[7])
            {
                return 1;
            }
            // match nul
            else if (Tab[1] != '1' && Tab[2] != '2' && Tab[3] != '3' && Tab[4] != '4' && Tab[5] != '5' && Tab[6] != '6' && Tab[7] != '7' && Tab[8] != '8' && Tab[9] != '9')
            {
                return -1;
            }
            else
            {
                return 0;
            }

        }

    }

}  
