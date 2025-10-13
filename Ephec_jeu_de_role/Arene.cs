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
                if (cible.GetHP() > 0) cible.Attaquer(attaquant);

                if (attaquant.GetHP() <= 0)
                {
                    cible.ToString();
                    Console.WriteLine($"Le vainceur est {cible.GetNom()}.");
                }
                else if (cible.GetHP() <= 0)
                {
                    ToString();
                    Console.WriteLine($"Le vainceur est {attaquant.GetNom()}.");
                }
            }
            while (cible.GetHP() >= 0 && attaquant.GetHP() >= 0);
        }
    }
}
