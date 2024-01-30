namespace TestDB
{
    partial class AP_DB_Manager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AP_DB_Manager));
            this.groupBoxNavbar = new System.Windows.Forms.GroupBox();
            this.dbLinkField = new System.Windows.Forms.RichTextBox();
            this.btnCrypt = new System.Windows.Forms.Button();
            this.pictureBoxLoader = new System.Windows.Forms.PictureBox();
            this.btnTestDB = new System.Windows.Forms.Button();
            this.groupBoxFooter = new System.Windows.Forms.GroupBox();
            this.buttonClean = new System.Windows.Forms.Button();
            this.BtnDecrypt = new System.Windows.Forms.Button();
            this.cryptField = new System.Windows.Forms.RichTextBox();
            this.groupBoxNavbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoader)).BeginInit();
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
            this.groupBoxNavbar.Size = new System.Drawing.Size(800, 90);
            this.groupBoxNavbar.TabIndex = 0;
            this.groupBoxNavbar.TabStop = false;
            // 
            // dbLinkField
            // 
            this.dbLinkField.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dbLinkField.Location = new System.Drawing.Point(3, 16);
            this.dbLinkField.Name = "dbLinkField";
            this.dbLinkField.Size = new System.Drawing.Size(794, 71);
            this.dbLinkField.TabIndex = 0;
            this.dbLinkField.Text = "";
            this.dbLinkField.TextChanged += new System.EventHandler(this.dbLinkField_TextChanged);
            // 
            // btnCrypt
            // 
            this.btnCrypt.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCrypt.Location = new System.Drawing.Point(720, 90);
            this.btnCrypt.Name = "btnCrypt";
            this.btnCrypt.Size = new System.Drawing.Size(80, 47);
            this.btnCrypt.TabIndex = 3;
            this.btnCrypt.Text = "Chiffré";
            this.btnCrypt.UseVisualStyleBackColor = true;
            this.btnCrypt.Click += new System.EventHandler(this.btnCrypt_Click);
            // 
            // pictureBoxLoader
            // 
            this.pictureBoxLoader.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBoxLoader.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLoader.Image")));
            this.pictureBoxLoader.Location = new System.Drawing.Point(3, 16);
            this.pictureBoxLoader.Name = "pictureBoxLoader";
            this.pictureBoxLoader.Size = new System.Drawing.Size(40, 41);
            this.pictureBoxLoader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLoader.TabIndex = 2;
            this.pictureBoxLoader.TabStop = false;
            this.pictureBoxLoader.Visible = false;
            // 
            // btnTestDB
            // 
            this.btnTestDB.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnTestDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnTestDB.Location = new System.Drawing.Point(673, 16);
            this.btnTestDB.Name = "btnTestDB";
            this.btnTestDB.Size = new System.Drawing.Size(124, 41);
            this.btnTestDB.TabIndex = 1;
            this.btnTestDB.Text = "Tester la connexion";
            this.btnTestDB.UseVisualStyleBackColor = true;
            this.btnTestDB.Click += new System.EventHandler(this.btnTestDB_Click);
            // 
            // groupBoxFooter
            // 
            this.groupBoxFooter.Controls.Add(this.buttonClean);
            this.groupBoxFooter.Controls.Add(this.btnTestDB);
            this.groupBoxFooter.Controls.Add(this.pictureBoxLoader);
            this.groupBoxFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBoxFooter.Location = new System.Drawing.Point(0, 208);
            this.groupBoxFooter.Name = "groupBoxFooter";
            this.groupBoxFooter.Size = new System.Drawing.Size(800, 60);
            this.groupBoxFooter.TabIndex = 4;
            this.groupBoxFooter.TabStop = false;
            // 
            // buttonClean
            // 
            this.buttonClean.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonClean.Location = new System.Drawing.Point(598, 16);
            this.buttonClean.Name = "buttonClean";
            this.buttonClean.Size = new System.Drawing.Size(75, 41);
            this.buttonClean.TabIndex = 3;
            this.buttonClean.Text = "Nettoyer";
            this.buttonClean.UseVisualStyleBackColor = true;
            this.buttonClean.Click += new System.EventHandler(this.buttonClean_Click);
            // 
            // BtnDecrypt
            // 
            this.BtnDecrypt.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnDecrypt.Location = new System.Drawing.Point(640, 90);
            this.BtnDecrypt.Name = "BtnDecrypt";
            this.BtnDecrypt.Size = new System.Drawing.Size(80, 47);
            this.BtnDecrypt.TabIndex = 4;
            this.BtnDecrypt.Text = "Déchiffrer";
            this.BtnDecrypt.UseVisualStyleBackColor = true;
            this.BtnDecrypt.Click += new System.EventHandler(this.BtnDecrypt_Click);
            // 
            // cryptField
            // 
            this.cryptField.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cryptField.Enabled = false;
            this.cryptField.Location = new System.Drawing.Point(0, 137);
            this.cryptField.Name = "cryptField";
            this.cryptField.Size = new System.Drawing.Size(800, 71);
            this.cryptField.TabIndex = 5;
            this.cryptField.Text = "";
            // 
            // AP_DB_Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 268);
            this.Controls.Add(this.BtnDecrypt);
            this.Controls.Add(this.btnCrypt);
            this.Controls.Add(this.cryptField);
            this.Controls.Add(this.groupBoxFooter);
            this.Controls.Add(this.groupBoxNavbar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AP_DB_Manager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DB manager";
            this.groupBoxNavbar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoader)).EndInit();
            this.groupBoxFooter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxNavbar;
        private System.Windows.Forms.RichTextBox dbLinkField;
        private System.Windows.Forms.Button btnCrypt;
        private System.Windows.Forms.PictureBox pictureBoxLoader;
        private System.Windows.Forms.Button btnTestDB;
        private System.Windows.Forms.GroupBox groupBoxFooter;
        private System.Windows.Forms.Button BtnDecrypt;
        private System.Windows.Forms.RichTextBox cryptField;
        private System.Windows.Forms.Button buttonClean;
    }
}

