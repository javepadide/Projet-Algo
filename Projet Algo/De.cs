using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Algo
{
    internal class Dé
    {
        public char[] Faces { get; set; }
        public char FaceVisible { get; set; }

        public Dé()
        {


        }

        public void Lance(Random r)
        {
            int a = r.Next(0,Faces.Length);
            FaceVisible = Faces[a];
        }

        public string toString()
        {
            return ("");
        }
    }
}
