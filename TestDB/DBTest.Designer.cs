namespace TestDB
{
    partial class DBTest
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DBTest));
            this.groupBoxNavbar = new System.Windows.Forms.GroupBox();
            this.dbLinkField = new System.Windows.Forms.RichTextBox();
            this.btnCrypt = new System.Windows.Forms.Button();
            this.pictureBoxLoder = new System.Windows.Forms.PictureBox();
            this.btnTestDB = new System.Windows.Forms.Button();
            this.groupBoxFooter = new System.Windows.Forms.GroupBox();
            this.BtnDecrypt = new System.Windows.Forms.Button();
            this.groupBoxNavbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoder)).BeginInit();
            this.groupBoxFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxNavbar
            // 
            this.groupBoxNavbar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.groupBoxNavbar.Controls.Add(this.dbLinkField);
            this.groupBoxNavbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxNavbar.Location = new System.Drawing.Point(0, 0);
            this.groupBoxNavbar.Name = "groupBoxNavbar";
            this.groupBoxNavbar.Size = new System.Drawing.Size(800, 124);
            this.groupBoxNavbar.TabIndex = 0;
            this.groupBoxNavbar.TabStop = false;
            // 
            // dbLinkField
            // 
            this.dbLinkField.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dbLinkField.Location = new System.Drawing.Point(3, 16);
            this.dbLinkField.Name = "dbLinkField";
            this.dbLinkField.Size = new System.Drawing.Size(794, 105);
            this.dbLinkField.TabIndex = 0;
            this.dbLinkField.Text = "";
            // 
            // btnCrypt
            // 
            this.btnCrypt.Location = new System.Drawing.Point(352, 14);
            this.btnCrypt.Name = "btnCrypt";
            this.btnCrypt.Size = new System.Drawing.Size(60, 40);
            this.btnCrypt.TabIndex = 3;
            this.btnCrypt.Text = "Crypt";
            this.btnCrypt.UseVisualStyleBackColor = true;
            this.btnCrypt.Click += new System.EventHandler(this.btnCrypt_Click);
            // 
            // pictureBoxLoder
            // 
            this.pictureBoxLoder.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBoxLoder.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLoder.Image")));
            this.pictureBoxLoder.Location = new System.Drawing.Point(3, 16);
            this.pictureBoxLoder.Name = "pictureBoxLoder";
            this.pictureBoxLoder.Size = new System.Drawing.Size(40, 41);
            this.pictureBoxLoder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLoder.TabIndex = 2;
            this.pictureBoxLoder.TabStop = false;
            this.pictureBoxLoder.Visible = false;
            // 
            // btnTestDB
            // 
            this.btnTestDB.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnTestDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnTestDB.Image = ((System.Drawing.Image)(resources.GetObject("btnTestDB.Image")));
            this.btnTestDB.Location = new System.Drawing.Point(757, 16);
            this.btnTestDB.Name = "btnTestDB";
            this.btnTestDB.Size = new System.Drawing.Size(40, 41);
            this.btnTestDB.TabIndex = 1;
            this.btnTestDB.UseVisualStyleBackColor = true;
            this.btnTestDB.Click += new System.EventHandler(this.btnTestDB_Click);
            // 
            // groupBoxFooter
            // 
            this.groupBoxFooter.Controls.Add(this.BtnDecrypt);
            this.groupBoxFooter.Controls.Add(this.btnTestDB);
            this.groupBoxFooter.Controls.Add(this.btnCrypt);
            this.groupBoxFooter.Controls.Add(this.pictureBoxLoder);
            this.groupBoxFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBoxFooter.Location = new System.Drawing.Point(0, 253);
            this.groupBoxFooter.Name = "groupBoxFooter";
            this.groupBoxFooter.Size = new System.Drawing.Size(800, 60);
            this.groupBoxFooter.TabIndex = 4;
            this.groupBoxFooter.TabStop = false;
            // 
            // BtnDecrypt
            // 
            this.BtnDecrypt.Location = new System.Drawing.Point(500, 14);
            this.BtnDecrypt.Name = "BtnDecrypt";
            this.BtnDecrypt.Size = new System.Drawing.Size(60, 40);
            this.BtnDecrypt.TabIndex = 4;
            this.BtnDecrypt.Text = "Decrypt";
            this.BtnDecrypt.UseVisualStyleBackColor = true;
            this.BtnDecrypt.Click += new System.EventHandler(this.BtnDecrypt_Click);
            // 
            // DBTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 313);
            this.Controls.Add(this.groupBoxFooter);
            this.Controls.Add(this.groupBoxNavbar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "DBTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Test de connexion";
            this.groupBoxNavbar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoder)).EndInit();
            this.groupBoxFooter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxNavbar;
        private System.Windows.Forms.RichTextBox dbLinkField;
        private System.Windows.Forms.Button btnCrypt;
        private System.Windows.Forms.PictureBox pictureBoxLoder;
        private System.Windows.Forms.Button btnTestDB;
        private System.Windows.Forms.GroupBox groupBoxFooter;
        private System.Windows.Forms.Button BtnDecrypt;
    }
}

