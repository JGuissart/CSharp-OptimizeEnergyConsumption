namespace OptimizeEnergyConsumption
{
    partial class FormUserModif
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
            this.lbLogin = new System.Windows.Forms.Label();
            this.tfLogin = new System.Windows.Forms.TextBox();
            this.lbMDPActuel = new System.Windows.Forms.Label();
            this.tfMDPActuel = new System.Windows.Forms.TextBox();
            this.lbNewMDP = new System.Windows.Forms.Label();
            this.lbConfMDP = new System.Windows.Forms.Label();
            this.tfNewMDP = new System.Windows.Forms.TextBox();
            this.tfConfMDP = new System.Windows.Forms.TextBox();
            this.cbMDP = new System.Windows.Forms.CheckBox();
            this.btValider = new System.Windows.Forms.Button();
            this.lbErreur = new System.Windows.Forms.Label();
            this.cbAfficherMDP = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lbLogin
            // 
            this.lbLogin.AutoSize = true;
            this.lbLogin.Location = new System.Drawing.Point(12, 59);
            this.lbLogin.Name = "lbLogin";
            this.lbLogin.Size = new System.Drawing.Size(39, 13);
            this.lbLogin.TabIndex = 0;
            this.lbLogin.Text = "Login: ";
            // 
            // tfLogin
            // 
            this.tfLogin.Location = new System.Drawing.Point(140, 56);
            this.tfLogin.Name = "tfLogin";
            this.tfLogin.Size = new System.Drawing.Size(248, 20);
            this.tfLogin.TabIndex = 1;
            // 
            // lbMDPActuel
            // 
            this.lbMDPActuel.AutoSize = true;
            this.lbMDPActuel.Location = new System.Drawing.Point(12, 85);
            this.lbMDPActuel.Name = "lbMDPActuel";
            this.lbMDPActuel.Size = new System.Drawing.Size(109, 13);
            this.lbMDPActuel.TabIndex = 2;
            this.lbMDPActuel.Text = "Mot de passe actuel: ";
            // 
            // tfMDPActuel
            // 
            this.tfMDPActuel.Location = new System.Drawing.Point(140, 82);
            this.tfMDPActuel.Name = "tfMDPActuel";
            this.tfMDPActuel.Size = new System.Drawing.Size(248, 20);
            this.tfMDPActuel.TabIndex = 3;
            this.tfMDPActuel.UseSystemPasswordChar = true;
            // 
            // lbNewMDP
            // 
            this.lbNewMDP.AutoSize = true;
            this.lbNewMDP.Location = new System.Drawing.Point(11, 134);
            this.lbNewMDP.Name = "lbNewMDP";
            this.lbNewMDP.Size = new System.Drawing.Size(123, 13);
            this.lbNewMDP.TabIndex = 4;
            this.lbNewMDP.Text = "Nouveau mot de passe: ";
            // 
            // lbConfMDP
            // 
            this.lbConfMDP.AutoSize = true;
            this.lbConfMDP.Location = new System.Drawing.Point(11, 160);
            this.lbConfMDP.Name = "lbConfMDP";
            this.lbConfMDP.Size = new System.Drawing.Size(71, 13);
            this.lbConfMDP.TabIndex = 5;
            this.lbConfMDP.Text = "Confirmation: ";
            // 
            // tfNewMDP
            // 
            this.tfNewMDP.Enabled = false;
            this.tfNewMDP.Location = new System.Drawing.Point(140, 131);
            this.tfNewMDP.Name = "tfNewMDP";
            this.tfNewMDP.Size = new System.Drawing.Size(248, 20);
            this.tfNewMDP.TabIndex = 6;
            this.tfNewMDP.UseSystemPasswordChar = true;
            // 
            // tfConfMDP
            // 
            this.tfConfMDP.Enabled = false;
            this.tfConfMDP.Location = new System.Drawing.Point(140, 157);
            this.tfConfMDP.Name = "tfConfMDP";
            this.tfConfMDP.Size = new System.Drawing.Size(248, 20);
            this.tfConfMDP.TabIndex = 7;
            this.tfConfMDP.UseSystemPasswordChar = true;
            // 
            // cbMDP
            // 
            this.cbMDP.AutoSize = true;
            this.cbMDP.Location = new System.Drawing.Point(14, 108);
            this.cbMDP.Name = "cbMDP";
            this.cbMDP.Size = new System.Drawing.Size(299, 17);
            this.cbMDP.TabIndex = 8;
            this.cbMDP.Text = "Cochez la case si vous souhaitez modifier le mot de passe";
            this.cbMDP.UseVisualStyleBackColor = true;
            this.cbMDP.CheckedChanged += new System.EventHandler(this.cbMDP_CheckedChanged);
            // 
            // btValider
            // 
            this.btValider.Location = new System.Drawing.Point(241, 183);
            this.btValider.Name = "btValider";
            this.btValider.Size = new System.Drawing.Size(147, 23);
            this.btValider.TabIndex = 9;
            this.btValider.Text = "Valider les modifications";
            this.btValider.UseVisualStyleBackColor = true;
            this.btValider.Click += new System.EventHandler(this.btValider_Click);
            // 
            // lbErreur
            // 
            this.lbErreur.AutoSize = true;
            this.lbErreur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbErreur.Location = new System.Drawing.Point(12, 9);
            this.lbErreur.Name = "lbErreur";
            this.lbErreur.Size = new System.Drawing.Size(0, 16);
            this.lbErreur.TabIndex = 10;
            // 
            // cbAfficherMDP
            // 
            this.cbAfficherMDP.AutoSize = true;
            this.cbAfficherMDP.Location = new System.Drawing.Point(13, 188);
            this.cbAfficherMDP.Name = "cbAfficherMDP";
            this.cbAfficherMDP.Size = new System.Drawing.Size(149, 17);
            this.cbAfficherMDP.TabIndex = 11;
            this.cbAfficherMDP.Text = "Afficher les mots de passe";
            this.cbAfficherMDP.UseVisualStyleBackColor = true;
            this.cbAfficherMDP.CheckedChanged += new System.EventHandler(this.cbAfficherMDP_CheckedChanged);
            // 
            // FormUserModif
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 218);
            this.Controls.Add(this.cbAfficherMDP);
            this.Controls.Add(this.lbErreur);
            this.Controls.Add(this.btValider);
            this.Controls.Add(this.cbMDP);
            this.Controls.Add(this.tfConfMDP);
            this.Controls.Add(this.tfNewMDP);
            this.Controls.Add(this.lbConfMDP);
            this.Controls.Add(this.lbNewMDP);
            this.Controls.Add(this.tfMDPActuel);
            this.Controls.Add(this.lbMDPActuel);
            this.Controls.Add(this.tfLogin);
            this.Controls.Add(this.lbLogin);
            this.Name = "FormUserModif";
            this.Text = "Optimize Energy Consumption - Modification d\'un utilisateur";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbLogin;
        private System.Windows.Forms.TextBox tfLogin;
        private System.Windows.Forms.Label lbMDPActuel;
        private System.Windows.Forms.TextBox tfMDPActuel;
        private System.Windows.Forms.Label lbNewMDP;
        private System.Windows.Forms.Label lbConfMDP;
        private System.Windows.Forms.TextBox tfNewMDP;
        private System.Windows.Forms.TextBox tfConfMDP;
        private System.Windows.Forms.CheckBox cbMDP;
        private System.Windows.Forms.Button btValider;
        private System.Windows.Forms.Label lbErreur;
        private System.Windows.Forms.CheckBox cbAfficherMDP;
    }
}