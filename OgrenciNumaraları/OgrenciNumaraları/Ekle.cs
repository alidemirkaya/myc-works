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
    public partial class Ekle : Form
    {
        public Ekle()
        {
            InitializeComponent();
        }

        private void Ekle_Load(object sender, EventArgs e)
        {
            OkulnoDataContext dc = new OkulnoDataContext();
            // Formumuz ilk açıldığında combobox ve datagridview 'i dolduralım           
            comboBox1.DataSource = dc.Okullar;
            comboBox1.DisplayMember = "OkulAdi";
            comboBox1.ValueMember = "OkulId";
            dataGridView2.DataSource = from a in dc.Ogrenciler
                                       select new
                                       {
                                           a.OgrenciId,
                                           a.OgrenciAdi,
                                       };
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OkulnoDataContext dc = new OkulnoDataContext();
            /* Elimizde olan verileri String türünden yazdıktan sonra
             * Onları birleştirmemiz gerekecek
             * Comboboxtaki Seçtiğimiz değer yani Okul Kodu 2.sırada
             * Datagridviewden seçtiğimiz bölüm kodu 3.sırada
             * Giriş sırasi 4. sırada
             * Giriş yılı ise en başta olacak şekilde toplama işlemini yapıyoruz.
             * String olarak değil de direkt int olarak atasaydık.
             * Toplama yapılırken sayıları sayı olarak  tanımlayıp toplardı
             */
            OgrenciEkle add = new OgrenciEkle();
            string okuladi = Convert.ToString(comboBox1.SelectedValue);
            string bolumadi = Convert.ToString(dataGridView1.CurrentRow.Cells["BolumId"].Value);
            string girisyili = txtgirisyil.Text;
            string girissirasi = txtgirissira.Text;
            string okulno = girisyili + okuladi + bolumadi + girissirasi;
            {
                add.OkulId = (int)comboBox1.SelectedValue;
                add.BolumId = (int)dataGridView1.CurrentRow.Cells["BolumId"].Value;
                add.OgrenciId = Convert.ToInt32(okulno);
                add.OgrenciAdi = txtadi.Text;


            };
            dc.Ogrenciler.InsertOnSubmit(add);
            dc.SubmitChanges();
            dataGridView2.DataSource = from a in dc.Ogrenciler
                                       join b in dc.Okullar on
                                       a.OkulId equals b.OkulId
                                       join c in dc.Bolumler on 
                                       a.BolumId equals c.BolumId
                                       select new {
                                           a.OgrenciId,
                                           a.OgrenciAdi,
                                           b.OkulAdi,
                                           c.BolumAdi,
                                           
                                           
                                       };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OkulnoDataContext dc = new OkulnoDataContext();
            dataGridView1.DataSource = from a in dc.Bolumler
                                       where a.OkulId == (int)comboBox1.SelectedValue
                                       select new {
                                       a.BolumId,
                                       a.BolumAdi,
                                       };
        }
    }
}
