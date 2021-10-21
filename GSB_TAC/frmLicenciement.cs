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
    public partial class frmLicenciement : Form
    {
        public frmLicenciement()
        {
            InitializeComponent();
        }

        private void frmLicenciement_Load(object sender, EventArgs e)
        {
            
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            if (Modele.LicencierVisiteur(cboMotif.Text, dtpDatelicencier.Text))
            {
                MessageBox.Show("Licenciement réussi !");
            }
            else if (!Modele.LicencierVisiteur(cboMotif.Text, dtpDatelicencier.Text))
            {
                MessageBox.Show("Erreur : Impossible de licencier un utilisateur qui est déjà inactif");
            }
        }
    }
}
