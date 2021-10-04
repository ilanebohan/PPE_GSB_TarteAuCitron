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
    public partial class frmConnexion : Form
    {
        public frmConnexion()
        {
            InitializeComponent();
        }

        public static void ThreadProc()
        {
            Application.Run(new frmMenu());
        }

        private void frmConnexion_Load(object sender, EventArgs e)
        {
            txtMDP.PasswordChar = '*';
        }

        private void btnConnexion_Click(object sender, EventArgs e)
        {
            if (Modele.userexists(txtIdentifiant.Text))
            {
                if (Modele.passexists(txtMDP.Text))
                {
                    MessageBox.Show("Connexion réussie !");
                    System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(ThreadProc));
                    t.Start();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Connexion refusée");
                }
            }
            else
            {
                MessageBox.Show("Connexion refusée");
            }
        }

        private void btnChangemdp_Click(object sender, EventArgs e)
        {
            lblAncienmdp.Visible = true;
            lblNouveaumdp.Visible = true;
            txtAncienmdp.Visible = true;
            txtAncienmdp.PasswordChar = '*';
            txtNouveaumdp.Visible = true;
            txtNouveaumdp.PasswordChar = '*';
            btnOK.Visible = true;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (Modele.userexists(txtIdentifiant.Text))
            {
                if (Modele.passexists(txtAncienmdp.Text))
                {
                    Modele.changepass(txtNouveaumdp.Text);
                }
            }
            else
            {
                MessageBox.Show("Changement refusé, veuillez vérifier votre identifiant ainsi que l'ancien mot de passe saisi !");
            }
        }
    }
}

