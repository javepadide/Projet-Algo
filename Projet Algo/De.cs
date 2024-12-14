using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Projet_Algo
{
    public class De
    {
        public char[] Faces { get; set; }
        public char FaceVisible { get; set; }

        public De(Random r)
        {
            List<Lettre> lettres = DefLettres(); // on récupère la liste
            Faces = DefFaces(lettres, r); //la fonction défini les 6 faces
            FaceVisible = Faces[0];
        }

        public class Lettre
        {
            public char Charactere { get; set; }
            public int Valeur {  get; set; }
            public int Proba { get; set; }

            public Lettre(char charactere, int valeur, int proba)
            {
                Charactere = charactere;
                Valeur = valeur;
                Proba = proba;

            }
        }

        public List<Lettre> DefLettres()
        {
            string[] lignes = File.ReadAllLines("Lettres.txt");
            List<Lettre> lettres = new List<Lettre>();
            foreach (string ligne in lignes) 
            {
                string[] parties = ligne.Split(';'); //on divise les lignes en partie pour pouvoir créer les lettres
                char charactere = Convert.ToChar(parties[0]);
                int valeur = Convert.ToInt32(parties[1]);
                int proba = Convert.ToInt32(parties[2]);
                lettres.Add(new Lettre(charactere, valeur, proba));
            }
            return lettres;
        }

        public char[] DefFaces(List<Lettre> lettres, Random r)
        {
            char[] faces = new char[6];
            List<char> TouteLettres = new List<char>(); //on fait une liste qui va contenir (lettre*proba)

            foreach(Lettre lettre in lettres)
            {
                for(int i = 0; i < lettre.Proba; i++)
                {
                    TouteLettres.Add(lettre.Charactere);
                }
            }
            for(int i = 0;i < 6; i++)
            {
                faces[i] = TouteLettres[r.Next(TouteLettres.Count)];
            }
            return faces;
        }

        public void Lance(Random r)
        {
            int a = r.Next(0,Faces.Length); //création d'une variable aléatoire qui définira la face
            FaceVisible = Faces[a];
        }

        public string toString()
        {
            string a = "Le Dé possède sur ses faces les lettres : ";
            for (int i = 0; i < 5; i++)
            {
                a = a + Faces[i] + ", ";
            }
            a = a + Faces[5] + " et la face visible est : " + FaceVisible;
            return a;
        }
    }
}
