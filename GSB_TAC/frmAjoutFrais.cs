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
using System.Text.RegularExpressions;

namespace GSB_TAC
{
    public partial class frmAjoutFrais : Form
    {
        public frmAjoutFrais()
        {
            InitializeComponent();
        }

        private void frmAjoutFrais_Load(object sender, EventArgs e)//Lorsqu'on lance le form
        {
            lblInfoVisiteur.Text = string.Format("Visiteur : {0} {1}", Modele.VisiteurChoisi.nom, Modele.VisiteurChoisi.prenom);//Affichage du nom du visiteur
            switch (Modele.ActionFrais) //Affichache label d'action en fonction de si on ajoute ou modifie un frais
            {
                case 1: lblAction.Text = string.Format("Création d'une note de frais");btnValider.Text = "Ajouter"; bsTypeFrais.DataSource = Modele.listeTypeFraisNonExistant(); break;
                case 2: lblAction.Text = string.Format("Modification d'une note de frais");btnValider.Text = "Modifier"; bsTypeFrais.DataSource = Modele.listeTypeFraisExistant(); break;
            }

            //On cache les inputs liés aux frais hor forfait

            lblLibelleHf.Visible = false;
            txtbLibelleHf.Visible = false;

            lblDate.Visible = false;
            dtpHForfait.Visible = false;

            //On remplit la combobox des frais normaux
            cboTypeFrais.ValueMember = "id";
            cboTypeFrais.DisplayMember = "libelle";
            cboTypeFrais.DataSource = bsTypeFrais;

        }

