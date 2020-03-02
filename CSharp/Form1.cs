using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp
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

        private void btnSomar_Click(object sender, EventArgs e)
        {
            int numeroUm;
            int numeroDois;
            try
            {
                numeroUm = int.Parse(txtBoxOne.Text);
                numeroDois = int.Parse(txtBoxTwo.Text);
            }
            catch (Exception ex)
            {
                // log
                MessageBox.Show("Digite apenas valores inteiros");

                throw;
            }


            int somar = numeroUm + numeroDois;


            // a partir da versão c# 07
            MessageBox.Show($"Resultado: {somar}");
        }

        private void txtBoxOne_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
