using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using static DBTest.Module.AP_Helper;

namespace TestDB
{
    public partial class AP_DB_Manager : Form
    {

        private string connectionString;
        public AP_DB_Manager() => InitializeComponent();

        private async void btnTestDB_Click(object sender, EventArgs e)
        {
            try
            {
                if (dbLinkField.Text.ToString() == "")
                {
                    AP_ShowString("le champ est vide !", "Base de donnée",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    pictureBoxLoder.Visible = true;
                    SqlConnection cnn;
                    string dbLink = dbLinkField.Text.ToString();
                    if (!dbLink.Contains("Data"))
                    {
                        dbLink = AP_Decrypt(dbLink);
                    }
                    cnn = new SqlConnection(dbLink);
                    await cnn.OpenAsync();
                    pictureBoxLoder.Visible = false;
                    AP_ShowString("Connexion ouverte !", "Etat de connexion",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                pictureBoxLoder.Visible = false;
                AP_ShowString(ex.Message, "Etat de connexion",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                pictureBoxLoder.Visible = false; 
            }
        }

        private void btnCrypt_Click(object sender, EventArgs e)
        {

            string dbLink = dbLinkField.Text.ToString();
            if (dbLink == "")
            {
                AP_ShowString("le champ est vide !", "Cryptage",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (!dbLink.Contains("Data"))
                {
                    AP_ShowString("Le lien doit être comme ça: Data Source=0.0.0.0; Initial Catalog=BD; User ID=utilisateur;password=motdepasse", "Cryptage",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    dbLink = AP_Encrypt(dbLink);
                    cryptField.Text = dbLink;
                }
                Clipboard.SetText(dbLink);
                AP_ShowString("Le lien est copié !", "Cryptage",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnDecrypt_Click(object sender, EventArgs e)
        {
            string dbLink = dbLinkField.Text.ToString();
            if (dbLink == "")
            {
                AP_ShowString("Le champ est vide !", "Cryptage",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (dbLink.Contains("Data"))
                {
                    AP_ShowString("Le lien n’est pas encore chiffré", "Cryptage",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    dbLink = AP_Decrypt(dbLink);
                    cryptField.Text = dbLink;
                }
                Clipboard.SetText(dbLink);
                AP_ShowString("Le lien est copié !", "Cryptage",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                AP_ShowString(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