        private void btnValider_Click(object sender, EventArgs e) //Lorsque qu'on appuie sur valider
        {
            if(cboTypeFrais.SelectedValue != null) {//Si on a bien selectionner un frais dans la combobox
                if(txtbQte.Text != "" && (Regex.IsMatch(txtbQte.Text, @"^[1-9]\d*(,\d+)?$"))) { //On vérifie que le textbox de quantité et remplis et contient un nombre, a virgule ou non (regex)
                    switch (Modele.ActionFrais)//Actions en fonction de la modif/ajout de frais
                    {
                        case 1: //Si on ajoute un frais
                            if (chbxHorsForfait.Checked == true)//Si on ajoute un frais hors forfait
                            {
                                if (txtbLibelleHf.Text != "") //On vérifie que le textbox de libelle contient du texte, si pio, on ajoute au la BDD le frais avec les infos inscrite par l'user
                                {
                                    if (Modele.ajoutHorsFrais(Modele.VisiteurChoisi.idVisiteur, Modele.MoisChoisi, txtbLibelleHf.Text, dtpHForfait.Value, Convert.ToDecimal(txtbQte.Text)))
                                    {
                                        //Si l'ajout est réussi, on renvoit le result OK et on ferme la form
                                        DialogResult = DialogResult.OK;
                                        this.Close();
                                    }
                                }
                                else//Si il n'y a rien dans le textbox libelle, on affiche une erreur
                                {
                                    afficheErrerur("Veuillez insérer un libellé");
                                }
                            }
                            else // Si on ajoute un frais normal
                            {
                                int number;
                                if (int.TryParse(txtbQte.Text, out number))//On vérifie que la quantité est bien un entier
                                {
                                    if (Modele.verifieDonnee(Convert.ToString(cboTypeFrais.SelectedValue), Convert.ToInt32(txtbQte.Text))) //On vérifie que la quantité est bien dans les limites de ceux du frais
                                    {
                                        if (Modele.addFrais(Modele.VisiteurChoisi.idVisiteur, Modele.MoisChoisi, Convert.ToString(cboTypeFrais.SelectedValue), Convert.ToInt32(txtbQte.Text)))
                                        {
                                            //Si l'ajout est réussi, on renvoit le result OK et on ferme la form
                                            DialogResult = DialogResult.OK;
                                            this.Close();
                                        }
                                    }
                                    else//Si la quantité n'est pas dans les limites, affichage d'une l'erreur
                                    {
                                        afficheErrerur("La quantité est en dessous/dessus des limites de la catégorie de frais");
                                    }
                                }
                                else//Si on a un nombre à virgule, affichage d'une erreur
                                {
                                    afficheErrerur("Vous ne pouvez pas ajouter de nombre à virgule");
                                }
                            }
                            break;
                        case 2: //Si on modifie le frais
                            if (chbxHorsForfait.Checked == true) //Si on modifie un frais hors forfait
                            {
                                if (txtbLibelleHf.Text != "") //Si le libelle n'est pas vide
                                {
                                    //Console.WriteLine(Modele.donneFraisHForfait(Convert.ToInt32(cboTypeFrais.SelectedValue)).libelle);
                                    if (Modele.modifHFrais(Decimal.ToInt32(Convert.ToDecimal(txtbQte.Text)), dtpHForfait.Value, txtbLibelleHf.Text, (Modele.donneFraisHForfait(Convert.ToInt32(cboTypeFrais.SelectedValue)))))
                                    {
                                        //Si la modif est réussi, on renvoit le result OK et on ferme la form
                                        DialogResult = DialogResult.OK;
                                        this.Close();
                                    }
                                }
                                else//Sinon affichage d'une erreur 
                                {
                                    afficheErrerur("Veuillez insérer un libellé");
                                }
                            }
                            else // Si on modifie un frais normal
                            {
                                int number;
                                if (int.TryParse(txtbQte.Text, out number)) //On vérifie qu'on a bien un entier
                                {
                                    if (Modele.verifieDonnee(Convert.ToString(cboTypeFrais.SelectedValue), Convert.ToInt32(txtbQte.Text))) //On vérifie que la quantité est bien dans la limite du frais
                                    {
                                        if (Modele.modifFrais(Convert.ToInt32(txtbQte.Text), Modele.donneFrais(Convert.ToString(cboTypeFrais.SelectedValue))))
                                        {
                                            //Si la modif est réussi, on renvoit le result OK et on ferme la form
                                            DialogResult = DialogResult.OK;
                                            this.Close();
                                        }
                                    }
                                    else //Si la quantité n'est pas dans les limites, affichage d'une erreur 
                                    {
                                        afficheErrerur("La quantité est en dessous/dessus des limites de la catégorie de frais");
                                    }
                                }
                                else //Si la quantité n'est pas un entier, affichage d'une erreur
                                {
                                    afficheErrerur("La quantité est doit être un entier");
                                }
                            }
                            break;
                    }
                }
                else////Si la quantité n'est pas un entier, affichage d'une erreur
                {
                    afficheErrerur("Quantité invalide, veuillez insérer uniquement un nombre ou un nombre à virgule (uniquement pour les frais hors forfait)");
                }
            }
            else//Si pas de frais choisi, on affiche une erreur
            {
                afficheErrerur("Veuillez selectionner un frais");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)//Si on annule, on ferme le form et on envois le "cancel"
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void chbxHorsForfait_CheckedChanged(object sender, EventArgs e) //Lorsqu'on appuie sur la checkbox de frais hors forfait
        {
            string dateChoisie = Modele.MoisChoisi; //On récupère la date de la fiche de frais

            //On définit les limites de date en fonction du mois (ex: Septembre : limites = 1 septembre et 30 Septembre
            string dateSMin = "01/" + dateChoisie.Substring(4) + "/" + dateChoisie.Substring(0, 4);
            string dateSMax = donneJourMax(dateChoisie.Substring(4),dateChoisie.Substring(0, 4)) + "/" + dateChoisie.Substring(4) + "/" + dateChoisie.Substring(0, 4);

            //On convertit les date type string en DateTime
            DateTime dateMin = DateTime.Parse(dateSMin);

            DateTime dateMax = DateTime.Parse(dateSMax);

            if (Modele.ActionFrais == 1)//Si on est en mode ajout
            {
                if (chbxHorsForfait.Checked == true) //Si on ajoute un hors forfait
                {
                    changeForm(true, true, true, true, false, "Prix : "); //on change le form en mode ajout hors forfait

                    //On définit les dates max du date picker
                    dtpHForfait.MinDate = dateMin;
                    dtpHForfait.MaxDate = dateMax;
                }
                else //Si on ajoute un frais nrml
                {
                    changeForm(false,false,false,false,true,"Quantité : ",Modele.listeTypeFraisNonExistant()); //On change le form en mode ajout de frais normaux

                }
            }
            else // Si on est en mode modification 
            {
                if(Modele.ActionFrais == 2)
                {
                    if (chbxHorsForfait.Checked == true) // Si on modifie un hors forfait
                    {

                        changeForm(true, true, true, true, true, "Prix : ", null, Modele.listeFraisHForfait()); //on change le form en mode modif hors forfait

                        //On définit les dates max du date picker
                        dtpHForfait.MinDate = dateMin;
                        dtpHForfait.MaxDate = dateMax;
                    }
                    else // Si on modifie un frais 
                    {

                        changeForm(false, false, false, false, true, "Quantité : ", Modele.listeTypeFraisExistant()); //On change le form en mode modif de frais normaux
                        txtbQte.Text = "";

                    }
                }
            }
        }

        private void bsTypeFrais_CurrentChanged(object sender, EventArgs e)//Lorsque qu'on selectionne un frais dans la combobox
        {

            if (Modele.ActionFrais == 2)//Si on est en mode modif
                {
                    if (chbxHorsForfait.Checked == true)//Si on est en mode modif de frais hors forfait
                    {
                        if (Modele.listeFraisHForfait().Count != 0)//Si il existe au moins 1 frais hors forfait
                        {
                            //On remplit la quantité, la date et le libelle par les valeurs du frais hors forfait
                            txtbQte.Text = Convert.ToString(Modele.donneFraisHForfait(((LigneFraisHorsForfait)bsTypeFrais.Current).id).montant);
                            txtbLibelleHf.Text = Convert.ToString(Modele.donneFraisHForfait(((LigneFraisHorsForfait)bsTypeFrais.Current).id).libelle);
                            dtpHForfait.Value = (DateTime)(Modele.donneFraisHForfait(((LigneFraisHorsForfait)bsTypeFrais.Current).id).date);
                        }
                        else //Si pas de frais hors forfait, on affiche une erreur
                        {
                        afficheErrerur("Impossible de modifier un frais hors forfait, il en existe aucun.");
                        }
                    }
                else //Si on est en mode modif de frais normaux
                {
                    LigneFraisForfait f = new LigneFraisForfait();
                    f = Modele.donneFrais(((FraisForfait)bsTypeFrais.Current).id); //On récupère le frais selectionner de la combobox et on affiche sa quantité dans la textbox de quantité

                    txtbQte.Text = Convert.ToString(f.quantite);
                }

                }
        }

        //Fonction de changement de form de mode frais hors forfait ou non
        private void changeForm(bool visLibHf, bool vistxtBHf, bool visLblDate, bool visDtpHF, bool enblCbo, string lblQteText, List<FraisForfait> listeFraisForfaits = null, List<LigneFraisHorsForfait> listeFraisHForfaits = null)
        {
            //Affichage ou non des différents élements du form
            lblLibelleHf.Visible = visLibHf;
            txtbLibelleHf.Visible = vistxtBHf;
            lblDate.Visible = visLblDate;
            dtpHForfait.Visible = visDtpHF;
            cboTypeFrais.Enabled = enblCbo;
            lblQte.Text = lblQteText;
            cboTypeFrais.ValueMember = "id";
            cboTypeFrais.DisplayMember = "libelle";

            if(listeFraisForfaits != null) // Si on est en mode modif/ajout d'un frais normal
            {
                switch (Modele.ActionFrais)//En fonction du mode
                {
                    case 1://Mode ajout, on remplit la combobox des frais qui n'ont pas encore été crées

                        bsTypeFrais.DataSource = listeFraisForfaits;
                        cboTypeFrais.DataSource = bsTypeFrais;
                        break;
                    case 2: //Mode modif, on remplit la combobx des frais par ceux qui existes déjà
                        bsTypeFrais.DataSource = listeFraisForfaits;
                        cboTypeFrais.DataSource = bsTypeFrais;
                        break;
                }

            }
            if(listeFraisHForfaits != null) //Si on est en mode modif/ajout d'un frais hors forfait
            {
                bsTypeFrais.DataSource =listeFraisHForfaits; //On remplit la combobox des frais hors forfait
                //Console.WriteLine(cboTypeFrais.SelectedIndex);
                //Console.WriteLine(cboTypeFrais.SelectedValue);
            }
            
        }

        private void afficheErrerur(string msg) //Affiche une MessageBox d'erreur avec son message ***
        {
            MessageBoxButtons button = MessageBoxButtons.OK;
            MessageBox.Show(msg, "Erreur", button);
            //chbxHorsForfait.Checked = false;
        }

        private string donneJourMax(string mois, string annee) //Renvois le nombre de jour d'un mois
        {
            string vretour = "";
            switch (mois)
            {
                case "01": case "03": case "05": case "07": case "08": case "10": case "12": //Pour Janvier, Mars, Mai, Juillet, Aout, Octobre, Décemnre
                    vretour = "31";
                    break;

                case "02": // Pour Février
                    if (DateTime.IsLeapYear(Convert.ToInt32(annee))) //Test si l'année est bissextile
                    {
                        vretour = "29";
                    }
                    else
                    {
                        vretour = "28";
                    }
                    break;
                    
                case "04": case "06": case "09": case "11": //Pour Avril, Juin, Septembre, Novembre
                    vretour = "30";
                    break;
            }
            return vretour;
        }

    }
}
