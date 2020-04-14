using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Datagrid
{
    public struct eleve
    {
        private string nom;

        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }
        private string prenom;

        public string Prenom
        {
            get { return prenom; }
            set { prenom = value; }
        }

        public eleve(string un_nom,string un_prenom)
        {
            this.nom = un_nom;
            this.prenom = un_prenom;
        }
    }
}
