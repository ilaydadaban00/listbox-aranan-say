using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lblCiftleri_karsıya_at
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int aranan=Convert.ToInt32(txtAranan.Text);
            bool bulundu=false;


            for(int i = 0; i < 20; i++)
            {
                int sayi = Convert.ToInt32(lblSayilar.Items[i]);
                if (sayi == aranan)
                {
                    bulundu = true;
                }  break;
            }

            if (bulundu)
            {
                MessageBox.Show("bulundu");
            }
            else
            {
                MessageBox.Show("bulunmadı");
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random random = new Random();
           for(int i = 0; i < 20; i++)
            {
                lblSayilar.Items.Add(random.Next(1, 101));
            }
        }
    }
}
