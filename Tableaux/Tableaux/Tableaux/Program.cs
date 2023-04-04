using System;

namespace Tableaux
{
    class Program
    {
        static void Main(string[] args)
        {
            string restartMatch = "";
            int choixTableau = 0;
            do
            {
                Console.WriteLine("             ");
                Console.WriteLine("             ");
                Console.WriteLine("                                             ---------------------------------------");
                Console.WriteLine("                                             Bienvenue dans la foire aux tableaux!!!");
                Console.WriteLine("                                             ---------------------------------------");
                Console.WriteLine("             ");
                Console.WriteLine("Choissisez le programme de tableaux que vous voulez parmi ceux-ci : ");
                Console.WriteLine("-Création aléatoire (1): une fonction qui crée une chaine de caractères contenant le les valeurs contenues dans un tableau d'entiers séparées par un espace.");
                Console.WriteLine("-Mélange de tableaux (2): une petite procédure qui crée un nouveau tableau.  Celui-ci devra contenir tous les éléments des deux tableaux en les alternant, de telle manière que chaque nom de mois soit suivi du nombre de jours correspondant : {Janvier, 31, FévrieR 28, Mars, 31, etc.…}.");
                Console.WriteLine("-Chaine de caractères (3): une fonction qui va renvoyer un tableau contenant un ensemble d'entiers générés aléatoirement. ");
                Console.WriteLine("-Pairs/Impairs (4): un morceau de programme qui analyse un par un tous les éléments d'un tableau de 20 entiers strictement positifs pré-rempli, pour remplir deux autres tableaux de même dimension. L'un contiendra seulement les nombres pairs du tableau initial, et l'autre les nombres impairs.");
                Console.WriteLine("-Fibonnaci (5): une fonction qui permet de sortir un tableau reprenant n termes de la suite (n étant fourni au départ). On suppose que l'utilisateur veut au moins deux éléments de la suite.");
                Console.WriteLine("-Décalage (6): une fonction qui range les occurrences d'une valeur indésirable à la fin d'un tableau d'entiers donné. ");
                string choixTableau_;

                do
                {
                    Console.WriteLine(" Choissisez le chiffre qui correspond à votre tableau :");
                    choixTableau_ = Console.ReadLine();
                } while (!int.TryParse(choixTableau_, out choixTableau));

                switch (choixTableau)
                {
                    case 1:
                        {
                            int[] tableau;
                            Aleatoire(10, 0, 100, out tableau);
                            string resultat;
                            Caractere(tableau, out resultat);
                            Console.WriteLine("Voici les résultats :" + resultat);
                            break;
                        }
                    case 2:
                        {
                            string[] tMois = new string[] { "Janvier", "Février", "Mars", "Avril", "Mai", "Juin", "Juillet", "Août", "Septembre", "Octobre", "Novembre", "Décembre" };
                            int[] tJours = new int[] {31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
                            string[] tMixed;
                            Melange(tMois, tJours, out tMixed);
                            Console.WriteLine("Voici le tableau de mélange :" + tMixed);
                        }   break;
                    case 3:
                        {
                            int[] tableau;
                            Aleatoire(10, 0, 100, out tableau);
                            string resultat;
                            Caractere(tableau, out resultat);
                            Console.WriteLine("Voici les résultats :" + resultat);
                        } break;
                    case 4:
                        {
                            int[] tableau = new int[] { 12, 13, 7, 8, 11, 7, 12, 9 };
                            int[] pair;
                            int[] impaire;
                            pairImpairs(tableau,out pair, out impaire);
                            Console.WriteLine("Voici les tableaux :" + impaire + pair);
                        }
                        break;
                    case 5:
                        {
                            int nbr = 0;
                            int[] T;
                            Fibonnaci(nbr ,out T);
                            Console.WriteLine("Voici le tableau Fibonnaci:" + T);
                        }
                        break;
                    case 6:
                        {
                            int V = 0;
                            int[] T = new int [0];
                            Decaler(V ,T);
                            Console.WriteLine("Voici le tableau de décalage:" + T);
                        }
                        break;
                    default:
                        Console.WriteLine("Cette option n'est pas disponible -_-");
                    break;
                   
                }
                Console.WriteLine("Voulez-vous recommencer une partie ? OUI ou NON ?");
                restartMatch = Console.ReadLine();
            } while (restartMatch != "NON");
            
        }
        static void pairImpairs(int[]tableau, out int[]pair, out int[]impaire)
        {
            int ii = 0;
            int ip = 0;
            impaire = new int[ip];
            pair = new int[ii];
            for (int i = 0; i < 19; i++)
            {
                if (tableau[i] % 2 == 0)
                {
                    pair[ip] = tableau[i];
                    ip = ip + 1;
                }
                else
                {
                    impaire[ii] = tableau[i];
                    ii = ii + 1;
                }
                while (ip < 20)
                {
                    pair[ip] = 0;
                    ip = ip + 1;
                }
                while (ip < 20)
                {
                    impaire[ii] = 0;
                    ii = ii + 1;
                }
            }
        }
        static void Aleatoire(int number, int intervallemin, int intervallemax, out int[]tableau)
        {
            Random alea = new Random();
            tableau = new int[number];
            for (int i = 0; i < number ; i++)
            {
                tableau[i] = alea.Next(intervallemin, intervallemax - 1);
            }
        }
        static void Melange(string[] tMois, int[] tJours, out string[] tMixed)
        {
            int compteurJ = 0;
            tMixed = new string[23];
            for (int i = 0; i < 23; i++)
            {
                tMixed[i] = tMois[compteurJ];
                tMixed[i + 1] = tJours[compteurJ].ToString();
                compteurJ = compteurJ + 1;
            }
        }
        static void Caractere(int[]tabEntier, out string chaineCaract)
        {
            int nbrCase = tabEntier.Length;
            chaineCaract = " ";
            for (int i = 0; i < nbrCase; i++)
            {
                chaineCaract = chaineCaract + tabEntier[i];
                chaineCaract = chaineCaract + "";
            }
        }
        static void Decaler(int V, int[] T)
        {
            int nbOcc = 0;
            for (int i = 0; i < T.Length; i++)
            {
                if (T[i] == V)
                {
                    nbOcc = nbOcc + 1;
                }
                else
                {
                    T[i - nbOcc] = T[i];
                }
            }
            for (int i = T.Length - nbOcc; i < T.Length; i++)
            {
                T[i] = V;
            }
        }
        static void Fibonnaci( int nbr, out int[] T)
        {
            T = new int[nbr];
            T[0] = 1;
            T[1] = 1;
            for (int i = 2; i < nbr - 1 ; i++)
            {
                T[i] = T[i - 1] + T[i - 2];
            }

        }
    }
}
