﻿using System;
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
        private static LigneFraisHorsForfait hFraisChoisi;

        public static Visiteur VisiteurChoisi { get => visiteurChoisi; set => visiteurChoisi = value; }
        public static int ActionFrais { get => actionFrais; set => actionFrais = value; }
        public static string MoisChoisi { get => moisChoisi; set => moisChoisi = value; }
        public static LigneFraisForfait FraisChoisi { get => fraisChoisi; set => fraisChoisi = value; }
        public static LigneFraisHorsForfait HFraisChoisi { get => hFraisChoisi; set => hFraisChoisi = value; }

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
            try
            {
                fretour = maConnexion.LigneFraisForfait.Where(x => x.idVisiteur == idVisi)
                                                       .Where(x => x.mois == mois)
                                                       .Where(x => x.idFraisForfait == idForf).ToList()[0];
            }
            catch
            {
                fretour = null;
            }
            return fretour;
        }


        public static List<FraisForfait> listeTypeFrais()
        {
            return maConnexion.FraisForfait.ToList();
        }

        public static List<LigneFraisHorsForfait> donneFraisHForfait()
        {
            List<LigneFraisHorsForfait> lretour;
            lretour = maConnexion.LigneFraisHorsForfait.Where(x => x.idVisiteur == visiteurChoisi.idVisiteur)
                                                       .Where(x => x.mois == moisChoisi).ToList();
            return lretour;
        }

        public static bool addFrais(string idVisiteur, string mois, string typeFrais, int qte)
        {
            bool vretour = false;

            try
            {
                fraisChoisi = new LigneFraisForfait();
                fraisChoisi.idVisiteur = idVisiteur;
                fraisChoisi.mois = mois;
                Debug.WriteLine(typeFrais);
                fraisChoisi.idFraisForfait = typeFrais;
                fraisChoisi.quantite = qte;
                vretour = true;

                maConnexion.LigneFraisForfait.Add(fraisChoisi);
                maConnexion.SaveChanges();
            }
            catch(Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
                maConnexion.Dispose();
                init();
            }

            return vretour;
        }

        public static bool modifFrais(int qte)
        {
            bool vretour = false;

            try
            {
                fraisChoisi.quantite += qte;
                maConnexion.SaveChanges();
            }catch(Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
                maConnexion.Dispose();
                init();
            }

            return vretour;
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
                System.Windows.Forms.MessageBox.Show(e.Message);
                maConnexion.Dispose();
                init();
            }
            return bretour;
        }

        public static bool ajoutHorsFrais(string idVi, string mois, string libelle, DateTime date, decimal montant)
        {
            bool vretour = false;
            int id;
            List<LigneFraisHorsForfait> list_fhf = maConnexion.LigneFraisHorsForfait.Where(x => x.mois == moisChoisi).ToList();
            if(list_fhf.Count() == 0)
            {
                id = 0;
            }
            else
            {
                id = list_fhf[list_fhf.Count()].id + 1;
            }


            try
            {
                hFraisChoisi = new LigneFraisHorsForfait();
                hFraisChoisi.id = id;
                hFraisChoisi.idVisiteur = idVi;
                hFraisChoisi.mois = mois;
                hFraisChoisi.libelle = libelle;
                hFraisChoisi.date = date;
                hFraisChoisi.montant = montant;

                maConnexion.LigneFraisHorsForfait.Add(hFraisChoisi);
                maConnexion.SaveChanges();
                vretour = true;
            }
            catch(Exception e){

                }


            return vretour;
        }

    }
}
