using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KisiEnvanteri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Kisi> kisiler = new List<Kisi>();
        private void ListeyiDoldur()
        {
            lstKisiler.Items.Clear();
            foreach (Kisi kisi in kisiler)
            {
                lstKisiler.Items.Add(kisi);
            }
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Multiselect = false;
            dialog.Title = "Bir Foto Seçiniz";
            dialog.Filter = "Resim Dosyaları | *.jpeg; *.jpg";
            dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                pbResim.ImageLocation = dialog.FileName;
            }
        }



        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Kisi yeniKisi = new Kisi()
            {
                Ad = txtAd.Text,
                Soyad = txtSoyad.Text,
                DogumTarihi = dtpDogumTarihi.Value,
                Telefon = txtTelefon.Text,
            };
            if (pbResim.Image != null)
            {
                MemoryStream resimStream = new MemoryStream();

                pbResim.Image.Save(resimStream, ImageFormat.Jpeg);

                yeniKisi.Fotograf = resimStream.ToArray();
            }
            kisiler.Add(yeniKisi);
            ListeyiDoldur();
        }

        private Kisi seciliKisi;
        private void lstKisiler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstKisiler.SelectedItem == null) return;

            seciliKisi = lstKisiler.SelectedItem as Kisi;

            txtAd.Text = seciliKisi.Ad;
            txtSoyad.Text = seciliKisi.Soyad;
            txtTelefon.Text = seciliKisi.Telefon;
            dtpDogumTarihi.Value = seciliKisi.DogumTarihi;

            if (seciliKisi.Fotograf != null)
            {
                MemoryStream stream = new MemoryStream(seciliKisi.Fotograf);
                pbResim.Image = Image.FromStream(stream);
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {

            seciliKisi.Ad = txtAd.Text;
            seciliKisi.Soyad = txtSoyad.Text;
            seciliKisi.Telefon = txtTelefon.Text;

            if (pbResim.Image != null)
            {
                MemoryStream resimStream = new MemoryStream();
                pbResim.Image.Save(resimStream, ImageFormat.Jpeg);

                seciliKisi.Fotograf = resimStream.ToArray();

            }
            ListeyiDoldur();

        }

        private void dışarıAktarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();        
            dialog.Title = "Dışarı Aktar";
            dialog.Filter = "XML Format | *.xml";
            dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {

            }

        }
    }
}
