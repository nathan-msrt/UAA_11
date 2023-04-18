using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_Matrices
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] tab1;
            int[,] tab2;
            int[,] tab3;
            bool resultat;
            int numbercolonne;
            int numberligne;
            string chaine;
            string choix;
            string restartMatch = "";
            Traitement MesOutils = new Traitement();

            do
            {
                Console.WriteLine("                                             Bienvenue dans le calcul de Matrices!!!");
                Console.WriteLine("                                             ---------------------------------------");
                Console.WriteLine("             ");

                Console.WriteLine("Menu : " +

                "\n    1. Addition de matrice" +
                "\n    2. Multiplication de matrice");
                choix = Console.ReadLine();
                do
                {
                    
                    if (choix == "1")
                    {
                        Console.WriteLine("Entrez les valeurs de la première matrice");
                        MesOutils.LectureR("Nombre de ligne : ", out numberligne);
                        MesOutils.LectureR("Nombre de colonne : ", out numbercolonne);
                        MesOutils.AleatoireM(out tab1, numberligne, numbercolonne);
                        Console.WriteLine("Entrez les valeurs de la deuxième matrice");
                        MesOutils.LectureR("Nombre de ligne : ", out numberligne);
                        MesOutils.LectureR("Nombre de colonne : ", out numbercolonne);
                        MesOutils.AleatoireM(out tab2, numberligne, numbercolonne);
                        MesOutils.AdditionM(tab1, tab2, out tab3, out resultat);
                        MesOutils.ConcatenationM(tab1, out chaine);
                        Console.WriteLine(chaine);
                        Console.WriteLine("=========================");
                        MesOutils.ConcatenationM(tab2, out chaine);
                        Console.WriteLine(chaine);
                        Console.WriteLine("=========================");
                        MesOutils.ConcatenationM(tab3, out chaine);
                        Console.WriteLine(chaine);
                    }
                    if (choix == "2")
                    {
                        Console.WriteLine("Entrez les valeurs de la première matrice");
                        MesOutils.LectureR("Nombre de ligne : ", out numberligne);
                        MesOutils.LectureR("Nombre de colonne : ", out numbercolonne);
                        MesOutils.AleatoireM(out tab1, numberligne, numbercolonne);
                        Console.WriteLine("Entrez les valeurs de la deuxième matrice");
                        MesOutils.LectureR("Nombre de ligne : ", out numberligne);
                        MesOutils.LectureR("Nombre de colonne : ", out numbercolonne);
                        MesOutils.AleatoireM(out tab2, numberligne, numbercolonne);
                        MesOutils.MultiplicationM(tab1, tab2, out tab3, out resultat);
                        MesOutils.ConcatenationM(tab1, out chaine);
                        Console.WriteLine(chaine);
                        Console.WriteLine("=========================");
                        MesOutils.ConcatenationM(tab2, out chaine);
                        Console.WriteLine(chaine);
                        Console.WriteLine("=========================");
                        MesOutils.ConcatenationM(tab3, out chaine);
                        Console.WriteLine(chaine);
                    }

                } while (true);
                Console.WriteLine("Voulez-vous recommencer une partie ? OUI ou NON ?");
                restartMatch = Console.ReadLine();
            } while (restartMatch != "NON");
        }
    }
}
