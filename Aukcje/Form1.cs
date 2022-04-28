using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Aukcje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public byte[] ImageToByteArray(System.Drawing.Image imageIn)
        {
            using (var ms = new MemoryStream())
            {
                imageIn.Save(ms, imageIn.RawFormat);
                return ms.ToArray();
            }
        }

        private void imageButton_Click(object sender, EventArgs e)
        {
            if (openImage.ShowDialog() == DialogResult.OK)
            {
                pictureBox.Image = new Bitmap(openImage.FileName);
            }
        }

        private void addAuctionButton_Click(object sender, EventArgs e)
        {
            String name = nameBox.Text;
            String description = descriptionBox.Text;
            decimal price = priceInput.Value;
            bool isAuction = auctionRadioButton.Checked;
            string image = pictureBox.Image != null ? Convert.ToBase64String(ImageToByteArray(pictureBox.Image)) : null;
            String finalAuction = name + ";" + description + ";" + price.ToString() + ";" + isAuction.ToString() + ";" + image + ";";

            if (saveAuction.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveAuction.FileName, finalAuction);
            }


            OpenAuctionForm openedAuctionForm = new OpenAuctionForm(saveAuction.FileName);
            openedAuctionForm.Show();
        }

        private void otwórzToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openAuctionFile.ShowDialog() == DialogResult.OK)
            {
                OpenAuctionForm openedAuctionForm = new OpenAuctionForm(openAuctionFile.FileName);
                openedAuctionForm.Show();
            }

        }
    }
}
