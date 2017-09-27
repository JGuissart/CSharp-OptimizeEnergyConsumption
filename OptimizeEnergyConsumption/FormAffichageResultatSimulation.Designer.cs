namespace OptimizeEnergyConsumption
{
    partial class FormAffichageResultatSimulation
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
            this.listBoxAppareil = new System.Windows.Forms.ListBox();
            this.lbChoixAppareil = new System.Windows.Forms.Label();
            this.lbConsommationMaison = new System.Windows.Forms.Label();
            this.lbConsommationEtage = new System.Windows.Forms.Label();
            this.lbConsommationPiece = new System.Windows.Forms.Label();
            this.lbConsommationAppareil = new System.Windows.Forms.Label();
            this.lbPrixConsoMaison = new System.Windows.Forms.Label();
            this.lbAfficheConsoMaison = new System.Windows.Forms.Label();
            this.lbAffichePrixMaison = new System.Windows.Forms.Label();
            this.lbPrixConsoEtage = new System.Windows.Forms.Label();
            this.lbPrixConsoPiece = new System.Windows.Forms.Label();
            this.lbPrixConsoAppareil = new System.Windows.Forms.Label();
            this.lbAfficheConsoEtage = new System.Windows.Forms.Label();
            this.lbAffichePrixEtage = new System.Windows.Forms.Label();
            this.lbAfficheConsoPiece = new System.Windows.Forms.Label();
            this.lbAffichePrixPiece = new System.Windows.Forms.Label();
            this.lbAfficheConsoAppareil = new System.Windows.Forms.Label();
            this.lbAffichePrixAppareil = new System.Windows.Forms.Label();
            this.btOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxAppareil
            // 
            this.listBoxAppareil.FormattingEnabled = true;
            this.listBoxAppareil.Location = new System.Drawing.Point(12, 42);
            this.listBoxAppareil.Name = "listBoxAppareil";
            this.listBoxAppareil.Size = new System.Drawing.Size(180, 251);
            this.listBoxAppareil.TabIndex = 0;
            this.listBoxAppareil.SelectedIndexChanged += new System.EventHandler(this.listBoxAppareil_SelectedIndexChanged);
            // 
            // lbChoixAppareil
            // 
            this.lbChoixAppareil.AutoSize = true;
            this.lbChoixAppareil.Location = new System.Drawing.Point(12, 9);
            this.lbChoixAppareil.Name = "lbChoixAppareil";
            this.lbChoixAppareil.Size = new System.Drawing.Size(252, 13);
            this.lbChoixAppareil.TabIndex = 1;
            this.lbChoixAppareil.Text = "Sélectionnez un appareil pour voir sa consommation";
            // 
            // lbConsommationMaison
            // 
            this.lbConsommationMaison.AutoSize = true;
            this.lbConsommationMaison.Location = new System.Drawing.Point(198, 42);
            this.lbConsommationMaison.Name = "lbConsommationMaison";
            this.lbConsommationMaison.Size = new System.Drawing.Size(382, 13);
            this.lbConsommationMaison.TabIndex = 2;
            this.lbConsommationMaison.Text = "Consommation journalière / hebdomadaire / mensuelle / annuelle de la maison :";
            // 
            // lbConsommationEtage
            // 
            this.lbConsommationEtage.AutoSize = true;
            this.lbConsommationEtage.Location = new System.Drawing.Point(198, 109);
            this.lbConsommationEtage.Name = "lbConsommationEtage";
            this.lbConsommationEtage.Size = new System.Drawing.Size(417, 13);
            this.lbConsommationEtage.TabIndex = 3;
            this.lbConsommationEtage.Text = "Consommation journalière / hebdomadaire / mensuelle / annuelle moyenne par étage " +
    ": ";
            // 
            // lbConsommationPiece
            // 
            this.lbConsommationPiece.AutoSize = true;
            this.lbConsommationPiece.Location = new System.Drawing.Point(198, 176);
            this.lbConsommationPiece.Name = "lbConsommationPiece";
            this.lbConsommationPiece.Size = new System.Drawing.Size(410, 13);
            this.lbConsommationPiece.TabIndex = 4;
            this.lbConsommationPiece.Text = "Consommation journalière / hebdomadaire / mensuelle / annuelle moyene par pièce :" +
    " ";
            // 
            // lbConsommationAppareil
            // 
            this.lbConsommationAppareil.AutoSize = true;
            this.lbConsommationAppareil.Location = new System.Drawing.Point(197, 239);
            this.lbConsommationAppareil.Name = "lbConsommationAppareil";
            this.lbConsommationAppareil.Size = new System.Drawing.Size(439, 13);
            this.lbConsommationAppareil.TabIndex = 5;
            this.lbConsommationAppareil.Text = "Consommation journalière / hebdomadaire / mensuelle / annuelle de l\'appareil séle" +
    "ctionné : ";
            this.lbConsommationAppareil.Visible = false;
            // 
            // lbPrixConsoMaison
            // 
            this.lbPrixConsoMaison.AutoSize = true;
            this.lbPrixConsoMaison.Location = new System.Drawing.Point(198, 66);
            this.lbPrixConsoMaison.Name = "lbPrixConsoMaison";
            this.lbPrixConsoMaison.Size = new System.Drawing.Size(408, 13);
            this.lbPrixConsoMaison.TabIndex = 6;
            this.lbPrixConsoMaison.Text = "Prix journalier / hebdomadaire / mensuel / annuel de la consommation de la maison" +
    " : ";
            // 
            // lbAfficheConsoMaison
            // 
            this.lbAfficheConsoMaison.AutoSize = true;
            this.lbAfficheConsoMaison.Location = new System.Drawing.Point(600, 42);
            this.lbAfficheConsoMaison.Name = "lbAfficheConsoMaison";
            this.lbAfficheConsoMaison.Size = new System.Drawing.Size(35, 13);
            this.lbAfficheConsoMaison.TabIndex = 7;
            this.lbAfficheConsoMaison.Text = "label3";
            // 
            // lbAffichePrixMaison
            // 
            this.lbAffichePrixMaison.AutoSize = true;
            this.lbAffichePrixMaison.Location = new System.Drawing.Point(623, 66);
            this.lbAffichePrixMaison.Name = "lbAffichePrixMaison";
            this.lbAffichePrixMaison.Size = new System.Drawing.Size(35, 13);
            this.lbAffichePrixMaison.TabIndex = 8;
            this.lbAffichePrixMaison.Text = "label2";
            // 
            // lbPrixConsoEtage
            // 
            this.lbPrixConsoEtage.AutoSize = true;
            this.lbPrixConsoEtage.Location = new System.Drawing.Point(197, 136);
            this.lbPrixConsoEtage.Name = "lbPrixConsoEtage";
            this.lbPrixConsoEtage.Size = new System.Drawing.Size(438, 13);
            this.lbPrixConsoEtage.TabIndex = 9;
            this.lbPrixConsoEtage.Text = "Prix journalier / hebdomadaire / mensuel / annuel de la consommation moyenne de l" +
    "\'étage :";
            // 
            // lbPrixConsoPiece
            // 
            this.lbPrixConsoPiece.AutoSize = true;
            this.lbPrixConsoPiece.Location = new System.Drawing.Point(199, 204);
            this.lbPrixConsoPiece.Name = "lbPrixConsoPiece";
            this.lbPrixConsoPiece.Size = new System.Drawing.Size(452, 13);
            this.lbPrixConsoPiece.TabIndex = 10;
            this.lbPrixConsoPiece.Text = "Prix journalier / hebdomadaire / mensuel / annuelle de la consommation moyenne de" +
    " la pièce :";
            // 
            // lbPrixConsoAppareil
            // 
            this.lbPrixConsoAppareil.AutoSize = true;
            this.lbPrixConsoAppareil.Location = new System.Drawing.Point(198, 265);
            this.lbPrixConsoAppareil.Name = "lbPrixConsoAppareil";
            this.lbPrixConsoAppareil.Size = new System.Drawing.Size(365, 13);
            this.lbPrixConsoAppareil.TabIndex = 11;
            this.lbPrixConsoAppareil.Text = "Prix journalier / hebdomadaire / mensuel / annuel de l\'appareil sélectionné : ";
            this.lbPrixConsoAppareil.Visible = false;
            // 
            // lbAfficheConsoEtage
            // 
            this.lbAfficheConsoEtage.AutoSize = true;
            this.lbAfficheConsoEtage.Location = new System.Drawing.Point(623, 109);
            this.lbAfficheConsoEtage.Name = "lbAfficheConsoEtage";
            this.lbAfficheConsoEtage.Size = new System.Drawing.Size(35, 13);
            this.lbAfficheConsoEtage.TabIndex = 12;
            this.lbAfficheConsoEtage.Text = "label5";
            // 
            // lbAffichePrixEtage
            // 
            this.lbAffichePrixEtage.AutoSize = true;
            this.lbAffichePrixEtage.Location = new System.Drawing.Point(652, 136);
            this.lbAffichePrixEtage.Name = "lbAffichePrixEtage";
            this.lbAffichePrixEtage.Size = new System.Drawing.Size(35, 13);
            this.lbAffichePrixEtage.TabIndex = 13;
            this.lbAffichePrixEtage.Text = "label6";
            // 
            // lbAfficheConsoPiece
            // 
            this.lbAfficheConsoPiece.AutoSize = true;
            this.lbAfficheConsoPiece.Location = new System.Drawing.Point(616, 176);
            this.lbAfficheConsoPiece.Name = "lbAfficheConsoPiece";
            this.lbAfficheConsoPiece.Size = new System.Drawing.Size(35, 13);
            this.lbAfficheConsoPiece.TabIndex = 14;
            this.lbAfficheConsoPiece.Text = "label7";
            // 
            // lbAffichePrixPiece
            // 
            this.lbAffichePrixPiece.AutoSize = true;
            this.lbAffichePrixPiece.Location = new System.Drawing.Point(657, 204);
            this.lbAffichePrixPiece.Name = "lbAffichePrixPiece";
            this.lbAffichePrixPiece.Size = new System.Drawing.Size(35, 13);
            this.lbAffichePrixPiece.TabIndex = 15;
            this.lbAffichePrixPiece.Text = "label8";
            // 
            // lbAfficheConsoAppareil
            // 
            this.lbAfficheConsoAppareil.AutoSize = true;
            this.lbAfficheConsoAppareil.Location = new System.Drawing.Point(643, 239);
            this.lbAfficheConsoAppareil.Name = "lbAfficheConsoAppareil";
            this.lbAfficheConsoAppareil.Size = new System.Drawing.Size(35, 13);
            this.lbAfficheConsoAppareil.TabIndex = 16;
            this.lbAfficheConsoAppareil.Text = "label9";
            this.lbAfficheConsoAppareil.Visible = false;
            // 
            // lbAffichePrixAppareil
            // 
            this.lbAffichePrixAppareil.AutoSize = true;
            this.lbAffichePrixAppareil.Location = new System.Drawing.Point(570, 265);
            this.lbAffichePrixAppareil.Name = "lbAffichePrixAppareil";
            this.lbAffichePrixAppareil.Size = new System.Drawing.Size(41, 13);
            this.lbAffichePrixAppareil.TabIndex = 17;
            this.lbAffichePrixAppareil.Text = "label10";
            this.lbAffichePrixAppareil.Visible = false;
            // 
            // btOk
            // 
            this.btOk.Location = new System.Drawing.Point(12, 299);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(878, 33);
            this.btOk.TabIndex = 18;
            this.btOk.Text = "Ok";
            this.btOk.UseVisualStyleBackColor = true;
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            // 
            // FormAffichageResultatSimulation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 344);
            this.Controls.Add(this.btOk);
            this.Controls.Add(this.lbAffichePrixAppareil);
            this.Controls.Add(this.lbAfficheConsoAppareil);
            this.Controls.Add(this.lbAffichePrixPiece);
            this.Controls.Add(this.lbAfficheConsoPiece);
            this.Controls.Add(this.lbAffichePrixEtage);
            this.Controls.Add(this.lbAfficheConsoEtage);
            this.Controls.Add(this.lbPrixConsoAppareil);
            this.Controls.Add(this.lbPrixConsoPiece);
            this.Controls.Add(this.lbPrixConsoEtage);
            this.Controls.Add(this.lbAffichePrixMaison);
            this.Controls.Add(this.lbAfficheConsoMaison);
            this.Controls.Add(this.lbPrixConsoMaison);
            this.Controls.Add(this.lbConsommationAppareil);
            this.Controls.Add(this.lbConsommationPiece);
            this.Controls.Add(this.lbConsommationEtage);
            this.Controls.Add(this.lbConsommationMaison);
            this.Controls.Add(this.lbChoixAppareil);
            this.Controls.Add(this.listBoxAppareil);
            this.Name = "FormAffichageResultatSimulation";
            this.Text = "Affichage des résultats de la simulation pour une maison";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxAppareil;
        private System.Windows.Forms.Label lbChoixAppareil;
        private System.Windows.Forms.Label lbConsommationMaison;
        private System.Windows.Forms.Label lbConsommationEtage;
        private System.Windows.Forms.Label lbConsommationPiece;
        private System.Windows.Forms.Label lbConsommationAppareil;
        private System.Windows.Forms.Label lbPrixConsoMaison;
        private System.Windows.Forms.Label lbAfficheConsoMaison;
        private System.Windows.Forms.Label lbAffichePrixMaison;
        private System.Windows.Forms.Label lbPrixConsoEtage;
        private System.Windows.Forms.Label lbPrixConsoPiece;
        private System.Windows.Forms.Label lbPrixConsoAppareil;
        private System.Windows.Forms.Label lbAfficheConsoEtage;
        private System.Windows.Forms.Label lbAffichePrixEtage;
        private System.Windows.Forms.Label lbAfficheConsoPiece;
        private System.Windows.Forms.Label lbAffichePrixPiece;
        private System.Windows.Forms.Label lbAfficheConsoAppareil;
        private System.Windows.Forms.Label lbAffichePrixAppareil;
        private System.Windows.Forms.Button btOk;
    }
}