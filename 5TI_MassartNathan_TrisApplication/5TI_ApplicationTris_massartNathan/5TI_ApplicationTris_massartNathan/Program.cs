using System;

namespace traitTableaux
{
    public struct outils
    {
        public void LireReel(string question, out int n)
        {
            string nUser;
            Console.Write(question);
            nUser = Console.ReadLine();
            while (!int.TryParse(nUser, out n))
            {
                Console.WriteLine("Attention ! vous devez taper un nombre réel !");
                nUser = Console.ReadLine();
            }
        }

        public void creationAleatoire(int nombre, int max, int min, out int[] tableau)
        {
            tableau = new int[nombre];
            Random alea = new Random();
            for (int i = 0; i < tableau.Length; i++)
            {
                tableau[i] = alea.Next(min, max + 1);
            }
        }

        public void affichage(int[] tableau, out string aff)
        {
            aff = "";
            for (int i = 0; i < tableau.Length; i++)
            {
                aff = aff + tableau[i] + "|";
            }
        }

        public void Tri_bulle(ref int[] tableau)
        {
            int x;
            int n;
            int passage = 0;
            bool test = false;
            n = tableau.Length;
            do
            {
                test = false;
                for (int i = 0; i <= n - 2 - passage; i++)
                {
                    if (tableau[i] > tableau[i + 1])
                    {
                        x = tableau[i];
                        tableau[i] = tableau[i + 1];
                        tableau[i + 1] = x;
                        test = true;
                    }
                }
                passage = passage + 1;

            } while (test == true);
        }
        public void Tri_insertion(ref int[] tableau)
        {
            int x;
            int n;
            int i;
            bool bpp;
            n = tableau.Length;
            for (int j = 1; j < n - 1; j++)
            {
                x = tableau[j];
                i = j - 1;
                bpp = false;
                while ((x < tableau[i]) != bpp)
                {
                    tableau[i + 1] = tableau[i];
                    if (i == 0)
                    {
                        bpp = true;
                    }
                    else
                    {
                        i = i - 1;
                    }
                }
                if (bpp)
                {
                    tableau[0] = x;
                }
                else
                {
                    tableau[i + 1] = x;
                }
            }
        }
        public void Tri_intuitif(ref int[] tableau)
        {
            int n;
            int x;
            n = tableau.Length;
            for (int i = 0; i < n - 2; i++)
            {
                for (int j = i + 1; j < n - 1; j++)
                {
                    if (tableau[j] < tableau[i])
                    {
                        x = tableau[i];
                        tableau[i] = tableau[j];
                        tableau[j] = x;
                    }
                    else
                    {

                    }
                }
            }
        }

        public void Tri_selection(ref int[] tableau)
        {
            int n;
            int x;
            int y;
            n = tableau.Length;
            for (int i = 0; i < n - 2; i++)
            {
                x = i;
                for (int j = i + 1; j < n - 1; j++)
                {
                    if (tableau[j] < tableau[x])
                    {
                        x = j;
                    }
                    else
                    {

                    }
                }
                if (x != i)
                {
                    y = tableau[x];
                    tableau[x] = tableau[i];
                    tableau[i] = y;
                }
                else
                {

                }
            }
        }
        public void Tri_shell(ref int[] tableau)
        {
            int n;
            int x;
            int j;
            bool test;
            n = tableau.Length;
            x = (n / 2);
            while (x >= 1)
            {
                do
                {
                    test = false;
                    for (int i = 0; i < n - 1 - x; i++)
                    {
                        if (tableau[i] > tableau[i + x])
                        {
                            j = tableau[i];
                            tableau[i] = tableau[i + x];
                            tableau[i + x] = j;
                            test = true;
                        }
                        else
                        {

                        }
                    }

                } while (test == true);
                x = (x / 2);
            }
        }
    }
}