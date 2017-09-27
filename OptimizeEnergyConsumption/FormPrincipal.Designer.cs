namespace OptimizeEnergyConsumption
{
    partial class FormPrincipal
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.msMaison = new System.Windows.Forms.ToolStripMenuItem();
            this.msAjouterMaison = new System.Windows.Forms.ToolStripMenuItem();
            this.msModifierMaison = new System.Windows.Forms.ToolStripMenuItem();
            this.msSupprimerMaison = new System.Windows.Forms.ToolStripMenuItem();
            this.msEtage = new System.Windows.Forms.ToolStripMenuItem();
            this.msAjouterEtage = new System.Windows.Forms.ToolStripMenuItem();
            this.msSupprimerEtage = new System.Windows.Forms.ToolStripMenuItem();
            this.msPiece = new System.Windows.Forms.ToolStripMenuItem();
            this.msAjouterPiece = new System.Windows.Forms.ToolStripMenuItem();
            this.msModifierPiece = new System.Windows.Forms.ToolStripMenuItem();
            this.msSupprimerPiece = new System.Windows.Forms.ToolStripMenuItem();
            this.msAppareil = new System.Windows.Forms.ToolStripMenuItem();
            this.msAjouterAppareil = new System.Windows.Forms.ToolStripMenuItem();
            this.msModifierAppareil = new System.Windows.Forms.ToolStripMenuItem();
            this.msSupprimerAppareil = new System.Windows.Forms.ToolStripMenuItem();
            this.msSimulation = new System.Windows.Forms.ToolStripMenuItem();
            this.msQuitter = new System.Windows.Forms.ToolStripMenuItem();
            this.treeView = new System.Windows.Forms.TreeView();
            this.pbDessin = new System.Windows.Forms.PictureBox();
            this.pbAppareil = new System.Windows.Forms.PictureBox();
            this.listBoxAppareil = new System.Windows.Forms.ListBox();
            this.lbRue = new System.Windows.Forms.Label();
            this.lbSimulationEnCours = new System.Windows.Forms.Label();
            this.progressBarSimulation = new System.Windows.Forms.ProgressBar();
            this.timerSimulation = new System.Windows.Forms.Timer(this.components);
            this.propertyGridAppareil = new System.Windows.Forms.PropertyGrid();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDessin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAppareil)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msMaison,
            this.msEtage,
            this.msPiece,
            this.msAppareil,
            this.msSimulation,
            this.msQuitter});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1276, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // msMaison
            // 
            this.msMaison.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msAjouterMaison,
            this.msModifierMaison,
            this.msSupprimerMaison});
            this.msMaison.Name = "msMaison";
            this.msMaison.Size = new System.Drawing.Size(58, 20);
            this.msMaison.Text = "Maison";
            // 
            // msAjouterMaison
            // 
            this.msAjouterMaison.Name = "msAjouterMaison";
            this.msAjouterMaison.Size = new System.Drawing.Size(129, 22);
            this.msAjouterMaison.Text = "Ajouter";
            this.msAjouterMaison.Click += new System.EventHandler(this.msAjouterMaison_Click);
            // 
            // msModifierMaison
            // 
            this.msModifierMaison.Enabled = false;
            this.msModifierMaison.Name = "msModifierMaison";
            this.msModifierMaison.Size = new System.Drawing.Size(129, 22);
            this.msModifierMaison.Text = "Modifier";
            this.msModifierMaison.Click += new System.EventHandler(this.msModifierMaison_Click);
            // 
            // msSupprimerMaison
            // 
            this.msSupprimerMaison.Enabled = false;
            this.msSupprimerMaison.Name = "msSupprimerMaison";
            this.msSupprimerMaison.Size = new System.Drawing.Size(129, 22);
            this.msSupprimerMaison.Text = "Supprimer";
            this.msSupprimerMaison.Click += new System.EventHandler(this.msSupprimerMaison_Click);
            // 
            // msEtage
            // 
            this.msEtage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msAjouterEtage,
            this.msSupprimerEtage});
            this.msEtage.Name = "msEtage";
            this.msEtage.Size = new System.Drawing.Size(48, 20);
            this.msEtage.Text = "Etage";
            // 
            // msAjouterEtage
            // 
            this.msAjouterEtage.Enabled = false;
            this.msAjouterEtage.Name = "msAjouterEtage";
            this.msAjouterEtage.Size = new System.Drawing.Size(129, 22);
            this.msAjouterEtage.Text = "Ajouter";
            this.msAjouterEtage.Click += new System.EventHandler(this.msAjouterEtage_Click);
            // 
            // msSupprimerEtage
            // 
            this.msSupprimerEtage.Enabled = false;
            this.msSupprimerEtage.Name = "msSupprimerEtage";
            this.msSupprimerEtage.Size = new System.Drawing.Size(129, 22);
            this.msSupprimerEtage.Text = "Supprimer";
            this.msSupprimerEtage.Click += new System.EventHandler(this.msSupprimerEtage_Click);
            // 
            // msPiece
            // 
            this.msPiece.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msAjouterPiece,
            this.msModifierPiece,
            this.msSupprimerPiece});
            this.msPiece.Name = "msPiece";
            this.msPiece.Size = new System.Drawing.Size(47, 20);
            this.msPiece.Text = "Pièce";
            // 
            // msAjouterPiece
            // 
            this.msAjouterPiece.Enabled = false;
            this.msAjouterPiece.Name = "msAjouterPiece";
            this.msAjouterPiece.Size = new System.Drawing.Size(129, 22);
            this.msAjouterPiece.Text = "Ajouter";
            this.msAjouterPiece.Click += new System.EventHandler(this.msAjouterPiece_Click);
            // 
            // msModifierPiece
            // 
            this.msModifierPiece.Enabled = false;
            this.msModifierPiece.Name = "msModifierPiece";
            this.msModifierPiece.Size = new System.Drawing.Size(129, 22);
            this.msModifierPiece.Text = "Modifier";
            this.msModifierPiece.Click += new System.EventHandler(this.msModifierPiece_Click);
            // 
            // msSupprimerPiece
            // 
            this.msSupprimerPiece.Enabled = false;
            this.msSupprimerPiece.Name = "msSupprimerPiece";
            this.msSupprimerPiece.Size = new System.Drawing.Size(129, 22);
            this.msSupprimerPiece.Text = "Supprimer";
            this.msSupprimerPiece.Click += new System.EventHandler(this.msSupprimerPiece_Click);
            // 
            // msAppareil
            // 
            this.msAppareil.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msAjouterAppareil,
            this.msModifierAppareil,
            this.msSupprimerAppareil});
            this.msAppareil.Name = "msAppareil";
            this.msAppareil.Size = new System.Drawing.Size(63, 20);
            this.msAppareil.Text = "Appareil";
            // 
            // msAjouterAppareil
            // 
            this.msAjouterAppareil.Enabled = false;
            this.msAjouterAppareil.Name = "msAjouterAppareil";
            this.msAjouterAppareil.Size = new System.Drawing.Size(129, 22);
            this.msAjouterAppareil.Text = "Ajouter";
            this.msAjouterAppareil.Click += new System.EventHandler(this.msAjouterAppareil_Click);
            // 
            // msModifierAppareil
            // 
            this.msModifierAppareil.Enabled = false;
            this.msModifierAppareil.Name = "msModifierAppareil";
            this.msModifierAppareil.Size = new System.Drawing.Size(129, 22);
            this.msModifierAppareil.Text = "Modifier";
            this.msModifierAppareil.Click += new System.EventHandler(this.msModifierAppareil_Click);
            // 
            // msSupprimerAppareil
            // 
            this.msSupprimerAppareil.Enabled = false;
            this.msSupprimerAppareil.Name = "msSupprimerAppareil";
            this.msSupprimerAppareil.Size = new System.Drawing.Size(129, 22);
            this.msSupprimerAppareil.Text = "Supprimer";
            this.msSupprimerAppareil.Click += new System.EventHandler(this.msSupprimerAppareil_Click);
            // 
            // msSimulation
            // 
            this.msSimulation.Name = "msSimulation";
            this.msSimulation.Size = new System.Drawing.Size(188, 20);
            this.msSimulation.Text = "Simulation de la consommation";
            this.msSimulation.Click += new System.EventHandler(this.msSimulation_Click);
            // 
            // msQuitter
            // 
            this.msQuitter.Name = "msQuitter";
            this.msQuitter.Size = new System.Drawing.Size(124, 20);
            this.msQuitter.Text = "Quitter l\'application";
            this.msQuitter.Click += new System.EventHandler(this.msQuitter_Click);
            // 
            // treeView
            // 
            this.treeView.Location = new System.Drawing.Point(13, 56);
            this.treeView.Name = "treeView";
            this.treeView.Size = new System.Drawing.Size(215, 310);
            this.treeView.TabIndex = 1;
            this.treeView.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView_NodeMouseDoubleClick);
            // 
            // pbDessin
            // 
            this.pbDessin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbDessin.Cursor = System.Windows.Forms.Cursors.Cross;
            this.pbDessin.Location = new System.Drawing.Point(234, 56);
            this.pbDessin.Name = "pbDessin";
            this.pbDessin.Size = new System.Drawing.Size(849, 534);
            this.pbDessin.TabIndex = 2;
            this.pbDessin.TabStop = false;
            this.pbDessin.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pbDessin_MouseClick);
            this.pbDessin.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbDessin_MouseDown);
            this.pbDessin.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbDessin_MouseMove);
            this.pbDessin.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbDessin_MouseUp);
            // 
            // pbAppareil
            // 
            this.pbAppareil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbAppareil.Location = new System.Drawing.Point(1089, 56);
            this.pbAppareil.Name = "pbAppareil";
            this.pbAppareil.Size = new System.Drawing.Size(175, 175);
            this.pbAppareil.TabIndex = 3;
            this.pbAppareil.TabStop = false;
            // 
            // listBoxAppareil
            // 
            this.listBoxAppareil.FormattingEnabled = true;
            this.listBoxAppareil.Location = new System.Drawing.Point(1089, 248);
            this.listBoxAppareil.Name = "listBoxAppareil";
            this.listBoxAppareil.Size = new System.Drawing.Size(175, 342);
            this.listBoxAppareil.TabIndex = 4;
            this.listBoxAppareil.SelectedIndexChanged += new System.EventHandler(this.listBoxAppareil_SelectedIndexChanged);
            this.listBoxAppareil.SelectedValueChanged += new System.EventHandler(this.listBoxAppareil_SelectedValueChanged);
            // 
            // lbRue
            // 
            this.lbRue.AutoSize = true;
            this.lbRue.Location = new System.Drawing.Point(853, 40);
            this.lbRue.Name = "lbRue";
            this.lbRue.Size = new System.Drawing.Size(0, 13);
            this.lbRue.TabIndex = 5;
            // 
            // lbSimulationEnCours
            // 
            this.lbSimulationEnCours.AutoSize = true;
            this.lbSimulationEnCours.Location = new System.Drawing.Point(576, 593);
            this.lbSimulationEnCours.Name = "lbSimulationEnCours";
            this.lbSimulationEnCours.Size = new System.Drawing.Size(141, 13);
            this.lbSimulationEnCours.TabIndex = 6;
            this.lbSimulationEnCours.Text = "La simulation est en cours ...";
            this.lbSimulationEnCours.Visible = false;
            // 
            // progressBarSimulation
            // 
            this.progressBarSimulation.Location = new System.Drawing.Point(12, 625);
            this.progressBarSimulation.Name = "progressBarSimulation";
            this.progressBarSimulation.Size = new System.Drawing.Size(1252, 23);
            this.progressBarSimulation.TabIndex = 7;
            this.progressBarSimulation.Visible = false;
            // 
            // timerSimulation
            // 
            this.timerSimulation.Tick += new System.EventHandler(this.timerSimulation_Tick);
            // 
            // propertyGridAppareil
            // 
            this.propertyGridAppareil.Location = new System.Drawing.Point(12, 372);
            this.propertyGridAppareil.Name = "propertyGridAppareil";
            this.propertyGridAppareil.Size = new System.Drawing.Size(216, 218);
            this.propertyGridAppareil.TabIndex = 8;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 660);
            this.Controls.Add(this.propertyGridAppareil);
            this.Controls.Add(this.progressBarSimulation);
            this.Controls.Add(this.lbSimulationEnCours);
            this.Controls.Add(this.lbRue);
            this.Controls.Add(this.listBoxAppareil);
            this.Controls.Add(this.pbAppareil);
            this.Controls.Add(this.pbDessin);
            this.Controls.Add(this.treeView);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormPrincipal";
            this.Text = "FormConnexionUser";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDessin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAppareil)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem msMaison;
        private System.Windows.Forms.ToolStripMenuItem msAjouterMaison;
        private System.Windows.Forms.ToolStripMenuItem msSupprimerMaison;
        private System.Windows.Forms.ToolStripMenuItem msEtage;
        private System.Windows.Forms.ToolStripMenuItem msAjouterEtage;
        private System.Windows.Forms.ToolStripMenuItem msSupprimerEtage;
        private System.Windows.Forms.ToolStripMenuItem msPiece;
        private System.Windows.Forms.ToolStripMenuItem msAjouterPiece;
        private System.Windows.Forms.ToolStripMenuItem msSupprimerPiece;
        private System.Windows.Forms.ToolStripMenuItem msAppareil;
        private System.Windows.Forms.ToolStripMenuItem msAjouterAppareil;
        private System.Windows.Forms.ToolStripMenuItem msModifierAppareil;
        private System.Windows.Forms.ToolStripMenuItem msSupprimerAppareil;
        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.PictureBox pbDessin;
        private System.Windows.Forms.PictureBox pbAppareil;
        private System.Windows.Forms.ListBox listBoxAppareil;
        private System.Windows.Forms.ToolStripMenuItem msQuitter;
        private System.Windows.Forms.ToolStripMenuItem msModifierPiece;
        private System.Windows.Forms.Label lbRue;
        private System.Windows.Forms.ToolStripMenuItem msSimulation;
        private System.Windows.Forms.Label lbSimulationEnCours;
        private System.Windows.Forms.ProgressBar progressBarSimulation;
        private System.Windows.Forms.Timer timerSimulation;
        private System.Windows.Forms.ToolStripMenuItem msModifierMaison;
        private System.Windows.Forms.PropertyGrid propertyGridAppareil;
    }
}