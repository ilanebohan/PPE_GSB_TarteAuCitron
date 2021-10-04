using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSB_TAC
{
    public static class Modele
    {
        private static connectGSB_TAC maConnexion;
        private static Visiteur visiteurChoisi;

        public static Visiteur VisiteurChoisi { get => visiteurChoisi; set => visiteurChoisi = value; }

        public static void init()
        {
            maConnexion = new connectGSB_TAC();
            visiteurChoisi = maConnexion.Visiteur.Where(x => x.idVisiteur == "a13").ToList()[0];
        }

        public static List<Visiteur> listVisiteurs()
        {
            return maConnexion.Visiteur.ToList();
        } 

        public static List<fichefrais> listFicheFraisVisiteur()
        {
            return maConnexion.fichefrais.Where(x => x.idVisiteur == visiteurChoisi.idVisiteur).ToList();
        }

        public static List<LigneFraisForfait> listeFraisMois(string mois)
        {
            return maConnexion.LigneFraisForfait.Where(x => x.idVisiteur == visiteurChoisi.idVisiteur)
                                                .Where(x => x.mois == mois).ToList();
        }

    }
}
