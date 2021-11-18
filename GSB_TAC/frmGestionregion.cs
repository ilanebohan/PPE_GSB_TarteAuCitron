using System;
using System.Linq;
using System.Windows.Forms;

namespace GSB_TAC
{
    public partial class frmGestionregion : Form
    {
        public frmGestionregion()
        {
            InitializeComponent();
        }

        private void frmGestionregion_Load(object sender, EventArgs e)
        {
            bsLabo.DataSource = Modele.listelabo();
            cboLabo.DataSource = bsLabo;
            bsRegion.DataSource = Modele.listeregion();
            dgvRegion.DataSource = bsRegion;
            cboLabo.ValueMember = "idLabo";//permet de stocker l'identifiant
            cboLabo.DisplayMember = "nomLabo";
            dgvRegion.Columns[0].Visible = false;
        }

        private void btnCreatenew_Click(object sender, EventArgs e)
        {

            if (!tests()) return;
            System.Type type = bsRegion.Current.GetType();
            int id = (int)type.GetProperty("idRegion").GetValue(bsRegion.Current, null);
            Modele.RegionChoisie = Modele.trouveregionbyid(id);


            System.Type typeLab = bsLabo.Current.GetType();
            int idLab = (int)typeLab.GetProperty("idLabo").GetValue(bsLabo.Current, null);
            Modele.LaboChoisi = Modele.trouvelabobyid(idLab);

            if (Modele.RegionChoisie.idVisiteur == Modele.UtilisateurConnecte.idVisiteur)
            { 
                Modele.AjoutVisiteur(txtNewid.Text, txtNewnom.Text, txtNewprenom.Text, txtNewrue.Text, txtNewcp.Text, txtNewVille.Text, dateEmbauche.Text, txtNewidentifiant.Text, txtNewpass.Text, Modele.LaboChoisi, Modele.RegionChoisie);
                MessageBox.Show("Création effectuée !");
            }
            else if (Modele.RegionChoisie.idVisiteur != Modele.UtilisateurConnecte.idVisiteur)
            {
                MessageBox.Show("Erreur : vous ne pouvez pas ajouter un utilisateur dans une Région de laquelle vous n'êtes pas responsable");
            }
            
            bsRegion_CurrentChanged(new Object(), new EventArgs());
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }


        private bool tests()
        {
            bool vretour = true;
            error1.Clear();
            if (String.IsNullOrEmpty(txtNewid.Text))
            {
                error1.SetError(txtNewid, "Un id doit être renseigné.");
                vretour = false;
            }
            if (String.IsNullOrEmpty(txtNewidentifiant.Text))
            {
                error1.SetError(txtNewidentifiant, "Un identifiant doit être renseigné.");
                vretour = false;
            }
            if (String.IsNullOrEmpty(txtNewnom.Text))
            {
                error1.SetError(txtNewnom, "Un nom doit être renseigné.");
                vretour = false;
            }
            if (String.IsNullOrEmpty(txtNewpass.Text))
            {
                error1.SetError(txtNewpass, "Un mot de passe doit être renseigné.");
                vretour = false;
            }
            if (String.IsNullOrEmpty(txtNewprenom.Text))
            {
                error1.SetError(txtNewprenom, "Un prénom doit être renseigné.");
                vretour = false;
            }
            if (String.IsNullOrEmpty(txtNewrue.Text))
            {
                error1.SetError(txtNewrue, "Une adresse doit être renseigné.");
                vretour = false;
            }
            if (String.IsNullOrEmpty(txtNewVille.Text))
            {
                error1.SetError(txtNewVille, "Une ville doit être renseigné.");
                vretour = false;
            }
            if (String.IsNullOrEmpty(txtNewcp.Text))
            {
                error1.SetError(txtNewcp, "Un code postal doit être renseigné.");
                vretour = false;
            }
            return vretour;
        }

        private void btnAssocier_Click(object sender, EventArgs e)
        {


            System.Type type = bsRegion.Current.GetType();
            int id = (int)type.GetProperty("idRegion").GetValue(bsRegion.Current, null);
            Modele.RegionChoisie = Modele.trouveregionbyid(id);

            System.Type typeVis = bsVisiteur.Current.GetType();
            string idVis = (string)typeVis.GetProperty("idVisiteur").GetValue(bsVisiteur.Current, null);
            Modele.VisiteurChoisi = Modele.trouvevisiteurbyid(idVis);


            if (!Modele.VisiteurChoisi.Region1.Contains(Modele.RegionChoisie))
            {
                
                 Modele.AssocierRegion(Modele.RegionChoisie);
                 MessageBox.Show("Association effectuée");
                
            }
            else if (Modele.VisiteurChoisi.Region1.Contains(Modele.RegionChoisie))
            {
                MessageBox.Show("Le visiteur choisi est déjà attribué à votre région !");
            }
            bsRegion_CurrentChanged(new Object(), new EventArgs());
        }


