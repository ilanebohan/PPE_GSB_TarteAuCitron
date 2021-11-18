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
                case 1: lblAction.Text = string.Format("Création d'une note de frais");btnValider.Text = "Ajouter";break;
                case 2: lblAction.Text = string.Format("Modification d'une note de frais");btnValider.Text = "Modifier";chbxHorsForfait.Visible=false; bsTypeFrais.DataSource = Modele.listeTypeFraisExistant(); break;
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
            if (chbxHorsForfait.Checked == false)
            {
      
                Modele.FraisChoisi = Modele.donneFrais(Modele.VisiteurChoisi.idVisiteur, Modele.MoisChoisi, Convert.ToString(cboTypeFrais.SelectedValue));

                if (Modele.FraisChoisi == null)
                {
                    if (Modele.addFrais(Modele.VisiteurChoisi.idVisiteur, Modele.MoisChoisi, Convert.ToString(cboTypeFrais.SelectedValue), Convert.ToInt32(txtbQte.Text)))
                    {
                        DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
                else
                {
                    Modele.modifFrais(Convert.ToInt32(txtbQte.Text));
                    DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            else
            {
                if(Modele.ajoutHorsFrais(Modele.VisiteurChoisi.idVisiteur, Modele.MoisChoisi, Convert.ToString(txtbLibelleHf.Text), dtpHForfait.Value, Convert.ToInt32(txtbQte.Text)))
                {
                    DialogResult = DialogResult.OK;
                    this.Close();
                }

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void chbxHorsForfait_CheckedChanged(object sender, EventArgs e)
        {
            if (chbxHorsForfait.Checked == true)
            {
                lblLibelleHf.Visible = true;
                txtbLibelleHf.Visible = true;
                lblDate.Visible = true;
                dtpHForfait.Visible = true;
                cboTypeFrais.Enabled = false;
                lblQte.Text = "Prix :";
            }
            else
            {
                lblLibelleHf.Visible = false;
                txtbLibelleHf.Visible = false;
                lblDate.Visible = false;
                dtpHForfait.Visible = false;
                cboTypeFrais.Enabled = true;
                lblQte.Text = "Quantité : ";
            }
        }

        private void bsTypeFrais_CurrentChanged(object sender, EventArgs e)
        {
            if (Modele.ActionFrais == 2)
            {
                txtbQte.Text = Convert.ToString(((FraisForfait)bsTypeFrais.Current).LigneFraisForfait.Select(x => x.quantite).ToList()[0]);
            }
        }
    }
}
