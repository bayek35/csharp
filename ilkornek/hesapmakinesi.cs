using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hesapmakinesi
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
      

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double a, b, top;
          
                if (textBox1.Text != "" && textBox2.Text != "")
                {
                    a = Convert.ToInt32(textBox1.Text);
                    b = Convert.ToInt32(textBox2.Text);

                    if (radioButton1.Checked == true)
                    {
                        top = a + b;
                        MessageBox.Show("sonuç=" + top);

                    }
                    else if (radioButton2.Checked == true)
                    {
                        top = a - b;
                        MessageBox.Show("sonuç=" + top);
                    }
                    else if (radioButton3.Checked == true)
                    {
                        top = a * b;
                        MessageBox.Show("sonuç=" + top);
                    }
                    else if (radioButton4.Checked == true)
                    {
                        top = a / b;
                        MessageBox.Show("sonuç=" + top);
                    }
                    else
                    {
                        MessageBox.Show("gerçeklesecek islemi giriniz!!");
                    }
                    textBox1.Clear();
                    textBox2.Clear();
                }
                else
                {
                    MessageBox.Show("boşlukları doldurun");
                }
            }
            catch
            {
                MessageBox.Show("BİLGİLERİ DOĞRU GİRİNİZ");
                textBox1.Clear();
                textBox2.Clear();
            }
        }


























        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }
    
    }
}
