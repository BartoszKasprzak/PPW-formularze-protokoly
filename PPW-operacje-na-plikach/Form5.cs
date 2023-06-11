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
    public partial class Form5 : Form
    {
        Doc protokol = new Doc();
        public System.Windows.Forms.TextBox[] textBoxes;

        public Form5()
        {
            InitializeComponent();
            Wprowadzone_Dane();
        }

        private void Wprowadzone_Dane()
        {
            textBoxes = new System.Windows.Forms.TextBox[]
            {
        textBox1, textBox2, textBox3, textBox4, textBox5, textBox6, textBox7, textBox8,
        textBox9, textBox10, textBox11, textBox12, textBox13, textBox14, textBox15, textBox16, textBox17
            };
        }
        private void label4_Click(object sender, EventArgs e)
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
                    protokol.DocList.Add(text);
                }


                XmlSerializer serializer = new XmlSerializer(typeof(Doc));
                using (TextWriter writer = new StreamWriter(saveFileDialog1.FileName))
                {
                    serializer.Serialize(writer, protokol);
                }
            }
        }
    }
}
