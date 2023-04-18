using System;
using System.Collections.Generic;
using System.Text;

namespace IMATP5_MassartNathan
{
    class Class1
    {
        public struct Traitement
        {
            public void Generation(int N, out int[,] MatriceResultat)
            {
                MatriceResultat = new int[N + 1, N + 1];
                for (int j = 0; j < N; j++)
                {
                    for (int i = 0; i < N; i++)
                    {
                        if ([j, i] = [0, i] || [j, i] = [j, i + 1])
                        {
                            [j, i] = 1 + "/n";
                        }
                        else
                        {
                            [j, i] = [j - 1, i - 1] + [j - 1, i];
                        }
                    }
                }
            }

            public void ReponseChaine(int N, int Colonne, int[,] MatriceResultat, out string reponseChaine)
            {
                for (int j = 0; j < N; j++)
                {
                    if ([j] = Colonne)
                    {
                        for (int i = 0; i < Colonne - 1; i++)
                        {
                            reponseChaine =  [j, i] + "a^" + [j, i] + ([j, i] + 1) + "b^0";

                        }
                    }
                    else
                    {
                        [j] +1;
                    }
                }
            }
        }

    }
}
