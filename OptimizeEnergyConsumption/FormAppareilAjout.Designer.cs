namespace OptimizeEnergyConsumption
{
    partial class FormAppareilAjout
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
            this.listBoxAppareil = new System.Windows.Forms.ListBox();
            this.pbAppareil = new System.Windows.Forms.PictureBox();
            this.pbDessinAppareil = new System.Windows.Forms.PictureBox();
            this.btValider = new System.Windows.Forms.Button();
            this.panelPbDessinAppareil = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pbAppareil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDessinAppareil)).BeginInit();
            this.panelPbDessinAppareil.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxAppareil
            // 
            this.listBoxAppareil.FormattingEnabled = true;
            this.listBoxAppareil.Location = new System.Drawing.Point(963, 193);
            this.listBoxAppareil.Name = "listBoxAppareil";
            this.listBoxAppareil.Size = new System.Drawing.Size(175, 290);
            this.listBoxAppareil.TabIndex = 6;
            this.listBoxAppareil.SelectedIndexChanged += new System.EventHandler(this.listBoxAppareil_SelectedIndexChanged);
            // 
            // pbAppareil
            // 
            this.pbAppareil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbAppareil.Location = new System.Drawing.Point(964, 12);
            this.pbAppareil.Name = "pbAppareil";
            this.pbAppareil.Size = new System.Drawing.Size(175, 175);
            this.pbAppareil.TabIndex = 5;
            this.pbAppareil.TabStop = false;
            // 
            // pbDessinAppareil
            // 
            this.pbDessinAppareil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbDessinAppareil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbDessinAppareil.Cursor = System.Windows.Forms.Cursors.Cross;
            this.pbDessinAppareil.Location = new System.Drawing.Point(-1, -1);
            this.pbDessinAppareil.Name = "pbDessinAppareil";
            this.pbDessinAppareil.Size = new System.Drawing.Size(945, 471);
            this.pbDessinAppareil.TabIndex = 0;
            this.pbDessinAppareil.TabStop = false;
            this.pbDessinAppareil.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbDessinAppareil_MouseDown);
            this.pbDessinAppareil.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbDessinAppareil_MouseMove);
            this.pbDessinAppareil.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbDessinAppareil_MouseUp);
            // 
            // btValider
            // 
            this.btValider.Location = new System.Drawing.Point(12, 489);
            this.btValider.Name = "btValider";
            this.btValider.Size = new System.Drawing.Size(174, 31);
            this.btValider.TabIndex = 7;
            this.btValider.Text = "Valider l\'ajout des appareils";
            this.btValider.UseVisualStyleBackColor = true;
            this.btValider.Click += new System.EventHandler(this.btValider_Click);
            // 
            // panelPbDessinAppareil
            // 
            this.panelPbDessinAppareil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPbDessinAppareil.Controls.Add(this.pbDessinAppareil);
            this.panelPbDessinAppareil.Location = new System.Drawing.Point(12, 12);
            this.panelPbDessinAppareil.Name = "panelPbDessinAppareil";
            this.panelPbDessinAppareil.Size = new System.Drawing.Size(944, 470);
            this.panelPbDessinAppareil.TabIndex = 9;
            // 
            // FormAppareilAjout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 532);
            this.Controls.Add(this.panelPbDessinAppareil);
            this.Controls.Add(this.btValider);
            this.Controls.Add(this.listBoxAppareil);
            this.Controls.Add(this.pbAppareil);
            this.Name = "FormAppareilAjout";
            this.Text = "Ajouter un appareil dans une pièce";
            ((System.ComponentModel.ISupportInitialize)(this.pbAppareil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDessinAppareil)).EndInit();
            this.panelPbDessinAppareil.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxAppareil;
        private System.Windows.Forms.PictureBox pbAppareil;
        private System.Windows.Forms.PictureBox pbDessinAppareil;
        private System.Windows.Forms.Button btValider;
        private System.Windows.Forms.Panel panelPbDessinAppareil;
    }
}