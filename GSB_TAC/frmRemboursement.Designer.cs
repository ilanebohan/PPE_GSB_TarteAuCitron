
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
            this.bsVisiteur = new System.Windows.Forms.BindingSource(this.components);
            this.lblBvnVisiteur = new System.Windows.Forms.Label();
            this.lblFicheDePaie = new System.Windows.Forms.Label();
            this.cboDate = new System.Windows.Forms.ComboBox();
            this.bsFicheFrais = new System.Windows.Forms.BindingSource(this.components);
            this.dgvFrais = new System.Windows.Forms.DataGridView();
            this.bsLigneFraisForfait = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.bsVisiteur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFicheFrais)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFrais)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsLigneFraisForfait)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.lblFicheDePaie.Location = new System.Drawing.Point(8, 104);
            this.lblFicheDePaie.Name = "lblFicheDePaie";
            this.lblFicheDePaie.Size = new System.Drawing.Size(140, 13);
            this.lblFicheDePaie.TabIndex = 1;
            this.lblFicheDePaie.Text = "Voici vos fiches de paie du :";
            // 
            // cboDate
            // 
            this.cboDate.FormattingEnabled = true;
            this.cboDate.Location = new System.Drawing.Point(155, 100);
            this.cboDate.Name = "cboDate";
            this.cboDate.Size = new System.Drawing.Size(121, 21);
            this.cboDate.TabIndex = 2;
            // 
            // bsFicheFrais
            // 
            this.bsFicheFrais.CurrentChanged += new System.EventHandler(this.bsFicheFrais_CurrentChanged);
            // 
            // dgvFrais
            // 
            this.dgvFrais.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFrais.Location = new System.Drawing.Point(10, 145);
            this.dgvFrais.Name = "dgvFrais";
            this.dgvFrais.Size = new System.Drawing.Size(465, 430);
            this.dgvFrais.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(675, 145);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(465, 430);
            this.dataGridView1.TabIndex = 4;
            // 
            // frmRemboursement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 596);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dgvFrais);
            this.Controls.Add(this.cboDate);
            this.Controls.Add(this.lblFicheDePaie);
            this.Controls.Add(this.lblBvnVisiteur);
            this.Name = "frmRemboursement";
            this.Text = " ";
            this.Load += new System.EventHandler(this.frmRemboursement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsVisiteur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFicheFrais)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFrais)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsLigneFraisForfait)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}