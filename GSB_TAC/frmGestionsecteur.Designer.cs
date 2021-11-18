namespace GSB_TAC
{
    partial class frmGestionsecteur
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestionsecteur));
            this.lblSecteurgerer = new System.Windows.Forms.Label();
            this.lblRegion = new System.Windows.Forms.Label();
            this.lblRespreg = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.error1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.dgvVisiteur = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.bsRegion = new System.Windows.Forms.BindingSource(this.components);
            this.bsVisiteur = new System.Windows.Forms.BindingSource(this.components);
            this.dgvRegion = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.error1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisiteur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRegion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsVisiteur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegion)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSecteurgerer
            // 
            this.lblSecteurgerer.AutoSize = true;
            this.lblSecteurgerer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecteurgerer.Location = new System.Drawing.Point(37, 20);
            this.lblSecteurgerer.Name = "lblSecteurgerer";
            this.lblSecteurgerer.Size = new System.Drawing.Size(104, 18);
            this.lblSecteurgerer.TabIndex = 1;
            this.lblSecteurgerer.Text = "Secteur géré : ";
            // 
            // lblRegion
            // 
            this.lblRegion.AutoSize = true;
            this.lblRegion.Location = new System.Drawing.Point(26, 61);
            this.lblRegion.Name = "lblRegion";
            this.lblRegion.Size = new System.Drawing.Size(61, 13);
            this.lblRegion.TabIndex = 2;
            this.lblRegion.Text = "Région(s) : ";
            // 
            // lblRespreg
            // 
            this.lblRespreg.AutoSize = true;
            this.lblRespreg.Location = new System.Drawing.Point(26, 318);
            this.lblRespreg.Name = "lblRespreg";
            this.lblRespreg.Size = new System.Drawing.Size(75, 13);
            this.lblRespreg.TabIndex = 8;
            this.lblRespreg.Text = "Responsable :";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(406, 176);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(226, 23);
            this.btnOK.TabIndex = 9;
            this.btnOK.Text = "Passer responsable de Région";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // error1
            // 
            this.error1.ContainerControl = this;
            // 
            // dgvVisiteur
            // 
            this.dgvVisiteur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVisiteur.Location = new System.Drawing.Point(354, 20);
            this.dgvVisiteur.Name = "dgvVisiteur";
            this.dgvVisiteur.Size = new System.Drawing.Size(329, 150);
            this.dgvVisiteur.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(354, 247);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Rendre actif";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(565, 247);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Rendre inactif";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(454, 276);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(132, 23);
            this.button3.TabIndex = 13;
            this.button3.Text = "Licencier";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // bsRegion
            // 
            this.bsRegion.CurrentChanged += new System.EventHandler(this.bsRegion_CurrentChanged);
            // 
            // dgvRegion
            // 
            this.dgvRegion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegion.Location = new System.Drawing.Point(29, 77);
            this.dgvRegion.Name = "dgvRegion";
            this.dgvRegion.Size = new System.Drawing.Size(300, 193);
            this.dgvRegion.TabIndex = 14;
            // 
            // frmGestionsecteur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 370);
            this.Controls.Add(this.dgvRegion);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvVisiteur);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lblRespreg);
            this.Controls.Add(this.lblRegion);
            this.Controls.Add(this.lblSecteurgerer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmGestionsecteur";
            this.Text = "frmGestionsecteur";
            this.Load += new System.EventHandler(this.frmGestionsecteur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.error1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisiteur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRegion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsVisiteur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblSecteurgerer;
        private System.Windows.Forms.Label lblRegion;
        private System.Windows.Forms.BindingSource bsRegion;
        private System.Windows.Forms.Label lblRespreg;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.ErrorProvider error1;
        private System.Windows.Forms.DataGridView dgvVisiteur;
        private System.Windows.Forms.BindingSource bsVisiteur;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvRegion;
    }
}