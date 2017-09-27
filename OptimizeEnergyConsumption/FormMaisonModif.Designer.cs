namespace OptimizeEnergyConsumption
{
    partial class FormMaisonModif
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
            this.tfCodePostal = new System.Windows.Forms.TextBox();
            this.tfNumero = new System.Windows.Forms.TextBox();
            this.tfRue = new System.Windows.Forms.TextBox();
            this.lbLocalité = new System.Windows.Forms.Label();
            this.cbLocalite = new System.Windows.Forms.ComboBox();
            this.lbCodePostal = new System.Windows.Forms.Label();
            this.lbNumero = new System.Windows.Forms.Label();
            this.lbRue = new System.Windows.Forms.Label();
            this.btValider = new System.Windows.Forms.Button();
            this.btAnnuler = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tfCodePostal
            // 
            this.tfCodePostal.Location = new System.Drawing.Point(106, 72);
            this.tfCodePostal.Name = "tfCodePostal";
            this.tfCodePostal.Size = new System.Drawing.Size(273, 20);
            this.tfCodePostal.TabIndex = 16;
            this.tfCodePostal.TextChanged += new System.EventHandler(this.tfCodePostal_TextChanged);
            // 
            // tfNumero
            // 
            this.tfNumero.Location = new System.Drawing.Point(106, 37);
            this.tfNumero.Name = "tfNumero";
            this.tfNumero.Size = new System.Drawing.Size(273, 20);
            this.tfNumero.TabIndex = 15;
            this.tfNumero.TextChanged += new System.EventHandler(this.tfNumero_TextChanged);
            // 
            // tfRue
            // 
            this.tfRue.Location = new System.Drawing.Point(106, 6);
            this.tfRue.Name = "tfRue";
            this.tfRue.Size = new System.Drawing.Size(273, 20);
            this.tfRue.TabIndex = 14;
            this.tfRue.TextChanged += new System.EventHandler(this.tfRue_TextChanged);
            // 
            // lbLocalité
            // 
            this.lbLocalité.AutoSize = true;
            this.lbLocalité.Location = new System.Drawing.Point(13, 108);
            this.lbLocalité.Name = "lbLocalité";
            this.lbLocalité.Size = new System.Drawing.Size(50, 13);
            this.lbLocalité.TabIndex = 13;
            this.lbLocalité.Text = "Localité: ";
            // 
            // cbLocalite
            // 
            this.cbLocalite.Enabled = false;
            this.cbLocalite.FormattingEnabled = true;
            this.cbLocalite.Location = new System.Drawing.Point(106, 105);
            this.cbLocalite.Name = "cbLocalite";
            this.cbLocalite.Size = new System.Drawing.Size(273, 21);
            this.cbLocalite.TabIndex = 12;
            this.cbLocalite.TextChanged += new System.EventHandler(this.cbLocalite_TextChanged);
            // 
            // lbCodePostal
            // 
            this.lbCodePostal.AutoSize = true;
            this.lbCodePostal.Location = new System.Drawing.Point(12, 75);
            this.lbCodePostal.Name = "lbCodePostal";
            this.lbCodePostal.Size = new System.Drawing.Size(69, 13);
            this.lbCodePostal.TabIndex = 11;
            this.lbCodePostal.Text = "Code postal: ";
            // 
            // lbNumero
            // 
            this.lbNumero.AutoSize = true;
            this.lbNumero.Location = new System.Drawing.Point(12, 40);
            this.lbNumero.Name = "lbNumero";
            this.lbNumero.Size = new System.Drawing.Size(50, 13);
            this.lbNumero.TabIndex = 10;
            this.lbNumero.Text = "Numéro: ";
            // 
            // lbRue
            // 
            this.lbRue.AutoSize = true;
            this.lbRue.Location = new System.Drawing.Point(12, 9);
            this.lbRue.Name = "lbRue";
            this.lbRue.Size = new System.Drawing.Size(33, 13);
            this.lbRue.TabIndex = 9;
            this.lbRue.Text = "Rue: ";
            // 
            // btValider
            // 
            this.btValider.Enabled = false;
            this.btValider.Location = new System.Drawing.Point(13, 143);
            this.btValider.Name = "btValider";
            this.btValider.Size = new System.Drawing.Size(173, 23);
            this.btValider.TabIndex = 17;
            this.btValider.Text = "Valider les modifications";
            this.btValider.UseVisualStyleBackColor = true;
            this.btValider.Click += new System.EventHandler(this.btValider_Click);
            // 
            // btAnnuler
            // 
            this.btAnnuler.Location = new System.Drawing.Point(193, 143);
            this.btAnnuler.Name = "btAnnuler";
            this.btAnnuler.Size = new System.Drawing.Size(186, 23);
            this.btAnnuler.TabIndex = 18;
            this.btAnnuler.Text = "Annuler les modifications";
            this.btAnnuler.UseVisualStyleBackColor = true;
            this.btAnnuler.Click += new System.EventHandler(this.btAnnuler_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 424);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 19;
            // 
            // FormMaisonModif
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 176);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btAnnuler);
            this.Controls.Add(this.btValider);
            this.Controls.Add(this.tfCodePostal);
            this.Controls.Add(this.tfNumero);
            this.Controls.Add(this.tfRue);
            this.Controls.Add(this.lbLocalité);
            this.Controls.Add(this.cbLocalite);
            this.Controls.Add(this.lbCodePostal);
            this.Controls.Add(this.lbNumero);
            this.Controls.Add(this.lbRue);
            this.Name = "FormMaisonModif";
            this.Text = "FormMaisonModif";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tfCodePostal;
        private System.Windows.Forms.TextBox tfNumero;
        private System.Windows.Forms.TextBox tfRue;
        private System.Windows.Forms.Label lbLocalité;
        private System.Windows.Forms.ComboBox cbLocalite;
        private System.Windows.Forms.Label lbCodePostal;
        private System.Windows.Forms.Label lbNumero;
        private System.Windows.Forms.Label lbRue;
        private System.Windows.Forms.Button btValider;
        private System.Windows.Forms.Button btAnnuler;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}