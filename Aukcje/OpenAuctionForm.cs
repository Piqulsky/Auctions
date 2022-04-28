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
    public partial class OpenAuctionForm : Form
    {
        public OpenAuctionForm()
        {
            InitializeComponent();
        }
        public static Image LoadBase64(string base64)
        {
            byte[] bytes = Convert.FromBase64String(base64);
            Image image;
            using (MemoryStream ms = new MemoryStream(bytes))
            {
                image = Image.FromStream(ms);
            }
            return image;
        }

        public OpenAuctionForm(string filePath) :this()
        {
            string[] file = File.ReadAllLines(filePath);
            string[] fileData = file[0].Split(';');
            nameLabel.Text = fileData[0];
            descriptionLabel.Text = fileData[1];
            priceLabel.Text = fileData[2];
            saleTypeLabel.Text = fileData[3] == "True" ? "Licytacja" : "Sprzedaż";
            pictureBox.Image = fileData[4] != null ? LoadBase64(fileData[4]) : null;
        }
    }

}
