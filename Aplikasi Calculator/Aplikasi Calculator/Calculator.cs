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
    public partial class Calculator : Form
    {
        public delegate void Proses1dan2(int operasi, int a, int b, int hasil);
        public event Proses1dan2 Proses;

        public Calculator()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string operasi = Opsi.SelectedItem.ToString();
            int a = Convert.ToInt32(txtNilaiA.Text);
            int b = Convert.ToInt32(txtNilaiB.Text);
            int hasil;

            switch (Opsi.SelectedIndex)
            {
                case 0:
                    hasil = a + b;
                    break;
                case 1:
                    hasil = a - b;
                    break;
                case 2:
                    hasil = a * b;
                    break;
                case 3:
                    hasil = a / b;
                    break;
                default:
                    hasil = 0;
                    break;
            }

            this.Proses(Opsi.SelectedIndex, a, b, hasil);
        }
    }
}
