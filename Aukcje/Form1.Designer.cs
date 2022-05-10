namespace Aukcje
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otwórzToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.saleRadioButton = new System.Windows.Forms.RadioButton();
            this.auctionRadioButton = new System.Windows.Forms.RadioButton();
            this.descriptionBox = new System.Windows.Forms.RichTextBox();
            this.imageButton = new System.Windows.Forms.Button();
            this.addAuctionButton = new System.Windows.Forms.Button();
            this.openImage = new System.Windows.Forms.OpenFileDialog();
            this.priceInput = new System.Windows.Forms.NumericUpDown();
            this.openAuctionFile = new System.Windows.Forms.OpenFileDialog();
            this.saveAuction = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.priceInput)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // plikToolStripMenuItem
            // 
            this.plikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.otwórzToolStripMenuItem});
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.plikToolStripMenuItem.Text = "Plik";
            // 
            // otwórzToolStripMenuItem
            // 
            this.otwórzToolStripMenuItem.Name = "otwórzToolStripMenuItem";
            this.otwórzToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.otwórzToolStripMenuItem.Text = "Otwórz";
            this.otwórzToolStripMenuItem.Click += new System.EventHandler(this.otwórzToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nazwa: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(305, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cena Wstępna:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Opis:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(525, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Obraz:";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(82, 58);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(208, 20);
            this.nameBox.TabIndex = 7;
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(528, 163);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(200, 140);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 8;
            this.pictureBox.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.saleRadioButton);
            this.groupBox1.Controls.Add(this.auctionRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(528, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 77);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // saleRadioButton
            // 
            this.saleRadioButton.AutoSize = true;
            this.saleRadioButton.Location = new System.Drawing.Point(6, 42);
            this.saleRadioButton.Name = "saleRadioButton";
            this.saleRadioButton.Size = new System.Drawing.Size(69, 17);
            this.saleRadioButton.TabIndex = 1;
            this.saleRadioButton.Text = "Sprzedaż";
            this.saleRadioButton.UseVisualStyleBackColor = true;
            // 
            // auctionRadioButton
            // 
            this.auctionRadioButton.AutoSize = true;
            this.auctionRadioButton.Checked = true;
            this.auctionRadioButton.Location = new System.Drawing.Point(6, 19);
            this.auctionRadioButton.Name = "auctionRadioButton";
            this.auctionRadioButton.Size = new System.Drawing.Size(67, 17);
            this.auctionRadioButton.TabIndex = 0;
            this.auctionRadioButton.TabStop = true;
            this.auctionRadioButton.Text = "Licytacja";
            this.auctionRadioButton.UseVisualStyleBackColor = true;
            // 
            // descriptionBox
            // 
            this.descriptionBox.Location = new System.Drawing.Point(82, 100);
            this.descriptionBox.Name = "descriptionBox";
            this.descriptionBox.Size = new System.Drawing.Size(410, 203);
            this.descriptionBox.TabIndex = 2;
            this.descriptionBox.Text = "";
            // 
            // imageButton
            // 
            this.imageButton.Location = new System.Drawing.Point(528, 323);
            this.imageButton.Name = "imageButton";
            this.imageButton.Size = new System.Drawing.Size(100, 23);
            this.imageButton.TabIndex = 10;
            this.imageButton.Text = "Dodaj obraz";
            this.imageButton.UseVisualStyleBackColor = true;
            this.imageButton.Click += new System.EventHandler(this.imageButton_Click);
            // 
            // addAuctionButton
            // 
            this.addAuctionButton.Location = new System.Drawing.Point(82, 323);
            this.addAuctionButton.Name = "addAuctionButton";
            this.addAuctionButton.Size = new System.Drawing.Size(105, 23);
            this.addAuctionButton.TabIndex = 11;
            this.addAuctionButton.Text = "Dodaj aukcję";
            this.addAuctionButton.UseVisualStyleBackColor = true;
            this.addAuctionButton.Click += new System.EventHandler(this.addAuctionButton_Click);
            // 
            // openImage
            // 
            this.openImage.FileName = "openImage";
            this.openImage.Filter = "Pliki Obrazu (*.jpg;*.jpeg;*.gif;*.png;)|*.jpg;*.jpeg;*.gif;*.png\"";
            // 
            // priceInput
            // 
            this.priceInput.Location = new System.Drawing.Point(392, 59);
            this.priceInput.Name = "priceInput";
            this.priceInput.Size = new System.Drawing.Size(100, 20);
            this.priceInput.TabIndex = 12;
            // 
            // openAuctionFile
            // 
            this.openAuctionFile.FileName = "openAuctionFile";
            // 
            // saveAuction
            // 
            this.saveAuction.DefaultExt = "auction";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.priceInput);
            this.Controls.Add(this.addAuctionButton);
            this.Controls.Add(this.imageButton);
            this.Controls.Add(this.descriptionBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Portal Aukcyjny";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.priceInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otwórzToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton saleRadioButton;
        private System.Windows.Forms.RadioButton auctionRadioButton;
        private System.Windows.Forms.RichTextBox descriptionBox;
        private System.Windows.Forms.Button imageButton;
        private System.Windows.Forms.Button addAuctionButton;
        private System.Windows.Forms.OpenFileDialog openImage;
        private System.Windows.Forms.NumericUpDown priceInput;
        private System.Windows.Forms.OpenFileDialog openAuctionFile;
        private System.Windows.Forms.SaveFileDialog saveAuction;
    }
}

