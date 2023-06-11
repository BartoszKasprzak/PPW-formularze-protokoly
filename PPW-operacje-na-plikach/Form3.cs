using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace PPW_operacje_na_plikach
{
    public partial class Form3 : Form
    {
        OP promotor = new OP();
        public System.Windows.Forms.TextBox[] textBoxes;
        public Form3()
        {
            InitializeComponent();
            Wprowadzone_Dane();
        }

        private void Wprowadzone_Dane()
        {
            textBoxes = new System.Windows.Forms.TextBox[]
            {
        textBox1, textBox2, textBox3, textBox4, textBox5, textBox6, textBox7, textBox8,
        textBox9, textBox10, textBox11, textBox12, textBox13, textBox14, textBox15, textBox16
            };
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Pliki XML (*.xml)|*.xml";
            saveFileDialog1.Title = "Wybierz miejsce zapisu pliku XML";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                foreach (System.Windows.Forms.TextBox textBox in textBoxes)
                {
                    string text = textBox.Text ?? "";
                    promotor.OPList.Add(text);
                }
                string rich = richTextBox1.Text ?? "";
                promotor.OPList.Add(rich);

                XmlSerializer serializer = new XmlSerializer(typeof(OP));
                using (TextWriter writer = new StreamWriter(saveFileDialog1.FileName))
                {
                    serializer.Serialize(writer, promotor);
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            promotor.OPList.Add(textBox3.Text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            promotor.OPList.Add(textBox1.Text);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            promotor.OPList.Add(textBox2.Text);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            promotor.OPList.Add(textBox4.Text);
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            promotor.OPList.Add(textBox5.Text);
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            promotor.OPList.Add(textBox6.Text);
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            promotor.OPList.Add(textBox7.Text);
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            promotor.OPList.Add(textBox8.Text);
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            promotor.OPList.Add(textBox11.Text);
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {
            promotor.OPList.Add(textBox13.Text);
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            promotor.OPList.Add(textBox12.Text);
        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {
            promotor.OPList.Add(textBox14.Text);
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            promotor.OPList.Add(textBox10.Text);
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            promotor.OPList.Add(textBox9.Text);
        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {
            promotor.OPList.Add(textBox16.Text);
        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {
            promotor.OPList.Add(textBox15.Text);
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
