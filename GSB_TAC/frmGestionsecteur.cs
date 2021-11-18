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
    public partial class frmGestionsecteur : Form
    {
        public frmGestionsecteur()
        {
            InitializeComponent();
        }
        private void frmGestionsecteur_Load(object sender, EventArgs e)
        {
            lblSecteurgerer.Text = "Secteur géré : " + Modele.SecteurGerer.libSecteur;
            bsRegion.DataSource = Modele.listeregion().Where(x => x.idSecteur == Modele.SecteurGerer.idSecteur);
            dgvRegion.DataSource = bsRegion;
            dgvRegion.Columns[0].Visible = false;
            dgvRegion.Columns[1].Visible = false;
            dgvRegion.Columns[2].Visible = false;
            dgvVisiteur.Columns[0].Visible = false;
            dgvVisiteur.Columns[1].Visible = false;

        }
        private void bsRegion_CurrentChanged(object sender, EventArgs e)
        {
            lblRespreg.Text = "Responsable de la région : " + ((Region)bsRegion.Current).Visiteur.nom + " " + ((Region)bsRegion.Current).Visiteur.prenom;
            bsVisiteur.DataSource = ((Region)bsRegion.Current).Visiteur1.ToList();
            dgvVisiteur.DataSource = bsVisiteur;
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            System.Type type = bsRegion.Current.GetType();
            int id = (int)type.GetProperty("idRegion").GetValue(bsRegion.Current, null);
            Modele.RegionChoisie = Modele.trouveregionbyid(id);

            System.Type typeVis = bsVisiteur.Current.GetType();
            string idVis = (string)typeVis.GetProperty("idVisiteur").GetValue(bsVisiteur.Current, null);
            Modele.VisiteurChoisi = Modele.trouvevisiteurbyid(idVis);





            if (Modele.ModifRegion(Modele.RegionChoisie.libRegion, Modele.VisiteurChoisi.idVisiteur))
            { 
            Modele.ModifRegion(Modele.RegionChoisie.libRegion, Modele.VisiteurChoisi.idVisiteur);
            MessageBox.Show("Modification effectuée !");
            bsRegion_CurrentChanged(new Object(), new EventArgs());
            bsRegion.DataSource = Modele.listeregion().Where(x => x.idSecteur == Modele.SecteurGerer.idSecteur);
            dgvRegion.DataSource = bsRegion;
            }
            else if (!Modele.ModifRegion(Modele.RegionChoisie.libRegion, Modele.VisiteurChoisi.idVisiteur))
            {
                MessageBox.Show("Désolé, mais cet utilisateur est déjà chef de la région choisie");
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            System.Type typeVis = bsVisiteur.Current.GetType();
            string idVis = (string)typeVis.GetProperty("idVisiteur").GetValue(bsVisiteur.Current, null);
            Modele.VisiteurChoisi = Modele.trouvevisiteurbyid(idVis);
            Form maform = new frmLicenciement();
            maform.ShowDialog();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            System.Type typeVis = bsVisiteur.Current.GetType();
            string idVis = (string)typeVis.GetProperty("idVisiteur").GetValue(bsVisiteur.Current, null);
            Modele.VisiteurChoisi = Modele.trouvevisiteurbyid(idVis);

            if (Modele.ActiverVisiteur())
            {
                MessageBox.Show("Activation réussie !");
            }
            else if (!Modele.ActiverVisiteur())
            {
                MessageBox.Show("Erreur : Impossible d'activer un utilisateur déjà actif");
            }
            bsRegion_CurrentChanged(new Object(), new EventArgs());
            
        }
        private void button2_Click(object sender, EventArgs e)
        {
            System.Type typeVis = bsVisiteur.Current.GetType();
            string idVis = (string)typeVis.GetProperty("idVisiteur").GetValue(bsVisiteur.Current, null);
            Modele.VisiteurChoisi = Modele.trouvevisiteurbyid(idVis);

            if (Modele.DesactiverVisiteur())
            {
                MessageBox.Show("Désactivation réussie !");
            }
            else if (!Modele.DesactiverVisiteur())
            {
                MessageBox.Show("Erreur : Impossible de désactiver un utilisateur qui est déjà inactif");
            }
            bsRegion_CurrentChanged(new Object(), new EventArgs());
        }
 
    }
}
