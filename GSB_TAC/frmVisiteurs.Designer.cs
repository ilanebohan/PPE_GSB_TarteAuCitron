
namespace GSB_TAC
{
    partial class frmVisiteurs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVisiteurs));
            this.dgvVisiteur = new System.Windows.Forms.DataGridView();
            this.lblRespsecteur = new System.Windows.Forms.Label();
            this.cboSecteur = new System.Windows.Forms.ComboBox();
            this.dgvRegion = new System.Windows.Forms.DataGridView();
            this.lblRespregion = new System.Windows.Forms.Label();
            this.lblPasdevisiteur = new System.Windows.Forms.Label();
            this.bsVisiteur = new System.Windows.Forms.BindingSource(this.components);
            this.bsSecteur = new System.Windows.Forms.BindingSource(this.components);
            this.bsRegion = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisiteur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsVisiteur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSecteur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRegion)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVisiteur
            // 
            this.dgvVisiteur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVisiteur.Location = new System.Drawing.Point(457, 154);
            this.dgvVisiteur.Name = "dgvVisiteur";
            this.dgvVisiteur.Size = new System.Drawing.Size(316, 234);
            this.dgvVisiteur.TabIndex = 0;
            // 
            // lblRespsecteur
            // 
            this.lblRespsecteur.AutoSize = true;
            this.lblRespsecteur.Location = new System.Drawing.Point(78, 89);
            this.lblRespsecteur.Name = "lblRespsecteur";
            this.lblRespsecteur.Size = new System.Drawing.Size(116, 13);
            this.lblRespsecteur.TabIndex = 3;
            this.lblRespsecteur.Text = "Responsable secteur : ";
            // 
            // cboSecteur
            // 
            this.cboSecteur.FormattingEnabled = true;
            this.cboSecteur.Location = new System.Drawing.Point(81, 40);
            this.cboSecteur.Name = "cboSecteur";
            this.cboSecteur.Size = new System.Drawing.Size(121, 21);
            this.cboSecteur.TabIndex = 5;
            // 
            // dgvRegion
            // 
            this.dgvRegion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegion.Location = new System.Drawing.Point(12, 154);
            this.dgvRegion.Name = "dgvRegion";
            this.dgvRegion.Size = new System.Drawing.Size(310, 234);
            this.dgvRegion.TabIndex = 6;
            // 
            // lblRespregion
            // 
            this.lblRespregion.AutoSize = true;
            this.lblRespregion.Location = new System.Drawing.Point(78, 122);
            this.lblRespregion.Name = "lblRespregion";
            this.lblRespregion.Size = new System.Drawing.Size(110, 13);
            this.lblRespregion.TabIndex = 7;
            this.lblRespregion.Text = "Responsable region : ";
            // 
            // lblPasdevisiteur
            // 
            this.lblPasdevisiteur.AutoSize = true;
            this.lblPasdevisiteur.Location = new System.Drawing.Point(487, 200);
            this.lblPasdevisiteur.Name = "lblPasdevisiteur";
            this.lblPasdevisiteur.Size = new System.Drawing.Size(217, 13);
            this.lblPasdevisiteur.TabIndex = 8;
            this.lblPasdevisiteur.Text = "/!\\ Aucun visiteurs attribué à cette région /!\\";
            this.lblPasdevisiteur.Visible = false;
            // 
            // bsSecteur
            // 
            this.bsSecteur.CurrentChanged += new System.EventHandler(this.bsSecteur_CurrentChanged);
            // 
            // bsRegion
            // 
            this.bsRegion.CurrentChanged += new System.EventHandler(this.bsRegion_CurrentChanged);
            // 
            // frmVisiteurs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPasdevisiteur);
            this.Controls.Add(this.lblRespregion);
            this.Controls.Add(this.dgvRegion);
            this.Controls.Add(this.cboSecteur);
            this.Controls.Add(this.lblRespsecteur);
            this.Controls.Add(this.dgvVisiteur);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmVisiteurs";
            this.Text = "frmVisiteurs";
            this.Load += new System.EventHandler(this.frmVisiteurs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisiteur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsVisiteur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSecteur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRegion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bsVisiteur;
        private System.Windows.Forms.DataGridView dgvVisiteur;
        private System.Windows.Forms.Label lblRespsecteur;
        private System.Windows.Forms.ComboBox cboSecteur;
        private System.Windows.Forms.BindingSource bsSecteur;
        private System.Windows.Forms.BindingSource bsRegion;
        private System.Windows.Forms.DataGridView dgvRegion;
        private System.Windows.Forms.Label lblRespregion;
        private System.Windows.Forms.Label lblPasdevisiteur;
    }
}