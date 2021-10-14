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
    public partial class frmRemboursement : Form
    {
        public frmRemboursement()
        {
            InitializeComponent();
        }

        private void frmRemboursement_Load(object sender, EventArgs e)
        {
            lblBvnVisiteur.Text = "Bienvenue " + Modele.VisiteurChoisi.nom + " " + Modele.VisiteurChoisi.prenom + " !";

            cboDate.ValueMember = "idVisteur";
            cboDate.DisplayMember = "mois";
            bsFicheFrais.DataSource = Modele.listFicheFraisVisiteur();
            cboDate.DataSource = bsFicheFrais;

        }

        private void bsFicheFrais_CurrentChanged(object sender, EventArgs e)
        {

            bsLigneFraisForfait.DataSource = ((fichefrais)bsFicheFrais.Current).LigneFraisForfait.Select(x => new
            {
                x.idVisiteur,
                x.mois,
                x.idFraisForfait,
                x.FraisForfait.libelle,
                x.quantite,
                x.FraisForfait.montant,
                total = (float) x.FraisForfait.montant * x.quantite //Multiplication de la quantié par le montant du type de forfait
            }).Where(x => !x.idFraisForfait.StartsWith("KM"));
            dgvFrais.DataSource = bsLigneFraisForfait;
            dgvFrais.Columns[0].Visible = false;
            dgvFrais.Columns[1].Visible = false;

            bsKm.DataSource = ((fichefrais)bsFicheFrais.Current).LigneFraisForfait.Select( x => new {
                x.idVisiteur,
                x.mois,
                x.idFraisForfait,
                x.FraisForfait.libelle,
                x.quantite,
                x.FraisForfait.montant,
                total = (float)x.FraisForfait.montant * x.quantite //Multiplication de la quantié par le montant du type de forfait
            }).Where(x => x.idFraisForfait.StartsWith("KM"));

            dgvKm.DataSource = bsKm;
            dgvKm.Columns[0].Visible = false;
            dgvKm.Columns[1].Visible = false;

        }

        private void btnAjoutFrais_Click(object sender, EventArgs e)
        {
            Modele.ActionFrais = 1;
            Modele.MoisChoisi = ((fichefrais)bsFicheFrais.Current).mois;
            frmAjoutFrais faf = new frmAjoutFrais();
            faf.Show();
            
        }

        private void btnSuppFrais_Click(object sender, EventArgs e)
        {
            Type type = bsLigneFraisForfait.Current.GetType();
            string idVisi = (string)type.GetProperty("idVisiteur").GetValue(bsLigneFraisForfait.Current, null);
            string idFrais = (string)type.GetProperty("idFraisForfait").GetValue(bsLigneFraisForfait.Current, null);
            string mois = (string)type.GetProperty("mois").GetValue(bsLigneFraisForfait.Current, null);

            Modele.FraisChoisi = Modele.donneFrais(idVisi, mois, idFrais);

            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            string message = string.Format("Voulez vous vraiment supprimer cet ligne ?");
            DialogResult result;
            result = MessageBox.Show(message, "Confirmation",buttons);
            if(result == System.Windows.Forms.DialogResult.Yes)
            {
                Modele.suppFrais();
                bsFicheFrais_CurrentChanged(new object(), new EventArgs());
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Modele.ActionFrais = 2;
            Modele.MoisChoisi = ((fichefrais)bsFicheFrais.Current).mois;
            frmAjoutFrais faf = new frmAjoutFrais();
            faf.Show();
        }
    }
}
