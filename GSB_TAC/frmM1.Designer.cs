
namespace GSB_TAC
{
    partial class frmM1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmM1));
            this.lblInfos = new System.Windows.Forms.Label();
            this.btnModif = new System.Windows.Forms.Button();
            this.txtNouveaunom = new System.Windows.Forms.TextBox();
            this.txtNouveauprenom = new System.Windows.Forms.TextBox();
            this.lblNouveaunom = new System.Windows.Forms.Label();
            this.lblNouveauprenom = new System.Windows.Forms.Label();
            this.btnChangementinfos = new System.Windows.Forms.Button();
            this.lblLabo = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.visiteursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionSecteursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionRégionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionLaboGSBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblSecteur = new System.Windows.Forms.Label();
            this.lblRegion = new System.Windows.Forms.Label();
            this.dgvRegions = new System.Windows.Forms.DataGridView();
            this.bsRegion = new System.Windows.Forms.BindingSource(this.components);
            this.btnDeco = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRegion)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInfos
            // 
            this.lblInfos.AutoSize = true;
            this.lblInfos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfos.Location = new System.Drawing.Point(33, 38);
            this.lblInfos.Name = "lblInfos";
            this.lblInfos.Size = new System.Drawing.Size(125, 17);
            this.lblInfos.TabIndex = 0;
            this.lblInfos.Text = "Infos nominatives :";
            // 
            // btnModif
            // 
            this.btnModif.Location = new System.Drawing.Point(36, 115);
            this.btnModif.Name = "btnModif";
            this.btnModif.Size = new System.Drawing.Size(234, 23);
            this.btnModif.TabIndex = 1;
            this.btnModif.Text = "Modifier informations nominatives";
            this.btnModif.UseVisualStyleBackColor = true;
            this.btnModif.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtNouveaunom
            // 
            this.txtNouveaunom.Location = new System.Drawing.Point(36, 89);
            this.txtNouveaunom.Name = "txtNouveaunom";
            this.txtNouveaunom.Size = new System.Drawing.Size(100, 20);
            this.txtNouveaunom.TabIndex = 2;
            this.txtNouveaunom.Visible = false;
            // 
            // txtNouveauprenom
            // 
            this.txtNouveauprenom.Location = new System.Drawing.Point(170, 89);
            this.txtNouveauprenom.Name = "txtNouveauprenom";
            this.txtNouveauprenom.Size = new System.Drawing.Size(100, 20);
            this.txtNouveauprenom.TabIndex = 3;
            this.txtNouveauprenom.Visible = false;
            // 
            // lblNouveaunom
            // 
            this.lblNouveaunom.AutoSize = true;
            this.lblNouveaunom.Location = new System.Drawing.Point(33, 68);
            this.lblNouveaunom.Name = "lblNouveaunom";
            this.lblNouveaunom.Size = new System.Drawing.Size(35, 13);
            this.lblNouveaunom.TabIndex = 4;
            this.lblNouveaunom.Text = "Nom :";
            this.lblNouveaunom.Visible = false;
            // 
            // lblNouveauprenom
            // 
            this.lblNouveauprenom.AutoSize = true;
            this.lblNouveauprenom.Location = new System.Drawing.Point(167, 68);
            this.lblNouveauprenom.Name = "lblNouveauprenom";
            this.lblNouveauprenom.Size = new System.Drawing.Size(49, 13);
            this.lblNouveauprenom.TabIndex = 5;
            this.lblNouveauprenom.Text = "Prénom :";
            this.lblNouveauprenom.Visible = false;
            // 
            // btnChangementinfos
            // 
            this.btnChangementinfos.Location = new System.Drawing.Point(316, 68);
            this.btnChangementinfos.Name = "btnChangementinfos";
            this.btnChangementinfos.Size = new System.Drawing.Size(75, 23);
            this.btnChangementinfos.TabIndex = 6;
            this.btnChangementinfos.Text = "OK";
            this.btnChangementinfos.UseVisualStyleBackColor = true;
            this.btnChangementinfos.Visible = false;
            this.btnChangementinfos.Click += new System.EventHandler(this.btnChangementinfos_Click);
            // 
            // lblLabo
            // 
            this.lblLabo.AutoSize = true;
            this.lblLabo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLabo.Location = new System.Drawing.Point(313, 38);
            this.lblLabo.Name = "lblLabo";
            this.lblLabo.Size = new System.Drawing.Size(192, 17);
            this.lblLabo.TabIndex = 7;
            this.lblLabo.Text = "Laboratoire d\'appartenance :";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.visiteursToolStripMenuItem,
            this.gestionSecteursToolStripMenuItem,
            this.gestionRégionsToolStripMenuItem,
            this.gestionLaboGSBToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(772, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // visiteursToolStripMenuItem
            // 
            this.visiteursToolStripMenuItem.Name = "visiteursToolStripMenuItem";
            this.visiteursToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.visiteursToolStripMenuItem.Text = "Visiteur(s)";
            this.visiteursToolStripMenuItem.Click += new System.EventHandler(this.visiteursToolStripMenuItem_Click);
            // 
            // gestionSecteursToolStripMenuItem
            // 
            this.gestionSecteursToolStripMenuItem.Name = "gestionSecteursToolStripMenuItem";
            this.gestionSecteursToolStripMenuItem.Size = new System.Drawing.Size(114, 20);
            this.gestionSecteursToolStripMenuItem.Text = "Gestion Secteur(s)";
            this.gestionSecteursToolStripMenuItem.Visible = false;
            this.gestionSecteursToolStripMenuItem.Click += new System.EventHandler(this.gestionSecteursToolStripMenuItem_Click);
            // 
            // gestionRégionsToolStripMenuItem
            // 
            this.gestionRégionsToolStripMenuItem.Name = "gestionRégionsToolStripMenuItem";
            this.gestionRégionsToolStripMenuItem.Size = new System.Drawing.Size(112, 20);
            this.gestionRégionsToolStripMenuItem.Text = "Gestion Région(s)";
            this.gestionRégionsToolStripMenuItem.Visible = false;
            this.gestionRégionsToolStripMenuItem.Click += new System.EventHandler(this.gestionRégionsToolStripMenuItem_Click);
            // 
            // gestionLaboGSBToolStripMenuItem
            // 
            this.gestionLaboGSBToolStripMenuItem.Name = "gestionLaboGSBToolStripMenuItem";
            this.gestionLaboGSBToolStripMenuItem.Size = new System.Drawing.Size(112, 20);
            this.gestionLaboGSBToolStripMenuItem.Text = "Gestion Labo GSB";
            this.gestionLaboGSBToolStripMenuItem.Visible = false;
            this.gestionLaboGSBToolStripMenuItem.Click += new System.EventHandler(this.gestionLaboGSBToolStripMenuItem_Click);
            // 
            // lblSecteur
            // 
            this.lblSecteur.AutoSize = true;
            this.lblSecteur.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecteur.Location = new System.Drawing.Point(524, 38);
            this.lblSecteur.Name = "lblSecteur";
            this.lblSecteur.Size = new System.Drawing.Size(102, 17);
            this.lblSecteur.TabIndex = 9;
            this.lblSecteur.Text = "Secteur géré : ";
            this.lblSecteur.Visible = false;
            // 
            // lblRegion
            // 
            this.lblRegion.AutoSize = true;
            this.lblRegion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegion.Location = new System.Drawing.Point(524, 74);
            this.lblRegion.Name = "lblRegion";
            this.lblRegion.Size = new System.Drawing.Size(140, 17);
            this.lblRegion.TabIndex = 10;
            this.lblRegion.Text = "Région(s) gérée(s) : ";
            this.lblRegion.Visible = false;
            // 
            // dgvRegions
            // 
            this.dgvRegions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegions.Location = new System.Drawing.Point(514, 94);
            this.dgvRegions.Name = "dgvRegions";
            this.dgvRegions.Size = new System.Drawing.Size(246, 106);
            this.dgvRegions.TabIndex = 11;
            this.dgvRegions.Visible = false;
            // 
            // btnDeco
            // 
            this.btnDeco.Location = new System.Drawing.Point(12, 195);
            this.btnDeco.Name = "btnDeco";
            this.btnDeco.Size = new System.Drawing.Size(124, 23);
            this.btnDeco.TabIndex = 12;
            this.btnDeco.Text = "Se déconnecter";
            this.btnDeco.UseVisualStyleBackColor = true;
            this.btnDeco.Click += new System.EventHandler(this.btnDeco_Click);
            // 
            // frmM1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 230);
            this.Controls.Add(this.btnDeco);
            this.Controls.Add(this.dgvRegions);
            this.Controls.Add(this.lblRegion);
            this.Controls.Add(this.lblSecteur);
            this.Controls.Add(this.lblLabo);
            this.Controls.Add(this.btnChangementinfos);
            this.Controls.Add(this.lblNouveauprenom);
            this.Controls.Add(this.lblNouveaunom);
            this.Controls.Add(this.txtNouveauprenom);
            this.Controls.Add(this.txtNouveaunom);
            this.Controls.Add(this.btnModif);
            this.Controls.Add(this.lblInfos);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmM1";
            this.Text = "frmM1";
            this.Load += new System.EventHandler(this.frmM1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRegion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInfos;
        private System.Windows.Forms.Button btnModif;
        private System.Windows.Forms.TextBox txtNouveaunom;
        private System.Windows.Forms.TextBox txtNouveauprenom;
        private System.Windows.Forms.Label lblNouveaunom;
        private System.Windows.Forms.Label lblNouveauprenom;
        private System.Windows.Forms.Button btnChangementinfos;
        private System.Windows.Forms.Label lblLabo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem visiteursToolStripMenuItem;
        private System.Windows.Forms.Label lblSecteur;
        private System.Windows.Forms.ToolStripMenuItem gestionSecteursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionRégionsToolStripMenuItem;
        private System.Windows.Forms.Label lblRegion;
        private System.Windows.Forms.ToolStripMenuItem gestionLaboGSBToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvRegions;
        private System.Windows.Forms.BindingSource bsRegion;
        private System.Windows.Forms.Button btnDeco;
    }
}