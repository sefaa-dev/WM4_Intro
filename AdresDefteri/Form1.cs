using System;
using System.Collections.Generic;
using System.Windows.Forms;
using AdresDefteri.Models;

namespace AdresDefteri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Kisi kisi = new Kisi();
        Ders ders = new Ders();

        private void Form1_Load(object sender, System.EventArgs e)
        {
            //try
            //{
            //    kisi.Ad = "Kamil";
            //    kisi.Soyad = "³Fıdıl";
            //    kisi.DogumTarihi = new DateTime(1998, 5, 26);
            //}
            //catch (Exception ex)
            //{
            // MessageBox.Show($"Bir hata oluştu: {ex.Message}");
            //} // set
            //MessageBox.Show($"Kişinin Yaşı: {kisi.Yas}"); //get
        }
        private List<Kisi> kisiler = new List<Kisi>();
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Kisi yeniKisi = new Kisi();
            try
            {
                yeniKisi.Ad = txtAd.Text;
                yeniKisi.Soyad = txtSoyad.Text;
                yeniKisi.DogumTarihi = dtpDogumTarihi.Value;
                yeniKisi.Tckn = txtTckn.Text;



                kisiler.Add(yeniKisi);
                //lstKisiler.Items.Add(yeniKisi);
                ListeyiDoldur();


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Bir hata oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void ListeyiDoldur()
        {
            lstKisiler.Items.Clear();
            foreach (Kisi kisi1 in kisiler)
            {
                lstKisiler.Items.Add(kisi1);
            }
        }


        private Kisi seciliKisi;

        private void lstKisiler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstKisiler.SelectedItem == null) return;

            seciliKisi = lstKisiler.SelectedItem as Kisi;

            seciliKisi.Ad = txtAd.Text;
            seciliKisi.Soyad = txtSoyad.Text;
            seciliKisi.Tckn = txtTckn.Text;
            seciliKisi.DogumTarihi = dtpDogumTarihi.Value;

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (seciliKisi == null) return;

            seciliKisi.Ad = txtAd.Text;
            seciliKisi.Soyad = txtSoyad.Text;
            seciliKisi.Tckn = txtTckn.Text;
            seciliKisi.DogumTarihi = dtpDogumTarihi.Value;

            
            ListeyiDoldur();

        }

        private void slBtn_Click(object sender, EventArgs e)
        {
            if (seciliKisi == null) return;

            DialogResult cevap = MessageBox.Show($"{seciliKisi} yi silmek istiyor musunuz ??", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (cevap == DialogResult.Yes)
            {
                kisiler.Remove(seciliKisi);
                ListeyiDoldur();
            }
        }
    }
}
