using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TypesManga
{
    public partial class TypesMangaForm : Form
    {
        public TypesMangaForm()
        {
            InitializeComponent();
        }
        private void TypesMangaForm_Load(object sender, EventArgs e)
        {
            int largeur= this.ClientSize.Width;
            int hauteur=this.ClientSize.Height;
            int zoom = 1;

        }

        ListBox lstItems; Image imageChoisie;

        private void imprimerButton_Click(object sender, EventArgs e)
        {
            
            PrintDialog printDialog = new PrintDialog();
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                PrintDocument document = new PrintDocument();
                document.PrintPage += (s, args) =>
                {
                    // Image/logo centré
                    if (imageChoisie != null)
                    {
                        args.Graphics.DrawImage(imageChoisie, new Point(100, 100));
                    }

                    // Titre et nom centré
                    string titre = "Type manga - Andreas, Cedric, Dylane, Manuela";
                   Font titreFont = new Font("Arial", 24, FontStyle.Bold);
                    args.Graphics.DrawString(titre, titreFont, Brushes.Black, new Point(100, 200));

                    // Liste des items avec numérotation
                    int yPosition = 250;
                    for (int i = 0; i < lstItems.Items.Count; i++)
                    {
                        string item = $"{i + 1}. {lstItems.Items[i].ToString()}";
                        args.Graphics.DrawString(item, new Font("Arial", 12), Brushes.Black, new Point(100, yPosition));
                        yPosition += 30;
                    }

                    // Signature en bas
                    args.Graphics.DrawString($"Signature: Votre Nom, {DateTime.Now.ToLongDateString()}",
                        new Font("Arial", 12, FontStyle.Italic), Brushes.Black, new Point(100, yPosition + 50));
                };
                document.Print();
            }
        }


        private void fermerButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
