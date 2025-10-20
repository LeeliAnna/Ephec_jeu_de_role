using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ephec_jeu_de_role
{
    internal class Mage : Hero
    {
        private int puissance;
        public Mage(string nom, int hp, int puissance) : base(nom, hp, null)
        {
            this.puissance = puissance;
        }

        public override void Attaquer(Hero cible)
        {
            int totalDegats = 0;
            for(int i = 0;  i < this.puissance; i++)
            {
                deAttaque.Lancer();
                totalDegats += deAttaque.Lire();
            }
            cible.PrendreDegats(totalDegats);
        }
    }
}
