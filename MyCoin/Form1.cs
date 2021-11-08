﻿using MyCoin.Models;
using MyCoin.Services;
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
            var result = new ExchangeInfoService().Result();
            _symbols = result.Symbols;
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
    }
}