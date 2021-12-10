using System;
using System.Collections.Generic;
using System.Linq;

namespace GSB_TAC
{
    public static class Modele
    {
        private static connectGSB_TAC maConnexion;
        private static Visiteur visiteurChoisi; //Visiteur connecté
        private static int actionFrais; //Si = 1 : Ajout frais Si = 2 : modif frais
        private static string moisChoisi; //Le mois de la fiche de frais sous forme "AAAAMM"
        private static LigneFraisForfait fraisChoisi;
        private static LigneFraisHorsForfait hFraisChoisi;

        public static Visiteur VisiteurChoisi { get => visiteurChoisi; set => visiteurChoisi = value; }
        public static int ActionFrais { get => actionFrais; set => actionFrais = value; }
        public static string MoisChoisi { get => moisChoisi; set => moisChoisi = value; }
        public static LigneFraisForfait FraisChoisi { get => fraisChoisi; set => fraisChoisi = value; }
        public static LigneFraisHorsForfait HFraisChoisi { get => hFraisChoisi; set => hFraisChoisi = value; }

        public static void init()
        {
            maConnexion = new connectGSB_TAC();
            visiteurChoisi = maConnexion.Visiteur.Where(x => x.idVisiteur == "a13").ToList()[0];//Remplace le formulaire de connexion pendant le développement de cette partie
        }

        public static List<Visiteur> listVisiteurs() //Renvoi tous les visiteurs de la BD
        {
            return maConnexion.Visiteur.ToList();
        }

        public static List<fichefrais> listFicheFraisVisiteur() //Renvoi les fiches de frais pour 1 visiteur
        {
            return maConnexion.fichefrais.Where(x => x.idVisiteur == visiteurChoisi.idVisiteur).ToList();
        }

        public static fichefrais donneFicheFrais(string mois) //Renvoi la fiche de frais d'un visiteur en fonction du mois
        {
            return maConnexion.fichefrais.Where(x => x.idVisiteur == visiteurChoisi.idVisiteur)
                                         .Where(x => x.mois == mois).ToList()[0];
        }

        public static Etat donneEtat(string id) //Renvoi la un état de la table Etat de la BDD en foncction de son ID
        {
            Etat vretour;
            try
            {
                vretour =  maConnexion.Etat.Where(x => x.id == id).ToList()[0];
            }
            catch
            {
                vretour = null;
            }

            return vretour;
        }

        /*public static List<LigneFraisForfait> listeFraisMois(string mois) //Renvoi les lignes de frais d'un visiteur en fonction du mois
        {
            return maConnexion.LigneFraisForfait.Where(x => x.idVisiteur == visiteurChoisi.idVisiteur)
                                                .Where(x => x.mois == mois).ToList();
        }*/

        public static LigneFraisForfait donneFrais(string idForf) //Renvoi un frais en fonction de son ID
        {
            LigneFraisForfait fretour;
            try
            {
                fretour = maConnexion.LigneFraisForfait.Where(x => x.idVisiteur == visiteurChoisi.idVisiteur)
                                                       .Where(x => x.mois == moisChoisi)
                                                       .Where(x => x.idFraisForfait == idForf).ToList()[0];
            }
            catch
            {
                fretour = null;
                //Debug.WriteLine("Null");
            }
            return fretour;
        }

        public static FraisForfait donneTypeFrais(string id) //Renvoi un type de frais de FraisForfait en fonction de son ID
        {
            FraisForfait tfretour;
            try
            {
                tfretour = maConnexion.FraisForfait.Where(x => x.id == id).ToList()[0];
            }
            catch
            {
                FraisForfait t = new FraisForfait();
                tfretour = t;
            }

            return tfretour;
        }

        public static List<FraisForfait> listeTypeFrais()
        {
            return maConnexion.FraisForfait.ToList();
        }


        public static List<LigneFraisForfait> listeLigneFrais(int type = 0)//Renvoi une liste de ligne de frais de forfait en choisisant quelle catégorie

        //0 = tous les frais; 1 = Frais sans KM; 2 = frais KM

