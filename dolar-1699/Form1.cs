﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dolar_1699
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCevir_Click(object sender, EventArgs e)
        {
            double adet, birim, sonuc;
            adet = Convert.ToDouble(txtAdet.Text);
            birim = Convert.ToDouble(txtAdet.Text.ToUpper());
            sonuc = birim*adet;

            lblßonuc.Text = sonuc.ToString();
    }

        private void lblßonuc_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
