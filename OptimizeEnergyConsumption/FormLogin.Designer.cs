namespace OptimizeEnergyConsumption
{
    partial class FormLogin
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.tfLogin = new System.Windows.Forms.TextBox();
            this.tfMotDePasse = new System.Windows.Forms.TextBox();
            this.lbLogin = new System.Windows.Forms.Label();
            this.lbMotDePasse = new System.Windows.Forms.Label();
            this.btSeConnecter = new System.Windows.Forms.Button();
            this.lbErreur = new System.Windows.Forms.Label();
            this.checkBoxAfficheMDP = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // tfLogin
            // 
            this.tfLogin.Location = new System.Drawing.Point(115, 33);
            this.tfLogin.Name = "tfLogin";
            this.tfLogin.Size = new System.Drawing.Size(227, 20);
            this.tfLogin.TabIndex = 0;
            // 
            // tfMotDePasse
            // 
            this.tfMotDePasse.Location = new System.Drawing.Point(115, 59);
            this.tfMotDePasse.Name = "tfMotDePasse";
            this.tfMotDePasse.Size = new System.Drawing.Size(227, 20);
            this.tfMotDePasse.TabIndex = 1;
            this.tfMotDePasse.UseSystemPasswordChar = true;
            // 
            // lbLogin
            // 
            this.lbLogin.AutoSize = true;
            this.lbLogin.Location = new System.Drawing.Point(12, 36);
            this.lbLogin.Name = "lbLogin";
            this.lbLogin.Size = new System.Drawing.Size(33, 13);
            this.lbLogin.TabIndex = 2;
            this.lbLogin.Text = "Login";
            // 
            // lbMotDePasse
            // 
            this.lbMotDePasse.AutoSize = true;
            this.lbMotDePasse.Location = new System.Drawing.Point(12, 62);
            this.lbMotDePasse.Name = "lbMotDePasse";
            this.lbMotDePasse.Size = new System.Drawing.Size(71, 13);
            this.lbMotDePasse.TabIndex = 3;
            this.lbMotDePasse.Text = "Mot de passe";
            // 
            // btSeConnecter
            // 
            this.btSeConnecter.Location = new System.Drawing.Point(12, 85);
            this.btSeConnecter.Name = "btSeConnecter";
            this.btSeConnecter.Size = new System.Drawing.Size(125, 23);
            this.btSeConnecter.TabIndex = 4;
            this.btSeConnecter.Text = "Se connecter";
            this.btSeConnecter.UseVisualStyleBackColor = true;
            this.btSeConnecter.Click += new System.EventHandler(this.btSeConnecter_Click);
            // 
            // lbErreur
            // 
            this.lbErreur.AutoSize = true;
            this.lbErreur.Location = new System.Drawing.Point(48, 9);
            this.lbErreur.Name = "lbErreur";
            this.lbErreur.Size = new System.Drawing.Size(0, 13);
            this.lbErreur.TabIndex = 5;
            // 
            // checkBoxAfficheMDP
            // 
            this.checkBoxAfficheMDP.AutoSize = true;
            this.checkBoxAfficheMDP.Location = new System.Drawing.Point(203, 91);
            this.checkBoxAfficheMDP.Name = "checkBoxAfficheMDP";
            this.checkBoxAfficheMDP.Size = new System.Drawing.Size(139, 17);
            this.checkBoxAfficheMDP.TabIndex = 6;
            this.checkBoxAfficheMDP.Text = "Afficher le mot de passe";
            this.checkBoxAfficheMDP.UseVisualStyleBackColor = true;
            this.checkBoxAfficheMDP.CheckedChanged += new System.EventHandler(this.checkBoxAfficheMDP_CheckedChanged);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 120);
            this.Controls.Add(this.checkBoxAfficheMDP);
            this.Controls.Add(this.lbErreur);
            this.Controls.Add(this.btSeConnecter);
            this.Controls.Add(this.lbMotDePasse);
            this.Controls.Add(this.lbLogin);
            this.Controls.Add(this.tfMotDePasse);
            this.Controls.Add(this.tfLogin);
            this.Name = "FormLogin";
            this.Text = "Optimize Energy Consumption - Connexion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tfLogin;
        private System.Windows.Forms.TextBox tfMotDePasse;
        private System.Windows.Forms.Label lbLogin;
        private System.Windows.Forms.Label lbMotDePasse;
        private System.Windows.Forms.Button btSeConnecter;
        private System.Windows.Forms.Label lbErreur;
        private System.Windows.Forms.CheckBox checkBoxAfficheMDP;
    }
}

