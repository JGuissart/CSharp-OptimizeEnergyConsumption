using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConsumptionLib;
using Microsoft.Win32;
using System.Security.Cryptography;

namespace OptimizeEnergyConsumption
{
    public partial class FormUserAjout : Form
    {
        #region Variables membres

        private bool _Valider;
        private CUser _User;
        private List<CUser> _ListUser;

        #endregion

        #region Propriétés

        public CUser User
        {
            get { return _User; }
            set { _User = value; }
        }

        public bool Valider
        {
            get { return _Valider; }
            set { _Valider = value; }
        }

        public List<CUser> ListUser
        {
            get { return _ListUser; }
            set { _ListUser = value; }
        }

        #endregion

        #region Constructeurs

        public FormUserAjout()
        {
            InitializeComponent();
            Valider = false;
            ListUser = new List<CUser>();
        }

        public FormUserAjout(List<CUser> lUser)
        {
            InitializeComponent();
            Valider = false;
            ListUser = lUser;
        }

        #endregion

        #region Evenements boutons

        private void btValiderUser_Click(object sender, EventArgs e)
        {
            SHA1 hasheur = new SHA1CryptoServiceProvider();

            UTF8Encoding utf8 = new UTF8Encoding();

            lbErreur.Visible = false;

            if (tfLogin.Text != "")
            {
                bool bLogDoublon = false;

                if (ListUser.Count > 0)
                {
                    foreach (CUser U in ListUser)
                    {
                        if (U.Login == tfLogin.Text)
                        {
                            bLogDoublon = true;
                            break;
                        }
                    }
                }

                if (bLogDoublon)
                {
                    lbErreur.Text = "Le login saisi existe déjà";
                    lbErreur.Visible = true;
                }
                else
                {
                    if (tfMDP.Text == tfConfMDP.Text)
                    {
                        User = new CUser(tfLogin.Text, BitConverter.ToString(hasheur.ComputeHash(utf8.GetBytes(tfMDP.Text))));
                        Valider = true;
                        this.Dispose();
                    }
                    else
                    {
                        lbErreur.Text = "Le mot de passe entré n'a pas été confirmé";
                        lbErreur.Visible = true;
                    }
                }
            }
            else
            {
                lbErreur.Text = "Veuillez spécifier un login correct";
                lbErreur.Visible = true;
            }
        }

        #endregion

        #region Evenements CheckBox

        private void cbAfficherMDP_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAfficherMDP.Checked)
            {
                tfMDP.UseSystemPasswordChar = false;
                tfConfMDP.UseSystemPasswordChar = false;
            }
            else
            {
                tfMDP.UseSystemPasswordChar = true;
                tfConfMDP.UseSystemPasswordChar = true;
            }
        }

        #endregion

        #region Méthodes

        private bool verificationMotDePasse(String motDePasse)
        {
            bool bMinuscule = false, bMajuscule = false, bNumero = false;
            char[] TabMotDePasse = motDePasse.ToCharArray();

            foreach (char c in TabMotDePasse)
            {
                if (!bMinuscule)
                {
                    if (char.IsLower(c))
                        bMinuscule = true;
                }

                if (!bMajuscule)
                {
                    if (char.IsUpper(c))
                        bMajuscule = true;
                }

                if (!bNumero)
                {
                    if (char.IsNumber(c))
                        bNumero = true;
                }

                if (bMinuscule && bMajuscule && bNumero)
                    break;
            }

            if (bMinuscule && bMajuscule && bNumero)
                return true;
            else
                return false;
        }

        #endregion
    }
}
