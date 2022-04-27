using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            Task t = Task.Run(() => {
                String name = nameBox.Text;
                String description = descriptionBox.Text;
                decimal price = priceInput.Value;
                bool isAuction = auctionRadioButton.Checked;
                byte[] image = pictureBox.Image != null ? ImageToByteArray(pictureBox.Image) : new byte[0];
                String finalAuction = name + ";" + description + ";" + price.ToString() + ";" + isAuction.ToString() + ";";
                foreach (byte b in image)
                {
                    finalAuction += b.ToString() + ",";
                }
                File.WriteAllText(name + ".txt", finalAuction);
            });
        }
    }
}