        {
            List<LigneFraisForfait> lretour = new List<LigneFraisForfait>();
            switch (type)
            {
                case 1:
                    lretour = maConnexion.LigneFraisForfait.Where(x => x.mois == moisChoisi)
                                                           .Where(x => x.idVisiteur == visiteurChoisi.idVisiteur)
                                                           .Where(x => !x.idFraisForfait.StartsWith("KM")).ToList();
                    break;
                case 2:
                    lretour = maConnexion.LigneFraisForfait.Where(x => x.mois == moisChoisi)
                                                           .Where(x => x.idVisiteur == visiteurChoisi.idVisiteur)
                                                           .Where(x => x.idFraisForfait.StartsWith("KM")).ToList();
                    break;
                case 0:
                    lretour = maConnexion.LigneFraisForfait.Where(x => x.mois == moisChoisi)
                                                           .Where(x => x.idVisiteur == visiteurChoisi.idVisiteur).ToList();
                    break;
            }
            return lretour;
        }



        public static List<FraisForfait> listeTypeFraisExistant() //Renvoi une liste de FraisForfait déjà existant pour une fiche de frais d'un visiteur
        {
            List<FraisForfait> vretour = new List<FraisForfait>();
            foreach (LigneFraisForfait frais in listeLigneFrais())//On regarde chaque frais dans lignefraisforfait
            {
                foreach (FraisForfait typeFrais in listeTypeFrais())//On regarde chaque type de frais dans fraisforfait
                {
                    if (frais.idFraisForfait == typeFrais.id)//Si on trouve bien une lignefrais qui correspond à un fraisforfait
                    {
                        vretour.Add(typeFrais);//On l'ajoute dans la liste finale
                    }
                }
            }
            return vretour;
        }

        public static List<FraisForfait> listeTypeFraisNonExistant() //Renvoi une liste de FraisForfait qui n'éxiste pas pour une fiche de frais d'un visiteur
        {

            /////Initialisation des listes et dictionnaires/////
            List<FraisForfait> vretour = new List<FraisForfait>();

            Dictionary<string, bool> dictTypeFrais = new Dictionary<string, bool>();

            List<FraisForfait> typesFrais = new List<FraisForfait>();
            ////////////////////////////////////////////////////
            

            typesFrais = listeTypeFrais(); //On remplit la liste des types de frais pas ceux dans la BDD

            foreach (FraisForfait type in typesFrais) //On ajoute dans le dictionnaire, tous les type de frais avec comme valeur false
            {
                dictTypeFrais.Add(type.id, false);
                //Debug.WriteLine(dictTypeFrais);
            }

            foreach (LigneFraisForfait frais in listeLigneFrais()) //On remplace "false" par "true", les type de frais présent dans la liste de ligne de frais
            {
                dictTypeFrais[frais.FraisForfait.id] = true;
            }

            foreach (KeyValuePair<string, bool> entry in dictTypeFrais)//On ajoute à la list finale touts les types de frais avec comme valeur "false"
            {
                if (entry.Value == false)
                {
                    //Debug.WriteLine(entry.Value);
                    vretour.Add(maConnexion.FraisForfait.Where(x => x.id == entry.Key).ToList()[0]);
                }
            }


            return vretour;
        }



        public static List<LigneFraisHorsForfait> listeFraisHForfait() //Renvoi la liste de frais hors forfait pour un visiteur pour un mois
        {
            List<LigneFraisHorsForfait> lretour;
            lretour = maConnexion.LigneFraisHorsForfait.Where(x => x.idVisiteur == visiteurChoisi.idVisiteur)
                                                       .Where(x => x.mois == moisChoisi).ToList();
            return lretour;
        }

        public static LigneFraisHorsForfait donneFraisHForfait(int id) //Renvoi un frais hors forfait en fonction de son id pour un visteur pour un mois
        {
            LigneFraisHorsForfait lretour;
            try
            {
                lretour = maConnexion.LigneFraisHorsForfait.Where(x => x.idVisiteur == visiteurChoisi.idVisiteur)
                                                           .Where(x => x.mois == moisChoisi)
                                                           .Where(x => x.id == id).ToList()[0];
            }
            catch
            {
                lretour = null;
            }

            return lretour;
        }

