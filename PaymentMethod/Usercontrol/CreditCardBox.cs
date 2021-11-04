using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaymentMethod.Usercontrol
{
    public partial class CreditCardBox : UserControl
    {
        public CreditCardBox()
        {
            InitializeComponent();
        }

        private void CreditCardBox_Load(object sender, EventArgs e)
        {
            for (int i = 0; i <= 12; i++)
            {
                cmbAy.Items.Add($"{i:00}");
            }
            for (DateTime i = DateTime.Now; i <= DateTime.Now.AddYears(10); i.AddYears(1)) 
            {
                cmbYil.Items.Add($"{i:yy}");

            }
        }
    }
}