        private void btnDissocier_Click(object sender, EventArgs e)
        {



            System.Type type = bsRegion.Current.GetType();
            int id = (int)type.GetProperty("idRegion").GetValue(bsRegion.Current, null);
            Modele.RegionChoisie = Modele.trouveregionbyid(id);

            System.Type typeVis = bsVisiteur.Current.GetType();
            string idVis = (string)typeVis.GetProperty("idVisiteur").GetValue(bsVisiteur.Current, null);
            Modele.VisiteurChoisi = Modele.trouvevisiteurbyid(idVis);

            if (Modele.VisiteurChoisi.Region1.Count > 1)
            {
                if (Modele.RegionChoisie.idVisiteur == Modele.UtilisateurConnecte.idVisiteur)
                {
                    Modele.DissocierRegion(Modele.RegionChoisie);
                    MessageBox.Show("Dissociation effectuée !");
                }
                else if (Modele.RegionChoisie.idVisiteur != Modele.UtilisateurConnecte.idVisiteur)
                {
                    MessageBox.Show("Impossible de dissocier un visiteur qui ne travaile pas dans une de vos régions !");
                }
            }
            else if (Modele.VisiteurChoisi.Region1.Count == 1)
            {
                MessageBox.Show("Alerte : Si vous dissociez le visiteur choisi de votre région il ne sera plus attribué à aucune région ! PS: Le product owner risque de ne pas être content ...");
            }
            bsRegion_CurrentChanged(new Object(), new EventArgs());
        }

        private void btnTousvisiteurs_Click(object sender, EventArgs e)
        {
            bsVisiteur.DataSource = Modele.listevisiteur();
            dgvVisiteur.DataSource = bsVisiteur;
        }

        private void btnVisiteurparregion_Click(object sender, EventArgs e)
        {
            bsVisiteur.DataSource = ((Region)bsRegion.Current).Visiteur1.ToList();
            dgvVisiteur.DataSource = bsVisiteur;
        }

        private void button3_Click(object sender, EventArgs e)
        {


            System.Type type = bsRegion.Current.GetType();
            int id = (int)type.GetProperty("idRegion").GetValue(bsRegion.Current, null);
            Modele.RegionChoisie = Modele.trouveregionbyid(id);

            System.Type typeVis = bsVisiteur.Current.GetType();
            string idVis = (string)typeVis.GetProperty("idVisiteur").GetValue(bsVisiteur.Current, null);
            Modele.VisiteurChoisi = Modele.trouvevisiteurbyid(idVis);

            foreach (Region R in Modele.UtilisateurConnecte.Region)
            {
                if (Modele.VisiteurChoisi.Region1.Contains(R))
                {
                    Form maform = new frmLicenciement();
                    maform.ShowDialog();
                    break;
                }
                else
                {
                    MessageBox.Show("Erreur, impossible de licencier un visiteur qui ne travaille pas dans une de vos régions.");
                    break;
                }
            }
           
        
            bsRegion_CurrentChanged(new Object(), new EventArgs());
        }

        private void bsRegion_CurrentChanged(object sender, EventArgs e)
        {
            bsVisiteur.DataSource = ((Region)bsRegion.Current).Visiteur1.ToList();
            dgvVisiteur.DataSource = bsVisiteur;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Type typeVis = bsVisiteur.Current.GetType();
            string idVis = (string)typeVis.GetProperty("idVisiteur").GetValue(bsVisiteur.Current, null);
            Modele.VisiteurChoisi = Modele.trouvevisiteurbyid(idVis);



            foreach (Region R in Modele.UtilisateurConnecte.Region)
            {
                if (Modele.VisiteurChoisi.Region1.Contains(R))
                {
                    if (Modele.DesactiverVisiteur())
                    {
                        MessageBox.Show("Désactivation réussie !");
                        break;
                    }
                    else if (!Modele.DesactiverVisiteur())
                    {
                        MessageBox.Show("Erreur : Impossible de désactiver un utilisateur qui est déjà inactif");
                        break;
                    }
                }
                else if (!Modele.VisiteurChoisi.Region1.Contains(R))
                {
                    MessageBox.Show("Erreur, vous ne pouvez pas désactiver un visiteur qui n'est pas attribué à votre région");
                    break;
                }

            }


            bsRegion_CurrentChanged(new Object(), new EventArgs());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Type typeVis = bsVisiteur.Current.GetType();
            string idVis = (string)typeVis.GetProperty("idVisiteur").GetValue(bsVisiteur.Current, null);
            Modele.VisiteurChoisi = Modele.trouvevisiteurbyid(idVis);


            foreach (Region R in Modele.UtilisateurConnecte.Region)
            {
                if (Modele.VisiteurChoisi.Region1.Contains(R))
                {
                    if (Modele.ActiverVisiteur())
                    {
                        MessageBox.Show("Activation réussie !");
                        break;
                    }
                    else if (!Modele.ActiverVisiteur())
                    {
                        MessageBox.Show("Erreur : Impossible d'activer un utilisateur déjà actif ou qui a été licencié");
                        break;
                    }
                }
                else
                {
                    MessageBox.Show("Erreur, vous ne pouvez pas activer un visiteur qui n'est pas attribué à votre région");
                    break;
                }
            }
     
            bsRegion_CurrentChanged(new Object(), new EventArgs());

        }
    }

}


