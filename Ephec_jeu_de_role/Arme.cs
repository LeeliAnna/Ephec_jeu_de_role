using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ephec_jeu_de_role
{
    internal class Arme
    {
        private string nom;
        private int bonus;

        public Arme(string nom, int bonus)
        {
            this.nom = nom;
            this.bonus = bonus;
        }

        public string GetNom()
        {
            return nom;
        }
        public int GetBonus()
        {
            return bonus;
        }
            
    }
}
