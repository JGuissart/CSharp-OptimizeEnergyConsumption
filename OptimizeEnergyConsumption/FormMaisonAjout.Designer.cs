namespace OptimizeEnergyConsumption
{
    partial class FormMaisonAjout
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
            this.lbTitre = new System.Windows.Forms.Label();
            this.lbRue = new System.Windows.Forms.Label();
            this.lbNumero = new System.Windows.Forms.Label();
            this.lbCodePostal = new System.Windows.Forms.Label();
            this.cbLocalite = new System.Windows.Forms.ComboBox();
            this.lbLocalité = new System.Windows.Forms.Label();
            this.tfRue = new System.Windows.Forms.TextBox();
            this.tfNumero = new System.Windows.Forms.TextBox();
            this.tfCodePostal = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pbVRue = new System.Windows.Forms.PictureBox();
            this.pbVNumero = new System.Windows.Forms.PictureBox();
            this.pbVCodePostal = new System.Windows.Forms.PictureBox();
            this.pbVLocalite = new System.Windows.Forms.PictureBox();
            this.btChoixImage = new System.Windows.Forms.Button();
            this.pbApercuMaison = new System.Windows.Forms.PictureBox();
            this.btValider = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVRue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVNumero)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVCodePostal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVLocalite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbApercuMaison)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTitre
            // 
            this.lbTitre.AutoSize = true;
            this.lbTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitre.Location = new System.Drawing.Point(12, 9);
            this.lbTitre.Name = "lbTitre";
            this.lbTitre.Size = new System.Drawing.Size(368, 25);
            this.lbTitre.TabIndex = 0;
            this.lbTitre.Text = "Remplissez les champs suivants: ";
            // 
            // lbRue
            // 
            this.lbRue.AutoSize = true;
            this.lbRue.Location = new System.Drawing.Point(12, 52);
            this.lbRue.Name = "lbRue";
            this.lbRue.Size = new System.Drawing.Size(33, 13);
            this.lbRue.TabIndex = 1;
            this.lbRue.Text = "Rue: ";
            // 
            // lbNumero
            // 
            this.lbNumero.AutoSize = true;
            this.lbNumero.Location = new System.Drawing.Point(12, 83);
            this.lbNumero.Name = "lbNumero";
            this.lbNumero.Size = new System.Drawing.Size(50, 13);
            this.lbNumero.TabIndex = 2;
            this.lbNumero.Text = "Numéro: ";
            // 
            // lbCodePostal
            // 
            this.lbCodePostal.AutoSize = true;
            this.lbCodePostal.Location = new System.Drawing.Point(12, 118);
            this.lbCodePostal.Name = "lbCodePostal";
            this.lbCodePostal.Size = new System.Drawing.Size(69, 13);
            this.lbCodePostal.TabIndex = 3;
            this.lbCodePostal.Text = "Code postal: ";
            // 
            // cbLocalite
            // 
            this.cbLocalite.Enabled = false;
            this.cbLocalite.FormattingEnabled = true;
            this.cbLocalite.Location = new System.Drawing.Point(106, 148);
            this.cbLocalite.Name = "cbLocalite";
            this.cbLocalite.Size = new System.Drawing.Size(274, 21);
            this.cbLocalite.TabIndex = 4;
            this.cbLocalite.TextChanged += new System.EventHandler(this.cbLocalite_TextChanged);
            // 
            // lbLocalité
            // 
            this.lbLocalité.AutoSize = true;
            this.lbLocalité.Location = new System.Drawing.Point(13, 151);
            this.lbLocalité.Name = "lbLocalité";
            this.lbLocalité.Size = new System.Drawing.Size(50, 13);
            this.lbLocalité.TabIndex = 5;
            this.lbLocalité.Text = "Localité: ";
            // 
            // tfRue
            // 
            this.tfRue.Location = new System.Drawing.Point(106, 49);
            this.tfRue.Name = "tfRue";
            this.tfRue.Size = new System.Drawing.Size(274, 20);
            this.tfRue.TabIndex = 6;
            this.tfRue.TextChanged += new System.EventHandler(this.tfRue_TextChanged);
            // 
            // tfNumero
            // 
            this.tfNumero.Location = new System.Drawing.Point(106, 80);
            this.tfNumero.Name = "tfNumero";
            this.tfNumero.Size = new System.Drawing.Size(274, 20);
            this.tfNumero.TabIndex = 7;
            this.tfNumero.TextChanged += new System.EventHandler(this.tfNumero_TextChanged);
            // 
            // tfCodePostal
            // 
            this.tfCodePostal.Location = new System.Drawing.Point(106, 115);
            this.tfCodePostal.Name = "tfCodePostal";
            this.tfCodePostal.Size = new System.Drawing.Size(274, 20);
            this.tfCodePostal.TabIndex = 8;
            this.tfCodePostal.TextChanged += new System.EventHandler(this.tfCodePostal_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 407);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.Visible = false;
            // 
            // pbVRue
            // 
            this.pbVRue.Location = new System.Drawing.Point(386, 49);
            this.pbVRue.Name = "pbVRue";
            this.pbVRue.Size = new System.Drawing.Size(20, 20);
            this.pbVRue.TabIndex = 10;
            this.pbVRue.TabStop = false;
            // 
            // pbVNumero
            // 
            this.pbVNumero.Location = new System.Drawing.Point(386, 80);
            this.pbVNumero.Name = "pbVNumero";
            this.pbVNumero.Size = new System.Drawing.Size(20, 20);
            this.pbVNumero.TabIndex = 11;
            this.pbVNumero.TabStop = false;
            // 
            // pbVCodePostal
            // 
            this.pbVCodePostal.Location = new System.Drawing.Point(386, 115);
            this.pbVCodePostal.Name = "pbVCodePostal";
            this.pbVCodePostal.Size = new System.Drawing.Size(20, 20);
            this.pbVCodePostal.TabIndex = 12;
            this.pbVCodePostal.TabStop = false;
            // 
            // pbVLocalite
            // 
            this.pbVLocalite.Location = new System.Drawing.Point(386, 148);
            this.pbVLocalite.Name = "pbVLocalite";
            this.pbVLocalite.Size = new System.Drawing.Size(20, 20);
            this.pbVLocalite.TabIndex = 13;
            this.pbVLocalite.TabStop = false;
            // 
            // btChoixImage
            // 
            this.btChoixImage.Enabled = false;
            this.btChoixImage.Location = new System.Drawing.Point(12, 191);
            this.btChoixImage.Name = "btChoixImage";
            this.btChoixImage.Size = new System.Drawing.Size(394, 23);
            this.btChoixImage.TabIndex = 14;
            this.btChoixImage.Text = "Choisir une image";
            this.btChoixImage.UseVisualStyleBackColor = true;
            this.btChoixImage.Click += new System.EventHandler(this.btChoixImage_Click);
            // 
            // pbApercuMaison
            // 
            this.pbApercuMaison.Location = new System.Drawing.Point(433, 49);
            this.pbApercuMaison.Name = "pbApercuMaison";
            this.pbApercuMaison.Size = new System.Drawing.Size(235, 165);
            this.pbApercuMaison.TabIndex = 15;
            this.pbApercuMaison.TabStop = false;
            // 
            // btValider
            // 
            this.btValider.Enabled = false;
            this.btValider.Location = new System.Drawing.Point(433, 220);
            this.btValider.Name = "btValider";
            this.btValider.Size = new System.Drawing.Size(235, 34);
            this.btValider.TabIndex = 16;
            this.btValider.Text = "Valider la maison";
            this.btValider.UseVisualStyleBackColor = true;
            this.btValider.Click += new System.EventHandler(this.btValider_Click);
            // 
            // FormMaisonAjout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 266);
            this.Controls.Add(this.btValider);
            this.Controls.Add(this.pbApercuMaison);
            this.Controls.Add(this.btChoixImage);
            this.Controls.Add(this.pbVLocalite);
            this.Controls.Add(this.pbVCodePostal);
            this.Controls.Add(this.pbVNumero);
            this.Controls.Add(this.pbVRue);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tfCodePostal);
            this.Controls.Add(this.tfNumero);
            this.Controls.Add(this.tfRue);
            this.Controls.Add(this.lbLocalité);
            this.Controls.Add(this.cbLocalite);
            this.Controls.Add(this.lbCodePostal);
            this.Controls.Add(this.lbNumero);
            this.Controls.Add(this.lbRue);
            this.Controls.Add(this.lbTitre);
            this.Name = "FormMaisonAjout";
            this.Text = "FormMaisonAjout";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVRue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVNumero)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVCodePostal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVLocalite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbApercuMaison)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitre;
        private System.Windows.Forms.Label lbRue;
        private System.Windows.Forms.Label lbNumero;
        private System.Windows.Forms.Label lbCodePostal;
        private System.Windows.Forms.ComboBox cbLocalite;
        private System.Windows.Forms.Label lbLocalité;
        private System.Windows.Forms.TextBox tfRue;
        private System.Windows.Forms.TextBox tfNumero;
        private System.Windows.Forms.TextBox tfCodePostal;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pbVRue;
        private System.Windows.Forms.PictureBox pbVNumero;
        private System.Windows.Forms.PictureBox pbVCodePostal;
        private System.Windows.Forms.PictureBox pbVLocalite;
        private System.Windows.Forms.Button btChoixImage;
        private System.Windows.Forms.PictureBox pbApercuMaison;
        private System.Windows.Forms.Button btValider;
    }
}