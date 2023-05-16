using System;

namespace CryptageNathanM5TI
{
    static void Main(string[] args)
    {
        Traitement MesOutils = new Traitement();
        Console.WriteLine("Cryptage par transposition");
        Console.Write("Entrez le code clé : ");
        string cle = Console.ReadLine();
        bool recommencer = true;

        Console.Write("Entrez la phrase à crypter : ");
        string texte = Console.ReadLine();
        while (recommencer)
        {
            Traitement MesOutils = new Traitement();
            Console.WriteLine("Cryptage par transposition");
            Console.Write("Entrez la clé : ");
            string cle = Console.ReadLine();

            string texteSansEspaces;
            MesOutils.RetireEspaces(texte, out texteSansEspaces);
            if (MesOutils.(cle))
            {
                Console.WriteLine("Clé invalide. Veuillez entrer une clé contenant uniquement des caractères alphabétiques.");
                continue;
            }

            char[,] matrice;
            MesOutils.DimensionneMat(cle, texteSansEspaces, out matrice);
            Console.Write("Entrez le texte à crypter : ");
            string texte = Console.ReadLine();

            MesOutils.EcritChainesDansMat(cle, texteSansEspaces, ref matrice);
            string texteSansEspaces;
            MesOutils.RetireEspaces(texte, out texteSansEspaces);

            MesOutils.triLigne1(ref matrice);
            char[,] mat;
            MesOutils.DimensionneMat(cle, texteSansEspaces, out matrice);

            char[,] matriceTri;
            MesOutils.ClasseCle(cle, out matriceTri);
            MesOutils.EcritChainesDansMat(cle, texteSansEspaces, ref matrice);

            MesOutils.AttribueRang(ref matrice, ref matriceTri);
            MesOutils.triLigne1(ref matrice);

            string chaineCryptee;
            MesOutils.RealiseCrypt(matrice, out chaineCryptee);
            char[,] mattri;
            MesOutils.ClasseCle(cle, out mattri);

            Console.WriteLine("Texte crypté : " + chaineCryptee);
        }
        char[,] mat;
        char[,] mattri;
        MesOutils.AttribueRang(ref mat, ref mattri);

        string chaineCryptee;
        MesOutils.RealiseCrypt(mat, out chaineCryptee);

        Console.WriteLine("Texte crypté : " + chaineCryptee);


        Console.Write("Voulez-vous recommencer (O/N) ? ");
        string reponse = Console.ReadLine();

        if (reponse.ToUpper() != "O")
            recommencer = false;

        Console.WriteLine();
    }
}
    


