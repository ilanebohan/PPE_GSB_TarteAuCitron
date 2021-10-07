
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
            this.lblInfoVisiteur = new System.Windows.Forms.Label();
            this.lblAction = new System.Windows.Forms.Label();
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
            this.lblAction.Size = new System.Drawing.Size(0, 13);
            this.lblAction.TabIndex = 1;
            // 
            // frmAjoutFrais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 319);
            this.Controls.Add(this.lblAction);
            this.Controls.Add(this.lblInfoVisiteur);
            this.Name = "frmAjoutFrais";
            this.Text = "frmAjoutFrais";
            this.Load += new System.EventHandler(this.frmAjoutFrais_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInfoVisiteur;
        private System.Windows.Forms.Label lblAction;
    }
}