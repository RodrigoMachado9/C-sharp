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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnClickMe_Click(object sender, EventArgs e)
        {
            try
            {
                int number;
                number = int.Parse(textBox1.Text);

                string message = number % 2 == 0 ? $"O numero {number} é par" : $"esse numero {number} é ímpar";


                if (number % 2 == 0)
                {
                    MessageBox.Show(message);
                }
                else
                {
                    MessageBox.Show(message);
                }


            }
            catch {

                MessageBox.Show("Please input integer number.");

            
            
            }
            



        }
    }
}
