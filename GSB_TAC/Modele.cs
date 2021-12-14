﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Diagnostics;
using System.Data.Entity;
using System.IO;
using System.Data.Entity.Validation;

namespace GSB_TAC
{
    class Modele
    {
        private static connectGSB_TAC maConnexion;
        private static Visiteur utilisateurConnecte;
        private static Visiteur visiteurChoisi;
        private static Secteur secteurChoisi;
        private static Secteur secteurGerer;
        private static Region regionChoisie;
        private static List<Region> regionGeree;
        private static Laboratoire laboChoisi;

        public static Visiteur UtilisateurConnecte { get => utilisateurConnecte; set => utilisateurConnecte = value; }
        public static Secteur SecteurGerer { get => secteurGerer; set => secteurGerer = value; }
        public static Region RegionChoisie { get => regionChoisie; set => regionChoisie = value; }
        public static Secteur SecteurChoisi { get => secteurChoisi; set => secteurChoisi = value; }
        public static Visiteur VisiteurChoisi { get => visiteurChoisi; set => visiteurChoisi = value; }
        public static List<Region> RegionGeree { get => regionGeree; set => regionGeree = value; }
        public static Laboratoire LaboChoisi { get => laboChoisi; set => laboChoisi = value; }



        /* --------------------------------------------
         * Méthodes pour trouver un objet par ID 
           --------------------------------------------*/


        public static Region trouveregionbyid(int id)
        {
            List<Region> malist = maConnexion.Region.Where(x => x.idRegion == id).ToList();
            return malist[0];

        }

        public static Visiteur trouvevisiteurbyid(string id)
        {
            List<Visiteur> malist = maConnexion.Visiteur.Where(x => x.idVisiteur == id).ToList();
            return malist[0];

        }


        public static Secteur trouvesecteurbyid(int id)
        {
            List<Secteur> malist = maConnexion.Secteur.Where(x => x.idSecteur == id).ToList();
            return malist[0];

        }

        public static Laboratoire trouvelabobyid(int id)
        {
            List<Laboratoire> malist = maConnexion.Laboratoire.Where(x => x.idLabo == id).ToList();
            return malist[0];

        }

        /* --------------------------------------------
       * Initialisation de la BDD 
         --------------------------------------------*/
        public static void init()
        {
            /* Instantiation d’un objet de la classe typée chaine de connexion SqlConnection */
            maConnexion = new connectGSB_TAC();
        }

        /* --------------------------------------------
        * Méthodes pour retourner des listes d'objets 
          --------------------------------------------*/

        public static List<Visiteur> listevisiteur()
        {
            return maConnexion.Visiteur.ToList();
        }
        public static List<Secteur> listesecteur()
        {
            return maConnexion.Secteur.ToList();
        }
        public static List<Region> listeregion()
        {
            return maConnexion.Region.ToList();
        }
        public static List<Laboratoire> listelabo()
        {
            return maConnexion.Laboratoire.ToList();
        }


        /* --------------------------------------------
                * Méthodes de connexion
                  --------------------------------------------*/

        public static bool userexists(string id) // vérifie existence utilisateur
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

        public static bool passexists(string mdp) // vérifie existence du mot de passe lié à l'UtilisateurChoisi
        {
            bool vretour = false;
            if (UtilisateurConnecte.password.Equals(GetMd5Hash(mdp)) && UtilisateurConnecte.actif == true)
            {
                vretour = true;
                maConnexion.SaveChanges();
            }
            return vretour;
        }


        /* --------------------------------------------
        * Méthodes pour hasher un pass en MD5
          --------------------------------------------*/

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



        /* --------------------------------------------
        * Méthodes pour modifier objets Visiteur
          --------------------------------------------*/


        public static bool changepass(string nouveaumdp)
        {
            bool vretour = false;
            UtilisateurConnecte.password = GetMd5Hash(nouveaumdp);
            maConnexion.SaveChanges();
            return vretour;
        }
        


        // Ajoute un visiteur dans la BDD => Actif par défaut.
        public static bool AjoutVisiteur(string idVisiteur, string nom, string prenom, string rue, string codepostal, string ville, string dateEmbauche, string identifiant, string password, Laboratoire labo, Region region)
        {
            bool vretour = true;
            try
            {
                VisiteurChoisi = new Visiteur();
                VisiteurChoisi.idVisiteur = idVisiteur;
                VisiteurChoisi.idLabo = labo.idLabo;
                VisiteurChoisi.nom = nom;
                VisiteurChoisi.prenom = prenom;
                VisiteurChoisi.rue = rue;
                VisiteurChoisi.cp = codepostal;
                VisiteurChoisi.ville = ville;
                VisiteurChoisi.dateEmbauche = dateEmbauche;
                Debug.WriteLine(dateEmbauche);
                VisiteurChoisi.identifiant = identifiant;
                VisiteurChoisi.password = GetMd5Hash(password);
                VisiteurChoisi.actif = true;



                VisiteurChoisi.Region1.Add(region);
                region.Visiteur1.Add(VisiteurChoisi);
                maConnexion.Visiteur.Add(VisiteurChoisi);
                maConnexion.SaveChanges();
            }
            catch (DbEntityValidationException ex)
            {

                vretour = false;

                foreach (var validationErrors in ex.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        Trace.TraceInformation("Property: {0} Error: {1}",
                                                validationError.PropertyName,
                                                validationError.ErrorMessage);
                    }
                }

            }
            return vretour;

        }

