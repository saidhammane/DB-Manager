using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestDB
{
    public partial class DBTest : Form
    {
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
                    cnn = new SqlConnection(dbLinkField.Text.ToString());

                    await cnn.OpenAsync();
                    pictureBoxLoder.Visible = false;
                    _ = MessageBox.Show("Connexion ouverte !", "Etat de connexion",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }catch (Exception ex)
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

    }
}
