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
    public partial class frmAjoutFrais : Form
    {
        public frmAjoutFrais()
        {
            InitializeComponent();
        }

        private void frmAjoutFrais_Load(object sender, EventArgs e)
        {
            lblInfoVisiteur.Text = string.Format("Visiteur : {0} {1}", Modele.VisiteurChoisi.nom, Modele.VisiteurChoisi.prenom);
            switch (Modele.ActionFrais)
            {
                case 1: lblAction.Text = string.Format("Création d'une note de frais");break;
                case 2: lblAction.Text = string.Format("Modification d'une note de frais");break;
            }
        }
    }
}
