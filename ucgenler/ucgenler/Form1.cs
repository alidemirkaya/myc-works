using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ucgenler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        Random rastgele = new Random();
        private void button1_Click(object sender, EventArgs e)
        {
            int sayi = rastgele.Next(1,100);
            listBox1.Items.Add(sayi);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sayi = rastgele.Next(1, 100);
            listBox2.Items.Add(sayi);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int sayi = rastgele.Next(1, 100);
            listBox3.Items.Add(sayi);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2, sayi3;
            sayi1 = (int)listBox1.Items[listBox1.SelectedIndex];
            sayi2 = (int)listBox2.Items[listBox2.SelectedIndex];
            sayi3 = (int)listBox3.Items[listBox3.SelectedIndex];
            if(sayi1+sayi2>=sayi3)
            {
                if (sayi2 + sayi3 >= sayi1)
                {
                    if (sayi1 + sayi3 >= sayi2)
                    {
                        label2.Text = Convert.ToString(sayi1);
                        label3.Text = Convert.ToString(sayi2);
                        label4.Text = Convert.ToString(sayi3);
                        label7.Text = "Üçgen Oluşur";
                        if (sayi1 == sayi2 &&sayi2==sayi3)
                        {
                            label8.Text = "Eşitkenar Üçgen";
                        }
                        else if(sayi1==sayi2 &&sayi2 != sayi3)
                        {
                            label8.Text = "İkizkenar Üçgen";
                        }
                        else if(sayi2==sayi3 &&sayi2 != sayi1)
                        {
                            label8.Text = "İkizkenar Üçgen";
                        }
                        else if(sayi1==sayi3 &&sayi3 != sayi2)
                        {
                            label8.Text = "İkizkenar Üçgen";
                        }
                        else
                        {
                            label8.Text = "Çeşitkenar Üçgen";

                        }
                        
                    }
                    else
                    {
                        label2.Text = Convert.ToString(sayi1);
                        label3.Text = Convert.ToString(sayi2);
                        label4.Text = Convert.ToString(sayi3);
                        label7.Text = "Üçgen Oluşmaz";
                    }
                }
                else
                {
                    label2.Text = Convert.ToString(sayi1);
                    label3.Text = Convert.ToString(sayi2);
                    label4.Text = Convert.ToString(sayi3);
                    label7.Text = "Üçgen Oluşmaz";
                }
            }
            else
            {
                label2.Text = Convert.ToString(sayi1);
                label3.Text = Convert.ToString(sayi2);
                label4.Text = Convert.ToString(sayi3);
                label7.Text = "Üçgen Oluşmaz";
            }
        }
    }
}
