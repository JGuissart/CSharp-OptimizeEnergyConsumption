using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using ConsumptionLib;
using System.Drawing.Imaging;

namespace OptimizeEnergyConsumption
{
    public partial class FormMaisonAjout : Form
    {
        #region Variables membres

        private MySqlConnection _SQLConnexion;
        private MySqlDataAdapter _SQLMyAdapter;
        private DataSet _SQLMyDataSet;
        private CHouse _Maison;
        private bool _Valide;  

        #endregion

        #region Propriétés

        public MySqlConnection SQLConnexion
        {
            get { return _SQLConnexion; }
            set { _SQLConnexion = value; }
        }

        public MySqlDataAdapter SQLMyAdapter
        {
            get { return _SQLMyAdapter; }
            set { _SQLMyAdapter = value; }
        }

        public DataSet SQLMyDataSet
        {
            get { return _SQLMyDataSet; }
            set { _SQLMyDataSet = value; }
        }

        public CHouse Maison
        {
            get { return _Maison; }
            set { _Maison = value; }
        }

        public bool Valide
        {
            get { return _Valide; }
            set { _Valide = value; }
        }

        #endregion

        #region Constructeurs

        public FormMaisonAjout()
        {
            InitializeComponent();
            SQLConnexion = new MySqlConnection("Database=ApplicCSharp2014;Data Source=localhost;User Id=root;Password=");
            SQLMyDataSet = new DataSet();
            Maison = new CHouse();
        }

        #endregion

        #region Evenements Boutons

        private void btChoixImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();

            if (f.ShowDialog() == DialogResult.OK)
            {
                Maison.PathImage = f.FileName;
                Bitmap img = new Bitmap(f.FileName);

                float fEchelleTemp, fCoordTemp;
                pbApercuMaison.Image = new Bitmap(pbApercuMaison.Size.Width, pbApercuMaison.Size.Height, PixelFormat.Format24bppRgb);
                Graphics g = Graphics.FromImage(pbApercuMaison.Image);

                if (img.Size.Width > img.Size.Height)
                {
                    fEchelleTemp = (float)img.Size.Width / (float)pbApercuMaison.Size.Width;
                    fCoordTemp = (pbApercuMaison.Size.Height - (img.Size.Height / fEchelleTemp)) / 2;

                    g.DrawImage(img, 0, (int)fCoordTemp, pbApercuMaison.Size.Width, img.Size.Height / fEchelleTemp);
                }
                else if (img.Size.Width < img.Size.Height)
                {
                    fEchelleTemp = (float)img.Size.Height / (float)pbApercuMaison.Size.Height;
                    fCoordTemp = (pbApercuMaison.Size.Width - (img.Size.Width / fEchelleTemp)) / 2;

                    g.DrawImage(img, (int)fCoordTemp, 0, img.Size.Width / fEchelleTemp, pbApercuMaison.Size.Height);
                }
                else
                {
                    if (img.Size.Width >= pbApercuMaison.Size.Width)
                        g.DrawImage(img, 0, 0, pbApercuMaison.Size.Width, pbApercuMaison.Size.Height);
                    else
                    {
                        fCoordTemp = pbApercuMaison.Size.Width - img.Size.Width;

                        g.DrawImage(img, fCoordTemp / 2, fCoordTemp / 2, img.Size.Width, img.Size.Height);
                    }
                }

                g.Dispose();
                pbApercuMaison.Refresh();
            }

            activerBoutons();
        }

        private void btValider_Click(object sender, EventArgs e)
        {
            Valide = true;
            this.Dispose();
        }

        #endregion

        #region Evenements TextBox

