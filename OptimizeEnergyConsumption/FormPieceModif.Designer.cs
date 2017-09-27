namespace OptimizeEnergyConsumption
{
    partial class FormPieceModif
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
            this.lbNomPiece = new System.Windows.Forms.Label();
            this.tfNomPiece = new System.Windows.Forms.TextBox();
            this.btValider = new System.Windows.Forms.Button();
            this.btAnnuler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbNomPiece
            // 
            this.lbNomPiece.AutoSize = true;
            this.lbNomPiece.Location = new System.Drawing.Point(13, 13);
            this.lbNomPiece.Name = "lbNomPiece";
            this.lbNomPiece.Size = new System.Drawing.Size(93, 13);
            this.lbNomPiece.TabIndex = 0;
            this.lbNomPiece.Text = "Nom de la pièce : ";
            // 
            // tfNomPiece
            // 
            this.tfNomPiece.Location = new System.Drawing.Point(112, 10);
            this.tfNomPiece.Name = "tfNomPiece";
            this.tfNomPiece.Size = new System.Drawing.Size(200, 20);
            this.tfNomPiece.TabIndex = 1;
            // 
            // btValider
            // 
            this.btValider.Location = new System.Drawing.Point(12, 37);
            this.btValider.Name = "btValider";
            this.btValider.Size = new System.Drawing.Size(148, 23);
            this.btValider.TabIndex = 2;
            this.btValider.Text = "Valider";
            this.btValider.UseVisualStyleBackColor = true;
            this.btValider.Click += new System.EventHandler(this.btValider_Click);
            // 
            // btAnnuler
            // 
            this.btAnnuler.Location = new System.Drawing.Point(166, 37);
            this.btAnnuler.Name = "btAnnuler";
            this.btAnnuler.Size = new System.Drawing.Size(146, 23);
            this.btAnnuler.TabIndex = 3;
            this.btAnnuler.Text = "Annuler";
            this.btAnnuler.UseVisualStyleBackColor = true;
            this.btAnnuler.Click += new System.EventHandler(this.btAnnuler_Click);
            // 
            // FormPieceModif
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 72);
            this.Controls.Add(this.btAnnuler);
            this.Controls.Add(this.btValider);
            this.Controls.Add(this.tfNomPiece);
            this.Controls.Add(this.lbNomPiece);
            this.Name = "FormPieceModif";
            this.Text = "FormPieceModif";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNomPiece;
        private System.Windows.Forms.TextBox tfNomPiece;
        private System.Windows.Forms.Button btValider;
        private System.Windows.Forms.Button btAnnuler;
    }
}