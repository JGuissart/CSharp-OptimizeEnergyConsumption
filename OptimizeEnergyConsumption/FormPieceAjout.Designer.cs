namespace OptimizeEnergyConsumption
{
    partial class FormPieceAjout
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
            this.btValider = new System.Windows.Forms.Button();
            this.lbNomPiece = new System.Windows.Forms.Label();
            this.tbNomPiece = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btValider
            // 
            this.btValider.Location = new System.Drawing.Point(12, 36);
            this.btValider.Name = "btValider";
            this.btValider.Size = new System.Drawing.Size(313, 31);
            this.btValider.TabIndex = 0;
            this.btValider.Text = "Valider";
            this.btValider.UseVisualStyleBackColor = true;
            this.btValider.Click += new System.EventHandler(this.btValider_Click);
            // 
            // lbNomPiece
            // 
            this.lbNomPiece.AutoSize = true;
            this.lbNomPiece.Location = new System.Drawing.Point(13, 13);
            this.lbNomPiece.Name = "lbNomPiece";
            this.lbNomPiece.Size = new System.Drawing.Size(132, 13);
            this.lbNomPiece.TabIndex = 1;
            this.lbNomPiece.Text = "Entrez le nom de la pièce: ";
            // 
            // tbNomPiece
            // 
            this.tbNomPiece.Location = new System.Drawing.Point(151, 10);
            this.tbNomPiece.Name = "tbNomPiece";
            this.tbNomPiece.Size = new System.Drawing.Size(174, 20);
            this.tbNomPiece.TabIndex = 2;
            // 
            // FormPieceAjout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 79);
            this.Controls.Add(this.tbNomPiece);
            this.Controls.Add(this.lbNomPiece);
            this.Controls.Add(this.btValider);
            this.Name = "FormPieceAjout";
            this.Text = "FormPieceAjout";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btValider;
        private System.Windows.Forms.Label lbNomPiece;
        private System.Windows.Forms.TextBox tbNomPiece;
    }
}