using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double Hesapla(double x, double kdv)
        {
            toplam = x * kdv / 100;
            Math.Sqrt(toplam = sayi1 + toplam);
            return toplam;
        }
        double Hesapla(double x)
        {
            Math.Sqrt(toplam2 = x * kdv / 100);
            return toplam2;
        }
        ArrayList array = new ArrayList();
        ArrayList array1 = new ArrayList();
        double sayi1, toplam, toplam2, kdv;

        private void button1_Click(object sender, EventArgs e)
        {
            kdv = Convert.ToDouble(textBox2.Text);
            sayi1 = Convert.ToDouble(textBox1.Text);
            Hesapla(sayi1, kdv);
            Hesapla(sayi1);
            array.Add(toplam);
            array1.Add(toplam2);
            textBox1.Clear();
            textBox2.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            foreach (object item in array)
            {
                listBox1.Items.Add(item + "₺");
            }
            foreach (object item in array1)
            {
                listBox2.Items.Add(item + "₺");
            }
        }
    }
}
