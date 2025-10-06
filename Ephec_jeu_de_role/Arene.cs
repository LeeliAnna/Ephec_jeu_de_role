using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ephec_jeu_de_role
{
    internal class Arene
    {
        public void Attaquer(Hero attaquant, Hero cible)
        {
            do
            {
                attaquant.Attaquer(cible);
                if (cible.HP > 0) cible.Attaquer(attaquant);

                if (attaquant.HP <= 0)
                {
                    cible.ToString();
                    Console.WriteLine($"Le vainceur est {cible.Nom}.");
                }
                else if (cible.HP <= 0)
                {
                    ToString();
                    Console.WriteLine($"Le vainceur est {attaquant.Nom}.");
                }
            }
            while (cible.HP >= 0 && attaquant.HP >= 0);
        }
    }
}
