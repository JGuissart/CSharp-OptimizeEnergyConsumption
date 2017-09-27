using ConsumptionLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OptimizeEnergyConsumption
{
    public partial class FormUserModif : Form
    {
        #region Variables membres

        CUser userAModifier;       
        CUser userModifie;
        List<CUser> lUsers;
        bool valider;

        #endregion

        #region Propriétés
        
        public CUser UserAModifier
        {
            get { return userAModifier; }
            set { userAModifier = value; }
        }

        public CUser UserModifie
        {
            get { return userModifie; }
            set { userModifie = value; }
        }

        public bool Valider
        {
            get { return valider; }
            set { valider = value; }
        }

        #endregion

        #region Constructeurs

        public FormUserModif()
        {
            InitializeComponent();
            this.Text = "Modification des données d'un utilisateur";
        }

        public FormUserModif(CUser U, List<CUser> listUsers)
        {
            InitializeComponent();
            this.Text = "Modification des données d'un utilisateur";
            UserAModifier = U;
            lUsers = listUsers;
            tfLogin.Text = U.Login;
        }

        #endregion

        #region Evenements CheckBox

        private void cbMDP_CheckedChanged(object sender, EventArgs e)
        {
            if (cbMDP.Checked)
            {
                tfNewMDP.Enabled = true;
                tfConfMDP.Enabled = true;
            }
            else
            {
                tfNewMDP.Enabled = false;
                tfConfMDP.Enabled = false;
            }
        }

        private void cbAfficherMDP_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAfficherMDP.Checked)
            {
                tfMDPActuel.UseSystemPasswordChar = false;
                tfNewMDP.UseSystemPasswordChar = false;
                tfConfMDP.UseSystemPasswordChar = false;
            }
            else
            {
                tfMDPActuel.UseSystemPasswordChar = true;
                tfNewMDP.UseSystemPasswordChar = true;
                tfConfMDP.UseSystemPasswordChar = true;
            }
        }

        #endregion

        #region Evenements Boutons

        private void btValider_Click(object sender, EventArgs e)
        {
            SHA1 hasheur = new SHA1CryptoServiceProvider();
            UTF8Encoding utf8 = new UTF8Encoding();

            if (tfLogin.Text != "")
            {
                bool bLogDoublon = false;

                if (tfLogin.Text != UserAModifier.Login)
                {
                    foreach (CUser U in lUsers)
                    {
                        if (U.Login == tfLogin.Text)
                        {
                            bLogDoublon = true;
                            break;
                        }
                    }

                    if (bLogDoublon)
                    {
                        lbErreur.ForeColor = Color.Red;
                        lbErreur.Text = "Ce login est déjà utilisé par un utilisateur !";
                    }
                    else
                    {
                        if (cbMDP.Checked)
                        {
                            if (tfNewMDP.Text == tfConfMDP.Text)
                            {
                                if (BitConverter.ToString(hasheur.ComputeHash(utf8.GetBytes(tfMDPActuel.Text))) == UserAModifier.Password)
                                {
                                    UserModifie = new CUser(tfLogin.Text, BitConverter.ToString(hasheur.ComputeHash(utf8.GetBytes(tfNewMDP.Text))));
                                    Valider = true;
                                    this.Dispose();
                                }
                                else
                                {
                                    lbErreur.ForeColor = Color.Red;
                                    lbErreur.Text = "Le mot de passe actuel n'est pas correct !";
                                }
                            }
                            else
                            {
                                lbErreur.ForeColor = Color.Red;
                                lbErreur.Text = "La confirmation du nouveau mot de passe n'est pas correcte !";
                            }
                        }
                        else
                        {
                            UserModifie = new CUser(tfLogin.Text, UserAModifier.Password);
                            Valider = true;
                            this.Dispose();
                        }
                    }
                }
                else
                {
                    if (cbMDP.Checked)
                    {
                        if (tfNewMDP.Text == tfConfMDP.Text)
                        {
                            if (BitConverter.ToString(hasheur.ComputeHash(utf8.GetBytes(tfMDPActuel.Text))) == UserAModifier.Password)
                            {
                                UserModifie = new CUser(tfLogin.Text, BitConverter.ToString(hasheur.ComputeHash(utf8.GetBytes(tfNewMDP.Text))));
                                Valider = true;
                                this.Dispose();
                            }
                            else
                            {
                                lbErreur.ForeColor = Color.Red;
                                lbErreur.Text = "Le mot de passe actuel n'est pas correct !";
                            }
                        }
                        else
                        {
                            lbErreur.ForeColor = Color.Red;
                            lbErreur.Text = "La confirmation du nouveau mot de passe n'est pas correcte !";
                        }
                    }
                }
            }
            else
            {
                lbErreur.ForeColor = Color.Red;
                lbErreur.Text = "Vous devez entrer un login !";
            }
        }

        #endregion

    }
}
