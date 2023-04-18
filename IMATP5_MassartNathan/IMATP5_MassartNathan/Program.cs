using System;

namespace IMATP5_MassartNathan
{
    class Program
    {
        static void Main(string[] args)
        {

            int N;
            int[,] MatriceResultat;
            int Colonne;
            string reponseChaine;
            Traitement MesOutils = new Traitement();



            do
            {

                Console.WriteLine("Entrez la valeur de N dans (a+b)^n");
                MesOutils.Generation(int N, out int[,] MatriceResultat);

    
        } while (true);
        }


    }
}