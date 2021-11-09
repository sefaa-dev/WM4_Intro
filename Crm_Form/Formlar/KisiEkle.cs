using Crm_Form.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crm_Form.Formlar
{
    public partial class KisiEkle : Form
    {
        public KisiEkle()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Kisi yeniKisi = new Kisi()
            {
                Ad = Faker.NameFaker.FirstName(),
                SoyAd = Faker.NameFaker.LastName(),
                DogumTarihi = Faker.DateTimeFaker.BirthDay(),
                Falan = Faker.NumberFaker.Number()
            };
            var form1 = this.MdiParent as Form1;
            form1.Kisiler.Add(yeniKisi);
            this.Close();
        }
    }
}
