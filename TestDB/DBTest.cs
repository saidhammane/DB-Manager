using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using static DBTest.Module.AP_Helper;

namespace TestDB
{
    public partial class AP_DB_Manager : Form
    {
        public AP_DB_Manager() => InitializeComponent();

        private async void btnTestDB_Click(object sender, EventArgs e)
        {
            try
            {
                if (dbLinkField.Text.ToString() == "")
                {
                    AP_ShowStringPopUp("Le champ est vide !", "Base de donnée",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    pictureBoxLoader.Visible = true;
                    SqlConnection cnn;
                    string dbLink = dbLinkField.Text.ToString();
                    if (!dbLink.Contains("Data"))
                    {
                        dbLink = AP_Decrypt(dbLink);
                    }
                    cnn = new SqlConnection(dbLink);
                    await cnn.OpenAsync();
                    pictureBoxLoader.Visible = false;
                    AP_ShowStringPopUp("Connexion ouverte !", "Etat de la connexion",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                pictureBoxLoader.Visible = false;
                AP_ShowStringPopUp(ex.Message, "Etat de la connexion",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                pictureBoxLoader.Visible = false; 
            }
        }

        private void btnCrypt_Click(object sender, EventArgs e)
        {

            string dbLink = dbLinkField.Text.ToString();
            if (dbLink == "")
            {
                AP_ShowStringPopUp("Le champ est vide !", "Cryptage",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    if (!dbLink.Contains("Data"))
                    {
                        AP_ShowStringPopUp("Le lien doit être comme ça: Data Source=0.0.0.0; " +
                            "Initial Catalog=BD; User ID=utilisateur;password=motdepasse", "Cryptage",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    else
                    {
                        dbLink = AP_Encrypt(dbLink);
                        cryptField.Text = dbLink;
                    }
                    Clipboard.SetText(dbLink);
                    AP_ShowStringPopUp("Le lien est copié !", "Cryptage",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cryptField.Enabled = true;
                }
                catch(Exception ex)
                {
                    AP_ShowStringPopUp(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnDecrypt_Click(object sender, EventArgs e)
        {
            string dbLink = dbLinkField.Text.ToString();
            if (dbLink == "")
            {
                AP_ShowStringPopUp("Le champ est vide !", "Cryptage",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    if (dbLink.Contains("Data"))
                    {
                        AP_ShowStringPopUp("Le lien n’est pas encore chiffré", "Cryptage",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    else
                    {
                        dbLink = AP_Decrypt(dbLink);
                        cryptField.Text = dbLink;
                    }
                    Clipboard.SetText(dbLink);
                    AP_ShowStringPopUp("Le lien est copié !", "Cryptage",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cryptField.Enabled = true;
                }
                catch(Exception ex)
                {
                    AP_ShowStringPopUp(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dbLinkField_TextChanged(object sender, EventArgs e)
        {
            try
            {
                cryptField.Text = dbLinkField.Text;
            }
            catch(Exception ex)
            {
                AP_ShowStringPopUp(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void buttonClean_Click(object sender, EventArgs e)
        {
            cryptField.Text = "";
            dbLinkField.Text = "";
            cryptField.Enabled = false;
        }

    }
}
