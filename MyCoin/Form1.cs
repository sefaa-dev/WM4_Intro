using MyCoin.Models;
using MyCoin.Services;
using MyCoin.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCoin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private List<Symbol> _symbols = new List<Symbol>();

        private void Form1_Load(object sender, EventArgs e)
        {

            try
            {
                var result = new ExchangeInfoService().Result();
                _symbols = result.Symbols;

            }
            catch (Exception ex)
            {

                MessageBox.Show($"{ex.Message}");
            }

            _symbols = _symbols.Where(x => x.status == "TRADING").
                   OrderBy(x => x.symbol).
                   ToList();
            listBox1.DataSource = _symbols;
            listBox1.DisplayMember = nameof(Symbol.symbol);

            this.Text = $"{_symbols.Count} Adet Coin Listelenmiştir";


        }

        private void txtAra_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAra.Text))
            {
                listBox1.DataSource = _symbols;
                this.Text = $"{_symbols.Count} Adet Coin Listelenmiştir";
            }
            else
            {
                var result = _symbols.Where(x => x.symbol.Contains(txtAra.Text.ToUpper())).ToList();
                listBox1.DataSource = result;
                this.Text = $"{result.Count} Adet Coin Listelenmiştir";
            }

        }

        private Symbol _seciliSymbol;

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null) return;
            _seciliSymbol = listBox1.SelectedItem as Symbol;

            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (_seciliSymbol == null) return;
            GetCoinInfo();
        }

        private void GetCoinInfo()
        {
            try
            {
                var result = new SymbolTickerService().Result(_seciliSymbol.symbol);

                lblSymbol.Text = result.Symbol;
                lblFiyat.Text = $"{result.LowPrice}\n{result.PriceChangePercent / 100:P1}";
                lblFiyat.ForeColor = result.PriceChange > 0 ? Color.LimeGreen : Color.Tomato;
                lblInfo.Text = $"En düşük: {result.LowPrice} \nEn yüksek: {result.HighPrice}\nAçılış: {BinanceHelper.DataConverter(result.OpenTime)}\nKapanış: {BinanceHelper.DataConverter(result.CloseTime)}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
            }
        }
    }
}
