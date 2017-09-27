namespace OptimizeEnergyConsumption
{
    partial class FormEtageAjout
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
            this.lbNombreEtages = new System.Windows.Forms.Label();
            this.cbNombreEtages = new System.Windows.Forms.ComboBox();
            this.btValider = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbNombreEtages
            // 
            this.lbNombreEtages.AutoSize = true;
            this.lbNombreEtages.Location = new System.Drawing.Point(13, 13);
            this.lbNombreEtages.Name = "lbNombreEtages";
            this.lbNombreEtages.Size = new System.Drawing.Size(93, 13);
            this.lbNombreEtages.TabIndex = 0;
            this.lbNombreEtages.Text = "Nombre d\'étages: ";
            // 
            // cbNombreEtages
            // 
            this.cbNombreEtages.FormattingEnabled = true;
            this.cbNombreEtages.Location = new System.Drawing.Point(113, 13);
            this.cbNombreEtages.Name = "cbNombreEtages";
            this.cbNombreEtages.Size = new System.Drawing.Size(121, 21);
            this.cbNombreEtages.TabIndex = 1;
            // 
            // btValider
            // 
            this.btValider.Location = new System.Drawing.Point(12, 45);
            this.btValider.Name = "btValider";
            this.btValider.Size = new System.Drawing.Size(222, 23);
            this.btValider.TabIndex = 2;
            this.btValider.Text = "Valider";
            this.btValider.UseVisualStyleBackColor = true;
            this.btValider.Click += new System.EventHandler(this.btValider_Click);
            // 
            // FormEtageAjout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 80);
            this.Controls.Add(this.btValider);
            this.Controls.Add(this.cbNombreEtages);
            this.Controls.Add(this.lbNombreEtages);
            this.Name = "FormEtageAjout";
            this.Text = "FormEtageAjout";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNombreEtages;
        private System.Windows.Forms.ComboBox cbNombreEtages;
        private System.Windows.Forms.Button btValider;
    }
}