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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Serialization;

namespace PPW_operacje_na_plikach
{
    public partial class Form2 : Form
    {
        Doc karta = new Doc();
        public System.Windows.Forms.TextBox[] textBoxes;

        public Form2()
        {
            InitializeComponent();
            Wprowadzone_Dane();
        }
        private void Wprowadzone_Dane()
        {
            textBoxes = new System.Windows.Forms.TextBox[]
            {
        textBox1, textBox2, textBox3, textBox4, textBox5, textBox6, textBox7, textBox8,
        textBox9, textBox10, textBox11, textBox12, textBox13, textBox14
            };
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
                    karta.DocList.Add(text);
                }


                XmlSerializer serializer = new XmlSerializer(typeof(Doc));
                using (TextWriter writer = new StreamWriter(saveFileDialog1.FileName))
                {
                    serializer.Serialize(writer, karta);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
