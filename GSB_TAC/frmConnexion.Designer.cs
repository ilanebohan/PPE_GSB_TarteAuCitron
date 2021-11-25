
namespace GSB_TAC
{
    partial class frmConnexion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConnexion));
            this.btnConnexion = new System.Windows.Forms.Button();
            this.lblIdentifiant = new System.Windows.Forms.Label();
            this.lblMDP = new System.Windows.Forms.Label();
            this.txtIdentifiant = new System.Windows.Forms.TextBox();
            this.txtMDP = new System.Windows.Forms.TextBox();
            this.btnChangemdp = new System.Windows.Forms.Button();
            this.txtAncienmdp = new System.Windows.Forms.TextBox();
            this.txtNouveaumdp = new System.Windows.Forms.TextBox();
            this.lblAncienmdp = new System.Windows.Forms.Label();
            this.lblNouveaumdp = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnConnexion
            // 
            this.btnConnexion.Location = new System.Drawing.Point(238, 260);
            this.btnConnexion.Name = "btnConnexion";
            this.btnConnexion.Size = new System.Drawing.Size(75, 23);
            this.btnConnexion.TabIndex = 0;
            this.btnConnexion.Text = "Connexion";
            this.btnConnexion.UseVisualStyleBackColor = true;
            this.btnConnexion.Click += new System.EventHandler(this.btnConnexion_Click);
            // 
            // lblIdentifiant
            // 
            this.lblIdentifiant.AutoSize = true;
            this.lblIdentifiant.Location = new System.Drawing.Point(104, 83);
            this.lblIdentifiant.Name = "lblIdentifiant";
            this.lblIdentifiant.Size = new System.Drawing.Size(62, 13);
            this.lblIdentifiant.TabIndex = 1;
            this.lblIdentifiant.Text = "Identifiant : ";
            // 
            // lblMDP
            // 
            this.lblMDP.AutoSize = true;
            this.lblMDP.Location = new System.Drawing.Point(104, 156);
            this.lblMDP.Name = "lblMDP";
            this.lblMDP.Size = new System.Drawing.Size(77, 13);
            this.lblMDP.TabIndex = 2;
            this.lblMDP.Text = "Mot de passe :";
            // 
            // txtIdentifiant
            // 
            this.txtIdentifiant.Location = new System.Drawing.Point(229, 76);
            this.txtIdentifiant.Name = "txtIdentifiant";
            this.txtIdentifiant.Size = new System.Drawing.Size(100, 20);
            this.txtIdentifiant.TabIndex = 3;
            // 
            // txtMDP
            // 
            this.txtMDP.Location = new System.Drawing.Point(229, 149);
            this.txtMDP.Name = "txtMDP";
            this.txtMDP.Size = new System.Drawing.Size(100, 20);
            this.txtMDP.TabIndex = 4;
            // 
            // btnChangemdp
            // 
            this.btnChangemdp.Location = new System.Drawing.Point(202, 301);
            this.btnChangemdp.Name = "btnChangemdp";
            this.btnChangemdp.Size = new System.Drawing.Size(150, 23);
            this.btnChangemdp.TabIndex = 5;
            this.btnChangemdp.Text = "Changer de mot de passe";
            this.btnChangemdp.UseVisualStyleBackColor = true;
            this.btnChangemdp.Click += new System.EventHandler(this.btnChangemdp_Click);
            // 
            // txtAncienmdp
            // 
            this.txtAncienmdp.Location = new System.Drawing.Point(158, 210);
            this.txtAncienmdp.Name = "txtAncienmdp";
            this.txtAncienmdp.Size = new System.Drawing.Size(100, 20);
            this.txtAncienmdp.TabIndex = 6;
            this.txtAncienmdp.Visible = false;
            // 
            // txtNouveaumdp
            // 
            this.txtNouveaumdp.Location = new System.Drawing.Point(431, 210);
            this.txtNouveaumdp.Name = "txtNouveaumdp";
            this.txtNouveaumdp.Size = new System.Drawing.Size(100, 20);
            this.txtNouveaumdp.TabIndex = 7;
            this.txtNouveaumdp.Visible = false;
            // 
            // lblAncienmdp
            // 
            this.lblAncienmdp.AutoSize = true;
            this.lblAncienmdp.Location = new System.Drawing.Point(12, 213);
            this.lblAncienmdp.Name = "lblAncienmdp";
            this.lblAncienmdp.Size = new System.Drawing.Size(112, 13);
            this.lblAncienmdp.TabIndex = 8;
            this.lblAncienmdp.Text = "Ancien mot de passe :";
            this.lblAncienmdp.Visible = false;
            // 
            // lblNouveaumdp
            // 
            this.lblNouveaumdp.AutoSize = true;
            this.lblNouveaumdp.Location = new System.Drawing.Point(282, 213);
            this.lblNouveaumdp.Name = "lblNouveaumdp";
            this.lblNouveaumdp.Size = new System.Drawing.Size(123, 13);
            this.lblNouveaumdp.TabIndex = 9;
            this.lblNouveaumdp.Text = "Nouveau mot de passe :";
            this.lblNouveaumdp.Visible = false;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(456, 260);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 10;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Visible = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // frmConnexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GSB_TAC.Properties.Resources.logo___CONNEXION;
            this.ClientSize = new System.Drawing.Size(631, 374);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lblNouveaumdp);
            this.Controls.Add(this.lblAncienmdp);
            this.Controls.Add(this.txtNouveaumdp);
            this.Controls.Add(this.txtAncienmdp);
            this.Controls.Add(this.btnChangemdp);
            this.Controls.Add(this.txtMDP);
            this.Controls.Add(this.txtIdentifiant);
            this.Controls.Add(this.lblMDP);
            this.Controls.Add(this.lblIdentifiant);
            this.Controls.Add(this.btnConnexion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmConnexion";
            this.Text = "frmConnexion";
            this.Load += new System.EventHandler(this.frmConnexion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConnexion;
        private System.Windows.Forms.Label lblIdentifiant;
        private System.Windows.Forms.Label lblMDP;
        private System.Windows.Forms.TextBox txtIdentifiant;
        private System.Windows.Forms.TextBox txtMDP;
        private System.Windows.Forms.Button btnChangemdp;
        private System.Windows.Forms.TextBox txtAncienmdp;
        private System.Windows.Forms.TextBox txtNouveaumdp;
        private System.Windows.Forms.Label lblAncienmdp;
        private System.Windows.Forms.Label lblNouveaumdp;
        private System.Windows.Forms.Button btnOK;
    }
}