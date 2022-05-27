using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp11_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        
        bool JePrvocislo(int cislo)
        {
            bool vysledek = (cislo % 2 != 0 || cislo == 2) && !(cislo == 1 || cislo == 0);
            for (int i = 3; i <= Math.Sqrt(cislo) && vysledek != false; i += 2)
            {
                vysledek = cislo % i != 0;
            }
            return vysledek;
        }



        int[] pole;
        void Prepis(TextBox tx, ListBox listbox)
        {
            listbox.Items.Clear();
            foreach (int i in pole)
            {
                if (JePrvocislo(i))
                    listbox.Items.Add(i);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Prepis(textBox1, listBox1);
        }

        Random r = new Random();
        private void button2_Click(object sender, EventArgs e)
        {
            pole = new int[(int)numericUpDown1.Value];
            for (int i = 0; i < (int)numericUpDown1.Value; i++)
            {
                int p = r.Next(2, 16);
                textBox1.AppendText(p.ToString() + Environment.NewLine);
                pole[i] = p;
            }
        }

        
    }
}

