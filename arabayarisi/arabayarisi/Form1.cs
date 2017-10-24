using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace arabayarisi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int birinci, ikinci, ucuncu, dorduncu;

        private void timer1_Tick(object sender, EventArgs e)
        {
            int genislik1 = pictureBox1.Width;
            int genislik2 = pictureBox2.Width;
            int genislik3 = pictureBox3.Width;
            int genislik4 = pictureBox4.Width;
            int bitisuzakligi = label6.Left;
            int sonuc = 0;
            int kumar;
            kumar = int.Parse(textBox1.Text);
            pictureBox1.Left = pictureBox1.Left + rastgele.Next(5, 15);
            pictureBox2.Left = pictureBox2.Left + rastgele.Next(5, 15);
            pictureBox3.Left = pictureBox3.Left + rastgele.Next(5, 15);
            pictureBox4.Left = pictureBox4.Left + rastgele.Next(5, 15);

            if(genislik1+pictureBox1.Left >= bitisuzakligi)
            {
                sonuc = 1;
                timer1.Enabled = false;
                if (kumar == sonuc)
                {
                    MessageBox.Show("Doğru Tahmin!!!");
                }
                else { MessageBox.Show("Malesef Yanlış Tahmin"); }
                


            }
            if (genislik2 + pictureBox2.Left >= bitisuzakligi)
            {
                sonuc = 2;
                timer1.Enabled = false;
                if (kumar == sonuc)
                {
                    MessageBox.Show("Doğru Tahmin!!!");
                }
                else { MessageBox.Show("Malesef Yanlış Tahmin"); }
                


            }
            if (genislik3 + pictureBox3.Left >= bitisuzakligi)
            {
                sonuc = 3;
                timer1.Enabled = false;
                if (kumar == sonuc)
                {
                    MessageBox.Show("Doğru Tahmin!!!");
                }
                else { MessageBox.Show("Malesef Yanlış Tahmin"); }
                


            }
            if (genislik4 + pictureBox4.Left >= bitisuzakligi)
            {
                sonuc = 4;
                timer1.Enabled = false;
                if (kumar == sonuc)
                {
                    MessageBox.Show("Doğru Tahmin!!!");
                }
                else { MessageBox.Show("Malesef Yanlış Tahmin"); }
                
            }



        }

        private void Form1_Load(object sender, EventArgs e)
        {
            birinci = pictureBox1.Left;
            ikinci = pictureBox2.Left;
            ucuncu = pictureBox3.Left;
            dorduncu = pictureBox4.Left;
        }

        Random rastgele = new Random();
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;

        }
    }
}
