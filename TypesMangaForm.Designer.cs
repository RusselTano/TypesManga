namespace TypesManga
{
    partial class TypesMangaForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TypesMangaForm));
            this.TitreLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.classificationLabel = new System.Windows.Forms.Label();
            this.typesMangaListBox = new System.Windows.Forms.ListBox();
            this.impressionGroupBox = new System.Windows.Forms.GroupBox();
            this.imprimerButton = new System.Windows.Forms.Button();
            this.imageRadioButton = new System.Windows.Forms.RadioButton();
            this.logoRadioButton = new System.Windows.Forms.RadioButton();
            this.fermerButton = new System.Windows.Forms.Button();
            this.siteLabel = new System.Windows.Forms.Label();
            this.programmeurLabel = new System.Windows.Forms.Label();
            this.liensListBox = new System.Windows.Forms.ListBox();
            this.mangaPictureBox = new System.Windows.Forms.PictureBox();
            this.logoMangaPictureBox = new System.Windows.Forms.PictureBox();
            this.impressionGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mangaPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoMangaPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // TitreLabel
            // 
            this.TitreLabel.AutoSize = true;
            this.TitreLabel.Font = new System.Drawing.Font("Pristina", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitreLabel.ForeColor = System.Drawing.Color.Firebrick;
            this.TitreLabel.Location = new System.Drawing.Point(624, 62);
            this.TitreLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TitreLabel.Name = "TitreLabel";
            this.TitreLabel.Size = new System.Drawing.Size(334, 75);
            this.TitreLabel.TabIndex = 2;
            this.TitreLabel.Text = "Types de manga";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(454, 510);
            this.descriptionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(549, 175);
            this.descriptionLabel.TabIndex = 3;
            this.descriptionLabel.Text = resources.GetString("descriptionLabel.Text");
            // 
            // classificationLabel
            // 
            this.classificationLabel.AutoSize = true;
            this.classificationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classificationLabel.ForeColor = System.Drawing.Color.Firebrick;
            this.classificationLabel.Location = new System.Drawing.Point(54, 208);
            this.classificationLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.classificationLabel.Name = "classificationLabel";
            this.classificationLabel.Size = new System.Drawing.Size(176, 29);
            this.classificationLabel.TabIndex = 5;
            this.classificationLabel.Text = "Classification:";
            // 
            // typesMangaListBox
            // 
            this.typesMangaListBox.FormattingEnabled = true;
            this.typesMangaListBox.ItemHeight = 24;
            this.typesMangaListBox.Items.AddRange(new object[] {
            "Il existe plusieurs types de manga:",
            "- Shonen Manga",
            "- Shojo Manga",
            "- Seinen Manga",
            "- Josei Manga",
            "- Yaoi Manga",
            "- Yuri Manga"});
            this.typesMangaListBox.Location = new System.Drawing.Point(56, 280);
            this.typesMangaListBox.Margin = new System.Windows.Forms.Padding(4);
            this.typesMangaListBox.Name = "typesMangaListBox";
            this.typesMangaListBox.Size = new System.Drawing.Size(913, 196);
            this.typesMangaListBox.TabIndex = 8;
            // 
            // impressionGroupBox
            // 
            this.impressionGroupBox.Controls.Add(this.imprimerButton);
            this.impressionGroupBox.Controls.Add(this.imageRadioButton);
            this.impressionGroupBox.Controls.Add(this.logoRadioButton);
            this.impressionGroupBox.Location = new System.Drawing.Point(1035, 510);
            this.impressionGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.impressionGroupBox.Name = "impressionGroupBox";
            this.impressionGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.impressionGroupBox.Size = new System.Drawing.Size(245, 291);
            this.impressionGroupBox.TabIndex = 9;
            this.impressionGroupBox.TabStop = false;
            this.impressionGroupBox.Text = "Impression";
            // 
            // imprimerButton
            // 
            this.imprimerButton.Location = new System.Drawing.Point(41, 202);
            this.imprimerButton.Margin = new System.Windows.Forms.Padding(4);
            this.imprimerButton.Name = "imprimerButton";
            this.imprimerButton.Size = new System.Drawing.Size(157, 57);
            this.imprimerButton.TabIndex = 2;
            this.imprimerButton.Text = "&Imprimer";
            this.imprimerButton.UseVisualStyleBackColor = true;
            this.imprimerButton.Click += new System.EventHandler(this.imprimerButton_Click);
            // 
            // imageRadioButton
            // 
            this.imageRadioButton.AutoSize = true;
            this.imageRadioButton.Location = new System.Drawing.Point(41, 129);
            this.imageRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.imageRadioButton.Name = "imageRadioButton";
            this.imageRadioButton.Size = new System.Drawing.Size(91, 29);
            this.imageRadioButton.TabIndex = 1;
            this.imageRadioButton.TabStop = true;
            this.imageRadioButton.Text = "Image";
            this.imageRadioButton.UseVisualStyleBackColor = true;
            // 
            // logoRadioButton
            // 
            this.logoRadioButton.AutoSize = true;
            this.logoRadioButton.Location = new System.Drawing.Point(41, 66);
            this.logoRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.logoRadioButton.Name = "logoRadioButton";
            this.logoRadioButton.Size = new System.Drawing.Size(81, 29);
            this.logoRadioButton.TabIndex = 0;
            this.logoRadioButton.TabStop = true;
            this.logoRadioButton.Text = "Logo";
            this.logoRadioButton.UseVisualStyleBackColor = true;
            // 
            // fermerButton
            // 
            this.fermerButton.Location = new System.Drawing.Point(1133, 1108);
            this.fermerButton.Margin = new System.Windows.Forms.Padding(4);
            this.fermerButton.Name = "fermerButton";
            this.fermerButton.Size = new System.Drawing.Size(157, 57);
            this.fermerButton.TabIndex = 3;
            this.fermerButton.Text = "Fermer";
            this.fermerButton.UseVisualStyleBackColor = true;
            this.fermerButton.Click += new System.EventHandler(this.fermerButton_Click);
            // 
            // siteLabel
            // 
            this.siteLabel.AutoSize = true;
            this.siteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siteLabel.ForeColor = System.Drawing.Color.Firebrick;
            this.siteLabel.Location = new System.Drawing.Point(54, 879);
            this.siteLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.siteLabel.Name = "siteLabel";
            this.siteLabel.Size = new System.Drawing.Size(297, 29);
            this.siteLabel.TabIndex = 10;
            this.siteLabel.Text = "Sites relies aux mangas:";
            // 
            // programmeurLabel
            // 
            this.programmeurLabel.AutoSize = true;
            this.programmeurLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.programmeurLabel.ForeColor = System.Drawing.Color.Green;
            this.programmeurLabel.Location = new System.Drawing.Point(63, 1120);
            this.programmeurLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.programmeurLabel.Name = "programmeurLabel";
            this.programmeurLabel.Size = new System.Drawing.Size(573, 29);
            this.programmeurLabel.TabIndex = 11;
            this.programmeurLabel.Text = "Programmeur: Andreas, Cedric,Dylane, Manuela";
            // 
            // liensListBox
            // 
            this.liensListBox.FormattingEnabled = true;
            this.liensListBox.ItemHeight = 24;
            this.liensListBox.Items.AddRange(new object[] {
            "https://harajuku-store.com/blogs/harajuku-blog/type-de-manga",
            "https://www.manga-news.com/",
            "https://v5.voiranime.com/",
            "https://mangadex.org/"});
            this.liensListBox.Location = new System.Drawing.Point(59, 944);
            this.liensListBox.Margin = new System.Windows.Forms.Padding(4);
            this.liensListBox.Name = "liensListBox";
            this.liensListBox.Size = new System.Drawing.Size(1220, 124);
            this.liensListBox.TabIndex = 12;
            // 
            // mangaPictureBox
            // 
            this.mangaPictureBox.Image = global::TypesManga.Properties.Resources.mha_com;
            this.mangaPictureBox.Location = new System.Drawing.Point(59, 510);
            this.mangaPictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.mangaPictureBox.Name = "mangaPictureBox";
            this.mangaPictureBox.Size = new System.Drawing.Size(358, 321);
            this.mangaPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mangaPictureBox.TabIndex = 1;
            this.mangaPictureBox.TabStop = false;
            // 
            // logoMangaPictureBox
            // 
            this.logoMangaPictureBox.Image = global::TypesManga.Properties.Resources.Logo_mangaschaine2022;
            this.logoMangaPictureBox.Location = new System.Drawing.Point(358, 45);
            this.logoMangaPictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.logoMangaPictureBox.Name = "logoMangaPictureBox";
            this.logoMangaPictureBox.Size = new System.Drawing.Size(235, 104);
            this.logoMangaPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoMangaPictureBox.TabIndex = 0;
            this.logoMangaPictureBox.TabStop = false;
            // 
            // TypesMangaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1373, 1190);
            this.Controls.Add(this.liensListBox);
            this.Controls.Add(this.programmeurLabel);
            this.Controls.Add(this.siteLabel);
            this.Controls.Add(this.fermerButton);
            this.Controls.Add(this.impressionGroupBox);
            this.Controls.Add(this.typesMangaListBox);
            this.Controls.Add(this.classificationLabel);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.TitreLabel);
            this.Controls.Add(this.mangaPictureBox);
            this.Controls.Add(this.logoMangaPictureBox);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TypesMangaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Types de manga";
            this.Load += new System.EventHandler(this.TypesMangaForm_Load);
            this.impressionGroupBox.ResumeLayout(false);
            this.impressionGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mangaPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoMangaPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logoMangaPictureBox;
        private System.Windows.Forms.PictureBox mangaPictureBox;
        private System.Windows.Forms.Label TitreLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label classificationLabel;
        private System.Windows.Forms.ListBox typesMangaListBox;
        private System.Windows.Forms.GroupBox impressionGroupBox;
        private System.Windows.Forms.Button imprimerButton;
        private System.Windows.Forms.RadioButton imageRadioButton;
        private System.Windows.Forms.RadioButton logoRadioButton;
        private System.Windows.Forms.Button fermerButton;
        private System.Windows.Forms.Label siteLabel;
        private System.Windows.Forms.Label programmeurLabel;
        private System.Windows.Forms.ListBox liensListBox;
       // private Microsoft.VisualBasic.PowerPacks.Printing.PrintForm typeMangaPrintForm;
    }
}

