using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplikasi_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Tulis(int operasi, int a, int b, int hasil)
        {
            char[] operasi_simbol = { '+', '-', '*', '/' };
            string[] operasi_str = { "Penjumlahan", "Pengurangan", "Perkalian", "Pembagian" };
            lstHasil.Items.Add($"Hasil {(operasi_str[operasi]).ToLower()} {a} {operasi_simbol[operasi]} {b} = {hasil}" );
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Calculator hitung = new Calculator();
            hitung.Proses += Tulis;
            hitung.ShowDialog();
        }
    }
}