using System.Text;
using System;
using System.Threading;
using System.Threading.Tasks;
using System.IO;

namespace Projet_Algo
{
    public class Jeu
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            // Attention lignes de Test
            //De DeTest = new De(rnd);
            //Console.WriteLine(DeTest.toString());
            

            Dictionnaire dico = new Dictionnaire("EN");
            Console.WriteLine(dico.ToString());

            Console.ReadLine();
        }
    }
}