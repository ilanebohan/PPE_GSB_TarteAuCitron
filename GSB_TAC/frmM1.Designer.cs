
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
            this.lblInfos = new System.Windows.Forms.Label();
            this.btnModif = new System.Windows.Forms.Button();
            this.txtNouveaunom = new System.Windows.Forms.TextBox();
            this.txtNouveauprenom = new System.Windows.Forms.TextBox();
            this.lblNouveaunom = new System.Windows.Forms.Label();
            this.lblNouveauprenom = new System.Windows.Forms.Label();
            this.btnChangementinfos = new System.Windows.Forms.Button();
            this.lblLabo = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.budgetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visiteursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblSecteur = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblInfos
            // 
            this.lblInfos.AutoSize = true;
            this.lblInfos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfos.Location = new System.Drawing.Point(33, 38);
            this.lblInfos.Name = "lblInfos";
            this.lblInfos.Size = new System.Drawing.Size(13, 17);
            this.lblInfos.TabIndex = 0;
            this.lblInfos.Text = "-";
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
            // 
            // lblLabo
            // 
            this.lblLabo.AutoSize = true;
            this.lblLabo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLabo.Location = new System.Drawing.Point(313, 38);
            this.lblLabo.Name = "lblLabo";
            this.lblLabo.Size = new System.Drawing.Size(13, 17);
            this.lblLabo.TabIndex = 7;
            this.lblLabo.Text = "-";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.budgetToolStripMenuItem,
            this.visiteursToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // budgetToolStripMenuItem
            // 
            this.budgetToolStripMenuItem.Name = "budgetToolStripMenuItem";
            this.budgetToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.budgetToolStripMenuItem.Text = "Budget(s)";
            this.budgetToolStripMenuItem.Click += new System.EventHandler(this.budgetToolStripMenuItem_Click);
            // 
            // visiteursToolStripMenuItem
            // 
            this.visiteursToolStripMenuItem.Name = "visiteursToolStripMenuItem";
            this.visiteursToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.visiteursToolStripMenuItem.Text = "Visiteur(s)";
            this.visiteursToolStripMenuItem.Click += new System.EventHandler(this.visiteursToolStripMenuItem_Click);
            // 
            // lblSecteur
            // 
            this.lblSecteur.AutoSize = true;
            this.lblSecteur.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecteur.Location = new System.Drawing.Point(524, 38);
            this.lblSecteur.Name = "lblSecteur";
            this.lblSecteur.Size = new System.Drawing.Size(13, 17);
            this.lblSecteur.TabIndex = 9;
            this.lblSecteur.Text = "-";
            this.lblSecteur.Visible = false;
            // 
            // frmM1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmM1";
            this.Text = "frmM1";
            this.Load += new System.EventHandler(this.frmM1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.ToolStripMenuItem budgetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visiteursToolStripMenuItem;
        private System.Windows.Forms.Label lblSecteur;
    }
}