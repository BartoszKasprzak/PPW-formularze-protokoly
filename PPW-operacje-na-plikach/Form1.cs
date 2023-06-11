using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPW_operacje_na_plikach
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex == 0)
            {
                Form2 form2 = new Form2();//karta
                form2.ShowDialog();
            }
            else if(comboBox1.SelectedIndex == 1)
            {
                Form3 form3 = new Form3();//promotor
                form3.ShowDialog();
            }
            else if(comboBox1.SelectedIndex == 2)
            {
                Form4 form4 = new Form4();//recenzent
                form4.ShowDialog();
            }
            else if(comboBox1.SelectedIndex == 3)
            {
                Form5 form5 = new Form5();//protokol
                form5.ShowDialog();
            }
        }
    }
}
