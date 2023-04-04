using System;

namespace _5T_TableauxEval
{
    class Program
    {
     
        static void Main(string[] args)
        {
            //déclaration de toutes mes variables
            string restartMatch = "";


            //presentation du programme
            Console.WriteLine("             ");
            Console.WriteLine("             ");
            Console.WriteLine("                                             ---------------------------------------------");
            Console.WriteLine("                                             Bienvenue dans le Tableau de non binaire !!!");
            Console.WriteLine("                                             ---------------------------------------------");
            Console.WriteLine("             ");
            //application du programme
            do
            {
                ProgrammeU(out int[]T);//appel du premier programme
                Console.WriteLine(T);
                ProgrammeD(out int[]TableauFinal);//appel du deuxième programme
                Console.WriteLine(TableauFinal);
                
                Console.WriteLine("Voulez-vous recommencer une partie ? OUI ou NON ?");//demande d'un restart
                restartMatch = Console.ReadLine();
            } while (restartMatch != "NON");
           
        }
        static void ProgrammeU(out int[]T)//premier programme 
        {
            T = new int[7];
            for (int i = 0; 0 < 6; i++)
            {
                if (T[i] == 0)
                {
                    T[i] = 0;
                }
                else
                {
                    T[i] = 1;
                }
            }
        }
         static void ProgrammmeD( int[]T, int[]T2, out int[]TableauFinal)// deuxième programme
         {
            int[] TabRetenues = new int[7];
            TableauFinal = new int[7];
            for (int i = 0; 0 < 6; i++)
            {
                if (T[i] + T2[i] + TabRetenues[i] = 0)
                {
                    TableauFinal[i] = TableauFinal[i] + 0;
                }
                else if (T[i] + T2[i] + TabRetenues[i] = 1)
                {
                    TableauFinal[i] = TableauFinal[i] + 1;
                }
                else if (T[i] + T2[i] + TabRetenues[i] = 10)
                {
                    TableauFinal[i] = TableauFinal[i] + 0;
                    TabRetenues[i + 1] = TabRetenues[i + 1] + 1;
                }
                else if (T[i] + T2[i] + TabRetenues[i] = 11)
                {
                    TableauFinal[i] = TableauFinal[i] + 1;
                    TabRetenues[i + 1] = TabRetenues[i + 1] + 1;
                }
            }
         }
    }
}
