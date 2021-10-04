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
            string mois = ((fichefrais)bsFicheFrais.Current).mois;
            bsLigneFraisForfait.DataSource = Modele.listeFraisMois(mois);
            dgvFrais.DataSource = bsLigneFraisForfait;
            dgvFrais.Columns[0].Visible = false;
            dgvFrais.Columns[1].Visible = false;
            dgvFrais.Columns[2].HeaderText = "Type de frais";
            dgvFrais.Columns[4].Visible = false;
            dgvFrais.Columns[5].Visible = false;
        }
    }
}
