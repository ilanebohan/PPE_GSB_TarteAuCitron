using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GSB_TAC
{
    public partial class frmM1 : Form
    {
        public frmM1()
        {
            InitializeComponent();
        }

        private void frmM1_Load(object sender, EventArgs e)
        {
            lblInfos.Text = "Bienvenue " + Modele.UtilisateurConnecte.prenom + " " + Modele.UtilisateurConnecte.nom;
            lblLabo.Text = "Labo : " + Modele.UtilisateurConnecte.Laboratoire.nomLabo;


            if (Modele.isResponsablesecteur(Modele.UtilisateurConnecte.idVisiteur))
            { 
                lblSecteur.Visible = true;
                lblSecteur.Text = "Secteur Géré : " + Modele.SecteurGerer.libSecteur;
                gestionSecteursToolStripMenuItem.Visible = true;
            }
            if (Modele.isResponsableregion(Modele.UtilisateurConnecte.idVisiteur))
            {
                gestionRégionsToolStripMenuItem.Visible = true;
                lblRegion.Visible = true;
                lblRegion.Text = "Régions gérées : ";
                dgvRegions.Visible = true;
                bsRegion.DataSource = Modele.listeregion().Where(x => x.idVisiteur == Modele.UtilisateurConnecte.idVisiteur);
                dgvRegions.DataSource = bsRegion;
                dgvRegions.Columns[0].Visible = false;
                dgvRegions.Columns[1].Visible = false;
                dgvRegions.Columns[2].Visible = false;
                dgvRegions.Columns[3].Visible = false;
                dgvRegions.Columns[5].Visible = false;

            }

            /* if (Modele.isResponsablelabo(Modele.UtilisateurConnecte.idVisiteur))
             {
                gestionLaboGSBToolStripMenuItem.Visible = true;
                
             }*/

        }
        private void button1_Click(object sender, EventArgs e)
        {
            lblNouveaunom.Visible = true;
            lblNouveauprenom.Visible = true;
            txtNouveaunom.Visible = true;
            txtNouveauprenom.Visible = true;
            btnChangementinfos.Visible = true;
        }

        private void budgetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form maForm = new frmBudget();
            maForm.Show();

        }

        private void visiteursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form maForm = new frmVisiteurs();
            maForm.Show();
        }

        private void gestionSecteursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form maForm = new frmGestionsecteur();
            maForm.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void gestionRégionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form maform = new frmGestionregion();
            maform.Show();
        }

        private void btnChangementinfos_Click(object sender, EventArgs e)
        {
            Modele.ModifUtilisateur(txtNouveaunom.Text, txtNouveauprenom.Text);
        }

        private void gestionLaboGSBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form maform = new frmGestionlabo();
            maform.Show();
        }
    }
}
