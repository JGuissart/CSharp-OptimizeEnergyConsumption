namespace OptimizeEnergyConsumption
{
    partial class FormAdmin
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
            this.listBoxUser = new System.Windows.Forms.ListBox();
            this.btAjoutUser = new System.Windows.Forms.Button();
            this.btModifUser = new System.Windows.Forms.Button();
            this.btSuppUser = new System.Windows.Forms.Button();
            this.btValiderQuitter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxUser
            // 
            this.listBoxUser.FormattingEnabled = true;
            this.listBoxUser.Location = new System.Drawing.Point(169, 12);
            this.listBoxUser.Name = "listBoxUser";
            this.listBoxUser.Size = new System.Drawing.Size(256, 173);
            this.listBoxUser.TabIndex = 0;
            // 
            // btAjoutUser
            // 
            this.btAjoutUser.Location = new System.Drawing.Point(12, 12);
            this.btAjoutUser.Name = "btAjoutUser";
            this.btAjoutUser.Size = new System.Drawing.Size(150, 34);
            this.btAjoutUser.TabIndex = 1;
            this.btAjoutUser.Text = "Ajouter un nouvel utilisateur";
            this.btAjoutUser.UseVisualStyleBackColor = true;
            this.btAjoutUser.Click += new System.EventHandler(this.btAjoutUser_Click);
            // 
            // btModifUser
            // 
            this.btModifUser.Location = new System.Drawing.Point(12, 52);
            this.btModifUser.Name = "btModifUser";
            this.btModifUser.Size = new System.Drawing.Size(150, 34);
            this.btModifUser.TabIndex = 2;
            this.btModifUser.Text = "Modifier un utilisateur";
            this.btModifUser.UseVisualStyleBackColor = true;
            this.btModifUser.Click += new System.EventHandler(this.btModifUser_Click);
            // 
            // btSuppUser
            // 
            this.btSuppUser.Location = new System.Drawing.Point(12, 92);
            this.btSuppUser.Name = "btSuppUser";
            this.btSuppUser.Size = new System.Drawing.Size(150, 34);
            this.btSuppUser.TabIndex = 3;
            this.btSuppUser.Text = "Supprimer un utilisateur";
            this.btSuppUser.UseVisualStyleBackColor = true;
            this.btSuppUser.Click += new System.EventHandler(this.btSuppUser_Click);
            // 
            // btValiderQuitter
            // 
            this.btValiderQuitter.Location = new System.Drawing.Point(12, 191);
            this.btValiderQuitter.Name = "btValiderQuitter";
            this.btValiderQuitter.Size = new System.Drawing.Size(413, 34);
            this.btValiderQuitter.TabIndex = 5;
            this.btValiderQuitter.Text = "Valider et quitter";
            this.btValiderQuitter.UseVisualStyleBackColor = true;
            this.btValiderQuitter.Click += new System.EventHandler(this.btValiderQuitter_Click);
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 237);
            this.Controls.Add(this.btValiderQuitter);
            this.Controls.Add(this.btSuppUser);
            this.Controls.Add(this.btModifUser);
            this.Controls.Add(this.btAjoutUser);
            this.Controls.Add(this.listBoxUser);
            this.Name = "FormAdmin";
            this.Text = "Optimize Energy Consumption - Administration";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxUser;
        private System.Windows.Forms.Button btAjoutUser;
        private System.Windows.Forms.Button btModifUser;
        private System.Windows.Forms.Button btSuppUser;
        private System.Windows.Forms.Button btValiderQuitter;
    }
}