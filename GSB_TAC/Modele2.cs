using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSB_TAC
{
    class Modele2
    {
        private static connectGSB_TAC maConnexion;
        private static Visiteur utilisateurConnecte;

        public static Visiteur UtilisateurConnecte { get => utilisateurConnecte; set => utilisateurConnecte = value; }


        public static void init()
        {
            /* Instantiation d’un objet de la classe typée chaine de connexion SqlConnection */
            maConnexion = new connectGSB_TAC();
            utilisateurConnecte = maConnexion.Visiteur.Where(x => x.idVisiteur = "a13").ToList()[0];
    }

    }
}
