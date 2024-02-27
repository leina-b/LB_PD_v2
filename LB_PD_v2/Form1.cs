using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LB_PD_v2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Apreekini(string precu_noss1, int prec_cenas1, int precu_daudzumss1)
        {
            int summa;
            summa = prec_cenas1 * precu_daudzumss1;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void aprekinat_btn_Click(object sender, EventArgs e)
        {
            int prece1 = Convert.ToInt32(precu_cena1.Text);
            int prece2 = Convert.ToInt32(precu_cena2.Text);
            int prece3 = Convert.ToInt32(precu_cena3.Text);

            double daudz = Convert.ToInt32(precu_daudzums1.Value);





        }
    }
}
