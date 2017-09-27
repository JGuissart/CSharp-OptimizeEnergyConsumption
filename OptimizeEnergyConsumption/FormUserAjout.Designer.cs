namespace OptimizeEnergyConsumption
{
    partial class FormUserAjout
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
            this.tfMDP = new System.Windows.Forms.TextBox();
            this.tfConfMDP = new System.Windows.Forms.TextBox();
            this.lbMDP = new System.Windows.Forms.Label();
            this.lbConfMDP = new System.Windows.Forms.Label();
            this.lbErreur = new System.Windows.Forms.Label();
            this.btValiderUser = new System.Windows.Forms.Button();
            this.cbAfficherMDP = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lbLogin
            // 
            this.lbLogin.AutoSize = true;
            this.lbLogin.Location = new System.Drawing.Point(12, 55);
            this.lbLogin.Name = "lbLogin";
            this.lbLogin.Size = new System.Drawing.Size(77, 13);
            this.lbLogin.TabIndex = 1;
            this.lbLogin.Text = "Entrez un login";
            // 
            // tfLogin
            // 
            this.tfLogin.Location = new System.Drawing.Point(156, 52);
            this.tfLogin.Name = "tfLogin";
            this.tfLogin.Size = new System.Drawing.Size(242, 20);
            this.tfLogin.TabIndex = 2;
            // 
            // tfMDP
            // 
            this.tfMDP.Location = new System.Drawing.Point(156, 79);
            this.tfMDP.Name = "tfMDP";
            this.tfMDP.Size = new System.Drawing.Size(242, 20);
            this.tfMDP.TabIndex = 3;
            this.tfMDP.UseSystemPasswordChar = true;
            // 
            // tfConfMDP
            // 
            this.tfConfMDP.Location = new System.Drawing.Point(156, 106);
            this.tfConfMDP.Name = "tfConfMDP";
            this.tfConfMDP.Size = new System.Drawing.Size(242, 20);
            this.tfConfMDP.TabIndex = 4;
            this.tfConfMDP.UseSystemPasswordChar = true;
            // 
            // lbMDP
            // 
            this.lbMDP.AutoSize = true;
            this.lbMDP.Location = new System.Drawing.Point(12, 82);
            this.lbMDP.Name = "lbMDP";
            this.lbMDP.Size = new System.Drawing.Size(114, 13);
            this.lbMDP.TabIndex = 5;
            this.lbMDP.Text = "Entrez le mot de passe";
            // 
            // lbConfMDP
            // 
            this.lbConfMDP.AutoSize = true;
            this.lbConfMDP.Location = new System.Drawing.Point(12, 109);
            this.lbConfMDP.Name = "lbConfMDP";
            this.lbConfMDP.Size = new System.Drawing.Size(130, 13);
            this.lbConfMDP.TabIndex = 6;
            this.lbConfMDP.Text = "Confirmez le mot de passe";
            // 
            // lbErreur
            // 
            this.lbErreur.AutoSize = true;
            this.lbErreur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbErreur.ForeColor = System.Drawing.Color.Red;
            this.lbErreur.Location = new System.Drawing.Point(12, 9);
            this.lbErreur.Name = "lbErreur";
            this.lbErreur.Size = new System.Drawing.Size(0, 16);
            this.lbErreur.TabIndex = 0;
            this.lbErreur.Visible = false;
            // 
            // btValiderUser
            // 
            this.btValiderUser.Location = new System.Drawing.Point(12, 159);
            this.btValiderUser.Name = "btValiderUser";
            this.btValiderUser.Size = new System.Drawing.Size(386, 45);
            this.btValiderUser.TabIndex = 8;
            this.btValiderUser.Text = "Valider les informations du nouvel utilisateur";
            this.btValiderUser.UseVisualStyleBackColor = true;
            this.btValiderUser.Click += new System.EventHandler(this.btValiderUser_Click);
            // 
            // cbAfficherMDP
            // 
            this.cbAfficherMDP.AutoSize = true;
            this.cbAfficherMDP.Location = new System.Drawing.Point(12, 136);
            this.cbAfficherMDP.Name = "cbAfficherMDP";
            this.cbAfficherMDP.Size = new System.Drawing.Size(139, 17);
            this.cbAfficherMDP.TabIndex = 9;
            this.cbAfficherMDP.Text = "Afficher le mot de passe";
            this.cbAfficherMDP.UseVisualStyleBackColor = true;
            this.cbAfficherMDP.CheckedChanged += new System.EventHandler(this.cbAfficherMDP_CheckedChanged);
            // 
            // FormUserAjout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 216);
            this.Controls.Add(this.cbAfficherMDP);
            this.Controls.Add(this.lbErreur);
            this.Controls.Add(this.btValiderUser);
            this.Controls.Add(this.lbConfMDP);
            this.Controls.Add(this.lbMDP);
            this.Controls.Add(this.tfConfMDP);
            this.Controls.Add(this.tfMDP);
            this.Controls.Add(this.tfLogin);
            this.Controls.Add(this.lbLogin);
            this.Name = "FormUserAjout";
            this.Text = "Optimize Energy Consumption - Ajouter un nouvel utilisateur";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbLogin;
        private System.Windows.Forms.TextBox tfLogin;
        private System.Windows.Forms.TextBox tfMDP;
        private System.Windows.Forms.TextBox tfConfMDP;
        private System.Windows.Forms.Label lbMDP;
        private System.Windows.Forms.Label lbConfMDP;
        private System.Windows.Forms.Label lbErreur;
        private System.Windows.Forms.Button btValiderUser;
        private System.Windows.Forms.CheckBox cbAfficherMDP;
    }
}