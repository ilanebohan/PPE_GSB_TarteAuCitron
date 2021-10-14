using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace GSB_TAC
{
    public static class Modele
    {
        private static connectGSB_TAC maConnexion;
        private static Visiteur visiteurChoisi;
        private static int actionFrais; //Si = 1 : Ajout frais Si = 2 : modif frais
        private static string moisChoisi;
        private static LigneFraisForfait fraisChoisi;

        public static Visiteur VisiteurChoisi { get => visiteurChoisi; set => visiteurChoisi = value; }
        public static int ActionFrais { get => actionFrais; set => actionFrais = value; }
        public static string MoisChoisi { get => moisChoisi; set => moisChoisi = value; }
        public static LigneFraisForfait FraisChoisi { get => fraisChoisi; set => fraisChoisi = value; }

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

        public static LigneFraisForfait donneFrais(string idVisi, string mois, string idForf)
        {
            LigneFraisForfait fretour;
            fretour = maConnexion.LigneFraisForfait.Where(x => x.idVisiteur == idVisi)
                                                   .Where(x => x.mois == mois)
                                                   .Where(x => x.idFraisForfait == idForf).ToList()[0];
            return fretour;
        }


        public static List<FraisForfait> listeTypeFrais()
        {
            return maConnexion.FraisForfait.ToList();
        }


        public static bool suppFrais()
        {
            bool bretour = false;
            try
            {
                maConnexion.LigneFraisForfait.Remove(FraisChoisi);
                maConnexion.SaveChanges();
                bretour = true;
            }catch (Exception e)
            {
                Debug.WriteLine(e);
                System.Windows.Forms.MessageBox.Show(e.Message);

            }
            return bretour;
        }
    }
}
