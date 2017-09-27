using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using ConsumptionLib;
using System.Xml.Serialization;
using System.IO;
using System.Security.Cryptography;

namespace OptimizeEnergyConsumption
{
    public partial class FormLogin : Form
    {
        #region Variables membres

        private bool _Mode;
        private RegistryKey _Reg;
        private CUser _Compte;
        private bool _PasswordChanged;
        private List<CUser> _lUser;
        private String _Password;

        #endregion

        #region Propriétés

        public String Password
        {
            get { return _Password; }
            set { _Password = value; }
        }

        public List<CUser> LUser
        {
            get { return _lUser; }
            set { _lUser = value; }
        }

        public bool Mode
        {
            get { return _Mode; }
            set { _Mode = value; }
        }

        public bool PasswordChanged
        {
            get { return _PasswordChanged; }
            set { _PasswordChanged = value; }
        }

        public RegistryKey Reg
        {
            get { return _Reg; }
            set { _Reg = value; }
        }

        public CUser Compte
        {
            get { return _Compte; }
            set { _Compte = value; }
        }

        #endregion

        #region Constructeurs

        public FormLogin()
        {
            InitializeComponent();
            creationRegistres();
        }

        #endregion

        #region Evenements Boutons

        private void btSeConnecter_Click(object sender, EventArgs e)
        {
            lbErreur.Text = null;
            String Log;
            String currentUser = Environment.UserName;
            LUser = new List<CUser>();
            XmlSerializer xml = new XmlSerializer(typeof(List<CUser>));

            RegistryKey regTemp = Registry.CurrentUser.OpenSubKey("Software", true).OpenSubKey("HEPL", true).OpenSubKey("Users", true);

            String returnVal = (String)regTemp.GetValue("Users", "NotFound");

            if (returnVal.Equals("NotFound"))
            {
                StreamWriter strW = new StreamWriter(@"C:\Users\" + Environment.UserName + @"\Documents\Visual Studio 2012\Projects\ApplicationFinaleJuin2014\XMLFiles\Users.xml");
                xml.Serialize(strW, LUser);
                strW.Close();
                regTemp.SetValue("Users", @"C:\Users\" + Environment.UserName + @"\Documents\Visual Studio 2012\Projects\ApplicationFinaleJuin2014\XMLFiles\Users.xml");
            }
            else
            {
                if (File.Exists(returnVal))
                {
                    StreamReader sR = new StreamReader(returnVal);
                    LUser = (List<CUser>)xml.Deserialize(sR);
                    sR.Close();
                }
            }

            regTemp.Close();


            if (tfLogin.Text == "")
            {
                MessageBox.Show("Veuillez entrez un login", "Connexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //lbErreur.ForeColor = Color.Red;
                //lbErreur.Text = "";
            }
            else if (tfLogin.Text == "Admin") // Partie vérification Admin
            {
                Reg = Registry.CurrentUser.OpenSubKey("Software", true).OpenSubKey("HEPL", true).OpenSubKey("Administrator", true);
                if (PasswordChanged) // On change le mot de passe par défaut
                {
                    Compte = new CUser(tfLogin.Text, tfMotDePasse.Text);
                    Reg.SetValue(Compte.Login, Compte.Password);
                    MessageBox.Show("Un compte admin a été créé");
                    FormAdmin FA = new FormAdmin(LUser);
                    this.Visible = false;
                    FA.ShowDialog();
                    this.Visible = true;
                    PasswordChanged = false;
                }
                else
                {
                    if (tfLogin.Text != "")
                    {
                        Log = (String)Reg.GetValue(tfLogin.Text, "Inconnu");
                        if (Log == "Inconnu") // Première connexion, admin par défaut -> Accès Admin
                        {
                            if (tfLogin.Text == "Admin")
                            {
                                lbErreur.ForeColor = Color.Red;
                                lbErreur.Text = "Veuillez maintenant saisir un nouveau mot de passe";
                                PasswordChanged = true; // On peut maintenant taper un nouveau mot de passe
                            }
                        }
                        else
                        {
                            Log = (String)Reg.GetValue(tfLogin.Text, "Inconnu");
                            if (Log != "Inconnu") // Accès admin
                            {
                                if (tfMotDePasse.Text == Log)
                                {
                                    FormAdmin FA = new FormAdmin(LUser);

                                    this.Visible = false;
                                    FA.ShowDialog();
                                    this.Visible = true;
                                }
                                else
                                {
                                    MessageBox.Show("Mot de passe invalide !", "Connexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    //lbErreur.ForeColor = Color.Red;
                                    //lbErreur.Text = "Mot de passe invalide !";
                                }
                            }
                            else
                            {
                                MessageBox.Show("Compte inexistant !", "Connexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                //lbErreur.ForeColor = Color.Red;
                                //lbErreur.Text = "Compte inexistant !";
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Veuillez saisir un nom d'utilisateur et un mot de passe correct !", "Connexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //lbErreur.ForeColor = Color.Red;
                        //lbErreur.Text = "Veuillez saisir un nom d'utilisateur et un mot de passe correct!";
                    }
                }
            }
            else // Partie vérification d'un USER
            {
                SHA1 hasheur = new SHA1CryptoServiceProvider();
                UTF8Encoding utf8 = new UTF8Encoding();

                bool bLogin = false, bMotDePasse = false;
                CUser UserConnecte = new CUser();
                if (tfLogin.Text != "" && tfMotDePasse.Text != "")
                {
                    foreach (CUser U in LUser)
                    {
                        if (tfLogin.Text == U.Login) // vérification du login
                            bLogin = true;

                        if (bLogin)
                        {
                            if (BitConverter.ToString(hasheur.ComputeHash(utf8.GetBytes(tfMotDePasse.Text))) == U.Password) // vérification du MDP
                            {
                                bMotDePasse = true;
                                UserConnecte = (CUser)U.Clone();
                            }
                            break;
                        }
                    }

                    if (bLogin && bMotDePasse) // Connexion réussie
                    {
                        FormPrincipal FP = new FormPrincipal(UserConnecte);
                        this.Visible = false;
                        FP.ShowDialog();
                        this.Visible = true;
                    }
                    else if (!bLogin)
                        MessageBox.Show("Le login entré n'existe pas ...", "Connexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        if (!bMotDePasse)
                            MessageBox.Show("Le mot de passe entré est incorrect ...", "Connexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                    MessageBox.Show("Veuillez saisir un nom d'utilisateur et un mot de passe correct !", "Connexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Evenements CheckBox

        private void checkBoxAfficheMDP_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAfficheMDP.Checked)
                tfMotDePasse.UseSystemPasswordChar = false;
            else
                tfMotDePasse.UseSystemPasswordChar = true;
        }

        #endregion

        #region Methodes

        private void creationRegistres()
        {
            Reg = Registry.CurrentUser.OpenSubKey("Software", true);
            if (Reg.OpenSubKey("HEPL", true) == null)
                Reg.CreateSubKey("HEPL");
            Reg = Reg.OpenSubKey("HEPL", true);
            if (Reg.OpenSubKey("Administrator", true) == null)
                Reg.CreateSubKey("Administrator");
            Reg = Reg.OpenSubKey("Administrator", true);
            Reg.Close();

            Reg = Registry.CurrentUser.OpenSubKey("Software", true);
            if (Reg.OpenSubKey("HEPL", true) == null)
                Reg.CreateSubKey("HEPL");
            Reg = Reg.OpenSubKey("HEPL", true);
            if (Reg.OpenSubKey("Users", true) == null)
                Reg.CreateSubKey("Users");
            Reg = Reg.OpenSubKey("Users", true);
            Reg.Close();

            Reg = Registry.CurrentUser.OpenSubKey("Software", true);
            if (Reg.OpenSubKey("HEPL", true) == null)
                Reg.CreateSubKey("HEPL");
            Reg = Reg.OpenSubKey("HEPL", true);
            if (Reg.OpenSubKey("User Data", true) == null)
                Reg.CreateSubKey("User Data");
            Reg = Reg.OpenSubKey("User Data", true);
        }

        #endregion
    }
}
