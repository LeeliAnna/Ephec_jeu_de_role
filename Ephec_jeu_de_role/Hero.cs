using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ephec_jeu_de_role
{
    internal class Hero
    {
        private string _nom;
        private string _hp;

        public string Nom { get; private set; }
        public int HP { get; private set; }

        private De deAttaque;

        public Hero(string nom, int hp)
        {
            Nom = nom;
            HP = hp;
            deAttaque = new De(6);
        }

        public void Attaquer(Hero cible)
        {
            deAttaque.Lancer();
            cible.HP -=  deAttaque.Lire();
        }

        public override string ToString() 
        {
            return $"{Nom} : {HP} PV.";
        }

        public void PropoquerEnDuel(Hero cible) 
        {
            do
            {
                Attaquer(cible);
                if(cible.HP > 0) cible.Attaquer(this);

                if(HP <= 0)
                {
                    cible.ToString();
                    Console.WriteLine($"Le vainceur est {cible.Nom}.");
                }
                else if (cible.HP <= 0)
                {
                    ToString();
                    Console.WriteLine($"Le vainceur est {Nom}.");
                }
            }
            while (cible.HP >= 0 && HP >= 0);
        }


    }
}
