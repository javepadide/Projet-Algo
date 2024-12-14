using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Algo
{
    public class Joueur
    {
        public string Nom { get; set; }

        public int Score { get; set; }

        public List<string> Mots;

        public Joueur(string nom)
        {

            while(nom == null || nom.Length == 0)
            {
                Console.WriteLine("Veuillez entrer un nom de joueur");
                    nom = Convert.ToString(Console.ReadLine());
            }
            Nom = nom;
            Score = 0;
            Mots = new List<string>();

        }

        public bool Contain(string mot)
        {
            for (int i = 0; i < Mots.Count-1; i++)
            {
                if(Mots[i] == mot) { return true; }
            }
            return false;
        }

        public void Add_Mot(string mot)
        {
            Mots.Add(mot);
        }

        public string toString()
        {
            string a = "Le score de " + Nom + "est de " + Score + " grâce aux mots cités suivants" + '\n' ;
            for (int i = 0; i < Mots.Count - 1; i++) 
            {
                a = a + Mots[i] + " ";
            }
            return (a);
        }
    }
}
