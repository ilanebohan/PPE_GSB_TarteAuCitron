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



            lblSecteur.Visible = true;
            lblSecteur.Text = "Secteur : " + Modele.UtilisateurConnecte.Secteur.Select(x => x.libSecteur).ToString();
            //Modele.UtilisateurConnecte.idVisiteur.ToString() == Modele.UtilisateurConnecte.Secteur.Select( x => x.idVisiteur).ToString()
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
            //maForm.MdiParent = this;
            maForm.Show();
        }
    }
}
