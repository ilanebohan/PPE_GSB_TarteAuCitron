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
    public partial class frmVisiteurs : Form
    {
        public frmVisiteurs()
        {
            InitializeComponent();
        }

        private void frmVisiteurs_Load(object sender, EventArgs e)
        {
            bsVisiteur.DataSource = Modele.listevisiteur();
            dgvVisiteur.DataSource = bsVisiteur;
        }
    }
}
