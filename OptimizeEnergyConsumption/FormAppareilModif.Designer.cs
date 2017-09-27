namespace OptimizeEnergyConsumption
{
    partial class FormAppareilModif
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
            this.lbConsoVeille = new System.Windows.Forms.Label();
            this.tfConsoVeille = new System.Windows.Forms.TextBox();
            this.lbConsoNormale = new System.Windows.Forms.Label();
            this.tfConsoNormale = new System.Windows.Forms.TextBox();
            this.lbNumeroSerie = new System.Windows.Forms.Label();
            this.lbModele = new System.Windows.Forms.Label();
            this.tfNumeroSerie = new System.Windows.Forms.TextBox();
            this.tfModele = new System.Windows.Forms.TextBox();
            this.tfMarque = new System.Windows.Forms.TextBox();
            this.lbMarque = new System.Windows.Forms.Label();
            this.tfNomAppareil = new System.Windows.Forms.TextBox();
            this.lbNomAppareil = new System.Windows.Forms.Label();
            this.btValider = new System.Windows.Forms.Button();
            this.btAnnuler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbConsoVeille
            // 
            this.lbConsoVeille.AutoSize = true;
            this.lbConsoVeille.Location = new System.Drawing.Point(13, 147);
            this.lbConsoVeille.Name = "lbConsoVeille";
            this.lbConsoVeille.Size = new System.Drawing.Size(146, 13);
            this.lbConsoVeille.TabIndex = 27;
            this.lbConsoVeille.Text = "Consommation veille (kW/h): ";
            // 
            // tfConsoVeille
            // 
            this.tfConsoVeille.Location = new System.Drawing.Point(175, 144);
            this.tfConsoVeille.Name = "tfConsoVeille";
            this.tfConsoVeille.Size = new System.Drawing.Size(170, 20);
            this.tfConsoVeille.TabIndex = 26;
            // 
            // lbConsoNormale
            // 
            this.lbConsoNormale.AutoSize = true;
            this.lbConsoNormale.Location = new System.Drawing.Point(13, 121);
            this.lbConsoNormale.Name = "lbConsoNormale";
            this.lbConsoNormale.Size = new System.Drawing.Size(159, 13);
            this.lbConsoNormale.TabIndex = 25;
            this.lbConsoNormale.Text = "Consommation normale (kW/h): ";
            // 
            // tfConsoNormale
            // 
            this.tfConsoNormale.Location = new System.Drawing.Point(175, 118);
            this.tfConsoNormale.Name = "tfConsoNormale";
            this.tfConsoNormale.Size = new System.Drawing.Size(170, 20);
            this.tfConsoNormale.TabIndex = 24;
            // 
            // lbNumeroSerie
            // 
            this.lbNumeroSerie.AutoSize = true;
            this.lbNumeroSerie.Location = new System.Drawing.Point(13, 95);
            this.lbNumeroSerie.Name = "lbNumeroSerie";
            this.lbNumeroSerie.Size = new System.Drawing.Size(90, 13);
            this.lbNumeroSerie.TabIndex = 23;
            this.lbNumeroSerie.Text = "Numéro de série: ";
            // 
            // lbModele
            // 
            this.lbModele.AutoSize = true;
            this.lbModele.Location = new System.Drawing.Point(13, 69);
            this.lbModele.Name = "lbModele";
            this.lbModele.Size = new System.Drawing.Size(42, 13);
            this.lbModele.TabIndex = 22;
            this.lbModele.Text = "Modèle";
            // 
            // tfNumeroSerie
            // 
            this.tfNumeroSerie.Location = new System.Drawing.Point(175, 92);
            this.tfNumeroSerie.Name = "tfNumeroSerie";
            this.tfNumeroSerie.Size = new System.Drawing.Size(170, 20);
            this.tfNumeroSerie.TabIndex = 21;
            // 
            // tfModele
            // 
            this.tfModele.Location = new System.Drawing.Point(175, 66);
            this.tfModele.Name = "tfModele";
            this.tfModele.Size = new System.Drawing.Size(170, 20);
            this.tfModele.TabIndex = 20;
            // 
            // tfMarque
            // 
            this.tfMarque.Location = new System.Drawing.Point(175, 39);
            this.tfMarque.Name = "tfMarque";
            this.tfMarque.Size = new System.Drawing.Size(170, 20);
            this.tfMarque.TabIndex = 19;
            // 
            // lbMarque
            // 
            this.lbMarque.AutoSize = true;
            this.lbMarque.Location = new System.Drawing.Point(13, 42);
            this.lbMarque.Name = "lbMarque";
            this.lbMarque.Size = new System.Drawing.Size(49, 13);
            this.lbMarque.TabIndex = 18;
            this.lbMarque.Text = "Marque: ";
            // 
            // tfNomAppareil
            // 
            this.tfNomAppareil.Location = new System.Drawing.Point(175, 12);
            this.tfNomAppareil.Name = "tfNomAppareil";
            this.tfNomAppareil.Size = new System.Drawing.Size(170, 20);
            this.tfNomAppareil.TabIndex = 17;
            // 
            // lbNomAppareil
            // 
            this.lbNomAppareil.AutoSize = true;
            this.lbNomAppareil.Location = new System.Drawing.Point(13, 15);
            this.lbNomAppareil.Name = "lbNomAppareil";
            this.lbNomAppareil.Size = new System.Drawing.Size(94, 13);
            this.lbNomAppareil.TabIndex = 16;
            this.lbNomAppareil.Text = "Nom de l\'appareil: ";
            // 
            // btValider
            // 
            this.btValider.Location = new System.Drawing.Point(13, 184);
            this.btValider.Name = "btValider";
            this.btValider.Size = new System.Drawing.Size(162, 23);
            this.btValider.TabIndex = 28;
            this.btValider.Text = "Valider les modifications";
            this.btValider.UseVisualStyleBackColor = true;
            this.btValider.Click += new System.EventHandler(this.btValider_Click);
            // 
            // btAnnuler
            // 
            this.btAnnuler.Location = new System.Drawing.Point(181, 184);
            this.btAnnuler.Name = "btAnnuler";
            this.btAnnuler.Size = new System.Drawing.Size(163, 23);
            this.btAnnuler.TabIndex = 29;
            this.btAnnuler.Text = "Annuler";
            this.btAnnuler.UseVisualStyleBackColor = true;
            this.btAnnuler.Click += new System.EventHandler(this.btAnnuler_Click);
            // 
            // FormAppareilModif
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 219);
            this.Controls.Add(this.btAnnuler);
            this.Controls.Add(this.btValider);
            this.Controls.Add(this.lbConsoVeille);
            this.Controls.Add(this.tfConsoVeille);
            this.Controls.Add(this.lbConsoNormale);
            this.Controls.Add(this.tfConsoNormale);
            this.Controls.Add(this.lbNumeroSerie);
            this.Controls.Add(this.lbModele);
            this.Controls.Add(this.tfNumeroSerie);
            this.Controls.Add(this.tfModele);
            this.Controls.Add(this.tfMarque);
            this.Controls.Add(this.lbMarque);
            this.Controls.Add(this.tfNomAppareil);
            this.Controls.Add(this.lbNomAppareil);
            this.Name = "FormAppareilModif";
            this.Text = "FormAppareilModif";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbConsoVeille;
        private System.Windows.Forms.TextBox tfConsoVeille;
        private System.Windows.Forms.Label lbConsoNormale;
        private System.Windows.Forms.TextBox tfConsoNormale;
        private System.Windows.Forms.Label lbNumeroSerie;
        private System.Windows.Forms.Label lbModele;
        private System.Windows.Forms.TextBox tfNumeroSerie;
        private System.Windows.Forms.TextBox tfModele;
        private System.Windows.Forms.TextBox tfMarque;
        private System.Windows.Forms.Label lbMarque;
        private System.Windows.Forms.TextBox tfNomAppareil;
        private System.Windows.Forms.Label lbNomAppareil;
        private System.Windows.Forms.Button btValider;
        private System.Windows.Forms.Button btAnnuler;
    }
}