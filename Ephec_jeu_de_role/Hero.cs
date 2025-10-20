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
        private string nom;
        private int hp;

        protected De deAttaque;
        private Arme? arme;

        public Hero(string nom, int hp, Arme? arme)
        {
            this.nom = nom;
            this.hp = hp;
            deAttaque = new De(6);
            if (arme != null) 
            {
                this.arme = new Arme(arme.GetNom(), arme.GetBonus());
            }
        }

        public Hero(string nom, int hp, string nomArme, int bonusArme)
        {
            this.nom = nom;
            this.hp = hp;
            deAttaque = new De(6);
            arme = new Arme(nomArme, bonusArme);            
        }

        public string GetNom()
        {
            return nom;
        }

        public int GetHP()
        {
            return hp;
        }

        public void PrendreDegats(int hp)
        {
            this.hp -= hp;
            if (this.hp < 0) this.hp = 0;
        }


        public virtual void Attaquer(Hero cible)
        {
            deAttaque.Lancer();
            if (arme != null) 
            {
                cible.hp -=  deAttaque.Lire() + arme.GetBonus();
            }
        }

        public override string ToString() 
        {
            return $"{nom} : {hp} PV.";
        }

        public void PropoquerEnDuel(Hero cible) 
        {
            do
            {
                Attaquer(cible);
                if(cible.hp > 0) cible.Attaquer(this);

                if(hp <= 0)
                {
                    cible.ToString();
                    Console.WriteLine($"Le vainceur est {cible.nom}.");
                }
                else if (cible.hp <= 0)
                {
                    ToString();
                    Console.WriteLine($"Le vainceur est {nom}.");
                }
            }
            while (cible.hp >= 0 && hp >= 0);
        }
    }
}
