using System;

namespace Matrices
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        static void GenerationAleatoire(int numberligne, int numbercolonne, out int[,]Generation)
        {
            Generation = new int[ numberligne,  numbercolonne];
            Random reponse = new Random() ;
            for (int i = 0; i <= numberligne -1 ; i++)
            {
                for (int j = 0; j < numbercolonne - 1; j++)
                {
                    Generation[i, j] = reponse.Next(0, 20);
                }
            }
           
            
        }
        static void Addition(int[,] tab1,int[,]tab2, out bool reponse, out int[,] tabResultat)
        {
            reponse = true;
            tabResultat = new int[tab1.GetLength(0), tab2.GetLength(1)];
            if (tab1.GetLength(0) != tab2.GetLength(0) || tab1.GetLength(1) != tab2.GetLength(1))
            {
                reponse = false;
            }
            else
            {
                for (int C = 0; C <= tab1.GetLength(0)-1; C++)
                {
                    for (int L = 0; L <= tab2.GetLength(1) -1; L++)
                    {
                        tabResultat[L, C] = tab1[L, C] + tab2[L, C];
                    }
                }
            }

        }

        static void Multiplication(int[,]tab1, int[,]tab2, out bool reponse, out int[,]tabResultat)
        {
            reponse = true;
            tabResultat = new int[tab1.GetLength(0), tab2.GetLength(1)];
            if (tab1.GetLength(1)==tab2.GetLength(0))
            {
                for (int C = 0; C <= tabResultat.GetLength(0) -1 ; C++)
                {
                    for (int L = 0; L <= tabResultat.GetLength(1) -1; L++)
                    {
                        for (int k = 0; k <= tab2.GetLength(0); k++)
                        {
                            tabResultat[L, C] = tab1[ C, k] * tab2[k, L];
                        }
                    }
                }
            }
            else
            {
                reponse = false;
            }

             
        }
        static void Concatenation (int[,]Generation ,int numberligne, int numbercolonne, out string chaine)
        {
            chaine = "";
            for (int i= 0; i <= numberligne -1; i++)
            {
                for (int j = 0; j <= numbercolonne; j++)
                {
                    chaine = chaine + Generation[i, j] + ",";
                }
                chaine = chaine + "\n";
            }
        }
    }
}
