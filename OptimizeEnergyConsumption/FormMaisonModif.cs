using ConsumptionLib;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OptimizeEnergyConsumption
{
    public partial class FormMaisonModif : Form
    {
        #region Variables membres

        private MySqlConnection SQLConnexion;
        private MySqlDataAdapter SQLMyAdapter;
        private DataSet SQLMyDataSet;

        private CAdress _AdresseAModifier;
        private CAdress _AdresseModifiee;
        private bool _Valider;

        private String _Rue;
        private String _Localite;
        private int _Numero;
        private int _CodePostal;

        #endregion

        #region Propriétés

        public CAdress AdresseAModifier
        {
            get { return _AdresseAModifier; }
            set { _AdresseAModifier = value; }
        }

        public CAdress AdresseModifiee
        {
            get { return _AdresseModifiee; }
            set { _AdresseModifiee = value; }
        }

        public bool Valider
        {
            get { return _Valider; }
            set { _Valider = value; }
        }

        public String Rue
        {
            get { return _Rue; }
            set { _Rue = value; }
        }

        public int Numero
        {
            get { return _Numero; }
            set { _Numero = value; }
        }

        public int CodePostal
        {
            get { return _CodePostal; }
            set { _CodePostal = value; }
        }

        public String Localite
        {
            get { return _Localite; }
            set { _Localite = value; }
        }

        #endregion

        #region Constructeurs

        public FormMaisonModif()
        {
            InitializeComponent();
        }

        public FormMaisonModif(CAdress adresseSelectionnee)
        {
            InitializeComponent();

            SQLConnexion = new MySqlConnection("Database=ApplicCSharp2014;Data Source=localhost;User Id=root;Password=");
            SQLMyDataSet = new DataSet();

            AdresseAModifier = adresseSelectionnee;
            AdresseModifiee = new CAdress();

            tfRue.Text = AdresseAModifier.Rue;
            tfNumero.Text = AdresseAModifier.Numero.ToString();
            tfCodePostal.Text = AdresseAModifier.CodePostal.ToString();
            //cbLocalite.Text = AdresseAModifier.Localite;
        }

        #endregion

        #region Evenements TextBox

        private void tfRue_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tfRue.Text) && tfRue.Text != AdresseAModifier.Rue)
                Rue = tfRue.Text;

            activerBoutons();
        }

        private void tfNumero_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int iNumero = Convert.ToInt32(tfNumero.Text);
                Numero = iNumero;
            }
            catch (FormatException)
            {
                tfNumero.Text = null;
                Numero = 0;
            }
            catch (OverflowException)
            {
                MessageBox.Show("Le numéro entré est trop grand ...", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Numero = 0;
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
                                cbLocalite.Enabled = true;
                                CodePostal = cp;
                            }

                            SQLConnexion.Close(); // fermeture de la connexion
                        }
                        catch (MySqlException ex)
                        {
                            MessageBox.Show("Erreur SQL: " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        catch (InvalidOperationException ex)
                        {
                            MessageBox.Show("IOE: " + ex.Message);
                        }
                    }
                }
                else
                {
                    cbLocalite.Items.Clear();
                    cbLocalite.Text = null;
                    cbLocalite.Enabled = false;
                }
            }
            catch (FormatException) // Exception levée si ce ne sont pas des chiffres, ou dans ce cas, s'il n'y a pas 4 chiffres entrés
            {
                MessageBox.Show("Le format du code postal est incorrect ...", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            catch (NullReferenceException ex)
            {
                MessageBox.Show("NullReferenceException : " + ex.Message);
            }

            activerBoutons();
        }

        #endregion

        #region Evenements ComboBox

        private void cbLocalite_TextChanged(object sender, EventArgs e)
        {
            if (cbLocalite.Text != "")
                Localite = cbLocalite.Text;
            else
                Localite = "default";

            activerBoutons();
        }

        #endregion

        #region Evenements Boutons

        private void btValider_Click(object sender, EventArgs e)
        {
            if (Rue != AdresseAModifier.Rue)
                AdresseModifiee.Rue = Rue;

            if (Numero != AdresseAModifier.Numero)
                AdresseModifiee.Numero = Numero;

            if (CodePostal != AdresseAModifier.CodePostal)
                AdresseModifiee.CodePostal = CodePostal;

            if (Localite != AdresseAModifier.Localite)
                AdresseModifiee.Localite = Localite;

            Valider = true;
            this.Dispose();
        }

        private void btAnnuler_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        #endregion

        #region Méthodes

        void activerBoutons()
        {
            if (tfRue.Text != "" && tfNumero.Text != "" && tfCodePostal.Text != "" && cbLocalite.Text != "")
                btValider.Enabled = true;
            else
                btValider.Enabled = false;
        }

        #endregion

        

        

    }
}
