using System;
using System.Collections.Generic;
using System.Text;

namespace CodeTrisShell
{
    class ProcedureTri
    {
        static void Aleatoire(int number, int intervallemin, int intervallemax, out int[] tableau)
        {
            Random alea = new Random();
            tableau = new int[number];
            for (int i = 0; i < number; i++)
            {
                tableau[i] = alea.Next(intervallemin, intervallemax - 1);
            }
        }
        static void TriBulle(int[] tab)
        {
            int n = tab.Length;
            int passage = 0;
            bool permut;
            int recup;
            do
            {
                permut = false;
                for (int i = 0; i<=n-2 - passage; i++)
                {
                    if (tab[i] > tab[i+1])
                    {
                        recup = tab[i];
                        tab[i] = tab[i + 1];
                        tab[i + 1] = recup;
                        permut = true;
                    }
                    passage = passage + 1;
                }
            } while (permut == true);
        }
        static void TriInsertion(int[] tab)
        {
            int n = tab.Length;
            int x;
            bool bpp;
            int i;
            for (int j = 1; j < n-1; j++)
            {
                x = tab[j];
                i = j - 1;
                bpp = false;
                while ((x> tab[i]) != bpp)
                {
                    tab[i + 1] = tab[i];
                    if (i == 0)
                    {
                        bpp = true;
                    }
                    else
                    {
                        i = i - 1;
                    }
                    if (bpp)
                    {
                        tab[0] = x;
                    }
                    else
                    {
                        tab[i + 1] = x;
                    }
                }
            }
        }

        static void TriIntuitif(int[] tab)
        {
            int recup;
            int n = tab.Length;
            for (int i = 0; i < n-2; i++)
            {
                for (int j = i +1 ; j < n -1; j++)
                {
                    if (tab[j] < tab[i])
                    {
                        recup = tab[i];
                        tab[i] = tab[j];
                        tab[j] = recup;
                    }
                }
            }
        }
        static void TriSelection (int[] tab )
        {
            int n = tab.Length;
            int p;
            int recup;
            for (int i = 0; i < n - 2; i++)
            {
                p = i;
                for (int j = i +1; j < n -1; j++)
                {
                    if (tab[j] < tab[p])
                    {
                        p = j;
                    }
                }
                if (p!= i)
                {
                    recup = tab[i];
                    tab[i] = tab[p];
                    tab[p] = recup;
                }
            }
        }
        static void TriShell(int[] tab)
        {
            int n = tab.Length;
            bool permut;
            int EC = (int)(n/2);
            int recup;
            while (EC >= 1)
            {
                do
                {
                    permut = false;
                    for (int i = 0; i < n-1-EC; i++)
                    {
                        if (tab[i] > tab[i+EC])
                        {
                            recup = tab[i];
                            tab[i] = tab[i+EC];
                            tab[i+EC] = recup;
                        }
                    }
                } while (permut == true);
                EC = (int)(EC/2);
            }

        }
    }
}
