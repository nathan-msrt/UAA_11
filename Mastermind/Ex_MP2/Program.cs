using System;

namespace Ex_MP2
{
    class Program
    {

        static void Main(string[] args)
        {
            string contenuTab;
            int[] TS = new int[4];
            int[] TU = new int [4];
            int compteurBienPlace;
            int compteurMalPlace;
            int compteurTour;
            int [] tabIndice = new int[4];
            string gagner ="";
            string restartMatch = "";


            do
            {
                Console.WriteLine("             ");
                Console.WriteLine("             ");
                Console.WriteLine("                                             --------------------------------");
                Console.WriteLine("                                             Bienvenue dans le mastermind !!!");
                Console.WriteLine("                                             --------------------------------");
                Console.WriteLine("             ");                  
                Console.WriteLine("Voici les règles de ce jeu : vous devrez introduire 4 chiffres parmi les 6 chiffres. \n                             Chaque chiffres représentent une couleur différente. \n                             1 = Bleu \n                             2 = Rouge \n                             3 = Vert \n                             4 = Violet \n                             5 = Orange \n                             6 = Noir");
                Console.WriteLine("             "); 
                Console.WriteLine("Vous avez dix tours maximum pour trouver la serie de 4 chiffres choisis par l'ordinateur.");
                Console.WriteLine("             ");
                compteurTour = 0;
                ColorGenerator(out TS);
                do
                {
                    MP2(out TU);
                    ContenuTab(TU, out contenuTab);
                    Console.WriteLine(contenuTab);
                    MP3(TU, TS, out compteurBienPlace, out tabIndice);
                    Console.WriteLine("Vous avez " + compteurBienPlace + " couleur(s) bien placée(s)");
                    MP4(TU, TS, tabIndice, out compteurMalPlace);
                    Console.WriteLine("Vous avez " + compteurMalPlace + " couleur(s) mal placée(s)");
                    compteurTour++;
                    if (compteurBienPlace == 4)
                    {
                        gagner = "Vous avez gagné !";
                    }
                } while (gagner != "Vous avez gagné !" && compteurTour != 10);
                Console.WriteLine("Voulez-vous recommencer une partie ? OUI ou NON ?");
                restartMatch = Console.ReadLine();
            } while (restartMatch != "NON");
            
        }

        static void ColorGenerator(out int[] T)
        {
            Random alea = new Random ();
            T = new int[4];
            int place;
            place = 0;

            do
            {
                T[place] = alea.Next(1, 7);
                place = place + 1;
            } while (place <4);

        }

        static void MP2(out int[] T)
        {
            T = new int[4];
            for (int i = 0; i <= 3; i++)
            {
                do
                {
                    Console.WriteLine("Encodez votre chiffre !");
                    T[i] = int.Parse(Console.ReadLine());
                } while (T[i] < 1 || T[i] > 6);

            }
        }

        static void ContenuTab (int[] T, out string contenuTab)
        {
            contenuTab = "";
            for (int i = 0; i <= 3; i++)
			{
                contenuTab = contenuTab + T[i] + " ";
			}


        }
        static void MP3(int[] tabCouleursChoisies, int[] tabBonnesReponses, out int compteurBienPlace, out int[]tabIndice)
        {
            compteurBienPlace = 0;
            tabIndice = new int[4];
            for (int i = 0; i <= 3; i++)
            {
                tabIndice[i] = tabBonnesReponses[i];
            }

            for (int i = 0; i <= 3; i++)
            {
                if (tabCouleursChoisies[i] == tabBonnesReponses[i])
                {
                    compteurBienPlace = compteurBienPlace + 1;
                    tabIndice[i] = 0;
                }
            }

        }
        static void MP4(int[] tabCouleursChoisies, int[] tabBonnesReponses, int[] tabIndice, out int compteurMalPlace)
        {
            compteurMalPlace = 0;
            int j;
            bool FT;
            for (int i = 0; i < 3; i++)
            {
                if (tabIndice [i] != 0)
                {
                    j = 0;
                    FT = false;

                    while ( j < 4 && FT == false)
                    {
                        if (tabCouleursChoisies[i] == tabBonnesReponses[j] )
                        {
                            FT = true; 
                        }
                        j = j + 1; 
                    }
                    if (FT == true)
                    {
                        compteurMalPlace = compteurMalPlace + 1;
                        tabIndice[j] = 0;
                    }
                }

            }
        }
    }
}
