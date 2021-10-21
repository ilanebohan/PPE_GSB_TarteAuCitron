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
    public partial class frmGestionlabo : Form
    {
        public frmGestionlabo()
        {
            InitializeComponent();
        }
        private void frmGestionlabo_Load(object sender, EventArgs e)
        {
            bsSecteur.DataSource = Modele.listesecteur();
            dgvSecteur.DataSource = bsSecteur;
            bsVisiteur.DataSource = Modele.listevisiteur();
            dgvVisiteur.DataSource = bsVisiteur;
        }
        private void bsSecteur_CurrentChanged(object sender, EventArgs e)
        {
            bsVisiteur.DataSource = Modele.listevisiteur().Where(x => x.Secteur.Contains(bsSecteur.Current));
            dgvVisiteur.DataSource = bsVisiteur;
            lblRespsect.Text = ((Secteur)bsSecteur.Current).Visiteur.nom + "" + ((Secteur)bsSecteur.Current).Visiteur.prenom;
        }
        private void btnActiver_Click(object sender, EventArgs e)
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


            bsSecteur_CurrentChanged(new Object(), new EventArgs());
        }
        private void btnDesactiver_Click(object sender, EventArgs e)
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
            bsSecteur_CurrentChanged(new Object(), new EventArgs());
        }

        private void button1_Click(object sender, EventArgs e)
        {

            System.Type typeVis = bsVisiteur.Current.GetType();
            string idVis = (string)typeVis.GetProperty("idVisiteur").GetValue(bsVisiteur.Current, null);
            Modele.VisiteurChoisi = Modele.trouvevisiteurbyid(idVis);

            System.Type typeSec = bsSecteur.Current.GetType();
            int idSec = (int)typeSec.GetProperty("idSecteur").GetValue(bsSecteur.Current, null);
            Modele.SecteurChoisi = Modele.trouvesecteurbyid(idSec);

            Modele.ModifSecteur(Modele.SecteurChoisi.libSecteur, Modele.VisiteurChoisi.idVisiteur);
            MessageBox.Show("Modification effectuée !");
        }

        private void btnToutvisiteur_Click(object sender, EventArgs e)
        {
            bsVisiteur.DataSource = Modele.listevisiteur();
            dgvVisiteur.DataSource = bsVisiteur;
        }
    }
}
