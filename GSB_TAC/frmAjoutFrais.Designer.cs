
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
            this.cboTypeFrais.Location = new System.Drawing.Point(115, 70);
            this.cboTypeFrais.Name = "cboTypeFrais";
            this.cboTypeFrais.Size = new System.Drawing.Size(121, 21);
            this.cboTypeFrais.TabIndex = 2;
            // 
            // txtbQte
            // 
            this.txtbQte.Location = new System.Drawing.Point(115, 105);
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
            this.lblQte.Location = new System.Drawing.Point(15, 110);
            this.lblQte.Name = "lblQte";
            this.lblQte.Size = new System.Drawing.Size(53, 13);
            this.lblQte.TabIndex = 5;
            this.lblQte.Text = "Quantité :";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(355, 145);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Annuler";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(270, 145);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(75, 23);
            this.btnValider.TabIndex = 7;
            this.btnValider.Text = "Ajouter";
            this.btnValider.UseVisualStyleBackColor = true;
            // 
            // frmAjoutFrais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 175);
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
    }
}