        //Modification des informations nominales du Visiteur.
        public static bool ModifUtilisateur(string nom, string prenom)
        {
            bool vretour = true;

            try
            {
                utilisateurConnecte.nom = nom;
                utilisateurConnecte.prenom = prenom;
                maConnexion.SaveChanges();
            }
            catch (Exception ex)
            {
                vretour = false;
            }
            return vretour;

        }


        public static bool DesactiverVisiteur() // Permet de désactiver un utilisateur (actif = false)
        {
            bool vretour = false;

            if (visiteurChoisi.actif == true || visiteurChoisi.actif == null)
            {
                visiteurChoisi.actif = false;
                maConnexion.SaveChanges();
                vretour = true;
            }
            return vretour;
        }

        public static bool ActiverVisiteur() // Permet d'activer un utilisateur (actif = true)
        {
            bool vretour = false;

            if (visiteurChoisi.actif == false || visiteurChoisi.actif == null)
            {
                if (visiteurChoisi.dateLicenciement == null && visiteurChoisi.motifLicenciement == null)
                {
                    visiteurChoisi.actif = true;
                    maConnexion.SaveChanges();
                    vretour = true;
                }
            }
            return vretour;
        }

        public static bool LicencierVisiteur(string motif, string date) // Récupère le motif & la date de licenciement du Visiteur et actif=false
        {
            bool vretour = false;

            if (visiteurChoisi.actif == true)
            {
                visiteurChoisi.actif = false;
                visiteurChoisi.motifLicenciement = motif;
                visiteurChoisi.dateLicenciement = date;
                maConnexion.SaveChanges();
                vretour = true;
            }
            return vretour;
        }


        /* --------------------------------------------
        * Méthodes pour modifier un objet Region
          --------------------------------------------*/

        public static bool ModifRegion(string nom, string idvisiteur) // Récupère un nom de région & un idVisiteur pour le passer Chef de région
        {
            bool vretour = false;

            try
            {
                if (visiteurChoisi != regionChoisie.Visiteur)
                { 
                    regionChoisie.libRegion = nom;
                    regionChoisie.idVisiteur = idvisiteur;
                    maConnexion.SaveChanges();
                    vretour = true;
                }
                else if (visiteurChoisi == regionChoisie.Visiteur)
                {
                    vretour = false;
                }
            }
            catch (Exception ex)
            {
                vretour = false;
            }
            return vretour;

        }

        // Associe le visiteur choisi à la région passé en paramètre.
        public static bool AssocierRegion(Region region)
        {
            bool vretour = true;

            try
            {
                region.Visiteur1.Add(visiteurChoisi);
                visiteurChoisi.Region1.Add(region);
                maConnexion.SaveChanges();
            }
            catch (Exception ex)
            {
                vretour = false;
            }
            return vretour;

        }


        public static bool DissocierRegion(Region region) // Dissocie le visiteur choisi de la région passée en paramètres
        {
            bool vretour = true;

            try
            {
                region.Visiteur1.Remove(visiteurChoisi);
                visiteurChoisi.Region1.Remove(region);
                maConnexion.SaveChanges();
            }
            catch (Exception ex)
            {
                vretour = false;
            }
            return vretour;

        }


        /* --------------------------------------------
        * Méthodes pour modifier un objet Secteur
          --------------------------------------------*/
        public static bool ModifSecteur(string nom, string idvisiteur) // Modifie le secteurChoisi pour lui attribuer l'idVisiteur envoyé pour le passer Chef de Secteur
        {
            bool vretour = true;
            try
            {
                secteurChoisi.libSecteur = nom;
                secteurChoisi.idVisiteur = idvisiteur;
                maConnexion.SaveChanges();
            }
            catch (Exception ex)
            {
                vretour = false;
            }
            return vretour;

        }


        /* --------------------------------------------
        * Méthodes pour vérifier le poste d'un Visiteur
          --------------------------------------------*/

        // Vérifie qu'un visiteur soit Responsable de Secteur (par l'idVisiteur passé en paramètre)
        public static bool isResponsablesecteur(string id)
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


        // Vérifie qu'un visiteur soit Responsable de Region (par l'idVisiteur passé en paramètre)
        public static bool isResponsableregion(string id)
        {
            bool vretour = false;

            if (maConnexion.Region.Where(x => x.idVisiteur == id).ToList().Count >= 1)
            {
                vretour = true;
                RegionGeree = maConnexion.Region.Where(x => x.idVisiteur == id).ToList();
                maConnexion.SaveChanges();
            }
            return vretour;
        }

       
    }
}
