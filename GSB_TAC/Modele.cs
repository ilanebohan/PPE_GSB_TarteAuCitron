using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

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

        public static LigneFraisForfait donneFrais(string idForf)
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
                Debug.WriteLine("Null");
            }
            return fretour;
        }

        public static FraisForfait donneTypeFrais(string id)
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


        public static List<LigneFraisForfait> listeLigneFrais(int type = 0) //0 = tous les frais; 1 = Frais sans KM; 2 = frais KM
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

        

        public static List<FraisForfait> listeTypeFraisExistant()
        {
            List<FraisForfait> vretour = new List<FraisForfait>();
            foreach (LigneFraisForfait frais in listeLigneFrais())
            {
                foreach (FraisForfait typeFrais in listeTypeFrais())
                {
                    if (frais.idFraisForfait == typeFrais.id)
                    {
                        vretour.Add(typeFrais);
                    }
                }
            }
            return vretour;
        }

        public static List<FraisForfait> listeTypeFraisNonExistant()
        {
            List<FraisForfait> vretour = new List<FraisForfait>();

            Dictionary<string, bool> dictTypeFrais = new Dictionary<string, bool>();

            List<FraisForfait> typesFrais = new List<FraisForfait>();

            typesFrais = listeTypeFrais();

            foreach (FraisForfait type in typesFrais)
            {
                dictTypeFrais.Add(type.id, false);
                Debug.WriteLine(dictTypeFrais);
            }

            foreach (LigneFraisForfait frais in listeLigneFrais())
            {
                dictTypeFrais[frais.FraisForfait.id] = true;
            }

            foreach (KeyValuePair<string, bool> entry in dictTypeFrais)
            {
                if (entry.Value == false)
                {
                    Debug.WriteLine(entry.Value);
                    vretour.Add(maConnexion.FraisForfait.Where(x => x.id == entry.Key).ToList()[0]);
                }
            }

            
            return vretour;
        }



        public static List<LigneFraisHorsForfait> listeFraisHForfait()
        {
            List<LigneFraisHorsForfait> lretour;
            lretour = maConnexion.LigneFraisHorsForfait.Where(x => x.idVisiteur == visiteurChoisi.idVisiteur)
                                                       .Where(x => x.mois == moisChoisi).ToList();
            return lretour;
        }

        public static LigneFraisHorsForfait donneFraisHForfait(int id)
        {
            LigneFraisHorsForfait lretour;
            try
            {
                lretour = maConnexion.LigneFraisHorsForfait.Where(x => x.idVisiteur == visiteurChoisi.idVisiteur)
                                                           .Where(x => x.mois == moisChoisi)
                                                           .Where(x => x.id == id).ToList()[0];
            }
            catch (Exception e)
            {
                lretour = null;
            }

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
                fraisChoisi.idFraisForfait = typeFrais;
                fraisChoisi.quantite = qte;
                vretour = true;

                maConnexion.LigneFraisForfait.Add(fraisChoisi);
                maConnexion.SaveChanges();
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
                maConnexion.Dispose();
                init();
            }

            return vretour;
        }

        public static bool modifFrais(int qte, LigneFraisForfait fraisForfait)
        {
            bool vretour = false;

            try
            {
 
                    fraisForfait.quantite = qte;
                    maConnexion.SaveChanges();
                    vretour = true;
               
            }catch(Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
                maConnexion.Dispose();
                vretour = false;
                init();
                
            }

            return vretour;
        }

        public static bool modifHFrais(int qte, DateTime date, string libelle, LigneFraisHorsForfait fraisHorsForfait)
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

        public static bool suppFrais()
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

        public static bool ajoutHorsFrais(string idVi, string mois, string libelle, DateTime date, decimal montant)
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

                Debug.WriteLine(hFraisChoisi.id);

                maConnexion.LigneFraisHorsForfait.Add(hFraisChoisi);
                maConnexion.SaveChanges();
                vretour = true;
            }
            catch (Exception e)
            {

            }


            return vretour;
        }

        public static bool suppHFrais()
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
    }
}
