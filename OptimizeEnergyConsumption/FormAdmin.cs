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
using System.Xml.Serialization;
using System.IO;
using Microsoft.Win32;

namespace OptimizeEnergyConsumption
{
    public partial class FormAdmin : Form
    {
        #region Variables membres

        List<CUser> _ListUser;

        #endregion

        #region Propriétés

        public List<CUser> ListUser
        {
            get { return _ListUser; }
            set { _ListUser = value; }
        }

        #endregion

        #region Constructeurs

        public FormAdmin()
        {
            InitializeComponent();
            ListUser = new List<CUser>();
        }

        public FormAdmin(List<CUser> lUser)
        {
            InitializeComponent();
            ListUser = lUser;

            foreach (CUser U in lUser)
            {
                listBoxUser.Items.Add(U);
            }
        }

        #endregion

        #region Evenements Boutons

        private void btAjoutUser_Click(object sender, EventArgs e)
        {
            FormUserAjout FUA = new FormUserAjout(ListUser);
            this.Visible = false;
            FUA.ShowDialog();
            this.Visible = true;

            if (FUA.Valider)
                listBoxUser.Items.Add(FUA.User);
        }

        private void btModifUser_Click(object sender, EventArgs e)
        {
            if (listBoxUser.SelectedItem != null)
            {
                List<CUser> lUsers = new List<CUser>();

                foreach (CUser U in listBoxUser.Items)
                {
                    lUsers.Add(U);
                }

                FormUserModif FUM = new FormUserModif((CUser)listBoxUser.SelectedItem, lUsers);
                FUM.ShowDialog();

                if (FUM.Valider)
                {
                    CUser U = (CUser)listBoxUser.SelectedItem;
                    listBoxUser.Items.Remove(listBoxUser.SelectedItem);
                    listBoxUser.Items.Add(FUM.UserModifie);
                    ListUser.Remove(U);
                    ListUser.Add(FUM.UserModifie);
                }

                listBoxUser.SelectedItem = null;
            }
            else
                MessageBox.Show("Veuillez sélectionner un utilisateur dans la liste !", "Modifier un utilisateur", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btSuppUser_Click(object sender, EventArgs e)
        {
            if (listBoxUser.SelectedItem != null)
            {
                CUser U = (CUser)listBoxUser.SelectedItem;
                DialogResult dialog = MessageBox.Show("Êtes-vous sûr de vouloir supprimer l'utilisateur " + U.Login + " ?", "Suppression d'un utilisateur", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                    listBoxUser.Items.Remove(U);
            }
        }

        private void btValiderQuitter_Click(object sender, EventArgs e)
        {
            ListUser.Clear();

            foreach (CUser U in listBoxUser.Items)
            {
                ListUser.Add(U);
            }

            RegistryKey regTemp = Registry.CurrentUser.OpenSubKey("Software", true).OpenSubKey("HEPL", true).OpenSubKey("Users", true);

            String sPath = (String)regTemp.GetValue("Users", "NotFound");

            if (sPath == "NotFound")
                MessageBox.Show("Un problème a eu lieu ! Pas fini, FormAdmin.cs, méthode btValider");
            else
            {
                XmlSerializer xml = new XmlSerializer(typeof(List<CUser>));
                StreamWriter strW = new StreamWriter(sPath);
                xml.Serialize(strW, ListUser); // écrire la liste dans le fichier XML

                strW.Close();
            }

            regTemp.Close();

            this.Dispose();
        }

        #endregion
    }
}
