using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace modul3_1302223019
{
    public partial class Form1 : Form
    {
        int penyimpanAngka = 0, jumlah = 0;
        bool multipleDigit = false;
        string operasi = "", hasil = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!multipleDigit)
            {
                penyimpanAngka += 3;
                multipleDigit = true;
            }
            else
            {
                penyimpanAngka = (penyimpanAngka * 10) + 3;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!multipleDigit)
            {
                penyimpanAngka += 1;
                multipleDigit = true;
            }
            else
            {
                penyimpanAngka = (penyimpanAngka * 10) + 1;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!multipleDigit)
            {
                penyimpanAngka += 2;
                multipleDigit = true;
            }
            else
            {
                penyimpanAngka = (penyimpanAngka * 10) + 2;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!multipleDigit)
            {
                penyimpanAngka += 4;
                multipleDigit = true;
            }
            else
            {
                penyimpanAngka = (penyimpanAngka * 10) + 4;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (!multipleDigit)
            {
                penyimpanAngka += 5;
                multipleDigit = true;
            }
            else
            {
                penyimpanAngka = (penyimpanAngka * 10) + 5;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (!multipleDigit)
            {
                penyimpanAngka += 6;
                multipleDigit = true;
            }
            else
            {
                penyimpanAngka = (penyimpanAngka * 10) + 6;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (!multipleDigit)
            {
                penyimpanAngka += 7;
                multipleDigit = true;
            }
            else
            {
                penyimpanAngka = (penyimpanAngka * 10) + 7;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (!multipleDigit)
            {
                penyimpanAngka += 8;
                multipleDigit = true;
            }
            else
            {
                penyimpanAngka = (penyimpanAngka * 10) + 8;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (!multipleDigit)
            {
                penyimpanAngka += 9;
                multipleDigit = true;
            }
            else
            {
                penyimpanAngka = (penyimpanAngka * 10) + 9;
            }
        }

        private void NumberButton_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            label_output.Text += btn.Text;
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            jumlah += penyimpanAngka;
            operasi += penyimpanAngka + " + ";
            labeloutput2.Text = operasi;
            penyimpanAngka = 0;
            multipleDigit = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void labeloutput2_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (!multipleDigit)
            {
                penyimpanAngka += 0;
                multipleDigit = true;
            }
            else
            {
                penyimpanAngka = (penyimpanAngka * 10) + 0;
            }
        }

        private void buttonSamaDengan_Click(object sender, EventArgs e)
        {
            jumlah += penyimpanAngka;
            operasi += penyimpanAngka;
            labeloutput2.Text = operasi;
            hasil += "Hasilnya adalah " + jumlah;
            labeloutput2.Text = hasil;
            jumlah = 0;
            penyimpanAngka = 0;
            multipleDigit = false;
        }
    }
}