        private void tfRue_TextChanged(object sender, EventArgs e)
        {
            if (tfRue.Text != "")
            {
                String currentUser = Environment.UserName;
                pbVRue.Image = Image.FromFile(@"C:\Users\" + currentUser + @"\Mes documents\Visual Studio 2012\Projects\ApplicationFinaleJuin2014\Images\Icones\V.png");
                Maison.Adresse.Rue = tfRue.Text;
            }
            else
            {
                pbVRue.Image = null;
                Maison.Adresse.Rue = "default";
            }

            activerBoutons();
        }

        private void tfNumero_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int iNumero = Convert.ToInt32(tfNumero.Text);
                String currentUser = Environment.UserName;
                pbVNumero.Image = Image.FromFile(@"C:\Users\" + currentUser + @"\Mes documents\Visual Studio 2012\Projects\ApplicationFinaleJuin2014\Images\Icones\V.png");
                Maison.Adresse.Numero = iNumero;
            }
            catch (FormatException)
            {
                pbVNumero.Image = null;
                Maison.Adresse.Numero = 0;
            }
            catch (OverflowException)
            {
                MessageBox.Show("Le numéro entré est trop grand ...", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                pbVNumero.Image = null;
                Maison.Adresse.Numero = 0;
            }

            activerBoutons();
        }

        private void tfCodePostal_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(tfCodePostal.Text) >= 1000 && Convert.ToInt32(tfCodePostal.Text) <= 9999)
                {
                    if (tfCodePostal.Text != "")
                    {
                        try
                        {
                            int cp = Convert.ToInt32(tfCodePostal.Text);

                            try
                            {
                                SQLConnexion.Open(); // ouverture de la connexion
                                SQLMyAdapter = new MySqlDataAdapter("SELECT name FROM cities WHERE zip = " + cp.ToString() + ";", SQLConnexion);
                                SQLMyDataSet.Clear(); // Clear du dataSet car sinon "concaténation" de tous les résultats de toutes les requêtes
                                SQLMyAdapter.Fill(SQLMyDataSet); // Remplissage du dataSet

                                dataGridView1.DataSource = SQLMyDataSet.Tables[0];

                                int i = 0;
                                for (i = 0; i < dataGridView1.Rows.Count; i++)
                                    cbLocalite.Items.Add(dataGridView1.Rows[i].Cells[0].Value.ToString());

                                if (i > 0)
                                {
                                    String currentUser = Environment.UserName;
                                    pbVCodePostal.Image = Image.FromFile(@"C:\Users\" + currentUser + @"\Mes documents\Visual Studio 2012\Projects\ApplicationFinaleJuin2014\Images\Icones\V.png");
                                    cbLocalite.Enabled = true;
                                    Maison.Adresse.CodePostal = cp;
                                }

                                SQLConnexion.Close(); // fermeture de la connexion
                            }
                            catch (MySqlException ex)
                            {
                                MessageBox.Show("Erreur SQL: " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        catch (FormatException)
                        {
                            MessageBox.Show("Le format du code postal est incorrect ...", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    cbLocalite.Items.Clear();
                    cbLocalite.Text = null;
                    pbVCodePostal.Image = null;
                    cbLocalite.Enabled = false;
                }
            }
            catch (FormatException) // Exception levée si ce ne sont pas des chiffres, ou dans ce cas, s'il n'y a pas 4 chiffres entrés
            {
                pbVCodePostal.Image = null;
                cbLocalite.Items.Clear();
                cbLocalite.Text = null;
                cbLocalite.Enabled = false;
            }
            catch (OverflowException) // Exception levée si on dépasse la capacité d'un int
            {
                MessageBox.Show("Le code postal entré est trop grand ...");
                MessageBox.Show("Le format du code postal est incorrect ...", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbLocalite.Enabled = false;
            }

            activerBoutons();
        }

        #endregion

        #region Evenements ComboBox

        private void cbLocalite_TextChanged(object sender, EventArgs e)
        {
            if (cbLocalite.Text != "")
            {
                String currentUser = Environment.UserName;
                pbVLocalite.Image = Image.FromFile(@"C:\Users\" + currentUser + @"\Mes documents\Visual Studio 2012\Projects\ApplicationFinaleJuin2014\Images\Icones\V.png");
                Maison.Adresse.Localite = cbLocalite.Text;
            }
            else
            {
                pbVLocalite.Image = null;
                Maison.Adresse.Localite = "default";
            }

            activerBoutons();
        }

        #endregion

        #region Méthodes

        void activerBoutons()
        {
            if (tfRue.Text != "" && tfNumero.Text != "" && tfCodePostal.Text != "" && cbLocalite.Text != "")
            {
                btChoixImage.Enabled = true;
                if (Maison.PathImage != "" && Maison.PathImage != "default")
                    btValider.Enabled = true;
                else
                    btValider.Enabled = false;
            }
            else
            {
                btChoixImage.Enabled = false;
                btValider.Enabled = false;
            }
        }

        #endregion
    }
}
