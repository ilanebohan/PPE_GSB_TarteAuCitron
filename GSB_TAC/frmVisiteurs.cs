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
    public partial class frmVisiteurs : Form
    {
        public frmVisiteurs()
        {
            InitializeComponent();
        }
        private void frmVisiteurs_Load(object sender, EventArgs e)
        {
            cboSecteur.ValueMember = "idSecteur";
            cboSecteur.DisplayMember = "libSecteur";
            bsSecteur.DataSource = Modele.listesecteur();
            cboSecteur.DataSource = bsSecteur;
        }
        private void bsSecteur_CurrentChanged(object sender, EventArgs e)
        {
            bsRegion.DataSource = ((Secteur)bsSecteur.Current).Region.ToList();
            dgvRegion.DataSource = bsRegion;
            lblRespsecteur.Text = "Reponsable du secteur : " + ((Secteur)bsSecteur.Current).Visiteur.prenom + " " + ((Secteur)bsSecteur.Current).Visiteur.nom;
            dgvRegion.Columns[0].Visible = false;
            dgvRegion.Columns[2].Visible = false;
            dgvRegion.Columns[3].Visible = false;
            dgvRegion.Columns[4].Visible = false;
            dgvRegion.Columns[5].Visible = false;
            dgvRegion.Columns[6].Visible = false;
        }
        private void bsRegion_CurrentChanged(object sender, EventArgs e)
        {
           

            if (((Region)bsRegion.Current).Visiteur1.Count > 0)
            {
                bsVisiteur.DataSource = ((Region)bsRegion.Current).Visiteur1;
                dgvVisiteur.DataSource = bsVisiteur;
                lblRespregion.Text = "Responsable de la région : " + ((Region)bsRegion.Current).Visiteur.prenom + " " + ((Region)bsRegion.Current).Visiteur.nom;


                dgvVisiteur.Visible = true;
                lblPasdevisiteur.Visible = false;

                dgvVisiteur.Columns[0].Visible = false;
            dgvVisiteur.Columns[1].Visible = false;
            dgvVisiteur.Columns[2].Visible = false;
            dgvVisiteur.Columns[3].Visible = false;
            dgvVisiteur.Columns[4].Visible = false;
            dgvVisiteur.Columns[5].Visible = false;
            dgvVisiteur.Columns[6].Visible = false;
            dgvVisiteur.Columns[7].Visible = false;
            dgvVisiteur.Columns[14].Visible = false;
            dgvVisiteur.Columns[15].Visible = false;
            }
            else if (((Region)bsRegion.Current).Visiteur1.Count == 0)
            {
                dgvVisiteur.Visible = false;
                lblPasdevisiteur.Visible = true;

                if (((Region)bsRegion.Current).Visiteur == null)
                { 
                lblRespregion.Text = "Aucun responsable de région !";
                }
                else if (((Region)bsRegion.Current).Visiteur != null)
                {
                    lblRespregion.Text = "Responsable de la région : " + ((Region)bsRegion.Current).Visiteur.prenom + " " + ((Region)bsRegion.Current).Visiteur.nom;
                }
            }
        }

    }
}
