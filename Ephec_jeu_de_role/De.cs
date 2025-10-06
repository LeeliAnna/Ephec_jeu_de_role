using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ephec_jeu_de_role
{
    internal class De
    {
        private int facesNb;
        private int face;
        private static Random rnd = new Random();

        public De(int facesNb)
        {
            this.facesNb = facesNb;
            face = rnd.Next(1, facesNb + 1);
        }

        public void Lancer()
        {
            face = rnd.Next(1, facesNb + 1);
        }

        public int Lire()
        {
            return face;
        }
    }
}
