
namespace GSB_TAC
{
    partial class frmRemboursement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRemboursement));
            this.lblBvnVisiteur = new System.Windows.Forms.Label();
            this.lblFicheDePaie = new System.Windows.Forms.Label();
            this.cboDate = new System.Windows.Forms.ComboBox();
            this.dgvFrais = new System.Windows.Forms.DataGridView();
            this.dgvFraisHForfait = new System.Windows.Forms.DataGridView();
            this.btnAjoutFrais = new System.Windows.Forms.Button();
            this.btnSuppFraisN = new System.Windows.Forms.Button();
            this.bsVisiteur = new System.Windows.Forms.BindingSource(this.components);
            this.bsFicheFrais = new System.Windows.Forms.BindingSource(this.components);
            this.bsLigneFraisForfait = new System.Windows.Forms.BindingSource(this.components);
            this.bsLigneFraisHForfait = new System.Windows.Forms.BindingSource(this.components);
            this.btnModifF = new System.Windows.Forms.Button();
            this.dgvKm = new System.Windows.Forms.DataGridView();
            this.bsKm = new System.Windows.Forms.BindingSource(this.components);
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSuppFraisKm = new System.Windows.Forms.Button();
            this.btnSuppFraisHf = new System.Windows.Forms.Button();
            this.lblTotalFNrml = new System.Windows.Forms.Label();
            this.lblFraisKm = new System.Windows.Forms.Label();
            this.lblTotHFraiss = new System.Windows.Forms.Label();
            this.lblTotGene = new System.Windows.Forms.Label();
            this.txtBFNrml = new System.Windows.Forms.TextBox();
            this.txtBTotalFKm = new System.Windows.Forms.TextBox();
            this.txtBTotalHFrais = new System.Windows.Forms.TextBox();
            this.txtBToGene = new System.Windows.Forms.TextBox();
            this.lblChoixFNrml = new System.Windows.Forms.Label();
            this.lblPrixUnitNrml = new System.Windows.Forms.Label();
            this.lblMontantNrml = new System.Windows.Forms.Label();
            this.lblLibeFraiKm = new System.Windows.Forms.Label();
            this.lblMontantKM = new System.Windows.Forms.Label();
            this.lblPrixUnitKm = new System.Windows.Forms.Label();
            this.lblTypeFrais = new System.Windows.Forms.Label();
            this.lblTypeFraisKm = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFrais)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFraisHForfait)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsVisiteur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFicheFrais)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsLigneFraisForfait)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsLigneFraisHForfait)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsKm)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBvnVisiteur
            // 
            this.lblBvnVisiteur.AutoSize = true;
            this.lblBvnVisiteur.Location = new System.Drawing.Point(12, 9);
            this.lblBvnVisiteur.Name = "lblBvnVisiteur";
            this.lblBvnVisiteur.Size = new System.Drawing.Size(10, 13);
            this.lblBvnVisiteur.TabIndex = 0;
            this.lblBvnVisiteur.Text = " ";
            // 
            // lblFicheDePaie
            // 
            this.lblFicheDePaie.AutoSize = true;
            this.lblFicheDePaie.Location = new System.Drawing.Point(8, 45);
            this.lblFicheDePaie.Name = "lblFicheDePaie";
            this.lblFicheDePaie.Size = new System.Drawing.Size(140, 13);
            this.lblFicheDePaie.TabIndex = 1;
            this.lblFicheDePaie.Text = "Voici vos fiches de paie du :";
            // 
            // cboDate
            // 
            this.cboDate.FormattingEnabled = true;
            this.cboDate.Location = new System.Drawing.Point(155, 40);
            this.cboDate.Name = "cboDate";
            this.cboDate.Size = new System.Drawing.Size(121, 21);
            this.cboDate.TabIndex = 2;
            // 
            // dgvFrais
            // 
            this.dgvFrais.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFrais.Location = new System.Drawing.Point(10, 75);
            this.dgvFrais.Name = "dgvFrais";
            this.dgvFrais.Size = new System.Drawing.Size(565, 190);
            this.dgvFrais.TabIndex = 3;
            // 
            // dgvFraisHForfait
            // 
            this.dgvFraisHForfait.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFraisHForfait.Location = new System.Drawing.Point(675, 75);
            this.dgvFraisHForfait.Name = "dgvFraisHForfait";
            this.dgvFraisHForfait.Size = new System.Drawing.Size(565, 305);
            this.dgvFraisHForfait.TabIndex = 4;
            // 
            // btnAjoutFrais
            // 
            this.btnAjoutFrais.Location = new System.Drawing.Point(580, 160);
            this.btnAjoutFrais.Name = "btnAjoutFrais";
            this.btnAjoutFrais.Size = new System.Drawing.Size(30, 30);
            this.btnAjoutFrais.TabIndex = 5;
            this.btnAjoutFrais.Text = "+";
            this.btnAjoutFrais.UseVisualStyleBackColor = true;
            this.btnAjoutFrais.Click += new System.EventHandler(this.btnAjoutFrais_Click);
            // 
            // btnSuppFraisN
            // 
            this.btnSuppFraisN.Location = new System.Drawing.Point(10, 270);
            this.btnSuppFraisN.Name = "btnSuppFraisN";
            this.btnSuppFraisN.Size = new System.Drawing.Size(120, 30);
            this.btnSuppFraisN.TabIndex = 7;
            this.btnSuppFraisN.Text = "Supprimer le frais";
            this.btnSuppFraisN.UseVisualStyleBackColor = true;
            this.btnSuppFraisN.Click += new System.EventHandler(this.btnSuppFrais_Click);
            // 
            // bsFicheFrais
            // 
            this.bsFicheFrais.CurrentChanged += new System.EventHandler(this.bsFicheFrais_CurrentChanged);
            // 
            // bsLigneFraisForfait
            // 
            this.bsLigneFraisForfait.CurrentChanged += new System.EventHandler(this.bsLigneFraisForfait_CurrentChanged);
            // 
            // btnModifF
            // 
            this.btnModifF.Location = new System.Drawing.Point(580, 200);
            this.btnModifF.Name = "btnModifF";
            this.btnModifF.Size = new System.Drawing.Size(30, 30);
            this.btnModifF.TabIndex = 9;
            this.btnModifF.Text = "M";
            this.btnModifF.UseVisualStyleBackColor = true;
            this.btnModifF.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvKm
            // 
            this.dgvKm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKm.Location = new System.Drawing.Point(10, 345);
            this.dgvKm.Name = "dgvKm";
            this.dgvKm.Size = new System.Drawing.Size(565, 190);
            this.dgvKm.TabIndex = 11;
            // 
            // bsKm
            // 
            this.bsKm.CurrentChanged += new System.EventHandler(this.bsKm_CurrentChanged);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRefresh.BackgroundImage")));
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRefresh.Location = new System.Drawing.Point(610, 110);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(30, 30);
            this.btnRefresh.TabIndex = 12;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnSuppFraisKm
            // 
            this.btnSuppFraisKm.Location = new System.Drawing.Point(10, 540);
            this.btnSuppFraisKm.Name = "btnSuppFraisKm";
            this.btnSuppFraisKm.Size = new System.Drawing.Size(120, 30);
            this.btnSuppFraisKm.TabIndex = 13;
            this.btnSuppFraisKm.Text = "Supprimer le frais";
            this.btnSuppFraisKm.UseVisualStyleBackColor = true;
            this.btnSuppFraisKm.Click += new System.EventHandler(this.btnSuppFraisKm_Click);
            // 
            // btnSuppFraisHf
            // 
            this.btnSuppFraisHf.Location = new System.Drawing.Point(675, 390);
            this.btnSuppFraisHf.Name = "btnSuppFraisHf";
            this.btnSuppFraisHf.Size = new System.Drawing.Size(120, 30);
            this.btnSuppFraisHf.TabIndex = 14;
            this.btnSuppFraisHf.Text = "Supprimer le frais";
            this.btnSuppFraisHf.UseVisualStyleBackColor = true;
            this.btnSuppFraisHf.Click += new System.EventHandler(this.btnSuppFraisHf_Click);
            // 
            // lblTotalFNrml
            // 
            this.lblTotalFNrml.AutoSize = true;
            this.lblTotalFNrml.Location = new System.Drawing.Point(450, 275);
            this.lblTotalFNrml.Name = "lblTotalFNrml";
            this.lblTotalFNrml.Size = new System.Drawing.Size(37, 13);
            this.lblTotalFNrml.TabIndex = 15;
            this.lblTotalFNrml.Text = "Total :";
            // 
            // lblFraisKm
            // 
            this.lblFraisKm.AutoSize = true;
            this.lblFraisKm.Location = new System.Drawing.Point(450, 545);
            this.lblFraisKm.Name = "lblFraisKm";
            this.lblFraisKm.Size = new System.Drawing.Size(37, 13);
            this.lblFraisKm.TabIndex = 16;
            this.lblFraisKm.Text = "Total :";
            // 
            // lblTotHFraiss
            // 
            this.lblTotHFraiss.AutoSize = true;
            this.lblTotHFraiss.Location = new System.Drawing.Point(1120, 390);
            this.lblTotHFraiss.Name = "lblTotHFraiss";
            this.lblTotHFraiss.Size = new System.Drawing.Size(37, 13);
            this.lblTotHFraiss.TabIndex = 17;
            this.lblTotHFraiss.Text = "Total :";
            // 
            // lblTotGene
            // 
            this.lblTotGene.AutoSize = true;
            this.lblTotGene.Location = new System.Drawing.Point(675, 520);
            this.lblTotGene.Name = "lblTotGene";
            this.lblTotGene.Size = new System.Drawing.Size(75, 13);
            this.lblTotGene.TabIndex = 18;
            this.lblTotGene.Text = "Total général :";
            // 
            // txtBFNrml
            // 
            this.txtBFNrml.Location = new System.Drawing.Point(490, 270);
            this.txtBFNrml.Name = "txtBFNrml";
            this.txtBFNrml.ReadOnly = true;
            this.txtBFNrml.Size = new System.Drawing.Size(85, 20);
            this.txtBFNrml.TabIndex = 19;
            // 
            // txtBTotalFKm
            // 
            this.txtBTotalFKm.Location = new System.Drawing.Point(490, 540);
            this.txtBTotalFKm.Name = "txtBTotalFKm";
            this.txtBTotalFKm.ReadOnly = true;
            this.txtBTotalFKm.Size = new System.Drawing.Size(85, 20);
            this.txtBTotalFKm.TabIndex = 20;
            // 
            // txtBTotalHFrais
            // 
            this.txtBTotalHFrais.Location = new System.Drawing.Point(1155, 385);
            this.txtBTotalHFrais.Name = "txtBTotalHFrais";
            this.txtBTotalHFrais.ReadOnly = true;
            this.txtBTotalHFrais.Size = new System.Drawing.Size(85, 20);
            this.txtBTotalHFrais.TabIndex = 21;
            // 
            // txtBToGene
            // 
            this.txtBToGene.Location = new System.Drawing.Point(750, 515);
            this.txtBToGene.Name = "txtBToGene";
            this.txtBToGene.ReadOnly = true;
            this.txtBToGene.Size = new System.Drawing.Size(85, 20);
            this.txtBToGene.TabIndex = 22;
            // 
            // lblChoixFNrml
            // 
            this.lblChoixFNrml.AutoSize = true;
            this.lblChoixFNrml.Location = new System.Drawing.Point(240, 275);
            this.lblChoixFNrml.Name = "lblChoixFNrml";
            this.lblChoixFNrml.Size = new System.Drawing.Size(89, 13);
            this.lblChoixFNrml.TabIndex = 23;
            this.lblChoixFNrml.Text = "Frais Kilometrique";
            // 
            // lblPrixUnitNrml
            // 
            this.lblPrixUnitNrml.AutoSize = true;
            this.lblPrixUnitNrml.Location = new System.Drawing.Point(335, 275);
            this.lblPrixUnitNrml.Name = "lblPrixUnitNrml";
            this.lblPrixUnitNrml.Size = new System.Drawing.Size(67, 13);
            this.lblPrixUnitNrml.TabIndex = 24;
            this.lblPrixUnitNrml.Text = "Prix unitaire :";
            // 
            // lblMontantNrml
            // 
            this.lblMontantNrml.AutoSize = true;
            this.lblMontantNrml.Location = new System.Drawing.Point(410, 275);
            this.lblMontantNrml.Name = "lblMontantNrml";
            this.lblMontantNrml.Size = new System.Drawing.Size(23, 13);
            this.lblMontantNrml.TabIndex = 25;
            this.lblMontantNrml.Text = "null";
            // 
            // lblLibeFraiKm
            // 
            this.lblLibeFraiKm.AutoSize = true;
            this.lblLibeFraiKm.Location = new System.Drawing.Point(240, 545);
            this.lblLibeFraiKm.Name = "lblLibeFraiKm";
            this.lblLibeFraiKm.Size = new System.Drawing.Size(89, 13);
            this.lblLibeFraiKm.TabIndex = 26;
            this.lblLibeFraiKm.Text = "Frais Kilometrique";
            // 
            // lblMontantKM
            // 
            this.lblMontantKM.AutoSize = true;
            this.lblMontantKM.Location = new System.Drawing.Point(410, 545);
            this.lblMontantKM.Name = "lblMontantKM";
            this.lblMontantKM.Size = new System.Drawing.Size(23, 13);
            this.lblMontantKM.TabIndex = 28;
            this.lblMontantKM.Text = "null";
            // 
            // lblPrixUnitKm
            // 
            this.lblPrixUnitKm.AutoSize = true;
            this.lblPrixUnitKm.Location = new System.Drawing.Point(335, 545);
            this.lblPrixUnitKm.Name = "lblPrixUnitKm";
            this.lblPrixUnitKm.Size = new System.Drawing.Size(67, 13);
            this.lblPrixUnitKm.TabIndex = 27;
            this.lblPrixUnitKm.Text = "Prix unitaire :";
            // 
            // lblTypeFrais
            // 
            this.lblTypeFrais.AutoSize = true;
            this.lblTypeFrais.Location = new System.Drawing.Point(165, 275);
            this.lblTypeFrais.Name = "lblTypeFrais";
            this.lblTypeFrais.Size = new System.Drawing.Size(77, 13);
            this.lblTypeFrais.TabIndex = 29;
            this.lblTypeFrais.Text = "Type de Frais :";
            // 
            // lblTypeFraisKm
            // 
            this.lblTypeFraisKm.AutoSize = true;
            this.lblTypeFraisKm.Location = new System.Drawing.Point(165, 545);
            this.lblTypeFraisKm.Name = "lblTypeFraisKm";
            this.lblTypeFraisKm.Size = new System.Drawing.Size(77, 13);
            this.lblTypeFraisKm.TabIndex = 30;
            this.lblTypeFraisKm.Text = "Type de Frais :";
            // 
            // frmRemboursement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1253, 621);
            this.Controls.Add(this.lblTypeFraisKm);
            this.Controls.Add(this.lblTypeFrais);
            this.Controls.Add(this.lblMontantKM);
            this.Controls.Add(this.lblPrixUnitKm);
            this.Controls.Add(this.lblLibeFraiKm);
            this.Controls.Add(this.lblMontantNrml);
            this.Controls.Add(this.lblPrixUnitNrml);
            this.Controls.Add(this.lblChoixFNrml);
            this.Controls.Add(this.txtBToGene);
            this.Controls.Add(this.txtBTotalHFrais);
            this.Controls.Add(this.txtBTotalFKm);
            this.Controls.Add(this.txtBFNrml);
            this.Controls.Add(this.lblTotGene);
            this.Controls.Add(this.lblTotHFraiss);
            this.Controls.Add(this.lblFraisKm);
            this.Controls.Add(this.lblTotalFNrml);
            this.Controls.Add(this.btnSuppFraisHf);
            this.Controls.Add(this.btnSuppFraisKm);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.dgvKm);
            this.Controls.Add(this.btnModifF);
            this.Controls.Add(this.btnSuppFraisN);
            this.Controls.Add(this.btnAjoutFrais);
            this.Controls.Add(this.dgvFraisHForfait);
            this.Controls.Add(this.dgvFrais);
            this.Controls.Add(this.cboDate);
            this.Controls.Add(this.lblFicheDePaie);
            this.Controls.Add(this.lblBvnVisiteur);
            this.Name = "frmRemboursement";
            this.Text = " ";
            this.Load += new System.EventHandler(this.frmRemboursement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFrais)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFraisHForfait)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsVisiteur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFicheFrais)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsLigneFraisForfait)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsLigneFraisHForfait)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsKm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource bsVisiteur;
        private System.Windows.Forms.Label lblBvnVisiteur;
        private System.Windows.Forms.Label lblFicheDePaie;
        private System.Windows.Forms.ComboBox cboDate;
        private System.Windows.Forms.BindingSource bsFicheFrais;
        private System.Windows.Forms.DataGridView dgvFrais;
        private System.Windows.Forms.BindingSource bsLigneFraisForfait;
        private System.Windows.Forms.DataGridView dgvFraisHForfait;
        private System.Windows.Forms.BindingSource bsLigneFraisHForfait;
        private System.Windows.Forms.Button btnAjoutFrais;
        private System.Windows.Forms.Button btnSuppFraisN;
        private System.Windows.Forms.Button btnModifF;
        private System.Windows.Forms.DataGridView dgvKm;
        private System.Windows.Forms.BindingSource bsKm;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnSuppFraisKm;
        private System.Windows.Forms.Button btnSuppFraisHf;
        private System.Windows.Forms.Label lblTotalFNrml;
        private System.Windows.Forms.Label lblFraisKm;
        private System.Windows.Forms.Label lblTotHFraiss;
        private System.Windows.Forms.Label lblTotGene;
        private System.Windows.Forms.TextBox txtBFNrml;
        private System.Windows.Forms.TextBox txtBTotalFKm;
        private System.Windows.Forms.TextBox txtBTotalHFrais;
        private System.Windows.Forms.TextBox txtBToGene;
        private System.Windows.Forms.Label lblChoixFNrml;
        private System.Windows.Forms.Label lblPrixUnitNrml;
        private System.Windows.Forms.Label lblMontantNrml;
        private System.Windows.Forms.Label lblLibeFraiKm;
        private System.Windows.Forms.Label lblMontantKM;
        private System.Windows.Forms.Label lblPrixUnitKm;
        private System.Windows.Forms.Label lblTypeFrais;
        private System.Windows.Forms.Label lblTypeFraisKm;
    }
}