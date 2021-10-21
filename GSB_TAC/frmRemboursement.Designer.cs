
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
            this.dgvFraisHForfait.Size = new System.Drawing.Size(565, 460);
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
            this.btnSuppFraisHf.Location = new System.Drawing.Point(675, 540);
            this.btnSuppFraisHf.Name = "btnSuppFraisHf";
            this.btnSuppFraisHf.Size = new System.Drawing.Size(120, 30);
            this.btnSuppFraisHf.TabIndex = 14;
            this.btnSuppFraisHf.Text = "Supprimer le frais";
            this.btnSuppFraisHf.UseVisualStyleBackColor = true;
            // 
            // frmRemboursement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1253, 621);
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
    }
}