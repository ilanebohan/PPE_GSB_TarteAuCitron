///////////////////////////////////////////////////////////////////////////////////////////
///
///
///
/// Bugs connus : Erreur quand suppression des fiches de frais en live et refresh des données
///
///
///
///////////////////////////////////////////////////////////////////////////////////////////



using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GSB_TAC
{
    public partial class frmRemboursement : Form
    {
        public frmRemboursement()
        {
            InitializeComponent();
        }

        private void frmRemboursement_Load(object sender, EventArgs e)
        {

            lblBvnVisiteur.Text = "Bienvenue " + Modele.VisiteurChoisi.nom + " " + Modele.VisiteurChoisi.prenom + " !"; //Affichage du visiteur

            //Remplissage de la combobox contenant les fiche de frais
            cboDate.ValueMember = "idVisteur";
            cboDate.DisplayMember = "mois";
            bsFicheFrais.DataSource = Modele.listFicheFraisVisiteur();
            cboDate.DataSource = bsFicheFrais;

            if (Modele.listFicheFraisVisiteur().Count == 0) //Si on a aucune fiche de frais on désactive les boutons
            {
                btnAjoutFrais.Enabled = false;
                btnModifF.Enabled = false;
                btnSuppFraisHf.Enabled = false;
                btnSuppFraisKm.Enabled = false;
                btnSuppFraisN.Enabled = false;
            }

        }

        private void bsFicheFrais_CurrentChanged(object sender, EventArgs e)
        {
            //Console.WriteLine(cboDate.SelectedIndex);
            if (Modele.listFicheFraisVisiteur().Count != 0/* && cboDate.SelectedIndex != -1*/)
            { //Si il existe au moins 1 fiche de frais pour le visteur

                //On definit le mois de la fiche de frais pour pouvoir l'utiliser plus tard
                Modele.MoisChoisi = ((fichefrais)bsFicheFrais.Current).mois;


               
                string idEtat = Modele.donneFicheFrais(Modele.MoisChoisi).idEtat; //Récupération de l'id l'état de la fiche de frais
                string statusFicheFrais = Modele.donneEtat(idEtat).libelle; //Récupération du libelle de l'état de la fiche de frais avec l'id de celui-ci

                txtBStatus.Text = statusFicheFrais;

                if (idEtat == "CR") //Si la fiche de frais est libre à la modification on active les boutons
                {
                    btnAjoutFrais.Enabled = true;
                    btnModifF.Enabled = true;
                    btnSuppFraisHf.Enabled = true;
                    btnSuppFraisKm.Enabled = true;
                    btnSuppFraisN.Enabled = true;

                    if (Modele.listeFraisHForfait().Count == 0 && Modele.listeLigneFrais().Count == 0) //Si il n'y a pas de frais, on désactive le bouton de modification, sinon on l'active
                    {
                        btnModifF.Enabled = false;
                    }
                    else
                    {
                        btnModifF.Enabled = true;
                    }
                }
                else //Si la fiche de frais est cloturé, on désactive les boutons
                {
                    btnAjoutFrais.Enabled = false;
                    btnModifF.Enabled = false;
                    btnSuppFraisHf.Enabled = false;
                    btnSuppFraisKm.Enabled = false;
                    btnSuppFraisN.Enabled = false;
                }

                
                //Remplissage de la datagridview des frais non kilométrique par ceux de la BDD + modification affichage des colonnes//
                bsLigneFraisForfait.DataSource = Modele.listeLigneFrais(1); //Remplissage de la binding source des frais non kilométrique
                dgvFrais.DataSource = bsLigneFraisForfait;
                try
                {
                    dgvFrais.Columns[0].Visible = false;
                    dgvFrais.Columns[1].Visible = false;
                    dgvFrais.Columns[4].Visible = false;
                    dgvFrais.Columns[5].Visible = false;
                    dgvFrais.Columns[2].HeaderText = "Type de frais";
                    dgvFrais.Columns[3].HeaderText = "Quantité";
                }
                catch { }
                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                
                ///////////Calcul et affichage du total monétaire des frais normaux non kilométrique///////////
                decimal totNrml = 0;
                foreach (LigneFraisForfait frais in bsLigneFraisForfait)
                {
                    totNrml += (decimal)(frais.quantite * frais.FraisForfait.montant);
                }
                txtBFNrml.Text = Convert.ToString(totNrml);
                ///////////////////////////////////////////////////////////////////////////////////////////////




                //Remplissage de la datagridview des frais kilométrique par ceux de la BDD + modification affichage des colonnes//
                bsKm.DataSource = Modele.listeLigneFrais(2); //Remplissage de la binding source des frais kilométrique
                dgvKm.DataSource = bsKm;
                try
                {
                    dgvKm.Columns[0].Visible = false;
                    dgvKm.Columns[1].Visible = false;
                    dgvKm.Columns[4].Visible = false;
                    dgvKm.Columns[5].Visible = false;
                    dgvKm.Columns[2].HeaderText = "Code de Frais";
                    dgvKm.Columns[3].HeaderText = "Quantité";
                }
                catch { }
                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////


                ///////////Calcul et affichage du total monétaire des frais normaux kilométrique///////////
                decimal totFKm = 0;
                foreach (LigneFraisForfait frais in bsKm)
                {
                    totFKm += (decimal)(frais.quantite * frais.FraisForfait.montant);
                }
                txtBTotalFKm.Text = Convert.ToString(totFKm);
                //////////////////////////////////////////////////////////////////////////////


                //Remplissage de la datagridview des hors forfait par ceux de la BDD + modification affichage des colonnes//
                bsLigneFraisHForfait.DataSource = Modele.listeFraisHForfait(); //Remplissage de la binding source des frais gors forfait
                dgvFraisHForfait.DataSource = bsLigneFraisHForfait;
                try
                {
                    dgvFraisHForfait.Columns[0].Visible = false;
                    dgvFraisHForfait.Columns[1].Visible = false;
                    dgvFraisHForfait.Columns[2].Visible = false;
                    dgvFraisHForfait.Columns[6].Visible = false;

                    dgvFraisHForfait.Columns[3].HeaderText = "Libellé du frais";
                    dgvFraisHForfait.Columns[4].HeaderText = "Date du frais";
                    dgvFraisHForfait.Columns[5].HeaderText = "Montant du frais";


                }
                catch { }
                ////////////////////////////////////////////////////////////////////////////////////////////////////////////
                

                ///////////Calcul du total monétaire des frais hors forfait///////////
                decimal totHFrais = 0;
                foreach (LigneFraisHorsForfait frais in bsLigneFraisHForfait)
                {
                    totHFrais += (decimal)(frais.montant);
                }
                txtBTotalHFrais.Text = Convert.ToString(totHFrais);
                //////////////////////////////////////////////////////////////////////

                
                txtBToGene.Text = Convert.ToString(totNrml + totFKm + totHFrais); // Calcul + affichage du total final

                //Si on a aucun frais hors km de selectionné, on affiche rien sur le détail des frais
                if (bsLigneFraisForfait.Current == null)
                {
                    lblChoixFNrml.Text = "";
                    lblMontantNrml.Text = "";
                }

                //Si on a aucun frais km de selectionné, on affiche rien sur le détail des frais
                if (bsKm.Current == null)
                {
                    lblLibeFraiKm.Text = "";
                    lblMontantKM.Text = "";
                }
            }
        }

        private void btnAjoutFrais_Click(object sender, EventArgs e) //Lorsque qu'on appuit sur le bouton "Ajouter"
        {
            Modele.ActionFrais = 1; //L'action devient Ajouter
            Modele.MoisChoisi = ((fichefrais)bsFicheFrais.Current).mois; //On definit le mois de la fiche de frais pour l'ajout
            frmAjoutFrais faf = new frmAjoutFrais(); //On ouvre le formulaire d'ajout/modif
            if (faf.ShowDialog() == DialogResult.OK) //Si le formulaire renvois un ok, on rafraichis les frais
            {
                bsFicheFrais_CurrentChanged(new object(), new EventArgs());
            }

        }

        private void btnSuppFrais_Click(object sender, EventArgs e) //Lorsque qu'on appuit sur le bouton "Supprimer" des frais normaux non km
        {
            List<LigneFraisForfait> frais = Modele.listeLigneFrais(1); //On selectionne les frais non km
            if (frais.Count() > 0) //Si il existe bien 1 ou + de frais
            {
                //On selectionne le frais que l'on veut supprimer via son id
                Type type = bsLigneFraisForfait.Current.GetType();
                //string idVisi = (string)type.GetProperty("idVisiteur").GetValue(bsLigneFraisForfait.Current, null);
                string idFrais = (string)type.GetProperty("idFraisForfait").GetValue(bsLigneFraisForfait.Current, null);
                //string mois = (string)type.GetProperty("mois").GetValue(bsLigneFraisForfait.Current, null);

                Modele.FraisChoisi = Modele.donneFrais(idFrais);
                
                //On demande confirmation de la suppression du frais
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                string message = string.Format("Voulez vous vraiment supprimer cet ligne ?");
                DialogResult result;
                result = MessageBox.Show(message, "Confirmation", buttons);
                if (result == System.Windows.Forms.DialogResult.Yes) //Si l'utilisateur confirme, on le supprime via la fonction dans Modele
                {
                    Modele.suppFrais();
                    bsFicheFrais_CurrentChanged(new object(), new EventArgs()); //On refresh l'affichage la fiche de frais
                }
            }
            else //Si il n'y a pas de frais on affiche un message d'erreur
            {
                MessageBoxButtons button = MessageBoxButtons.OK;
                string msg = string.Format("Suppression impossible, aucun entrée disponible ");
                MessageBox.Show(msg, "Erreur", button);
            }

        }



        private void btnRefresh_Click(object sender, EventArgs e) //Lorsque qu'on clicque le bouton rafraichir 
        {
            bsFicheFrais_CurrentChanged(new object(), new EventArgs());//On rafraichis d'abord la fiche de frais selectionner
            //frmRemboursement_Load(new object(), new EventArgs());

            bsFicheFrais.DataSource = Modele.listFicheFraisVisiteur(); //On re-remplit la combobox des fiches de frais
            cboDate.DataSource = bsFicheFrais;

            if (Modele.listFicheFraisVisiteur().Count != 0) //Si il y a + d'une fiche de frais, on selectionne la première
            {
                cboDate.SelectedIndex = 0;
            }
            else //Sinon, on selectionne rien, on vide les datagridviews et on désactive les boutons
            {
                cboDate.SelectedIndex = -1;
                dgvFrais.Rows.Clear();
                dgvFrais.Refresh();
                dgvFraisHForfait.Rows.Clear();
                dgvFraisHForfait.Refresh();
                dgvKm.Rows.Clear();
                dgvKm.Refresh();

                btnAjoutFrais.Enabled = false;
                btnModifF.Enabled = false;
                btnSuppFraisHf.Enabled = false;
                btnSuppFraisKm.Enabled = false;
                btnSuppFraisN.Enabled = false;
                txtBStatus.Text = "";
            }

        }

        private void btnSuppFraisKm_Click(object sender, EventArgs e) //Lorsqu'on clique sur le bouton "Supprimer" des frais kilométriques
        {

            List<LigneFraisForfait> frais = Modele.listeLigneFrais(2); //On récupère tous les frais kilométriques

            if (frais.Count() != 0) //Si il y a au moins 1 frais kilométrique, on récupère celui selectionner
            {

                Type type = bsKm.Current.GetType();

                //string idVisi = (string)type.GetProperty("idVisiteur").GetValue(bsKm.Current, null);
                string idFrais = (string)type.GetProperty("idFraisForfait").GetValue(bsKm.Current, null);
                //string mois = (string)type.GetProperty("mois").GetValue(bsKm.Current, null);

                Modele.FraisChoisi = Modele.donneFrais(idFrais);

                //On demande une confirmation de suppression
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                string message = string.Format("Voulez vous vraiment supprimer cet ligne ?");
                DialogResult result;
                result = MessageBox.Show(message, "Confirmation", buttons);
                if (result == System.Windows.Forms.DialogResult.Yes) //Si l'utilisateur confirme, on supprime le frais km choisi via la fonction dans Modele
                {
                    Modele.suppFrais();
                    bsFicheFrais_CurrentChanged(new object(), new EventArgs()); //On rafraichis l'affichage de fiche de frais
                }
            }
            else //Si il n'y a pas de frais km, on affiche un message d'erreur
            {
                MessageBoxButtons button = MessageBoxButtons.OK;
                string msg = string.Format("Suppression impossible, aucune entrée disponible ");
                MessageBox.Show(msg, "Erreur", button);
            }
        }

        private void btnSuppFraisHf_Click(object sender, EventArgs e) //Lorsque qu'on clique sur "Supprimer" des frais hors forfait
        {

            if (bsLigneFraisHForfait.Current != null) //Si on en a bien selectionner un, on le récupère via son ID 
            {

                Type type = bsLigneFraisHForfait.Current.GetType();
                int id = (int)type.GetProperty("id").GetValue(bsLigneFraisHForfait.Current, null);

                Modele.HFraisChoisi = Modele.donneFraisHForfait(id);

                //On demande une confirmation de suppresion 
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                string message = string.Format("Voulez-vous vraiment supprimer cette ligne ?");
                DialogResult result;
                result = MessageBox.Show(message, "Confirmation", buttons);
                if (result == System.Windows.Forms.DialogResult.Yes) // Si l'utilisateur valide, on le supprime via la fonction dans Modele
                {
                    Modele.suppHFrais();
                    bsFicheFrais_CurrentChanged(new object(), new EventArgs()); //On rafraichit l'affichage de la fiche de frais
                }
            }
            else
            {
                MessageBoxButtons button = MessageBoxButtons.OK;
                string msg = string.Format("Suppression impossible, aucune entrée disponible ");
                MessageBox.Show(msg, "Erreur", button);

            }
        }

        private void bsLigneFraisForfait_CurrentChanged(object sender, EventArgs e)//Lorsque qu'on sélectionne un frais hors km
        {
            if (Modele.listeLigneFrais(1).Count != 0)//Si il existe au moins un frais, on affiche les infos lié au type du frais en bas du datagridview (Nom, prix unitaire)
            {
                lblChoixFNrml.Text = Modele.donneTypeFrais(((LigneFraisForfait)bsLigneFraisForfait.Current).idFraisForfait).libelle;
                lblMontantNrml.Text = Convert.ToString(Modele.donneTypeFrais(((LigneFraisForfait)bsLigneFraisForfait.Current).idFraisForfait).montant);
            }
        }

        private void bsKm_CurrentChanged(object sender, EventArgs e)//Lorsque qu'on sélectionne un frais km
        {
            if (Modele.listeLigneFrais(2).Count != 0)//Si il existe au moins un frais, on affiche les infos lié au type du frais en bas du datagridview (Nom, prix unitaire)
            {
                lblLibeFraiKm.Text = Modele.donneTypeFrais(((LigneFraisForfait)bsKm.Current).idFraisForfait).libelle;
                lblMontantKM.Text = Convert.ToString(Modele.donneTypeFrais(((LigneFraisForfait)bsKm.Current).idFraisForfait).montant);
            }
        }

        private void btnModifF_Click(object sender, EventArgs e)//Lorsque qu'on appuit sur le bouton "Modifier"
        {
            Modele.ActionFrais = 2; //On Définit le mode du formAjoutFrais en modification
            Modele.MoisChoisi = ((fichefrais)bsFicheFrais.Current).mois;//On selectionne la fiche de frais
            frmAjoutFrais faf = new frmAjoutFrais(); //On ouvre le formAjoutFrais
            if (faf.ShowDialog() == DialogResult.OK)
            {
                bsFicheFrais_CurrentChanged(new object(), new EventArgs()); //Si le form renvois un ok, on rafraichit l'affichage de la fiche de frais
            }
        }
    }
}
