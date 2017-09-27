namespace OptimizeEnergyConsumption
{
    partial class FormSimulationChoix
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
            this.label1 = new System.Windows.Forms.Label();
            this.btMaisonSelectionnee = new System.Windows.Forms.Button();
            this.btToutesLesMaisons = new System.Windows.Forms.Button();
            this.btAnnuler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choisissez le type de simulation que vous souhaitez faire";
            // 
            // btMaisonSelectionnee
            // 
            this.btMaisonSelectionnee.Location = new System.Drawing.Point(12, 38);
            this.btMaisonSelectionnee.Name = "btMaisonSelectionnee";
            this.btMaisonSelectionnee.Size = new System.Drawing.Size(266, 23);
            this.btMaisonSelectionnee.TabIndex = 1;
            this.btMaisonSelectionnee.Text = "Maison sélectionnée";
            this.btMaisonSelectionnee.UseVisualStyleBackColor = true;
            this.btMaisonSelectionnee.Click += new System.EventHandler(this.btMaisonSelectionnee_Click);
            // 
            // btToutesLesMaisons
            // 
            this.btToutesLesMaisons.Enabled = false;
            this.btToutesLesMaisons.Location = new System.Drawing.Point(12, 73);
            this.btToutesLesMaisons.Name = "btToutesLesMaisons";
            this.btToutesLesMaisons.Size = new System.Drawing.Size(266, 23);
            this.btToutesLesMaisons.TabIndex = 2;
            this.btToutesLesMaisons.Text = "Toutes les maisons";
            this.btToutesLesMaisons.UseVisualStyleBackColor = true;
            this.btToutesLesMaisons.Click += new System.EventHandler(this.btToutesLesMaisons_Click);
            // 
            // btAnnuler
            // 
            this.btAnnuler.Location = new System.Drawing.Point(12, 121);
            this.btAnnuler.Name = "btAnnuler";
            this.btAnnuler.Size = new System.Drawing.Size(266, 23);
            this.btAnnuler.TabIndex = 3;
            this.btAnnuler.Text = "Annuler";
            this.btAnnuler.UseVisualStyleBackColor = true;
            this.btAnnuler.Click += new System.EventHandler(this.btAnnuler_Click);
            // 
            // FormSimulationChoix
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 156);
            this.Controls.Add(this.btAnnuler);
            this.Controls.Add(this.btToutesLesMaisons);
            this.Controls.Add(this.btMaisonSelectionnee);
            this.Controls.Add(this.label1);
            this.Name = "FormSimulationChoix";
            this.Text = "Choix du type de simulation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btMaisonSelectionnee;
        private System.Windows.Forms.Button btToutesLesMaisons;
        private System.Windows.Forms.Button btAnnuler;
    }
}