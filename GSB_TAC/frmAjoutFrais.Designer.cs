
namespace GSB_TAC
{
    partial class frmAjoutFrais
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblInfoVisiteur = new System.Windows.Forms.Label();
            this.lblAction = new System.Windows.Forms.Label();
            this.cboTypeFrais = new System.Windows.Forms.ComboBox();
            this.bsTypeFrais = new System.Windows.Forms.BindingSource(this.components);
            this.txtbQte = new System.Windows.Forms.TextBox();
            this.lblType = new System.Windows.Forms.Label();
            this.lblQte = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnValider = new System.Windows.Forms.Button();
            this.chbxHorsForfait = new System.Windows.Forms.CheckBox();
            this.lblLibelleHf = new System.Windows.Forms.Label();
            this.txtbLibelleHf = new System.Windows.Forms.TextBox();
            this.dtpHForfait = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bsTypeFrais)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInfoVisiteur
            // 
            this.lblInfoVisiteur.AutoSize = true;
            this.lblInfoVisiteur.Location = new System.Drawing.Point(15, 25);
            this.lblInfoVisiteur.Name = "lblInfoVisiteur";
            this.lblInfoVisiteur.Size = new System.Drawing.Size(47, 13);
            this.lblInfoVisiteur.TabIndex = 0;
            this.lblInfoVisiteur.Text = "Visiteur :";
            // 
            // lblAction
            // 
            this.lblAction.AutoSize = true;
            this.lblAction.Location = new System.Drawing.Point(15, 45);
            this.lblAction.Name = "lblAction";
            this.lblAction.Size = new System.Drawing.Size(31, 13);
            this.lblAction.TabIndex = 1;
            this.lblAction.Text = "Type";
            // 
            // cboTypeFrais
            // 
            this.cboTypeFrais.FormattingEnabled = true;
            this.cboTypeFrais.Location = new System.Drawing.Point(110, 70);
            this.cboTypeFrais.Name = "cboTypeFrais";
            this.cboTypeFrais.Size = new System.Drawing.Size(121, 21);
            this.cboTypeFrais.TabIndex = 2;
            // 
            // txtbQte
            // 
            this.txtbQte.Location = new System.Drawing.Point(110, 140);
            this.txtbQte.Name = "txtbQte";
            this.txtbQte.Size = new System.Drawing.Size(100, 20);
            this.txtbQte.TabIndex = 3;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(15, 75);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(77, 13);
            this.lblType.TabIndex = 4;
            this.lblType.Text = "Type de Frais :";
            // 
            // lblQte
            // 
            this.lblQte.AutoSize = true;
            this.lblQte.Location = new System.Drawing.Point(15, 145);
            this.lblQte.Name = "lblQte";
            this.lblQte.Size = new System.Drawing.Size(53, 13);
            this.lblQte.TabIndex = 5;
            this.lblQte.Text = "Quantité :";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(385, 145);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Annuler";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(300, 145);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(75, 23);
            this.btnValider.TabIndex = 7;
            this.btnValider.Text = "Ajouter";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // chbxHorsForfait
            // 
            this.chbxHorsForfait.AutoSize = true;
            this.chbxHorsForfait.Location = new System.Drawing.Point(270, 70);
            this.chbxHorsForfait.Name = "chbxHorsForfait";
            this.chbxHorsForfait.Size = new System.Drawing.Size(105, 17);
            this.chbxHorsForfait.TabIndex = 8;
            this.chbxHorsForfait.Text = "Frais Hors Forfait";
            this.chbxHorsForfait.UseVisualStyleBackColor = true;
            this.chbxHorsForfait.CheckedChanged += new System.EventHandler(this.chbxHorsForfait_CheckedChanged);
            // 
            // lblLibelleHf
            // 
            this.lblLibelleHf.AutoSize = true;
            this.lblLibelleHf.Location = new System.Drawing.Point(15, 110);
            this.lblLibelleHf.Name = "lblLibelleHf";
            this.lblLibelleHf.Size = new System.Drawing.Size(43, 13);
            this.lblLibelleHf.TabIndex = 9;
            this.lblLibelleHf.Text = "Libelle :";
            // 
            // txtbLibelleHf
            // 
            this.txtbLibelleHf.Location = new System.Drawing.Point(110, 105);
            this.txtbLibelleHf.Name = "txtbLibelleHf";
            this.txtbLibelleHf.Size = new System.Drawing.Size(100, 20);
            this.txtbLibelleHf.TabIndex = 10;
            // 
            // dtpHForfait
            // 
            this.dtpHForfait.Location = new System.Drawing.Point(345, 105);
            this.dtpHForfait.Name = "dtpHForfait";
            this.dtpHForfait.Size = new System.Drawing.Size(115, 20);
            this.dtpHForfait.TabIndex = 11;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(275, 110);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(25, 13);
            this.lblDate.TabIndex = 12;
            this.lblDate.Text = "Le :";
            // 
            // frmAjoutFrais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 174);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.dtpHForfait);
            this.Controls.Add(this.txtbLibelleHf);
            this.Controls.Add(this.lblLibelleHf);
            this.Controls.Add(this.chbxHorsForfait);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblQte);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.txtbQte);
            this.Controls.Add(this.cboTypeFrais);
            this.Controls.Add(this.lblAction);
            this.Controls.Add(this.lblInfoVisiteur);
            this.Name = "frmAjoutFrais";
            this.Text = "frmAjoutFrais";
            this.Load += new System.EventHandler(this.frmAjoutFrais_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsTypeFrais)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInfoVisiteur;
        private System.Windows.Forms.Label lblAction;
        private System.Windows.Forms.ComboBox cboTypeFrais;
        private System.Windows.Forms.BindingSource bsTypeFrais;
        private System.Windows.Forms.TextBox txtbQte;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblQte;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.CheckBox chbxHorsForfait;
        private System.Windows.Forms.Label lblLibelleHf;
        private System.Windows.Forms.TextBox txtbLibelleHf;
        private System.Windows.Forms.DateTimePicker dtpHForfait;
        private System.Windows.Forms.Label lblDate;
    }
}