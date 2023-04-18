using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_Matrices
{
    public struct Traitement
    {
        public void AleatoireM(out int[,] T, int numberligne, int numbercolonne)
        {
            Random alea = new Random();
            T = new int[numberligne, numbercolonne];
            for (int i = 0; i < numberligne; i++)
            {
                for (int j = 0; j < numbercolonne; j++)
                {
                    T[i, j] = alea.Next(0, 20);
                }
            }
        }
        public void ConcatenationM(int[,] T, out string chaine)
        {
            chaine = "";
            for (int i = 0; i < T.GetLength(0); i++)
            {
                for (int j = 0; j < T.GetLength(1); j++)
                {
                    chaine += T[i, j] + ", ";
                }
                chaine += "\n";
            }
        }
        public void AdditionM(int[,] tab1, int[,] tab2, out int[,] tab3, out bool resultat)
        {
            tab3 = new int[tab1.GetLength(0), tab2.GetLength(0)];
            if (tab1.GetLength(0) == tab2.GetLength(0) && tab1.GetLength(1) == tab2.GetLength(1))
            {
                for (int i = 0; i < tab1.GetLength(0); i++)
                {
                    for (int j = 0; j < tab2.GetLength(1); j++)
                    {
                        tab3[i, j] = tab1[i, j] + tab2[i, j];
                    }
                }
                resultat = true;
            }
            else
            {
                resultat = false;
            }
        }
        public void MultiplicationM(int[,] tab1, int[,] tab2, out int[,] tablMultiplication, out bool resultat)
        {
            tablMultiplication = new int[tab1.GetLength(0), tab2.GetLength(1)];
            if (tab1.GetLength(1) == tab2.GetLength(0))
            {
                resultat = true;
                for (int i = 0; i < tab1.GetLength(0); i++)
                {
                    for (int j = 0; j < tab2.GetLength(1); j++)
                    {
                        tablMultiplication[i, j] = 0;
                        for (int k = 0; k < tab1.GetLength(1); k++)
                        {
                            tablMultiplication[i, j] += tab1[i, k] * tab2[k, j];
                        }
                    }
                }
            }
            else
            {
                resultat = false;
            }
        }
        public void LectureR(string question, out int n)
        {
            string nUser;
            Console.Write(question);
            nUser = Console.ReadLine();
            while (!int.TryParse(nUser, out n))
            {

                Console.WriteLine("Attention ! Vous devez taper un nombre réel !");
                nUser = Console.ReadLine();
            }
        }
    }
}
