using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex.Array2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            lsbVetorA.Items.Clear();
            lsbVetorB.Items.Clear();


            int[] vetorA = new int[10];
            int[] vetorB = new int[10];
            Random random = new Random();

            for (int i = 0; i < vetorA.Length; i++)
            {
                vetorA[i] = random.Next(1, 101);


                lsbVetorA.Items.Add("Valor " + vetorA[i]);


                if (i % 2 == 0)
                {
                    vetorB[i] = vetorA[i] * 5;
                }
                else
                {
                    vetorB[i] = vetorA[i] + 5;
                }


                lsbVetorB.Items.Add("Valor " + vetorB[i]);
            }

        }
    }

}
