namespace OptimizeEnergyConsumption
{
    partial class FormAppareilAjoutHeure
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
            this.listBoxHeureMarche = new System.Windows.Forms.ListBox();
            this.lbA = new System.Windows.Forms.Label();
            this.cbHeureFinMarche = new System.Windows.Forms.ComboBox();
            this.lbDe = new System.Windows.Forms.Label();
            this.cbHeureDebutMarche = new System.Windows.Forms.ComboBox();
            this.lbChoixHeureAppareilMarche = new System.Windows.Forms.Label();
            this.listBoxHeureVeille = new System.Windows.Forms.ListBox();
            this.lbA2 = new System.Windows.Forms.Label();
            this.cbHeureFinVeille = new System.Windows.Forms.ComboBox();
            this.lbDe2 = new System.Windows.Forms.Label();
            this.cbHeureDebutVeille = new System.Windows.Forms.ComboBox();
            this.lbChoixHeureAppareilVeille = new System.Windows.Forms.Label();
            this.btValider = new System.Windows.Forms.Button();
            this.btAjoutHeureMarche = new System.Windows.Forms.Button();
            this.btAjoutHeureVeille = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxHeureMarche
            // 
            this.listBoxHeureMarche.FormattingEnabled = true;
            this.listBoxHeureMarche.Location = new System.Drawing.Point(15, 59);
            this.listBoxHeureMarche.Name = "listBoxHeureMarche";
            this.listBoxHeureMarche.Size = new System.Drawing.Size(239, 160);
            this.listBoxHeureMarche.TabIndex = 40;
            // 
            // lbA
            // 
            this.lbA.AutoSize = true;
            this.lbA.Location = new System.Drawing.Point(140, 35);
            this.lbA.Name = "lbA";
            this.lbA.Size = new System.Drawing.Size(13, 13);
            this.lbA.TabIndex = 39;
            this.lbA.Text = "à";
            // 
            // cbHeureFinMarche
            // 
            this.cbHeureFinMarche.FormattingEnabled = true;
            this.cbHeureFinMarche.Location = new System.Drawing.Point(159, 32);
            this.cbHeureFinMarche.Name = "cbHeureFinMarche";
            this.cbHeureFinMarche.Size = new System.Drawing.Size(95, 21);
            this.cbHeureFinMarche.TabIndex = 38;
            this.cbHeureFinMarche.SelectedIndexChanged += new System.EventHandler(this.cbHeureFinMarche_SelectedIndexChanged);
            // 
            // lbDe
            // 
            this.lbDe.AutoSize = true;
            this.lbDe.Location = new System.Drawing.Point(12, 35);
            this.lbDe.Name = "lbDe";
            this.lbDe.Size = new System.Drawing.Size(21, 13);
            this.lbDe.TabIndex = 37;
            this.lbDe.Text = "De";
            // 
            // cbHeureDebutMarche
            // 
            this.cbHeureDebutMarche.FormattingEnabled = true;
            this.cbHeureDebutMarche.Location = new System.Drawing.Point(39, 32);
            this.cbHeureDebutMarche.Name = "cbHeureDebutMarche";
            this.cbHeureDebutMarche.Size = new System.Drawing.Size(95, 21);
            this.cbHeureDebutMarche.TabIndex = 36;
            // 
            // lbChoixHeureAppareilMarche
            // 
            this.lbChoixHeureAppareilMarche.AutoSize = true;
            this.lbChoixHeureAppareilMarche.Location = new System.Drawing.Point(12, 9);
            this.lbChoixHeureAppareilMarche.Name = "lbChoixHeureAppareilMarche";
            this.lbChoixHeureAppareilMarche.Size = new System.Drawing.Size(242, 13);
            this.lbChoixHeureAppareilMarche.TabIndex = 35;
            this.lbChoixHeureAppareilMarche.Text = "Choisissez les heures où l\'appareil sera en marche";
            // 
            // listBoxHeureVeille
            // 
            this.listBoxHeureVeille.Enabled = false;
            this.listBoxHeureVeille.FormattingEnabled = true;
            this.listBoxHeureVeille.Location = new System.Drawing.Point(280, 59);
            this.listBoxHeureVeille.Name = "listBoxHeureVeille";
            this.listBoxHeureVeille.Size = new System.Drawing.Size(239, 160);
            this.listBoxHeureVeille.TabIndex = 46;
            // 
            // lbA2
            // 
            this.lbA2.AutoSize = true;
            this.lbA2.Location = new System.Drawing.Point(405, 35);
            this.lbA2.Name = "lbA2";
            this.lbA2.Size = new System.Drawing.Size(13, 13);
            this.lbA2.TabIndex = 45;
            this.lbA2.Text = "à";
            // 
            // cbHeureFinVeille
            // 
            this.cbHeureFinVeille.Enabled = false;
            this.cbHeureFinVeille.FormattingEnabled = true;
            this.cbHeureFinVeille.Location = new System.Drawing.Point(424, 32);
            this.cbHeureFinVeille.Name = "cbHeureFinVeille";
            this.cbHeureFinVeille.Size = new System.Drawing.Size(95, 21);
            this.cbHeureFinVeille.TabIndex = 44;
            this.cbHeureFinVeille.SelectedIndexChanged += new System.EventHandler(this.cbHeureFinVeille_SelectedIndexChanged);
            // 
            // lbDe2
            // 
            this.lbDe2.AutoSize = true;
            this.lbDe2.Location = new System.Drawing.Point(277, 35);
            this.lbDe2.Name = "lbDe2";
            this.lbDe2.Size = new System.Drawing.Size(21, 13);
            this.lbDe2.TabIndex = 43;
            this.lbDe2.Text = "De";
            // 
            // cbHeureDebutVeille
            // 
            this.cbHeureDebutVeille.Enabled = false;
            this.cbHeureDebutVeille.FormattingEnabled = true;
            this.cbHeureDebutVeille.Location = new System.Drawing.Point(304, 32);
            this.cbHeureDebutVeille.Name = "cbHeureDebutVeille";
            this.cbHeureDebutVeille.Size = new System.Drawing.Size(95, 21);
            this.cbHeureDebutVeille.TabIndex = 42;
            // 
            // lbChoixHeureAppareilVeille
            // 
            this.lbChoixHeureAppareilVeille.AutoSize = true;
            this.lbChoixHeureAppareilVeille.Enabled = false;
            this.lbChoixHeureAppareilVeille.Location = new System.Drawing.Point(277, 9);
            this.lbChoixHeureAppareilVeille.Name = "lbChoixHeureAppareilVeille";
            this.lbChoixHeureAppareilVeille.Size = new System.Drawing.Size(231, 13);
            this.lbChoixHeureAppareilVeille.TabIndex = 41;
            this.lbChoixHeureAppareilVeille.Text = "Choisissez les heures où l\'appareil sera en veille";
            // 
            // btValider
            // 
            this.btValider.Location = new System.Drawing.Point(13, 264);
            this.btValider.Name = "btValider";
            this.btValider.Size = new System.Drawing.Size(506, 29);
            this.btValider.TabIndex = 47;
            this.btValider.Text = "Valider les heures";
            this.btValider.UseVisualStyleBackColor = true;
            this.btValider.Click += new System.EventHandler(this.btValider_Click);
            // 
            // btAjoutHeureMarche
            // 
            this.btAjoutHeureMarche.Location = new System.Drawing.Point(15, 225);
            this.btAjoutHeureMarche.Name = "btAjoutHeureMarche";
            this.btAjoutHeureMarche.Size = new System.Drawing.Size(239, 33);
            this.btAjoutHeureMarche.TabIndex = 48;
            this.btAjoutHeureMarche.Text = "Ajouter l\'heure \"en marche\"";
            this.btAjoutHeureMarche.UseVisualStyleBackColor = true;
            this.btAjoutHeureMarche.Click += new System.EventHandler(this.btAjoutHeureMarche_Click);
            // 
            // btAjoutHeureVeille
            // 
            this.btAjoutHeureVeille.Enabled = false;
            this.btAjoutHeureVeille.Location = new System.Drawing.Point(280, 225);
            this.btAjoutHeureVeille.Name = "btAjoutHeureVeille";
            this.btAjoutHeureVeille.Size = new System.Drawing.Size(239, 33);
            this.btAjoutHeureVeille.TabIndex = 49;
            this.btAjoutHeureVeille.Text = "Ajouter l\'heure \"en veille\"";
            this.btAjoutHeureVeille.UseVisualStyleBackColor = true;
            this.btAjoutHeureVeille.Click += new System.EventHandler(this.btAjoutHeureVeille_Click);
            // 
            // FormAppareilAjoutHeure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 305);
            this.Controls.Add(this.btAjoutHeureVeille);
            this.Controls.Add(this.btAjoutHeureMarche);
            this.Controls.Add(this.btValider);
            this.Controls.Add(this.listBoxHeureVeille);
            this.Controls.Add(this.lbA2);
            this.Controls.Add(this.cbHeureFinVeille);
            this.Controls.Add(this.lbDe2);
            this.Controls.Add(this.cbHeureDebutVeille);
            this.Controls.Add(this.lbChoixHeureAppareilVeille);
            this.Controls.Add(this.listBoxHeureMarche);
            this.Controls.Add(this.lbA);
            this.Controls.Add(this.cbHeureFinMarche);
            this.Controls.Add(this.lbDe);
            this.Controls.Add(this.cbHeureDebutMarche);
            this.Controls.Add(this.lbChoixHeureAppareilMarche);
            this.Name = "FormAppareilAjoutHeure";
            this.Text = "FormAppareilAjoutHeure";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxHeureMarche;
        private System.Windows.Forms.Label lbA;
        private System.Windows.Forms.ComboBox cbHeureFinMarche;
        private System.Windows.Forms.Label lbDe;
        private System.Windows.Forms.ComboBox cbHeureDebutMarche;
        private System.Windows.Forms.Label lbChoixHeureAppareilMarche;
        private System.Windows.Forms.ListBox listBoxHeureVeille;
        private System.Windows.Forms.Label lbA2;
        private System.Windows.Forms.ComboBox cbHeureFinVeille;
        private System.Windows.Forms.Label lbDe2;
        private System.Windows.Forms.ComboBox cbHeureDebutVeille;
        private System.Windows.Forms.Label lbChoixHeureAppareilVeille;
        private System.Windows.Forms.Button btValider;
        private System.Windows.Forms.Button btAjoutHeureMarche;
        private System.Windows.Forms.Button btAjoutHeureVeille;
    }
}