using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace GSB_TAC
{
    public partial class frmAjoutFrais : Form
    {
        public frmAjoutFrais()
        {
            InitializeComponent();
        }

        private void frmAjoutFrais_Load(object sender, EventArgs e)
        {
            lblInfoVisiteur.Text = string.Format("Visiteur : {0} {1}", Modele.VisiteurChoisi.nom, Modele.VisiteurChoisi.prenom);
            switch (Modele.ActionFrais)
            {
                case 1: lblAction.Text = string.Format("Création d'une note de frais");btnValider.Text = "Ajouter"; bsTypeFrais.DataSource = Modele.listeTypeFraisNonExistant(); break;
                case 2: lblAction.Text = string.Format("Modification d'une note de frais");btnValider.Text = "Modifier"; bsTypeFrais.DataSource = Modele.listeTypeFraisExistant(); break;
            }

            lblLibelleHf.Visible = false;
            txtbLibelleHf.Visible = false;

            lblDate.Visible = false;
            dtpHForfait.Visible = false;


            cboTypeFrais.ValueMember = "id";
            cboTypeFrais.DisplayMember = "libelle";
            cboTypeFrais.DataSource = bsTypeFrais;

        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            if(cboTypeFrais.SelectedValue != null) {
                if(txtbQte.Text != "" && (Regex.IsMatch(txtbQte.Text, @"^[1-9]\d*(,\d+)?$"))) {
                    switch (Modele.ActionFrais)
                    {
                        case 1: //Si on ajoute un frais
                            if (chbxHorsForfait.Checked == true)//Si on ajoute un frais hors forfait
                            {
                                if (txtbLibelleHf.Text != "")
                                {
                                    if (Modele.ajoutHorsFrais(Modele.VisiteurChoisi.idVisiteur, Modele.MoisChoisi, txtbLibelleHf.Text, dtpHForfait.Value, Convert.ToDecimal(txtbQte.Text)))
                                    {
                                        DialogResult = DialogResult.OK;
                                        this.Close();
                                    }
                                }
                                else
                                {
                                    afficheErrerur("Veuillez insérer un libellé");
                                }
                            }
                            else // Si on ajoute un frais normal
                            {
                                int number;
                                if (int.TryParse(txtbQte.Text, out number))
                                {
                                    if (Modele.verifieDonnee(Convert.ToString(cboTypeFrais.SelectedValue), Convert.ToInt32(txtbQte.Text)))
                                    {

                                        if (Modele.addFrais(Modele.VisiteurChoisi.idVisiteur, Modele.MoisChoisi, Convert.ToString(cboTypeFrais.SelectedValue), Convert.ToInt32(txtbQte.Text)))
                                        {
                                            DialogResult = DialogResult.OK;
                                            this.Close();
                                        }
                                    }
                                    else
                                    {
                                        afficheErrerur("La quantité est en dessous/dessus des limites de la catégorie de frais");
                                    }
                                }
                                else
                                {
                                    afficheErrerur("Vous ne pouvez pas ajouter de nombre à virgule");
                                }
                            }
                            break;
                        case 2: //Si on modifie le frais
                            if (chbxHorsForfait.Checked == true) //Si on modifie un frais hors forfait
                            {
                                if (txtbLibelleHf.Text != "")
                                {
                                    if (Modele.modifHFrais(Convert.ToInt32(txtbQte.Text), dtpHForfait.Value, txtbLibelleHf.Text, (Modele.donneFraisHForfait(Convert.ToInt32(cboTypeFrais.SelectedIndex)))))
                                    {
                                        DialogResult = DialogResult.OK;
                                        this.Close();
                                    }
                                }
                                else
                                {
                                    afficheErrerur("Veuillez insérer un libellé");
                                }
                            }
                            else // Si on modifie un frais normal
                            {
                                int number;
                                if (int.TryParse(txtbQte.Text, out number))
                                {
                                    if (Modele.verifieDonnee(Convert.ToString(cboTypeFrais.SelectedValue), Convert.ToInt32(txtbQte.Text)))
                                    {
                                        if (Modele.modifFrais(Convert.ToInt32(txtbQte.Text), Modele.donneFrais(Convert.ToString(cboTypeFrais.SelectedValue))))
                                        {
                                            DialogResult = DialogResult.OK;
                                            this.Close();
                                        }
                                    }
                                    else
                                    {
                                        afficheErrerur("La quantité est en dessous/dessus des limites de la catégorie de frais");
                                    }
                                }
                                else
                                {
                                    afficheErrerur("La quantité est en dessous/dessus des limites de la catégorie de frais");
                                }
                            }
                            break;
                    }
                }
                else
                {
                    afficheErrerur("Quantité invalide, veuillez insérer uniquement un nombre ou un nombre à virgule (uniquement pour les frais hors forfait)");
                }
            }
            else
            {
                afficheErrerur("Veuillez selectionner un frais");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void chbxHorsForfait_CheckedChanged(object sender, EventArgs e)
        {
            string dateChoisie = Modele.MoisChoisi;

            string dateSMin = "01/" + dateChoisie.Substring(4) + "/" + dateChoisie.Substring(0, 4);
            string dateSMax = "31/" + dateChoisie.Substring(4) + "/" + dateChoisie.Substring(0, 4);

            DateTime dateMin = DateTime.Parse(dateSMin);
            DateTime dateMax = DateTime.Parse(dateSMax);

            if (Modele.ActionFrais == 1)//Si on est en mode ajout
            {
                if (chbxHorsForfait.Checked == true) //Si on ajoute un hors forfait
                {
                    changeForm(true, true, true, true, false, "Prix : ");


                    dtpHForfait.MinDate = dateMin;
                    dtpHForfait.MaxDate = dateMax;
                }
                else //Si on ajoute un frais nrml
                {
                    changeForm(false,false,false,false,true,"Quantité : ",Modele.listeTypeFraisNonExistant());

                }
            }
            else // Si on est en mode modification 
            {
                if(Modele.ActionFrais == 2)
                {
                    if (chbxHorsForfait.Checked == true) // Si on modifie un hors forfait
                    {

                        changeForm(true, true, true, true, true, "Prix : ", null, Modele.listeFraisHForfait());

                        dtpHForfait.MinDate = dateMin;
                        dtpHForfait.MaxDate = dateMax;
                    }
                    else // Si on modifie un frais 
                    {

                        changeForm(false, false, false, false, true, "Quantité : ", Modele.listeTypeFraisExistant());
                        txtbQte.Text = "";

                    }
                }
            }
        }

        private void bsTypeFrais_CurrentChanged(object sender, EventArgs e)
        {

            if (Modele.ActionFrais == 2)
                {
                    if (chbxHorsForfait.Checked == true)
                    {
                        if (Modele.listeFraisHForfait().Count != 0)
                        {
                            txtbQte.Text = Convert.ToString(Modele.donneFraisHForfait(((LigneFraisHorsForfait)bsTypeFrais.Current).id).montant);
                            txtbLibelleHf.Text = Convert.ToString(Modele.donneFraisHForfait(((LigneFraisHorsForfait)bsTypeFrais.Current).id).libelle);
                            dtpHForfait.Value = (DateTime)(Modele.donneFraisHForfait(((LigneFraisHorsForfait)bsTypeFrais.Current).id).date);
                        }
                        else
                        {
                        afficheErrerur("Impossible de modifier un frais hors forfait, il en existe aucun.");
                        }
                    }
                else
                {
                    LigneFraisForfait f = new LigneFraisForfait();
                    f = Modele.donneFrais(((FraisForfait)bsTypeFrais.Current).id);

                    txtbQte.Text = Convert.ToString(f.quantite);
                }

                }
        }


        private void changeForm(bool visLibHf, bool vistxtBHf, bool visLblDate, bool visDtpHF, bool enblCbo, string lblQteText, List<FraisForfait> listeFraisForfaits = null, List<LigneFraisHorsForfait> listeFraisHForfaits = null)
        {
            lblLibelleHf.Visible = visLibHf;
            txtbLibelleHf.Visible = vistxtBHf;
            lblDate.Visible = visLblDate;
            dtpHForfait.Visible = visDtpHF;
            cboTypeFrais.Enabled = enblCbo;
            lblQte.Text = lblQteText;
            cboTypeFrais.ValueMember = "id";
            cboTypeFrais.DisplayMember = "libelle";

            if(listeFraisForfaits != null)
            {
                switch (Modele.ActionFrais)
                {
                    case 1:

                        bsTypeFrais.DataSource = listeFraisForfaits;
                        cboTypeFrais.DataSource = bsTypeFrais;
                        break;
                    case 2:
                        bsTypeFrais.DataSource = listeFraisForfaits;
                        cboTypeFrais.DataSource = bsTypeFrais;
                        break;
                }

            }
            if(listeFraisHForfaits != null)
            {
                bsTypeFrais.DataSource =listeFraisHForfaits;
            }
            
        }

        private void afficheErrerur(string msg)
        {
            MessageBoxButtons button = MessageBoxButtons.OK;
            MessageBox.Show(msg, "Erreur", button);
            chbxHorsForfait.Checked = false;
        }


    }
}
