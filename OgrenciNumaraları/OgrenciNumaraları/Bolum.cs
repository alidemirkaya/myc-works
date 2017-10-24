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
    public partial class Bolum : Form
    {
        public Bolum()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OkulnoDataContext dc = new OkulnoDataContext();
            Bolumler add = new Bolumler();
            {
                add.OkulId = (int)comboBox1.SelectedValue;
                add.BolumAdi = textBox1.Text;

            };
            dc.Bolumler.InsertOnSubmit(add);
            dc.SubmitChanges();
            dataGridView1.DataSource = from a in dc.Bolumler
                                       join b in dc.Okullar on
                                       a.OkulId equals b.OkulId
                                       select new
                                       {
                                           b.OkulAdi,
                                           a.BolumAdi,

                                       };
                                     
                                     
        }

        private void Bolum_Load(object sender, EventArgs e)
        {
            OkulnoDataContext dc = new OkulnoDataContext();
            comboBox1.DataSource = dc.Okullar;
            comboBox1.DisplayMember = "OkulAdi";
            comboBox1.ValueMember = "OkulId";
        }
    }
}