        public static bool addFrais(string idVisiteur, string mois, string typeFrais, int qte) //Fonction d'ajout de frais normal dans la BDD
        {
            bool vretour = false;

            try
            {
                fraisChoisi = new LigneFraisForfait();
                fraisChoisi.idVisiteur = idVisiteur;
                fraisChoisi.mois = mois;
                fraisChoisi.idFraisForfait = typeFrais;
                fraisChoisi.quantite = qte;
                vretour = true;

                maConnexion.LigneFraisForfait.Add(fraisChoisi); //Ajout de la ligne à la BDD
                maConnexion.SaveChanges(); //Sauvegarde des changements
            }
            catch (Exception e)//Si impossible d'ajouter la ligne, on se déconnecte et on se reconnecte de la BDD
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
                maConnexion.Dispose();
                init();
            }

            return vretour;
        }

        public static bool modifFrais(int qte, LigneFraisForfait fraisForfait) //Fonction de modification d'un frais normal dans la BDD
        {
            bool vretour = false;

            try
            {

                fraisForfait.quantite = qte;
                maConnexion.SaveChanges();
                vretour = true;

            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
                maConnexion.Dispose();
                vretour = false;
                init();

            }

            return vretour;
        }

        public static bool modifHFrais(int qte, DateTime date, string libelle, LigneFraisHorsForfait fraisHorsForfait) //Fonction de modification d'un frais hors forfait dans la BDD
        {
            bool vretour = false;

            try
            {
                fraisHorsForfait.montant = qte;
                fraisHorsForfait.date = date;
                fraisHorsForfait.libelle = libelle;
                maConnexion.SaveChanges();
                vretour = true;
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
                maConnexion.Dispose();
                vretour = false;
                init();

            }

            return vretour;
        }

        public static bool suppFrais() //Fonction de suppression de la BDD d'un frais normal
        {
            bool bretour = false;
            try
            {
                maConnexion.LigneFraisForfait.Remove(FraisChoisi);
                maConnexion.SaveChanges();
                bretour = true;
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
                maConnexion.Dispose();
                init();
            }
            return bretour;
        }

        public static bool ajoutHorsFrais(string idVi, string mois, string libelle, DateTime date, decimal montant)// Fonction d'ajout de frais hors forfait dans la bDD
        {
            bool vretour = false;
            /*int id;
            List<LigneFraisHorsForfait> list_fhf = maConnexion.LigneFraisHorsForfait.Where(x => x.mois == moisChoisi).ToList();
            Debug.WriteLine(list_fhf.Count());
            if(list_fhf.Count() == 0)
            {
                id = 1;
                Debug.WriteLine("Je suis ici");
            }
            else
            {
                id = (list_fhf[list_fhf.Count()-1].id)+1;
                Debug.WriteLine("Je suis passé par là");
            } Pas utile, auto increment dans la BD de l'id */


            try
            {
                hFraisChoisi = new LigneFraisHorsForfait();
                hFraisChoisi.idVisiteur = idVi;
                hFraisChoisi.mois = mois;
                hFraisChoisi.libelle = libelle;
                hFraisChoisi.date = date;
                hFraisChoisi.montant = montant;

                //Debug.WriteLine(hFraisChoisi.id);

                maConnexion.LigneFraisHorsForfait.Add(hFraisChoisi);
                maConnexion.SaveChanges();
                vretour = true;
            }
            catch
            {

            }


            return vretour;
        }

        public static bool suppHFrais() //Fonction de suppression d'un frais hors forfait de la BDD
        {
            bool bretour = false;
            try
            {
                maConnexion.LigneFraisHorsForfait.Remove(HFraisChoisi);
                maConnexion.SaveChanges();
                bretour = true;
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
                maConnexion.Dispose();
                init();
            }
            return bretour;
        }

        public static bool verifieDonnee(string donnee, int quantite) //Fonction de vérification de si la quantité inscrite est bien dans l'interval de son type de frais
        {
            bool vretour = false;

            //Debug.WriteLine(vretour);
            //Debug.WriteLine(donnee);

            if (donnee.Contains("KM"))//Pour touts les frais de type kilométrique 
            {
                if (0 < quantite && quantite <= 350)
                {
                    vretour = true;
                }
            }
            if (donnee == "ETP")
            {
                if (0 < quantite && quantite <= 30)
                {
                    vretour = true;
                }
            }
            if (donnee == "NUI")
            {
                if (0 < quantite && quantite <= 30)
                {
                    vretour = true;
                }
            }
            if (donnee == "REP")
            {
                if (0 < quantite && quantite <= 62)
                {
                    vretour = true;
                }
            }
            return vretour;
        }
    }
}
