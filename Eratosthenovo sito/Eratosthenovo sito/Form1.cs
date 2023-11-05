using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eratosthenovo_sito
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (int.TryParse(textBox1.Text, out int n) && n > 1)
            {
                List<int> prvocisla = Najdiprvocisla(n);
                listBox1.Items.Clear();

                foreach (int prvocislo in prvocisla)
                {
                    listBox1.Items.Add(prvocislo);
                }
            }
            else
            {
                MessageBox.Show("Nekde se stala chyba");
            }
        }
        private List<int> Najdiprvocisla(int n)
        {
            List<int> prvocisla = new List<int>();
            bool[] jePrvocislo = new bool[n + 1];

           
            for (int i = 2; i <= n; i++)
            {
                jePrvocislo[i] = true;
            }




            for(int i = 2; i * i <= n; i++)
            {
                if (jePrvocislo[i])
                {
                    for (int p = i * i; p <= n; p += i)
                    {
                       
                        jePrvocislo[p] = false;
                    }
                }
            }


            
            for (int i = 2; i <= n; i++)
            {
                if (jePrvocislo[i])
                {
                    prvocisla.Add(i);
                }
            }

            return prvocisla;
        }
    }
}
