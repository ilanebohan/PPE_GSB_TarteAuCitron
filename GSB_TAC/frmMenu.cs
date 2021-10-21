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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            //lblInfos.Text = "Bienvenue " + Modele.UtilisateurConnecte.prenom + " " + Modele.UtilisateurConnecte.nom;
        }

        private void m1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form maForm = new frmM1();
            maForm.MdiParent = this;
            maForm.Show();

        }

        public void isMdiParent()
        {
            MdiParent = this;
        }

    }
}
