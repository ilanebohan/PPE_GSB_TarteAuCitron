using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace GSB_TAC
{
    class Modele
    {
        private static connectGSB_TAC maConnexion;
        private static Visiteur utilisateurConnecte;
        private static Secteur secteurGerer;

        public static Visiteur UtilisateurConnecte { get => utilisateurConnecte; set => utilisateurConnecte = value; }
        public static Secteur SecteurGerer { get => secteurGerer; set => secteurGerer = value; }

        public static void init()
        {
            /* Instantiation d’un objet de la classe typée chaine de connexion SqlConnection */
            maConnexion = new connectGSB_TAC();
        }

        public static List<Visiteur> listevisiteur()
        {
            return maConnexion.Visiteur.ToList();
        }
        public static List<Secteur> listesecteur()
        {
            return maConnexion.Secteur.ToList();
        }


        public static bool userexists(string id)
        {
            bool vretour = false;

            if (maConnexion.Visiteur.Where(x => x.identifiant == id).ToList().Count == 1)
            {
                vretour = true;
                UtilisateurConnecte = maConnexion.Visiteur.Where(x => x.identifiant == id).ToList()[0];
                maConnexion.SaveChanges();

            }
            return vretour;
        }

        public static bool isResponsable(string id)
        {
            bool vretour = false;

            if (maConnexion.Secteur.Where(x => x.idVisiteur == id).ToList().Count == 1)
            {
                vretour = true;
                SecteurGerer = maConnexion.Secteur.Where(x => x.idVisiteur == id).ToList()[0];
                maConnexion.SaveChanges();
            }
            return vretour;
        }
            public static bool passexists(string mdp)
        {
            bool vretour = false;
            if (UtilisateurConnecte.password.Equals(GetMd5Hash(mdp)))
            {
                vretour = true;
                maConnexion.SaveChanges();
            }
            return vretour;
        }

        public static bool changepass(string nouveaumdp)
        {
            bool vretour = false;
            UtilisateurConnecte.password = GetMd5Hash(nouveaumdp);
            maConnexion.SaveChanges();
            return vretour;
        }

        private static string GetMd5Hash(string PasswdSaisi)
        {
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(PasswdSaisi);
            byte[] hash = (MD5.Create()).ComputeHash(inputBytes);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("x2"));
            }
            return sb.ToString();
        }
    }
}
