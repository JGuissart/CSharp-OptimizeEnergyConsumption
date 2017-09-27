namespace OptimizeEnergyConsumption
{
    partial class FormAppareilAjoutSpecifications
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
            this.lbNomAppareil = new System.Windows.Forms.Label();
            this.tfNomAppareil = new System.Windows.Forms.TextBox();
            this.lbMarque = new System.Windows.Forms.Label();
            this.lbType = new System.Windows.Forms.Label();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.tfMarque = new System.Windows.Forms.TextBox();
            this.tfModele = new System.Windows.Forms.TextBox();
            this.tfNumeroSerie = new System.Windows.Forms.TextBox();
            this.lbModele = new System.Windows.Forms.Label();
            this.lbNumeroSerie = new System.Windows.Forms.Label();
            this.tfConsoNormale = new System.Windows.Forms.TextBox();
            this.lbConsoNormale = new System.Windows.Forms.Label();
            this.lbConsoVeille = new System.Windows.Forms.Label();
            this.tfConsoVeille = new System.Windows.Forms.TextBox();
            this.btValider = new System.Windows.Forms.Button();
            this.btAnnuler = new System.Windows.Forms.Button();
            this.btReinit = new System.Windows.Forms.Button();
            this.pbVType = new System.Windows.Forms.PictureBox();
            this.pbVNom = new System.Windows.Forms.PictureBox();
            this.pbVMarque = new System.Windows.Forms.PictureBox();
            this.pbVModele = new System.Windows.Forms.PictureBox();
            this.pbVNum = new System.Windows.Forms.PictureBox();
            this.pbVConsoN = new System.Windows.Forms.PictureBox();
            this.pbVConsoV = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbVType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVNom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVMarque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVModele)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVConsoN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVConsoV)).BeginInit();
            this.SuspendLayout();
            // 
            // lbNomAppareil
            // 
            this.lbNomAppareil.AutoSize = true;
            this.lbNomAppareil.Location = new System.Drawing.Point(12, 40);
            this.lbNomAppareil.Name = "lbNomAppareil";
            this.lbNomAppareil.Size = new System.Drawing.Size(94, 13);
            this.lbNomAppareil.TabIndex = 0;
            this.lbNomAppareil.Text = "Nom de l\'appareil: ";
            // 
            // tfNomAppareil
            // 
            this.tfNomAppareil.Location = new System.Drawing.Point(174, 37);
            this.tfNomAppareil.Name = "tfNomAppareil";
            this.tfNomAppareil.Size = new System.Drawing.Size(191, 20);
            this.tfNomAppareil.TabIndex = 1;
            this.tfNomAppareil.TextChanged += new System.EventHandler(this.tfNomAppareil_TextChanged);
            // 
            // lbMarque
            // 
            this.lbMarque.AutoSize = true;
            this.lbMarque.Location = new System.Drawing.Point(12, 67);
            this.lbMarque.Name = "lbMarque";
            this.lbMarque.Size = new System.Drawing.Size(49, 13);
            this.lbMarque.TabIndex = 2;
            this.lbMarque.Text = "Marque: ";
            // 
            // lbType
            // 
            this.lbType.AutoSize = true;
            this.lbType.Location = new System.Drawing.Point(12, 13);
            this.lbType.Name = "lbType";
            this.lbType.Size = new System.Drawing.Size(85, 13);
            this.lbType.TabIndex = 3;
            this.lbType.Text = "Type d\'appareil: ";
            // 
            // cbType
            // 
            this.cbType.FormattingEnabled = true;
            this.cbType.Items.AddRange(new object[] {
            "Electromenager",
            "Media",
            "Chauffage",
            "Eclairage",
            "Autre"});
            this.cbType.Location = new System.Drawing.Point(174, 10);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(191, 21);
            this.cbType.TabIndex = 4;
            this.cbType.TextChanged += new System.EventHandler(this.cbType_TextChanged);
            // 
            // tfMarque
            // 
            this.tfMarque.Location = new System.Drawing.Point(174, 64);
            this.tfMarque.Name = "tfMarque";
            this.tfMarque.Size = new System.Drawing.Size(191, 20);
            this.tfMarque.TabIndex = 5;
            this.tfMarque.TextChanged += new System.EventHandler(this.tfMarque_TextChanged);
            // 
            // tfModele
            // 
            this.tfModele.Location = new System.Drawing.Point(174, 91);
            this.tfModele.Name = "tfModele";
            this.tfModele.Size = new System.Drawing.Size(191, 20);
            this.tfModele.TabIndex = 6;
            this.tfModele.TextChanged += new System.EventHandler(this.tfModele_TextChanged);
            // 
            // tfNumeroSerie
            // 
            this.tfNumeroSerie.Location = new System.Drawing.Point(174, 117);
            this.tfNumeroSerie.Name = "tfNumeroSerie";
            this.tfNumeroSerie.Size = new System.Drawing.Size(191, 20);
            this.tfNumeroSerie.TabIndex = 7;
            this.tfNumeroSerie.TextChanged += new System.EventHandler(this.tfNumeroSerie_TextChanged);
            // 
            // lbModele
            // 
            this.lbModele.AutoSize = true;
            this.lbModele.Location = new System.Drawing.Point(12, 94);
            this.lbModele.Name = "lbModele";
            this.lbModele.Size = new System.Drawing.Size(42, 13);
            this.lbModele.TabIndex = 9;
            this.lbModele.Text = "Modèle";
            // 
            // lbNumeroSerie
            // 
            this.lbNumeroSerie.AutoSize = true;
            this.lbNumeroSerie.Location = new System.Drawing.Point(12, 120);
            this.lbNumeroSerie.Name = "lbNumeroSerie";
            this.lbNumeroSerie.Size = new System.Drawing.Size(90, 13);
            this.lbNumeroSerie.TabIndex = 10;
            this.lbNumeroSerie.Text = "Numéro de série: ";
            // 
            // tfConsoNormale
            // 
            this.tfConsoNormale.Location = new System.Drawing.Point(174, 143);
            this.tfConsoNormale.Name = "tfConsoNormale";
            this.tfConsoNormale.Size = new System.Drawing.Size(191, 20);
            this.tfConsoNormale.TabIndex = 11;
            this.tfConsoNormale.TextChanged += new System.EventHandler(this.tfConsoNormale_TextChanged);
            // 
            // lbConsoNormale
            // 
            this.lbConsoNormale.AutoSize = true;
            this.lbConsoNormale.Location = new System.Drawing.Point(12, 146);
            this.lbConsoNormale.Name = "lbConsoNormale";
            this.lbConsoNormale.Size = new System.Drawing.Size(153, 13);
            this.lbConsoNormale.TabIndex = 12;
            this.lbConsoNormale.Text = "Consommation normale (W/h): ";
            // 
            // lbConsoVeille
            // 
            this.lbConsoVeille.AutoSize = true;
            this.lbConsoVeille.Enabled = false;
            this.lbConsoVeille.Location = new System.Drawing.Point(12, 172);
            this.lbConsoVeille.Name = "lbConsoVeille";
            this.lbConsoVeille.Size = new System.Drawing.Size(140, 13);
            this.lbConsoVeille.TabIndex = 15;
            this.lbConsoVeille.Text = "Consommation veille (W/h): ";
            // 
            // tfConsoVeille
            // 
            this.tfConsoVeille.Enabled = false;
            this.tfConsoVeille.Location = new System.Drawing.Point(174, 169);
            this.tfConsoVeille.Name = "tfConsoVeille";
            this.tfConsoVeille.Size = new System.Drawing.Size(191, 20);
            this.tfConsoVeille.TabIndex = 14;
            this.tfConsoVeille.TextChanged += new System.EventHandler(this.tfConsoVeille_TextChanged);
            // 
            // btValider
            // 
            this.btValider.Location = new System.Drawing.Point(12, 206);
            this.btValider.Name = "btValider";
            this.btValider.Size = new System.Drawing.Size(116, 32);
            this.btValider.TabIndex = 18;
            this.btValider.Text = "Valider l\'appareil";
            this.btValider.UseVisualStyleBackColor = true;
            this.btValider.Click += new System.EventHandler(this.btValider_Click);
            // 
            // btAnnuler
            // 
            this.btAnnuler.Location = new System.Drawing.Point(134, 206);
            this.btAnnuler.Name = "btAnnuler";
            this.btAnnuler.Size = new System.Drawing.Size(127, 32);
            this.btAnnuler.TabIndex = 19;
            this.btAnnuler.Text = "Annuler";
            this.btAnnuler.UseVisualStyleBackColor = true;
            this.btAnnuler.Click += new System.EventHandler(this.btAnnuler_Click);
            // 
            // btReinit
            // 
            this.btReinit.Location = new System.Drawing.Point(267, 206);
            this.btReinit.Name = "btReinit";
            this.btReinit.Size = new System.Drawing.Size(133, 32);
            this.btReinit.TabIndex = 20;
            this.btReinit.Text = "Réinitialiser les champs";
            this.btReinit.UseVisualStyleBackColor = true;
            this.btReinit.Click += new System.EventHandler(this.btReinit_Click);
            // 
            // pbVType
            // 
            this.pbVType.Location = new System.Drawing.Point(371, 10);
            this.pbVType.Name = "pbVType";
            this.pbVType.Size = new System.Drawing.Size(20, 20);
            this.pbVType.TabIndex = 21;
            this.pbVType.TabStop = false;
            // 
            // pbVNom
            // 
            this.pbVNom.Location = new System.Drawing.Point(371, 37);
            this.pbVNom.Name = "pbVNom";
            this.pbVNom.Size = new System.Drawing.Size(20, 20);
            this.pbVNom.TabIndex = 22;
            this.pbVNom.TabStop = false;
            // 
            // pbVMarque
            // 
            this.pbVMarque.Location = new System.Drawing.Point(371, 63);
            this.pbVMarque.Name = "pbVMarque";
            this.pbVMarque.Size = new System.Drawing.Size(20, 20);
            this.pbVMarque.TabIndex = 23;
            this.pbVMarque.TabStop = false;
            // 
            // pbVModele
            // 
            this.pbVModele.Location = new System.Drawing.Point(371, 91);
            this.pbVModele.Name = "pbVModele";
            this.pbVModele.Size = new System.Drawing.Size(20, 20);
            this.pbVModele.TabIndex = 24;
            this.pbVModele.TabStop = false;
            // 
            // pbVNum
            // 
            this.pbVNum.Location = new System.Drawing.Point(371, 117);
            this.pbVNum.Name = "pbVNum";
            this.pbVNum.Size = new System.Drawing.Size(20, 20);
            this.pbVNum.TabIndex = 25;
            this.pbVNum.TabStop = false;
            // 
            // pbVConsoN
            // 
            this.pbVConsoN.Location = new System.Drawing.Point(371, 143);
            this.pbVConsoN.Name = "pbVConsoN";
            this.pbVConsoN.Size = new System.Drawing.Size(20, 20);
            this.pbVConsoN.TabIndex = 26;
            this.pbVConsoN.TabStop = false;
            // 
            // pbVConsoV
            // 
            this.pbVConsoV.Enabled = false;
            this.pbVConsoV.Location = new System.Drawing.Point(371, 169);
            this.pbVConsoV.Name = "pbVConsoV";
            this.pbVConsoV.Size = new System.Drawing.Size(20, 20);
            this.pbVConsoV.TabIndex = 27;
            this.pbVConsoV.TabStop = false;
            // 
            // FormAppareilAjoutSpecifications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 248);
            this.Controls.Add(this.pbVConsoV);
            this.Controls.Add(this.pbVConsoN);
            this.Controls.Add(this.pbVNum);
            this.Controls.Add(this.pbVModele);
            this.Controls.Add(this.pbVMarque);
            this.Controls.Add(this.pbVNom);
            this.Controls.Add(this.pbVType);
            this.Controls.Add(this.btReinit);
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
            this.Controls.Add(this.cbType);
            this.Controls.Add(this.lbType);
            this.Controls.Add(this.lbMarque);
            this.Controls.Add(this.tfNomAppareil);
            this.Controls.Add(this.lbNomAppareil);
            this.Name = "FormAppareilAjoutSpecifications";
            this.Text = "Ajouter un appareil";
            ((System.ComponentModel.ISupportInitialize)(this.pbVType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVNom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVMarque)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVModele)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVConsoN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVConsoV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNomAppareil;
        private System.Windows.Forms.TextBox tfNomAppareil;
        private System.Windows.Forms.Label lbMarque;
        private System.Windows.Forms.Label lbType;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.TextBox tfMarque;
        private System.Windows.Forms.TextBox tfModele;
        private System.Windows.Forms.TextBox tfNumeroSerie;
        private System.Windows.Forms.Label lbModele;
        private System.Windows.Forms.Label lbNumeroSerie;
        private System.Windows.Forms.TextBox tfConsoNormale;
        private System.Windows.Forms.Label lbConsoNormale;
        private System.Windows.Forms.Label lbConsoVeille;
        private System.Windows.Forms.TextBox tfConsoVeille;
        private System.Windows.Forms.Button btValider;
        private System.Windows.Forms.Button btAnnuler;
        private System.Windows.Forms.Button btReinit;
        private System.Windows.Forms.PictureBox pbVType;
        private System.Windows.Forms.PictureBox pbVNom;
        private System.Windows.Forms.PictureBox pbVMarque;
        private System.Windows.Forms.PictureBox pbVModele;
        private System.Windows.Forms.PictureBox pbVNum;
        private System.Windows.Forms.PictureBox pbVConsoN;
        private System.Windows.Forms.PictureBox pbVConsoV;
    }
}