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
    public partial class frmRemboursement : Form
    {
        public frmRemboursement()
        {
            InitializeComponent();
        }

        private void frmRemboursement_Load(object sender, EventArgs e)
        {
            lblBvnVisiteur.Text = "Bienvenue " + Modele.VisiteurChoisi.nom + " " + Modele.VisiteurChoisi.prenom + " !";

            cboDate.ValueMember = "idVisteur";
            cboDate.DisplayMember = "mois";
            bsFicheFrais.DataSource = Modele.listFicheFraisVisiteur();
            cboDate.DataSource = bsFicheFrais;

        }

        private void bsFicheFrais_CurrentChanged(object sender, EventArgs e)
        {
            Modele.MoisChoisi = ((fichefrais)bsFicheFrais.Current).mois;
            bsLigneFraisForfait.DataSource = Modele.listeLigneFrais(1);
            dgvFrais.DataSource = bsLigneFraisForfait;
            try
            {
                dgvFrais.Columns[0].Visible = false;
                dgvFrais.Columns[1].Visible = false;
                dgvFrais.Columns[4].Visible = false;
                dgvFrais.Columns[5].Visible = false;
                dgvFrais.Columns[2].HeaderText = "Code de Frais";
                dgvFrais.Columns[3].HeaderText = "Type de Frais";
            }
            catch { }
            bsKm.DataSource = Modele.listeLigneFrais(2);

            dgvKm.DataSource = bsKm;
            try
            {
                dgvKm.Columns[0].Visible = false;
                dgvKm.Columns[1].Visible = false;
                dgvKm.Columns[4].Visible = false;
                dgvKm.Columns[5].Visible = false;
                dgvKm.Columns[2].HeaderText = "Code de Frais";
                dgvKm.Columns[3].HeaderText = "Type de Frais";
            }
            catch { }

            bsLigneFraisHForfait.DataSource = Modele.listeFraisHForfait();
            dgvFraisHForfait.DataSource = bsLigneFraisHForfait;

            try
            {
                dgvFraisHForfait.Columns[1].Visible = false;
                dgvFraisHForfait.Columns[2].Visible = false;
                dgvFraisHForfait.Columns[6].Visible = false;
            }
            catch { }


        }

        private void btnAjoutFrais_Click(object sender, EventArgs e)
        {
            Modele.ActionFrais = 1;
            Modele.MoisChoisi = ((fichefrais)bsFicheFrais.Current).mois;
            frmAjoutFrais faf = new frmAjoutFrais();
            if (faf.ShowDialog() == DialogResult.OK)
            {
                bsFicheFrais_CurrentChanged(new object(), new EventArgs());
            }

        }

        private void btnSuppFrais_Click(object sender, EventArgs e)
        {
            List<LigneFraisForfait> frais = Modele.listeLigneFrais(1);
            if (frais.Count() > 0)
            {
                Type type = bsLigneFraisForfait.Current.GetType();
                string idVisi = (string)type.GetProperty("idVisiteur").GetValue(bsLigneFraisForfait.Current, null);
                string idFrais = (string)type.GetProperty("idFraisForfait").GetValue(bsLigneFraisForfait.Current, null);
                string mois = (string)type.GetProperty("mois").GetValue(bsLigneFraisForfait.Current, null);

                Modele.FraisChoisi = Modele.donneFrais(idVisi, mois, idFrais);

                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                string message = string.Format("Voulez vous vraiment supprimer cet ligne ?");
                DialogResult result;
                result = MessageBox.Show(message, "Confirmation", buttons);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    Modele.suppFrais();
                    bsFicheFrais_CurrentChanged(new object(), new EventArgs());
                }
            }
            else
            {
                MessageBoxButtons button = MessageBoxButtons.OK;
                string msg = string.Format("Suppression impossible, aucun entrée disponible ");
                MessageBox.Show(msg, "Erreur", button);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Modele.ActionFrais = 2;
            Modele.MoisChoisi = ((fichefrais)bsFicheFrais.Current).mois;
            frmAjoutFrais faf = new frmAjoutFrais();
            faf.Show();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            bsFicheFrais_CurrentChanged(new object(), new EventArgs());
        }

        private void btnSuppFraisKm_Click(object sender, EventArgs e)
        {

            List<LigneFraisForfait> frais = Modele.listeLigneFrais(2);

            if (frais.Count() != 0)
            {

                Type type = bsKm.Current.GetType();

                string idVisi = (string)type.GetProperty("idVisiteur").GetValue(bsKm.Current, null);
                string idFrais = (string)type.GetProperty("idFraisForfait").GetValue(bsKm.Current, null);
                string mois = (string)type.GetProperty("mois").GetValue(bsKm.Current, null);

                Modele.FraisChoisi = Modele.donneFrais(idVisi, mois, idFrais);

                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                string message = string.Format("Voulez vous vraiment supprimer cet ligne ?");
                DialogResult result;
                result = MessageBox.Show(message, "Confirmation", buttons);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    Modele.suppFrais();
                    bsFicheFrais_CurrentChanged(new object(), new EventArgs());
                }
            }
            else
            {
                MessageBoxButtons button = MessageBoxButtons.OK;
                string msg = string.Format("Suppression impossible, aucune entrée disponible ");
                MessageBox.Show(msg, "Erreur", button);
            }
        }

        private void btnSuppFraisHf_Click(object sender, EventArgs e)
        {

            if (bsLigneFraisHForfait.Current != null)
            {

                Type type = bsLigneFraisHForfait.Current.GetType();
                int id = (int)type.GetProperty("id").GetValue(bsLigneFraisHForfait.Current, null);

                    Modele.HFraisChoisi = Modele.donneFraisHForfait(id);

                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    string message = string.Format("Voulez-vous vraiment supprimer cette ligne ?");
                    DialogResult result;
                    result = MessageBox.Show(message, "Confirmation", buttons);
                    if (result == System.Windows.Forms.DialogResult.Yes)
                    {
                        Modele.suppHFrais();
                        bsFicheFrais_CurrentChanged(new object(), new EventArgs());
                    }
            }
            else
            {
               MessageBoxButtons button = MessageBoxButtons.OK;
               string msg = string.Format("Suppression impossible, aucune entrée disponible ");
               MessageBox.Show(msg, "Erreur", button);
               
            }
        }
    }
}
