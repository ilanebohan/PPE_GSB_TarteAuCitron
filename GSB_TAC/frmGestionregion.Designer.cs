namespace GSB_TAC
{
    partial class frmGestionregion
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
            this.bsVisiteur = new System.Windows.Forms.BindingSource(this.components);
            this.dgvVisiteur = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnLicenciement = new System.Windows.Forms.Button();
            this.txtNewid = new System.Windows.Forms.TextBox();
            this.txtNewidentifiant = new System.Windows.Forms.TextBox();
            this.txtNewprenom = new System.Windows.Forms.TextBox();
            this.txtNewrue = new System.Windows.Forms.TextBox();
            this.txtNewnom = new System.Windows.Forms.TextBox();
            this.txtNewVille = new System.Windows.Forms.TextBox();
            this.txtNewcp = new System.Windows.Forms.TextBox();
            this.txtNewpass = new System.Windows.Forms.TextBox();
            this.cboLabo = new System.Windows.Forms.ComboBox();
            this.btnCreatenew = new System.Windows.Forms.Button();
            this.dateEmbauche = new System.Windows.Forms.DateTimePicker();
            this.bsLabo = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.error1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnAssocier = new System.Windows.Forms.Button();
            this.btnDissocier = new System.Windows.Forms.Button();
            this.bsRegion = new System.Windows.Forms.BindingSource(this.components);
            this.btnTousvisiteurs = new System.Windows.Forms.Button();
            this.btnVisiteurparregion = new System.Windows.Forms.Button();
            this.dgvRegion = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.bsVisiteur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisiteur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsLabo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRegion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegion)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVisiteur
            // 
            this.dgvVisiteur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVisiteur.Location = new System.Drawing.Point(24, 29);
            this.dgvVisiteur.Name = "dgvVisiteur";
            this.dgvVisiteur.Size = new System.Drawing.Size(381, 154);
            this.dgvVisiteur.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 189);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Rendre actif";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(105, 189);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Rendre inactif";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnLicenciement
            // 
            this.btnLicenciement.Location = new System.Drawing.Point(204, 189);
            this.btnLicenciement.Name = "btnLicenciement";
            this.btnLicenciement.Size = new System.Drawing.Size(75, 23);
            this.btnLicenciement.TabIndex = 4;
            this.btnLicenciement.Text = "Licencier";
            this.btnLicenciement.UseVisualStyleBackColor = true;
            this.btnLicenciement.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtNewid
            // 
            this.txtNewid.Location = new System.Drawing.Point(24, 317);
            this.txtNewid.Name = "txtNewid";
            this.txtNewid.Size = new System.Drawing.Size(75, 20);
            this.txtNewid.TabIndex = 5;
            // 
            // txtNewidentifiant
            // 
            this.txtNewidentifiant.Location = new System.Drawing.Point(589, 317);
            this.txtNewidentifiant.Name = "txtNewidentifiant";
            this.txtNewidentifiant.Size = new System.Drawing.Size(100, 20);
            this.txtNewidentifiant.TabIndex = 6;
            // 
            // txtNewprenom
            // 
            this.txtNewprenom.Location = new System.Drawing.Point(24, 392);
            this.txtNewprenom.Name = "txtNewprenom";
            this.txtNewprenom.Size = new System.Drawing.Size(100, 20);
            this.txtNewprenom.TabIndex = 7;
            // 
            // txtNewrue
            // 
            this.txtNewrue.Location = new System.Drawing.Point(158, 317);
            this.txtNewrue.Name = "txtNewrue";
            this.txtNewrue.Size = new System.Drawing.Size(159, 20);
            this.txtNewrue.TabIndex = 9;
            // 
            // txtNewnom
            // 
            this.txtNewnom.Location = new System.Drawing.Point(23, 356);
            this.txtNewnom.Name = "txtNewnom";
            this.txtNewnom.Size = new System.Drawing.Size(100, 20);
            this.txtNewnom.TabIndex = 10;
            // 
            // txtNewVille
            // 
            this.txtNewVille.Location = new System.Drawing.Point(158, 392);
            this.txtNewVille.Name = "txtNewVille";
            this.txtNewVille.Size = new System.Drawing.Size(159, 20);
            this.txtNewVille.TabIndex = 11;
            // 
            // txtNewcp
            // 
            this.txtNewcp.Location = new System.Drawing.Point(158, 356);
            this.txtNewcp.Name = "txtNewcp";
            this.txtNewcp.Size = new System.Drawing.Size(159, 20);
            this.txtNewcp.TabIndex = 12;
            // 
            // txtNewpass
            // 
            this.txtNewpass.Location = new System.Drawing.Point(589, 392);
            this.txtNewpass.Name = "txtNewpass";
            this.txtNewpass.Size = new System.Drawing.Size(100, 20);
            this.txtNewpass.TabIndex = 13;
            // 
            // cboLabo
            // 
            this.cboLabo.FormattingEnabled = true;
            this.cboLabo.Location = new System.Drawing.Point(349, 391);
            this.cboLabo.Name = "cboLabo";
            this.cboLabo.Size = new System.Drawing.Size(98, 21);
            this.cboLabo.TabIndex = 14;
            // 
            // btnCreatenew
            // 
            this.btnCreatenew.Location = new System.Drawing.Point(201, 418);
            this.btnCreatenew.Name = "btnCreatenew";
            this.btnCreatenew.Size = new System.Drawing.Size(300, 23);
            this.btnCreatenew.TabIndex = 15;
            this.btnCreatenew.Text = "Nouveau visiteur";
            this.btnCreatenew.UseVisualStyleBackColor = true;
            this.btnCreatenew.Click += new System.EventHandler(this.btnCreatenew_Click);
            // 
            // dateEmbauche
            // 
            this.dateEmbauche.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateEmbauche.Location = new System.Drawing.Point(349, 317);
            this.dateEmbauche.MaxDate = new System.DateTime(2050, 12, 31, 0, 0, 0, 0);
            this.dateEmbauche.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.dateEmbauche.Name = "dateEmbauche";
            this.dateEmbauche.Size = new System.Drawing.Size(98, 20);
            this.dateEmbauche.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 301);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "ID :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 340);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Nom :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 379);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Prénom : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(155, 301);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Adresse :";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(155, 340);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Code Postal :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(155, 376);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Ville : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(346, 301);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Date Embauche : ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(346, 375);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "Laboratoire : ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(586, 375);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 13);
            this.label10.TabIndex = 26;
            this.label10.Text = "Mot de passe :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(586, 301);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 13);
            this.label11.TabIndex = 27;
            this.label11.Text = "Identifiant : ";
            // 
            // error1
            // 
            this.error1.ContainerControl = this;
            // 
            // btnAssocier
            // 
            this.btnAssocier.Location = new System.Drawing.Point(402, 189);
            this.btnAssocier.Name = "btnAssocier";
            this.btnAssocier.Size = new System.Drawing.Size(75, 23);
            this.btnAssocier.TabIndex = 28;
            this.btnAssocier.Text = "Associer";
            this.btnAssocier.UseVisualStyleBackColor = true;
            this.btnAssocier.Click += new System.EventHandler(this.btnAssocier_Click);
            // 
            // btnDissocier
            // 
            this.btnDissocier.Location = new System.Drawing.Point(321, 189);
            this.btnDissocier.Name = "btnDissocier";
            this.btnDissocier.Size = new System.Drawing.Size(75, 23);
            this.btnDissocier.TabIndex = 29;
            this.btnDissocier.Text = "Dissocier";
            this.btnDissocier.UseVisualStyleBackColor = true;
            this.btnDissocier.Click += new System.EventHandler(this.btnDissocier_Click);
            // 
            // bsRegion
            // 
            this.bsRegion.CurrentChanged += new System.EventHandler(this.bsRegion_CurrentChanged);
            // 
            // btnTousvisiteurs
            // 
            this.btnTousvisiteurs.Location = new System.Drawing.Point(277, 229);
            this.btnTousvisiteurs.Name = "btnTousvisiteurs";
            this.btnTousvisiteurs.Size = new System.Drawing.Size(162, 23);
            this.btnTousvisiteurs.TabIndex = 31;
            this.btnTousvisiteurs.Text = "Tout les visiteur(s)";
            this.btnTousvisiteurs.UseVisualStyleBackColor = true;
            this.btnTousvisiteurs.Click += new System.EventHandler(this.btnTousvisiteurs_Click);
            // 
            // btnVisiteurparregion
            // 
            this.btnVisiteurparregion.Location = new System.Drawing.Point(277, 258);
            this.btnVisiteurparregion.Name = "btnVisiteurparregion";
            this.btnVisiteurparregion.Size = new System.Drawing.Size(162, 23);
            this.btnVisiteurparregion.TabIndex = 32;
            this.btnVisiteurparregion.Text = "Visiteur(s) par région";
            this.btnVisiteurparregion.UseVisualStyleBackColor = true;
            this.btnVisiteurparregion.Click += new System.EventHandler(this.btnVisiteurparregion_Click);
            // 
            // dgvRegion
            // 
            this.dgvRegion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegion.Location = new System.Drawing.Point(411, 29);
            this.dgvRegion.Name = "dgvRegion";
            this.dgvRegion.Size = new System.Drawing.Size(381, 154);
            this.dgvRegion.TabIndex = 33;
            // 
            // frmGestionregion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvRegion);
            this.Controls.Add(this.btnVisiteurparregion);
            this.Controls.Add(this.btnTousvisiteurs);
            this.Controls.Add(this.btnDissocier);
            this.Controls.Add(this.btnAssocier);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateEmbauche);
            this.Controls.Add(this.btnCreatenew);
            this.Controls.Add(this.cboLabo);
            this.Controls.Add(this.txtNewpass);
            this.Controls.Add(this.txtNewcp);
            this.Controls.Add(this.txtNewVille);
            this.Controls.Add(this.txtNewnom);
            this.Controls.Add(this.txtNewrue);
            this.Controls.Add(this.txtNewprenom);
            this.Controls.Add(this.txtNewidentifiant);
            this.Controls.Add(this.txtNewid);
            this.Controls.Add(this.btnLicenciement);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvVisiteur);
            this.Name = "frmGestionregion";
            this.Text = "frmGestionregion";
            this.Load += new System.EventHandler(this.frmGestionregion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsVisiteur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisiteur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsLabo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRegion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bsVisiteur;
        private System.Windows.Forms.DataGridView dgvVisiteur;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnLicenciement;
        private System.Windows.Forms.TextBox txtNewid;
        private System.Windows.Forms.TextBox txtNewidentifiant;
        private System.Windows.Forms.TextBox txtNewprenom;
        private System.Windows.Forms.TextBox txtNewrue;
        private System.Windows.Forms.TextBox txtNewnom;
        private System.Windows.Forms.TextBox txtNewVille;
        private System.Windows.Forms.TextBox txtNewcp;
        private System.Windows.Forms.TextBox txtNewpass;
        private System.Windows.Forms.ComboBox cboLabo;
        private System.Windows.Forms.Button btnCreatenew;
        private System.Windows.Forms.DateTimePicker dateEmbauche;
        private System.Windows.Forms.BindingSource bsLabo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ErrorProvider error1;
        private System.Windows.Forms.Button btnDissocier;
        private System.Windows.Forms.Button btnAssocier;
        private System.Windows.Forms.BindingSource bsRegion;
        private System.Windows.Forms.Button btnTousvisiteurs;
        private System.Windows.Forms.Button btnVisiteurparregion;
        private System.Windows.Forms.DataGridView dgvRegion;
    }
}