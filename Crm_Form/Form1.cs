using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Crm_Form.Formlar;
using Crm_Form.Models;

namespace Crm_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show("Programı kapatmak istiyor musunuz?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result != DialogResult.Yes)
                e.Cancel = true;
        }
        //singleton
        private FrmDisariAktar _frmDisariAktar;
        private void dışarıAktarToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            if (_frmDisariAktar == null || _frmDisariAktar.IsDisposed)
                _frmDisariAktar = new FrmDisariAktar();
            _frmDisariAktar.MdiParent = this;
            _frmDisariAktar.Show();
        }

        private FrmIceriAktar _frmIceriAktar;
        private void içeriAktarToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            if (_frmIceriAktar == null || _frmIceriAktar.IsDisposed)
                _frmIceriAktar = new FrmIceriAktar();
            _frmIceriAktar.MdiParent = this;
            _frmIceriAktar.Show();
        }

        public List<Kisi> Kisiler { get; set;}

        private void Form1_Load(object sender, System.EventArgs e)
        {
            var context = new Context();
            Kisiler = context.Kisiler;
            Console.WriteLine();
        }

        private KisiEkle _kisiEkle; 
        private void ekleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_kisiEkle == null || _kisiEkle.IsDisposed)
            {
                _kisiEkle = new KisiEkle();
                _kisiEkle.MdiParent = this;
                _kisiEkle.Show();

            }
        }

        private FrmKisiGuncelle _frmKisiGuncelle;
        private void güncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_frmKisiGuncelle == null || _frmKisiGuncelle.IsDisposed)
            {
                _frmKisiGuncelle = new FrmKisiGuncelle();
                _frmKisiGuncelle.MdiParent = this;
                _frmKisiGuncelle.Kisi = Kisiler.Last();
                _frmKisiGuncelle.Show();

            }
        }
        FormKisiListele _formKisiListele;
        private void listeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
                _formKisiListele = new FormKisiListele();
            _formKisiListele.StartPosition = FormStartPosition.CenterScreen;
                _formKisiListele.Kisiler = Kisiler;
                var result = _formKisiListele.ShowDialog();
                if (result == DialogResult.OK)
                {
                    var seciliKisi = _formKisiListele.SeciliKisi;
                    MessageBox.Show($"Seçili Kişi: {seciliKisi}");
                }

            }
        }
    }

