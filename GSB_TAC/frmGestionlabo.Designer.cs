namespace GSB_TAC
{
    partial class frmGestionlabo
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
            this.dgvSecteur = new System.Windows.Forms.DataGridView();
            this.bsSecteur = new System.Windows.Forms.BindingSource(this.components);
            this.dgvVisiteur = new System.Windows.Forms.DataGridView();
            this.bsVisiteur = new System.Windows.Forms.BindingSource(this.components);
            this.btnActiver = new System.Windows.Forms.Button();
            this.btnDesactiver = new System.Windows.Forms.Button();
            this.btnPasserresp = new System.Windows.Forms.Button();
            this.btnToutvisiteur = new System.Windows.Forms.Button();
            this.lblRespsect = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSecteur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSecteur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisiteur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsVisiteur)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSecteur
            // 
            this.dgvSecteur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSecteur.Location = new System.Drawing.Point(12, 41);
            this.dgvSecteur.Name = "dgvSecteur";
            this.dgvSecteur.Size = new System.Drawing.Size(334, 239);
            this.dgvSecteur.TabIndex = 0;
            // 
            // dgvVisiteur
            // 
            this.dgvVisiteur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVisiteur.Location = new System.Drawing.Point(440, 41);
            this.dgvVisiteur.Name = "dgvVisiteur";
            this.dgvVisiteur.Size = new System.Drawing.Size(348, 239);
            this.dgvVisiteur.TabIndex = 1;
            // 
            // btnActiver
            // 
            this.btnActiver.Location = new System.Drawing.Point(440, 12);
            this.btnActiver.Name = "btnActiver";
            this.btnActiver.Size = new System.Drawing.Size(75, 23);
            this.btnActiver.TabIndex = 2;
            this.btnActiver.Text = "Activer";
            this.btnActiver.UseVisualStyleBackColor = true;
            this.btnActiver.Click += new System.EventHandler(this.btnActiver_Click);
            // 
            // btnDesactiver
            // 
            this.btnDesactiver.Location = new System.Drawing.Point(535, 12);
            this.btnDesactiver.Name = "btnDesactiver";
            this.btnDesactiver.Size = new System.Drawing.Size(75, 23);
            this.btnDesactiver.TabIndex = 3;
            this.btnDesactiver.Text = "Désactiver";
            this.btnDesactiver.UseVisualStyleBackColor = true;
            this.btnDesactiver.Click += new System.EventHandler(this.btnDesactiver_Click);
            // 
            // btnPasserresp
            // 
            this.btnPasserresp.Location = new System.Drawing.Point(234, 12);
            this.btnPasserresp.Name = "btnPasserresp";
            this.btnPasserresp.Size = new System.Drawing.Size(187, 23);
            this.btnPasserresp.TabIndex = 4;
            this.btnPasserresp.Text = "Passer responsable du secteur";
            this.btnPasserresp.UseVisualStyleBackColor = true;
            this.btnPasserresp.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnToutvisiteur
            // 
            this.btnToutvisiteur.Location = new System.Drawing.Point(646, 12);
            this.btnToutvisiteur.Name = "btnToutvisiteur";
            this.btnToutvisiteur.Size = new System.Drawing.Size(134, 23);
            this.btnToutvisiteur.TabIndex = 5;
            this.btnToutvisiteur.Text = "Tout les visiteurs";
            this.btnToutvisiteur.UseVisualStyleBackColor = true;
            this.btnToutvisiteur.Click += new System.EventHandler(this.btnToutvisiteur_Click);
            // 
            // lblRespsect
            // 
            this.lblRespsect.AutoSize = true;
            this.lblRespsect.Location = new System.Drawing.Point(12, 17);
            this.lblRespsect.Name = "lblRespsect";
            this.lblRespsect.Size = new System.Drawing.Size(116, 13);
            this.lblRespsect.TabIndex = 6;
            this.lblRespsect.Text = "Responsable secteur : ";
            // 
            // frmGestionlabo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 299);
            this.Controls.Add(this.lblRespsect);
            this.Controls.Add(this.btnToutvisiteur);
            this.Controls.Add(this.btnPasserresp);
            this.Controls.Add(this.btnDesactiver);
            this.Controls.Add(this.btnActiver);
            this.Controls.Add(this.dgvVisiteur);
            this.Controls.Add(this.dgvSecteur);
            this.Name = "frmGestionlabo";
            this.Text = "frmGestionlabo";
            this.Load += new System.EventHandler(this.frmGestionlabo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSecteur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSecteur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisiteur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsVisiteur)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bsSecteur;
        private System.Windows.Forms.DataGridView dgvSecteur;
        private System.Windows.Forms.DataGridView dgvVisiteur;
        private System.Windows.Forms.BindingSource bsVisiteur;
        private System.Windows.Forms.Button btnActiver;
        private System.Windows.Forms.Button btnDesactiver;
        private System.Windows.Forms.Button btnPasserresp;
        private System.Windows.Forms.Button btnToutvisiteur;
        private System.Windows.Forms.Label lblRespsect;
    }
}