using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OgrenciNumaraları
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OkulnoDataContext dc = new OkulnoDataContext();
            Okullar add = new Okullar();
            {
                add.OkulAdi = textBox1.Text;
            };
            dc.Okullar.InsertOnSubmit(add);
            dc.SubmitChanges();
            dataGridView1.DataSource = from a in dc.Okullar
                                       select new {
                                           a.OkulId,
                                           a.OkulAdi,
                                       };

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bolum form = new Bolum();
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Ekle form = new Ekle();
            form.Show();

        }
    }
}
