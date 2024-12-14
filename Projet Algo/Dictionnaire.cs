using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Projet_Algo
{
    internal class Dictionnaire
    {
        public string Langue { get; set; }
        private string[] Mots {  get; set; }

        public Dictionnaire (string langue)
        {
            Langue = langue;

            while(Langue != "EN" && Langue != "FR")
            {
                Console.WriteLine("La langue doit être FR (francais) ou EN (english)");
                Langue = Console.ReadLine();
            }

            if (Langue == "EN")
            {
                Mots = DefMots("MotsPossiblesEN.txt");
            }

            else if (Langue == "FR")
            {
                Mots = DefMots("MotsPossiblesFR.txt");
            }

        }

        public string[] DefMots(string chemin)
        {
            string Fichier = File.ReadAllText(chemin);
            string[] Dico = Fichier.Split(' ');
            return Dico;

        }

        public string toString()
        {
            string a = "";
            foreach (string s in Mots)
            {
                a = a + s;
            }
            return a;
        }

    }
}
