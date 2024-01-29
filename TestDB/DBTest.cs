using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static DBTest.Module.Helper;

namespace TestDB
{
    public partial class DBTest : Form
    {

        private string connectionString;
        public DBTest() => InitializeComponent();

        private async void btnTestDB_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (dbLinkField.Text.ToString() == "")
                    _ = MessageBox.Show("le champ est vide !", "Base de donnée",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    pictureBoxLoder.Visible = true;
                    SqlConnection cnn;
                    string dbLink = dbLinkField.Text.ToString();
                    if (!dbLink.Contains("Data"))
                    {
                        dbLink = Decrypt(dbLink);
                    }
                    cnn = new SqlConnection(dbLink);

                    await cnn.OpenAsync();
                    pictureBoxLoder.Visible = false;
                    _ = MessageBox.Show("Connexion ouverte !", "Etat de connexion",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch (Exception ex)
            {
                pictureBoxLoder.Visible = false;
                _ = MessageBox.Show(ex.Message, "Etat de connexion",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                pictureBoxLoder.Visible = false; 
            }
        }

        private void btnCrypt_Click(object sender, EventArgs e)
        {
            connectionString = ConfigurationManager.ConnectionStrings["GAP_Prod"]?.ConnectionString;

            Console.WriteLine(Encrypt(connectionString));
        }

        private void BtnDecrypt_Click(object sender, EventArgs e)
        {
            connectionString = ConfigurationManager.ConnectionStrings["GAP_ProdC"]?.ConnectionString;

            //Console.WriteLine(Decrypt(connectionString));
            //Clipboard.SetText(Decrypt(test));

            ShowString(Decrypt(connectionString), "Decrypter", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
