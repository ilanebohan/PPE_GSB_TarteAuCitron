namespace GSB_TAC
{
    partial class frmLicenciement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLicenciement));
            this.btnValider = new System.Windows.Forms.Button();
            this.cboMotif = new System.Windows.Forms.ComboBox();
            this.dtpDatelicencier = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(139, 52);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(75, 23);
            this.btnValider.TabIndex = 0;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // cboMotif
            // 
            this.cboMotif.FormattingEnabled = true;
            this.cboMotif.Items.AddRange(new object[] {
            "Démission",
            "Licenciement"});
            this.cboMotif.Location = new System.Drawing.Point(22, 25);
            this.cboMotif.Name = "cboMotif";
            this.cboMotif.Size = new System.Drawing.Size(121, 21);
            this.cboMotif.TabIndex = 1;
            // 
            // dtpDatelicencier
            // 
            this.dtpDatelicencier.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDatelicencier.Location = new System.Drawing.Point(181, 25);
            this.dtpDatelicencier.Name = "dtpDatelicencier";
            this.dtpDatelicencier.Size = new System.Drawing.Size(94, 20);
            this.dtpDatelicencier.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(178, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Date :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Motif : ";
            // 
            // frmLicenciement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 101);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpDatelicencier);
            this.Controls.Add(this.cboMotif);
            this.Controls.Add(this.btnValider);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLicenciement";
            this.Text = "frmLicenciement";
            this.Load += new System.EventHandler(this.frmLicenciement_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.ComboBox cboMotif;
        private System.Windows.Forms.DateTimePicker dtpDatelicencier;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}